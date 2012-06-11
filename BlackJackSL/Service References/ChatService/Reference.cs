﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.269
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This code was auto-generated by Microsoft.Silverlight.ServiceReference, version 4.0.50826.0
// 
namespace BlackJackSL.ChatService {
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="DuplexMessage", Namespace="http://samples.microsoft.com/silverlight2/duplex")]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(BlackJackSL.ChatService.DisconnectMessage))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(BlackJackSL.ChatService.ConnectMessage))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(BlackJackSL.ChatService.TextChatMessageToServer))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(BlackJackSL.ChatService.TextChatMessageFromServer))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(BlackJackSL.ChatService.StockTickerMessage))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(BlackJackSL.ChatService.JoinChatMessage))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(BlackJackSL.ChatService.LeaveChatMessage))]
    public partial class DuplexMessage : object, System.ComponentModel.INotifyPropertyChanged {
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="DisconnectMessage", Namespace="http://samples.microsoft.com/silverlight2/duplex")]
    public partial class DisconnectMessage : BlackJackSL.ChatService.DuplexMessage {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ConnectMessage", Namespace="http://samples.microsoft.com/silverlight2/duplex")]
    public partial class ConnectMessage : BlackJackSL.ChatService.DuplexMessage {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="TextChatMessageToServer", Namespace="http://schemas.datacontract.org/2004/07/BlackJackSL.Web.Chat")]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(BlackJackSL.ChatService.TextChatMessageFromServer))]
    public partial class TextChatMessageToServer : BlackJackSL.ChatService.DuplexMessage {
        
        private string textField;
        
        private int textColorField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string text {
            get {
                return this.textField;
            }
            set {
                if ((object.ReferenceEquals(this.textField, value) != true)) {
                    this.textField = value;
                    this.RaisePropertyChanged("text");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int textColor {
            get {
                return this.textColorField;
            }
            set {
                if ((this.textColorField.Equals(value) != true)) {
                    this.textColorField = value;
                    this.RaisePropertyChanged("textColor");
                }
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="TextChatMessageFromServer", Namespace="http://schemas.datacontract.org/2004/07/BlackJackSL.Web.Chat")]
    public partial class TextChatMessageFromServer : BlackJackSL.ChatService.TextChatMessageToServer {
        
        private string nicknameField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string nickname {
            get {
                return this.nicknameField;
            }
            set {
                if ((object.ReferenceEquals(this.nicknameField, value) != true)) {
                    this.nicknameField = value;
                    this.RaisePropertyChanged("nickname");
                }
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="StockTickerMessage", Namespace="http://schemas.datacontract.org/2004/07/BlackJackSL.Web.Chat")]
    public partial class StockTickerMessage : BlackJackSL.ChatService.DuplexMessage {
        
        private string ChangeField;
        
        private string HighField;
        
        private string LastTradeTimeField;
        
        private string LowField;
        
        private string OpenField;
        
        private decimal priceField;
        
        private string stockField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Change {
            get {
                return this.ChangeField;
            }
            set {
                if ((object.ReferenceEquals(this.ChangeField, value) != true)) {
                    this.ChangeField = value;
                    this.RaisePropertyChanged("Change");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string High {
            get {
                return this.HighField;
            }
            set {
                if ((object.ReferenceEquals(this.HighField, value) != true)) {
                    this.HighField = value;
                    this.RaisePropertyChanged("High");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string LastTradeTime {
            get {
                return this.LastTradeTimeField;
            }
            set {
                if ((object.ReferenceEquals(this.LastTradeTimeField, value) != true)) {
                    this.LastTradeTimeField = value;
                    this.RaisePropertyChanged("LastTradeTime");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Low {
            get {
                return this.LowField;
            }
            set {
                if ((object.ReferenceEquals(this.LowField, value) != true)) {
                    this.LowField = value;
                    this.RaisePropertyChanged("Low");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Open {
            get {
                return this.OpenField;
            }
            set {
                if ((object.ReferenceEquals(this.OpenField, value) != true)) {
                    this.OpenField = value;
                    this.RaisePropertyChanged("Open");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal price {
            get {
                return this.priceField;
            }
            set {
                if ((this.priceField.Equals(value) != true)) {
                    this.priceField = value;
                    this.RaisePropertyChanged("price");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string stock {
            get {
                return this.stockField;
            }
            set {
                if ((object.ReferenceEquals(this.stockField, value) != true)) {
                    this.stockField = value;
                    this.RaisePropertyChanged("stock");
                }
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="JoinChatMessage", Namespace="http://schemas.datacontract.org/2004/07/BlackJackSL.Web.Chat")]
    public partial class JoinChatMessage : BlackJackSL.ChatService.DuplexMessage {
        
        private string nicknameField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string nickname {
            get {
                return this.nicknameField;
            }
            set {
                if ((object.ReferenceEquals(this.nicknameField, value) != true)) {
                    this.nicknameField = value;
                    this.RaisePropertyChanged("nickname");
                }
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="LeaveChatMessage", Namespace="http://schemas.datacontract.org/2004/07/BlackJackSL.Web.Chat")]
    public partial class LeaveChatMessage : BlackJackSL.ChatService.DuplexMessage {
        
        private string nicknameField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string nickname {
            get {
                return this.nicknameField;
            }
            set {
                if ((object.ReferenceEquals(this.nicknameField, value) != true)) {
                    this.nicknameField = value;
                    this.RaisePropertyChanged("nickname");
                }
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ChatService.DuplexService", CallbackContract=typeof(BlackJackSL.ChatService.DuplexServiceCallback))]
    public interface DuplexService {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, AsyncPattern=true, Action="http://tempuri.org/DuplexService/SendToService")]
        System.IAsyncResult BeginSendToService(BlackJackSL.ChatService.DuplexMessage msg, System.AsyncCallback callback, object asyncState);
        
        void EndSendToService(System.IAsyncResult result);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface DuplexServiceCallback {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/DuplexService/SendToClient")]
        void SendToClient(BlackJackSL.ChatService.DuplexMessage msg);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface DuplexServiceChannel : BlackJackSL.ChatService.DuplexService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class DuplexServiceClient : System.ServiceModel.DuplexClientBase<BlackJackSL.ChatService.DuplexService>, BlackJackSL.ChatService.DuplexService {
        
        private BeginOperationDelegate onBeginSendToServiceDelegate;
        
        private EndOperationDelegate onEndSendToServiceDelegate;
        
        private System.Threading.SendOrPostCallback onSendToServiceCompletedDelegate;
        
        private bool useGeneratedCallback;
        
        private BeginOperationDelegate onBeginOpenDelegate;
        
        private EndOperationDelegate onEndOpenDelegate;
        
        private System.Threading.SendOrPostCallback onOpenCompletedDelegate;
        
        private BeginOperationDelegate onBeginCloseDelegate;
        
        private EndOperationDelegate onEndCloseDelegate;
        
        private System.Threading.SendOrPostCallback onCloseCompletedDelegate;
        
        public DuplexServiceClient(System.ServiceModel.InstanceContext callbackInstance) : 
                base(callbackInstance) {
        }
        
        public DuplexServiceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName) : 
                base(callbackInstance, endpointConfigurationName) {
        }
        
        public DuplexServiceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, string remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public DuplexServiceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public DuplexServiceClient(System.ServiceModel.InstanceContext callbackInstance, System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, binding, remoteAddress) {
        }
        
        public DuplexServiceClient(string endpointConfigurationName) : 
                this(new DuplexServiceClientCallback(), endpointConfigurationName) {
        }
        
        private DuplexServiceClient(DuplexServiceClientCallback callbackImpl, string endpointConfigurationName) : 
                this(new System.ServiceModel.InstanceContext(callbackImpl), endpointConfigurationName) {
            useGeneratedCallback = true;
            callbackImpl.Initialize(this);
        }
        
        public DuplexServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                this(new DuplexServiceClientCallback(), binding, remoteAddress) {
        }
        
        private DuplexServiceClient(DuplexServiceClientCallback callbackImpl, System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                this(new System.ServiceModel.InstanceContext(callbackImpl), binding, remoteAddress) {
            useGeneratedCallback = true;
            callbackImpl.Initialize(this);
        }
        
        public DuplexServiceClient() : 
                this(new DuplexServiceClientCallback()) {
        }
        
        private DuplexServiceClient(DuplexServiceClientCallback callbackImpl) : 
                this(new System.ServiceModel.InstanceContext(callbackImpl)) {
            useGeneratedCallback = true;
            callbackImpl.Initialize(this);
        }
        
        public System.Net.CookieContainer CookieContainer {
            get {
                System.ServiceModel.Channels.IHttpCookieContainerManager httpCookieContainerManager = this.InnerChannel.GetProperty<System.ServiceModel.Channels.IHttpCookieContainerManager>();
                if ((httpCookieContainerManager != null)) {
                    return httpCookieContainerManager.CookieContainer;
                }
                else {
                    return null;
                }
            }
            set {
                System.ServiceModel.Channels.IHttpCookieContainerManager httpCookieContainerManager = this.InnerChannel.GetProperty<System.ServiceModel.Channels.IHttpCookieContainerManager>();
                if ((httpCookieContainerManager != null)) {
                    httpCookieContainerManager.CookieContainer = value;
                }
                else {
                    throw new System.InvalidOperationException("Unable to set the CookieContainer. Please make sure the binding contains an HttpC" +
                            "ookieContainerBindingElement.");
                }
            }
        }
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> SendToServiceCompleted;
        
        public event System.EventHandler<SendToClientReceivedEventArgs> SendToClientReceived;
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> OpenCompleted;
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> CloseCompleted;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult BlackJackSL.ChatService.DuplexService.BeginSendToService(BlackJackSL.ChatService.DuplexMessage msg, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginSendToService(msg, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        void BlackJackSL.ChatService.DuplexService.EndSendToService(System.IAsyncResult result) {
            base.Channel.EndSendToService(result);
        }
        
        private System.IAsyncResult OnBeginSendToService(object[] inValues, System.AsyncCallback callback, object asyncState) {
            this.VerifyCallbackEvents();
            BlackJackSL.ChatService.DuplexMessage msg = ((BlackJackSL.ChatService.DuplexMessage)(inValues[0]));
            return ((BlackJackSL.ChatService.DuplexService)(this)).BeginSendToService(msg, callback, asyncState);
        }
        
        private object[] OnEndSendToService(System.IAsyncResult result) {
            ((BlackJackSL.ChatService.DuplexService)(this)).EndSendToService(result);
            return null;
        }
        
        private void OnSendToServiceCompleted(object state) {
            if ((this.SendToServiceCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.SendToServiceCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void SendToServiceAsync(BlackJackSL.ChatService.DuplexMessage msg) {
            this.SendToServiceAsync(msg, null);
        }
        
        public void SendToServiceAsync(BlackJackSL.ChatService.DuplexMessage msg, object userState) {
            if ((this.onBeginSendToServiceDelegate == null)) {
                this.onBeginSendToServiceDelegate = new BeginOperationDelegate(this.OnBeginSendToService);
            }
            if ((this.onEndSendToServiceDelegate == null)) {
                this.onEndSendToServiceDelegate = new EndOperationDelegate(this.OnEndSendToService);
            }
            if ((this.onSendToServiceCompletedDelegate == null)) {
                this.onSendToServiceCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnSendToServiceCompleted);
            }
            base.InvokeAsync(this.onBeginSendToServiceDelegate, new object[] {
                        msg}, this.onEndSendToServiceDelegate, this.onSendToServiceCompletedDelegate, userState);
        }
        
        private void OnSendToClientReceived(object state) {
            if ((this.SendToClientReceived != null)) {
                object[] results = ((object[])(state));
                this.SendToClientReceived(this, new SendToClientReceivedEventArgs(results, null, false, null));
            }
        }
        
        private void VerifyCallbackEvents() {
            if (((this.useGeneratedCallback != true) 
                        && (this.SendToClientReceived != null))) {
                throw new System.InvalidOperationException("Callback events cannot be used when the callback InstanceContext is specified. Pl" +
                        "ease choose between specifying the callback InstanceContext or subscribing to th" +
                        "e callback events.");
            }
        }
        
        private System.IAsyncResult OnBeginOpen(object[] inValues, System.AsyncCallback callback, object asyncState) {
            this.VerifyCallbackEvents();
            return ((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(callback, asyncState);
        }
        
        private object[] OnEndOpen(System.IAsyncResult result) {
            ((System.ServiceModel.ICommunicationObject)(this)).EndOpen(result);
            return null;
        }
        
        private void OnOpenCompleted(object state) {
            if ((this.OpenCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.OpenCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void OpenAsync() {
            this.OpenAsync(null);
        }
        
        public void OpenAsync(object userState) {
            if ((this.onBeginOpenDelegate == null)) {
                this.onBeginOpenDelegate = new BeginOperationDelegate(this.OnBeginOpen);
            }
            if ((this.onEndOpenDelegate == null)) {
                this.onEndOpenDelegate = new EndOperationDelegate(this.OnEndOpen);
            }
            if ((this.onOpenCompletedDelegate == null)) {
                this.onOpenCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnOpenCompleted);
            }
            base.InvokeAsync(this.onBeginOpenDelegate, null, this.onEndOpenDelegate, this.onOpenCompletedDelegate, userState);
        }
        
        private System.IAsyncResult OnBeginClose(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return ((System.ServiceModel.ICommunicationObject)(this)).BeginClose(callback, asyncState);
        }
        
        private object[] OnEndClose(System.IAsyncResult result) {
            ((System.ServiceModel.ICommunicationObject)(this)).EndClose(result);
            return null;
        }
        
        private void OnCloseCompleted(object state) {
            if ((this.CloseCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.CloseCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void CloseAsync() {
            this.CloseAsync(null);
        }
        
        public void CloseAsync(object userState) {
            if ((this.onBeginCloseDelegate == null)) {
                this.onBeginCloseDelegate = new BeginOperationDelegate(this.OnBeginClose);
            }
            if ((this.onEndCloseDelegate == null)) {
                this.onEndCloseDelegate = new EndOperationDelegate(this.OnEndClose);
            }
            if ((this.onCloseCompletedDelegate == null)) {
                this.onCloseCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnCloseCompleted);
            }
            base.InvokeAsync(this.onBeginCloseDelegate, null, this.onEndCloseDelegate, this.onCloseCompletedDelegate, userState);
        }
        
        protected override BlackJackSL.ChatService.DuplexService CreateChannel() {
            return new DuplexServiceClientChannel(this);
        }
        
        private class DuplexServiceClientCallback : object, DuplexServiceCallback {
            
            private DuplexServiceClient proxy;
            
            public void Initialize(DuplexServiceClient proxy) {
                this.proxy = proxy;
            }
            
            public void SendToClient(BlackJackSL.ChatService.DuplexMessage msg) {
                this.proxy.OnSendToClientReceived(new object[] {
                            msg});
            }
        }
        
        private class DuplexServiceClientChannel : ChannelBase<BlackJackSL.ChatService.DuplexService>, BlackJackSL.ChatService.DuplexService {
            
            public DuplexServiceClientChannel(System.ServiceModel.DuplexClientBase<BlackJackSL.ChatService.DuplexService> client) : 
                    base(client) {
            }
            
            public System.IAsyncResult BeginSendToService(BlackJackSL.ChatService.DuplexMessage msg, System.AsyncCallback callback, object asyncState) {
                object[] _args = new object[1];
                _args[0] = msg;
                System.IAsyncResult _result = base.BeginInvoke("SendToService", _args, callback, asyncState);
                return _result;
            }
            
            public void EndSendToService(System.IAsyncResult result) {
                object[] _args = new object[0];
                base.EndInvoke("SendToService", _args, result);
            }
        }
    }
    
    public class SendToClientReceivedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public SendToClientReceivedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public BlackJackSL.ChatService.DuplexMessage msg {
            get {
                base.RaiseExceptionIfNecessary();
                return ((BlackJackSL.ChatService.DuplexMessage)(this.results[0]));
            }
        }
    }
}
