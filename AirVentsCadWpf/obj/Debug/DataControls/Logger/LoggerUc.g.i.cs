﻿#pragma checksum "..\..\..\..\DataControls\Logger\LoggerUc.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "3A6BF02BCF4DCF2AC3210A4530066B13"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18063
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
using System.Windows.Controls.Ribbon;
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


namespace AirVentsCadWpf.DataControls.Logger {
    
    
    /// <summary>
    /// LoggerUc
    /// </summary>
    public partial class LoggerUc : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 41 "..\..\..\..\DataControls\Logger\LoggerUc.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid СобытийТаблицаDataGrid;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\..\..\DataControls\Logger\LoggerUc.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox УровеньКомбо;
        
        #line default
        #line hidden
        
        
        #line 67 "..\..\..\..\DataControls\Logger\LoggerUc.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ДатаComboBox;
        
        #line default
        #line hidden
        
        
        #line 91 "..\..\..\..\DataControls\Logger\LoggerUc.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox Имя;
        
        #line default
        #line hidden
        
        
        #line 99 "..\..\..\..\DataControls\Logger\LoggerUc.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox Дата;
        
        #line default
        #line hidden
        
        
        #line 107 "..\..\..\..\DataControls\Logger\LoggerUc.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ИмяКласса;
        
        #line default
        #line hidden
        
        
        #line 115 "..\..\..\..\DataControls\Logger\LoggerUc.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox Функция;
        
        #line default
        #line hidden
        
        
        #line 118 "..\..\..\..\DataControls\Logger\LoggerUc.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ОбновитьДанные;
        
        #line default
        #line hidden
        
        
        #line 120 "..\..\..\..\DataControls\Logger\LoggerUc.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid ТаблицаДанных;
        
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
            System.Uri resourceLocater = new System.Uri("/AirVentsCad;component/datacontrols/logger/loggeruc.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\DataControls\Logger\LoggerUc.xaml"
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
            this.СобытийТаблицаDataGrid = ((System.Windows.Controls.DataGrid)(target));
            
            #line 41 "..\..\..\..\DataControls\Logger\LoggerUc.xaml"
            this.СобытийТаблицаDataGrid.Loaded += new System.Windows.RoutedEventHandler(this.СобытийТаблицаDataGrid_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.УровеньКомбо = ((System.Windows.Controls.ComboBox)(target));
            
            #line 59 "..\..\..\..\DataControls\Logger\LoggerUc.xaml"
            this.УровеньКомбо.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.УровеньКомбо_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.ДатаComboBox = ((System.Windows.Controls.ComboBox)(target));
            
            #line 67 "..\..\..\..\DataControls\Logger\LoggerUc.xaml"
            this.ДатаComboBox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ДатаComboBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Имя = ((System.Windows.Controls.ComboBox)(target));
            
            #line 91 "..\..\..\..\DataControls\Logger\LoggerUc.xaml"
            this.Имя.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.Имя_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Дата = ((System.Windows.Controls.ComboBox)(target));
            
            #line 99 "..\..\..\..\DataControls\Logger\LoggerUc.xaml"
            this.Дата.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.Дата_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.ИмяКласса = ((System.Windows.Controls.ComboBox)(target));
            
            #line 107 "..\..\..\..\DataControls\Logger\LoggerUc.xaml"
            this.ИмяКласса.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ИмяКласса_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.Функция = ((System.Windows.Controls.ComboBox)(target));
            
            #line 115 "..\..\..\..\DataControls\Logger\LoggerUc.xaml"
            this.Функция.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.Функция_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 8:
            this.ОбновитьДанные = ((System.Windows.Controls.Button)(target));
            
            #line 118 "..\..\..\..\DataControls\Logger\LoggerUc.xaml"
            this.ОбновитьДанные.Click += new System.Windows.RoutedEventHandler(this.ОбновитьДанные_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.ТаблицаДанных = ((System.Windows.Controls.DataGrid)(target));
            
            #line 120 "..\..\..\..\DataControls\Logger\LoggerUc.xaml"
            this.ТаблицаДанных.AutoGeneratingColumn += new System.EventHandler<System.Windows.Controls.DataGridAutoGeneratingColumnEventArgs>(this.ТаблицаДанных_AutoGeneratingColumn);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

