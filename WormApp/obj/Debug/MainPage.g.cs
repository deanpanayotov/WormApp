﻿#pragma checksum "C:\Documents and Settings\073468\My Documents\Visual Studio 2010\Projects\WormApp\WormApp\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "BA1E41512B5DDF87DD50B3D9E9FCEBA3"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.296
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Phone.Controls;
using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace WormApp {
    
    
    public partial class MainPage : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.Grid ContentPanel;
        
        internal System.Windows.Controls.Canvas drawingCanvas;
        
        internal System.Windows.Controls.Grid SettingsPanel;
        
        internal System.Windows.Controls.Slider slRed;
        
        internal System.Windows.Controls.Slider slGreen;
        
        internal System.Windows.Controls.Slider slBlue;
        
        internal System.Windows.Controls.Slider slThickness;
        
        internal System.Windows.Controls.Slider slSpeed;
        
        internal System.Windows.Controls.Slider slDistance;
        
        internal System.Windows.Controls.TextBlock textBlock2;
        
        internal System.Windows.Controls.TextBlock textBlock3;
        
        internal System.Windows.Controls.TextBlock textBlock4;
        
        internal System.Windows.Controls.TextBlock textBlock5;
        
        internal System.Windows.Controls.TextBlock textBlock6;
        
        internal System.Windows.Controls.TextBlock textBlock7;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/WormApp;component/MainPage.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.ContentPanel = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel")));
            this.drawingCanvas = ((System.Windows.Controls.Canvas)(this.FindName("drawingCanvas")));
            this.SettingsPanel = ((System.Windows.Controls.Grid)(this.FindName("SettingsPanel")));
            this.slRed = ((System.Windows.Controls.Slider)(this.FindName("slRed")));
            this.slGreen = ((System.Windows.Controls.Slider)(this.FindName("slGreen")));
            this.slBlue = ((System.Windows.Controls.Slider)(this.FindName("slBlue")));
            this.slThickness = ((System.Windows.Controls.Slider)(this.FindName("slThickness")));
            this.slSpeed = ((System.Windows.Controls.Slider)(this.FindName("slSpeed")));
            this.slDistance = ((System.Windows.Controls.Slider)(this.FindName("slDistance")));
            this.textBlock2 = ((System.Windows.Controls.TextBlock)(this.FindName("textBlock2")));
            this.textBlock3 = ((System.Windows.Controls.TextBlock)(this.FindName("textBlock3")));
            this.textBlock4 = ((System.Windows.Controls.TextBlock)(this.FindName("textBlock4")));
            this.textBlock5 = ((System.Windows.Controls.TextBlock)(this.FindName("textBlock5")));
            this.textBlock6 = ((System.Windows.Controls.TextBlock)(this.FindName("textBlock6")));
            this.textBlock7 = ((System.Windows.Controls.TextBlock)(this.FindName("textBlock7")));
        }
    }
}

