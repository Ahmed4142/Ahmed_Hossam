﻿#pragma checksum "..\..\view_tasks.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "EF8316B78B04E1504126B548D2CD2EC0003078820983F3D32EE4C523C0F338A1"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

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
using System.Windows.Shell;
using p_tasks;


namespace p_tasks {
    
    
    /// <summary>
    /// view_tasks
    /// </summary>
    public partial class view_tasks : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\view_tasks.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label nameemp;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\view_tasks.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dgtasksfrist;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\view_tasks.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox taskidtxt;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\view_tasks.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmbstatus;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\view_tasks.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dgtasksend;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/p_tasks;component/view_tasks.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\view_tasks.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.nameemp = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.dgtasksfrist = ((System.Windows.Controls.DataGrid)(target));
            
            #line 12 "..\..\view_tasks.xaml"
            this.dgtasksfrist.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.dgtasksfrist_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.taskidtxt = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.cmbstatus = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 5:
            
            #line 24 "..\..\view_tasks.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.save_update_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.dgtasksend = ((System.Windows.Controls.DataGrid)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
