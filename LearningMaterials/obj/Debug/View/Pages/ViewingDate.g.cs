﻿#pragma checksum "..\..\..\..\View\Pages\ViewingDate.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "BFE8070D5F687A23F14A2593BC68335743C15425FDBE34C3A1E994DB024A68AF"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using LearningMaterials.View.Pages;
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


namespace LearningMaterials.View.Pages {
    
    
    /// <summary>
    /// ViewingDate
    /// </summary>
    public partial class ViewingDate : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 23 "..\..\..\..\View\Pages\ViewingDate.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox SearchBox;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\..\View\Pages\ViewingDate.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox TypeSort;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\..\View\Pages\ViewingDate.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox OrderCheck;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\..\View\Pages\ViewingDate.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox SourceBox;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\..\View\Pages\ViewingDate.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView ViewMaterials;
        
        #line default
        #line hidden
        
        
        #line 75 "..\..\..\..\View\Pages\ViewingDate.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnPreviousPage;
        
        #line default
        #line hidden
        
        
        #line 76 "..\..\..\..\View\Pages\ViewingDate.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnOnePage;
        
        #line default
        #line hidden
        
        
        #line 77 "..\..\..\..\View\Pages\ViewingDate.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnTwoPage;
        
        #line default
        #line hidden
        
        
        #line 78 "..\..\..\..\View\Pages\ViewingDate.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnThreePage;
        
        #line default
        #line hidden
        
        
        #line 79 "..\..\..\..\View\Pages\ViewingDate.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnFourPage;
        
        #line default
        #line hidden
        
        
        #line 80 "..\..\..\..\View\Pages\ViewingDate.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnNextPage;
        
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
            System.Uri resourceLocater = new System.Uri("/LearningMaterials;component/view/pages/viewingdate.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\View\Pages\ViewingDate.xaml"
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
            this.SearchBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 23 "..\..\..\..\View\Pages\ViewingDate.xaml"
            this.SearchBox.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.SearchBox_TextChanged);
            
            #line default
            #line hidden
            
            #line 23 "..\..\..\..\View\Pages\ViewingDate.xaml"
            this.SearchBox.LostFocus += new System.Windows.RoutedEventHandler(this.SearchBox_LostFocus);
            
            #line default
            #line hidden
            
            #line 23 "..\..\..\..\View\Pages\ViewingDate.xaml"
            this.SearchBox.GotFocus += new System.Windows.RoutedEventHandler(this.SearchBox_GotFocus);
            
            #line default
            #line hidden
            return;
            case 2:
            this.TypeSort = ((System.Windows.Controls.ComboBox)(target));
            
            #line 24 "..\..\..\..\View\Pages\ViewingDate.xaml"
            this.TypeSort.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.TypeSort_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.OrderCheck = ((System.Windows.Controls.CheckBox)(target));
            
            #line 35 "..\..\..\..\View\Pages\ViewingDate.xaml"
            this.OrderCheck.Checked += new System.Windows.RoutedEventHandler(this.OrderCheck_Checked);
            
            #line default
            #line hidden
            
            #line 35 "..\..\..\..\View\Pages\ViewingDate.xaml"
            this.OrderCheck.Unchecked += new System.Windows.RoutedEventHandler(this.OrderCheck_Unchecked);
            
            #line default
            #line hidden
            return;
            case 4:
            this.SourceBox = ((System.Windows.Controls.ComboBox)(target));
            
            #line 36 "..\..\..\..\View\Pages\ViewingDate.xaml"
            this.SourceBox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.SourceBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.ViewMaterials = ((System.Windows.Controls.ListView)(target));
            return;
            case 6:
            this.BtnPreviousPage = ((System.Windows.Controls.Button)(target));
            
            #line 75 "..\..\..\..\View\Pages\ViewingDate.xaml"
            this.BtnPreviousPage.Click += new System.Windows.RoutedEventHandler(this.BtnPreviousPage_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.BtnOnePage = ((System.Windows.Controls.Button)(target));
            
            #line 76 "..\..\..\..\View\Pages\ViewingDate.xaml"
            this.BtnOnePage.Click += new System.Windows.RoutedEventHandler(this.BtnOnePage_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.BtnTwoPage = ((System.Windows.Controls.Button)(target));
            
            #line 77 "..\..\..\..\View\Pages\ViewingDate.xaml"
            this.BtnTwoPage.Click += new System.Windows.RoutedEventHandler(this.BtnTwoPage_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.BtnThreePage = ((System.Windows.Controls.Button)(target));
            
            #line 78 "..\..\..\..\View\Pages\ViewingDate.xaml"
            this.BtnThreePage.Click += new System.Windows.RoutedEventHandler(this.BtnThreePage_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.BtnFourPage = ((System.Windows.Controls.Button)(target));
            
            #line 79 "..\..\..\..\View\Pages\ViewingDate.xaml"
            this.BtnFourPage.Click += new System.Windows.RoutedEventHandler(this.BtnFourPage_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.BtnNextPage = ((System.Windows.Controls.Button)(target));
            
            #line 80 "..\..\..\..\View\Pages\ViewingDate.xaml"
            this.BtnNextPage.Click += new System.Windows.RoutedEventHandler(this.BtnNextPage_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

