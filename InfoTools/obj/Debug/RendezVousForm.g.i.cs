﻿#pragma checksum "..\..\RendezVousForm.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "A3F0806E38CC0F11319113CF4FA657FC84B263788CE0AC0217F6AD89737BA1BE"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

using InfoTools;
using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
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


namespace InfoTools {
    
    
    /// <summary>
    /// RendezVousForm
    /// </summary>
    public partial class RendezVousForm : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 15 "..\..\RendezVousForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid DtgRDV;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\RendezVousForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox CboUtilisateur;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\RendezVousForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxtNom;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\RendezVousForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxtPrenom;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\RendezVousForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxtMail;
        
        #line default
        #line hidden
        
        
        #line 73 "..\..\RendezVousForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxtTel;
        
        #line default
        #line hidden
        
        
        #line 82 "..\..\RendezVousForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxtContenu;
        
        #line default
        #line hidden
        
        
        #line 91 "..\..\RendezVousForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker DpRDV;
        
        #line default
        #line hidden
        
        
        #line 98 "..\..\RendezVousForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnAjouter;
        
        #line default
        #line hidden
        
        
        #line 99 "..\..\RendezVousForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnModifier;
        
        #line default
        #line hidden
        
        
        #line 100 "..\..\RendezVousForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnSupprimer;
        
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
            System.Uri resourceLocater = new System.Uri("/InfoTools;component/rendezvousform.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\RendezVousForm.xaml"
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
            this.DtgRDV = ((System.Windows.Controls.DataGrid)(target));
            
            #line 19 "..\..\RendezVousForm.xaml"
            this.DtgRDV.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.DtgRDV_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.CboUtilisateur = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 3:
            this.TxtNom = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.TxtPrenom = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.TxtMail = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.TxtTel = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.TxtContenu = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.DpRDV = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 9:
            this.BtnAjouter = ((System.Windows.Controls.Button)(target));
            
            #line 98 "..\..\RendezVousForm.xaml"
            this.BtnAjouter.Click += new System.Windows.RoutedEventHandler(this.BtnAjouter_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.BtnModifier = ((System.Windows.Controls.Button)(target));
            
            #line 99 "..\..\RendezVousForm.xaml"
            this.BtnModifier.Click += new System.Windows.RoutedEventHandler(this.BtnModifier_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.BtnSupprimer = ((System.Windows.Controls.Button)(target));
            
            #line 100 "..\..\RendezVousForm.xaml"
            this.BtnSupprimer.Click += new System.Windows.RoutedEventHandler(this.BtnSupprimer_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

