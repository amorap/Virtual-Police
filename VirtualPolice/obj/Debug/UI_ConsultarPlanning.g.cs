﻿#pragma checksum "..\..\UI_ConsultarPlanning.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "0A79B28AAD7BCF9C2B53633EA055B697"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.18444
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
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


namespace VirtualPolice {
    
    
    /// <summary>
    /// UI_ConsultarPlanning
    /// </summary>
    public partial class UI_ConsultarPlanning : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\UI_ConsultarPlanning.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Calendar MonthlyCalendar;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\UI_ConsultarPlanning.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image FotoAgente;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\UI_ConsultarPlanning.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView ListView1;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\UI_ConsultarPlanning.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lb_nombre;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\UI_ConsultarPlanning.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lb_dni;
        
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
            System.Uri resourceLocater = new System.Uri("/VirtualPolice;component/ui_consultarplanning.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\UI_ConsultarPlanning.xaml"
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
            
            #line 5 "..\..\UI_ConsultarPlanning.xaml"
            ((VirtualPolice.UI_ConsultarPlanning)(target)).Closing += new System.ComponentModel.CancelEventHandler(this.Window_Closing);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 10 "..\..\UI_ConsultarPlanning.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Imprimir_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.MonthlyCalendar = ((System.Windows.Controls.Calendar)(target));
            
            #line 13 "..\..\UI_ConsultarPlanning.xaml"
            this.MonthlyCalendar.SelectedDatesChanged += new System.EventHandler<System.Windows.Controls.SelectionChangedEventArgs>(this.MonthlyCalendar_SelectedDatesChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.FotoAgente = ((System.Windows.Controls.Image)(target));
            return;
            case 5:
            this.ListView1 = ((System.Windows.Controls.ListView)(target));
            return;
            case 6:
            this.lb_nombre = ((System.Windows.Controls.Label)(target));
            return;
            case 7:
            this.lb_dni = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

