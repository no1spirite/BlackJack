﻿// <copyright file="CommandService.cs" company="Ucaya">
// Distributed under Microsoft Public License (Ms-PL)
// </copyright>
// <author>Thierry Bouquain</author>
using System;
using System.Windows;
using System.Windows.Controls;

namespace BlackJackSL.SLExtensions.Input
{
    /// <summary>
    /// Service class that provides the system implementation for linking Command
    /// </summary>
    public static class CommandService
    {
        #region Fields

        /// <summary>
        ///     The DependencyProperty for the CommandParameter property.
        /// </summary> 
        public static readonly DependencyProperty CommandParameterProperty = 
            DependencyProperty.RegisterAttached(
                "CommandParameter",         // Name
                typeof(object),            // Type
                typeof(CommandService),   // Owner
                null);

        /// <summary>
        ///     The DependencyProperty for the Command property.
        /// </summary> 
        public static readonly DependencyProperty CommandProperty = 
            DependencyProperty.RegisterAttached(
                "Command",         // Name
                typeof(string),            // Type
                typeof(CommandService), // Owner
                new PropertyMetadata(CommandChanged));

        #endregion Fields

        #region Methods

        /// <summary>
        ///     Gets the value of the Command property. 
        /// </summary>
        /// <param name="element">The object on which to query the property.</param>
        /// <returns>The value of the property.</returns> 
        public static string GetCommand(DependencyObject element)
        {
            if (element == null)
            {
                throw new ArgumentNullException("element");
            }

            return (string)element.GetValue(CommandProperty);
        }

        /// <summary>
        ///     Gets the value of the CommandParameter property. 
        /// </summary>
        /// <param name="element">The object on which to query the property.</param>
        /// <returns>The value of the property.</returns> 
        public static object GetCommandParameter(DependencyObject element)
        {
            if (element == null)
            {
                throw new ArgumentNullException("element");
            }

            return element.GetValue(CommandParameterProperty);
        }

        /// <summary> 
        ///     Sets the value of the Command property.
        /// </summary>
        /// <param name="element">The object on which to set the value.</param> 
        /// <param name="value">The desired value of the property.</param> 
        public static void SetCommand(DependencyObject element, string value)
        {
            if (element == null)
            {
                throw new ArgumentNullException("element");
            }

            element.SetValue(CommandProperty, value);
        }

        /// <summary> 
        ///     Sets the value of the CommandParameter property.
        /// </summary>
        /// <param name="element">The object on which to set the value.</param> 
        /// <param name="value">The desired value of the property.</param> 
        public static void SetCommandParameter(DependencyObject element, object value)
        {
            if (element == null)
            {
                throw new ArgumentNullException("element");
            }

            element.SetValue(CommandParameterProperty, value);
        }

        public static void UnregisterCommands(UIElement obj)
        {
            CommandSubscription.UnregisterAllSubscriptions(obj);
        }

        public static void UnregisterCommandsRecursive(UIElement obj)
        {
            Panel pnl = obj as Panel;
            if (pnl != null)
            {
                foreach (var item in pnl.Children)
                {
                    UnregisterCommandsRecursive(item);
                }
            }
            CommandSubscription.UnregisterAllSubscriptions(obj);
        }

        /// <summary>
        /// Finds the command.
        /// </summary>
        /// <param name="commandName">The command name.</param>
        /// <returns>returns the command for a given commandName</returns>
        internal static Command FindCommand(string commandName)
        {
            if (string.IsNullOrEmpty(commandName))
            {
                return null;
            }

            // Check from cache
            Command cmd = null;
            if (Command.CommandCache.TryGetValue(commandName, out cmd))
            {
                return cmd;
            }

            return null;
        }

        /// <summary>
        /// occurs when the command change on a <see cref="DependencyObject"/>
        /// </summary>
        /// <param name="d">The dependency object.</param>
        /// <param name="e">The <see cref="System.Windows.DependencyPropertyChangedEventArgs"/> instance containing the event data.</param>
        private static void CommandChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is UIElement)
            {
                UIElement elem = (UIElement)d;
                string oldCommands = e.OldValue as string;
                if(!string.IsNullOrEmpty(oldCommands))
                {
                    foreach (var item in oldCommands.Split(' '))
                    {
                        CommandSubscription.UnregisterSubscription(item, elem);
                    }
                }

                string newCommands = e.NewValue as string;
                if (!string.IsNullOrEmpty(newCommands))
                {
                    foreach (var item in newCommands.Split(' '))
                    {
                        CommandSubscription.RegisterCommand(item, elem);
                    }
                }
            }
        }

        #endregion Methods
    }
}