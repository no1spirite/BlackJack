using System;
using System.Collections.Generic;
using System.Timers;
using System.Threading;
using System.Xml;
using BlackJackSL.Web.BlackJack;
using BlackJackSL.Web.BlackJack.Objects;
using Timer=System.Timers.Timer;
using XmlWriter=BlackJackSL.Web.BlackJack.XML.XmlWriter;

namespace BlackJackSL.Web.BlackJack
{
    using System.ServiceModel;

    public class BlackJackServiceFactory : DuplexServiceFactory<BlackJackService> { }

    [ServiceBehavior(AddressFilterMode = AddressFilterMode.Any)]
    public class BlackJackService : DuplexService
    {
        //Base class (DuplexService) keeps track of all connected chatters
        //But it only deals with Session IDs, it has no concept of "chat nickname"
        //So this dictionary will map Session IDs to Nicknames:
        Dictionary<string,string> players = new Dictionary<string,string>();
        List<string> dealRequests = new List<string>();
        List<string> disconnectRequests = new List<string>();
        XmlWriter writer = new XmlWriter();
        Deck deck = new Deck();

        public BlackJackService()
        {
            
        }

        protected override void OnMessage(string sessionId, BlackJack.DuplexMessage data)
        {
            if (data is JoinGameMessageToServer)
            {
                JoinGameMessageToServer msg = (JoinGameMessageToServer)data;  
                if(players.ContainsValue(msg.nickname))
                {
                    PlayerAlreadyExistsMessageFromServer outMsg = new PlayerAlreadyExistsMessageFromServer();
                    PushMessageToClient(sessionId, outMsg);
                }
                else
                {
                    players.Add(sessionId, msg.nickname);
                    JoinGameMessageFromServer outMsg = new JoinGameMessageFromServer();
                    outMsg.playerId = msg.playerId;
                    outMsg.nickname = players[sessionId];
                    string filename = AppDomain.CurrentDomain.BaseDirectory.ToString() + @"/Table1.xml";
                    XmlDocument xmlDoc = new XmlDocument();
                    try
                    {
                        xmlDoc.Load(filename);
                        outMsg.xmlDoc = xmlDoc.InnerXml;
                    }
                    catch (System.IO.FileNotFoundException)
                    {

                    }
                    PushMessageToClient(sessionId, outMsg);
                }
            }
            else if (data is LeaveGameMessageToServer)
            {
                
            }
            else if (data is AddPlayerMessageToServer)
            {
                AddPlayerMessageToServer msg = (AddPlayerMessageToServer) data;

                AddPlayerMessageFromServer outMsg = new AddPlayerMessageFromServer();
                outMsg.playerId = msg.playerId;
                outMsg.nickname = players[sessionId];
                PushToAllClients(outMsg);
                writer.PlayerAdded(msg);
            }
            else if (data is RemovePlayerMessageToServer)
            {
                RemovePlayerMessageToServer msg = (RemovePlayerMessageToServer)data;

                RemovePlayerMessageFromServer outMsg = new RemovePlayerMessageFromServer();
                outMsg.playerId = msg.playerId;
                outMsg.nickname = players[sessionId];
                PushToAllClients(outMsg);
                writer.PlayerRemoved(msg);

                string filename = AppDomain.CurrentDomain.BaseDirectory.ToString() + @"/Table1.xml";
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(filename);
                XmlNodeList currentPlayers = xmlDoc.SelectNodes("/Table/Players/Player");

                if (currentPlayers.Count == 0)
                {
                    ClearDealerMessageFromServer clearMsg = new ClearDealerMessageFromServer();
                    PushToAllClients(clearMsg);
                    writer.DealerRemove();
                }

            }
            else if (data is BetMessageToServer)
            {
                BetMessageToServer msg = (BetMessageToServer)data;

                BetMessageFromServer outMsg = new BetMessageFromServer();
                outMsg.betAmount = msg.betAmount;
                outMsg.playerId = msg.playerId;
                outMsg.nickname = players[sessionId];
                PushToAllClients(outMsg);
                writer.PlayerBet(msg);
            }
            else if (data is DealMessageToServer)
            {
                DealMessageToServer msg = (DealMessageToServer)data;

                string filename = AppDomain.CurrentDomain.BaseDirectory.ToString() + @"/Table1.xml";
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(filename);
                XmlNodeList currentPlayers = xmlDoc.SelectNodes("/Table/Players/Player");

                List<string> currentActivePlayers = new List<string>();
                foreach (XmlNode player in currentPlayers)
                {
                    if(!dealRequests.Contains(player.Attributes["PlayerName"].Value))
                        currentActivePlayers.Add(player.Attributes["PlayerName"].Value);
                }

                dealRequests.Add(msg.nickname);
                bool shouldDeal = false;
                foreach (var player in currentActivePlayers)
                {
                    shouldDeal = dealRequests.Contains(player);
                    if (!shouldDeal)
                        break;
                }
                if (shouldDeal)
                {
                    DealMessageFromServer outMsg = new DealMessageFromServer();
                    deck = new Deck();
                    outMsg.deck = deck;
                    outMsg.nickname = players[sessionId];
                    PushToAllClients(outMsg);
                    writer.DealerRemove();
                    writer.DealCards(deck);
                    dealRequests.Clear();
                }
            }
            else if (data is FinishedDealingMessageToServer)
            {
                FinishedDealingMessageToServer msg = (FinishedDealingMessageToServer)data;

                FinishedDealingMessageFromServer outMsg = new FinishedDealingMessageFromServer();
                outMsg.nickname = players[sessionId];
                //outMsg.timer = new Timer(10000);
                PushToAllClients(outMsg);
            }
            else if (data is StandMessageToServer)
            {
                StandMessageToServer msg = (StandMessageToServer)data;

                StandMessageFromServer outMsg = new StandMessageFromServer();
                outMsg.nickname = players[sessionId];
                outMsg.playerId = msg.playerId;
                PushToAllClients(outMsg);
            }
            else if (data is HitMessageToServer)
            {
                HitMessageToServer msg = (HitMessageToServer)data;

                HitMessageFromServer outMsg = new HitMessageFromServer();
                outMsg.nickname = players[sessionId];
                outMsg.playerId = msg.playerId;
                PushToAllClients(outMsg);
                writer.PlayerHit(msg, deck);
            }
            else if (data is DoubleMessageToServer)
            {
                DoubleMessageToServer msg = (DoubleMessageToServer)data;

                DoubleMessageFromServer outMsg = new DoubleMessageFromServer();
                outMsg.nickname = players[sessionId];
                outMsg.playerId = msg.playerId;
                PushToAllClients(outMsg);
                writer.PlayerDouble(msg, deck);
            }
            else if (data is SplitMessageToServer)
            {
                SplitMessageToServer msg = (SplitMessageToServer)data;

                SplitMessageFromServer outMsg = new SplitMessageFromServer();
                outMsg.nickname = players[sessionId];
                outMsg.playerId = msg.playerId;
                PushToAllClients(outMsg);
                writer.PlayerSplit(msg, deck);
            }
            else if (data is ClearPlayersMessageToServer)
            {
                ClearPlayersMessageToServer msg = (ClearPlayersMessageToServer)data;

                ClearPlayersMessageFromServer outMsg = new ClearPlayersMessageFromServer();
                outMsg.nickname = players[sessionId];
                PushToAllClients(outMsg);
                writer.PlayersRemoved(msg);
                
            }
        }

        protected override void OnDisconnected(string sessionId)
        {
            string nickname;
            if (players.TryGetValue(sessionId, out nickname))
            {
                LeaveGameMessageFromServer lcm = new LeaveGameMessageFromServer();
                lcm.nickname = nickname;
                PushToAllClients(lcm);
                players.Remove(sessionId);
                writer.PlayersRemoved(lcm);

                string filename = AppDomain.CurrentDomain.BaseDirectory.ToString() + @"/Table1.xml";
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(filename);
                XmlNodeList currentPlayers = xmlDoc.SelectNodes("/Table/Players/Player");

                if (currentPlayers.Count == 0)
                {
                    ClearDealerMessageFromServer clearMsg = new ClearDealerMessageFromServer();
                    PushToAllClients(clearMsg);
                    writer.DealerRemove();
                }
            }
        }
    }
}