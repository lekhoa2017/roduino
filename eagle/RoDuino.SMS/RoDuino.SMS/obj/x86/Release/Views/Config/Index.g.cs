﻿#pragma checksum "..\..\..\..\..\Views\Config\Index.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "45DBF0C753F3D33D6590617CECE3ACF6"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.239
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Windows.Themes;
using RoDuino.SMS.Components;
using RoDuino.SMS.Converters;
using RoDuino.SMS.Properties;
using RoDuino.SMS.Views;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace RoDuino.SMS.Views.Config {
    
    
    /// <summary>
    /// Index
    /// </summary>
    public partial class Index : RoDuino.SMS.Views.View, System.Windows.Markup.IComponentConnector {
        
        
        #line 8 "..\..\..\..\..\Views\Config\Index.xaml"
        internal System.Windows.Controls.DockPanel dockPanel;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\..\..\Views\Config\Index.xaml"
        internal System.Windows.Controls.Grid gridContainer;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\..\..\Views\Config\Index.xaml"
        internal System.Windows.Controls.StackPanel pnlLinks;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\..\..\Views\Config\Index.xaml"
        internal System.Windows.Controls.ComboBox cbxPorts;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\..\..\Views\Config\Index.xaml"
        internal System.Windows.Controls.ComboBox cbxBitsPerSec;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\..\..\Views\Config\Index.xaml"
        internal System.Windows.Controls.ComboBox cbxDataBits;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\..\..\..\Views\Config\Index.xaml"
        internal System.Windows.Controls.ComboBox cbxParity;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\..\..\Views\Config\Index.xaml"
        internal System.Windows.Controls.ComboBox cbxStopBits;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\..\..\..\Views\Config\Index.xaml"
        internal System.Windows.Controls.ComboBox cbxFlowControl;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\..\..\..\Views\Config\Index.xaml"
        internal System.Windows.Controls.Button btnSave;
        
        #line default
        #line hidden
        
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
            System.Uri resourceLocater = new System.Uri("/RoDuino.SMS;component/views/config/index.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\Views\Config\Index.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal System.Delegate _CreateDelegate(System.Type delegateType, string handler) {
            return System.Delegate.CreateDelegate(delegateType, this, handler);
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.dockPanel = ((System.Windows.Controls.DockPanel)(target));
            return;
            case 2:
            this.gridContainer = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            this.pnlLinks = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 4:
            this.cbxPorts = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 5:
            this.cbxBitsPerSec = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 6:
            this.cbxDataBits = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 7:
            this.cbxParity = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 8:
            this.cbxStopBits = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 9:
            this.cbxFlowControl = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 10:
            this.btnSave = ((System.Windows.Controls.Button)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
