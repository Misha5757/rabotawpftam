﻿#pragma checksum "..\..\..\..\Viws\Pages\Otobr.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "64EC5C88A8DEDE9CB39F9AFAF0FA46C349B919A9BF59403EBEF0147B5AED6643"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
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
using WpfApp3.Viws.Pages;


namespace WpfApp3.Viws.Pages {
    
    
    /// <summary>
    /// Otobr
    /// </summary>
    public partial class Otobr : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 17 "..\..\..\..\Viws\Pages\Otobr.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView list;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\..\Viws\Pages\Otobr.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid DataViews;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\..\..\Viws\Pages\Otobr.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Suka;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\..\..\Viws\Pages\Otobr.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Del;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\..\..\Viws\Pages\Otobr.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button red2;
        
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
            System.Uri resourceLocater = new System.Uri("/WpfApp3;component/viws/pages/otobr.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Viws\Pages\Otobr.xaml"
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
            
            #line 9 "..\..\..\..\Viws\Pages\Otobr.xaml"
            ((WpfApp3.Viws.Pages.Otobr)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Page_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.list = ((System.Windows.Controls.ListView)(target));
            
            #line 17 "..\..\..\..\Viws\Pages\Otobr.xaml"
            this.list.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.list_MouseDoubleClick);
            
            #line default
            #line hidden
            return;
            case 3:
            this.DataViews = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 4:
            this.Suka = ((System.Windows.Controls.Button)(target));
            
            #line 63 "..\..\..\..\Viws\Pages\Otobr.xaml"
            this.Suka.Click += new System.Windows.RoutedEventHandler(this.Suka_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Del = ((System.Windows.Controls.Button)(target));
            
            #line 64 "..\..\..\..\Viws\Pages\Otobr.xaml"
            this.Del.Click += new System.Windows.RoutedEventHandler(this.Del_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.red2 = ((System.Windows.Controls.Button)(target));
            
            #line 65 "..\..\..\..\Viws\Pages\Otobr.xaml"
            this.red2.Click += new System.Windows.RoutedEventHandler(this.red2_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
