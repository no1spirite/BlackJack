﻿using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace BlackJackSL.Code
{
    public static class UIThread
    {
        public static Dispatcher Dispatcher { get; set; }
        public static void Run(Action a)
        {
            Dispatcher.BeginInvoke(a);
        }
    }
}
