// Updated by XamlIntelliSenseFileGenerator 17/03/2021 15:02:19
#pragma checksum "..\..\..\..\Formulaire\ControleUtilisateur\RendezVousForm.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "C1079AB6F9A4C19CEC5B3B32D727E43B9A7E8A09C0C6677F75894303EB1C4416"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

using InfoTools.Formulaire.ControleUtilisateur;
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


namespace InfoTools.Formulaire.ControleUtilisateur
{


    /// <summary>
    /// RendezVousForm
    /// </summary>
    public partial class RendezVousForm : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector
    {

        private bool _contentLoaded;

        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent()
        {
            if (_contentLoaded)
            {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/InfoTools;component/formulaire/controleutilisateur/rendezvousform.xaml", System.UriKind.Relative);

#line 1 "..\..\..\..\Formulaire\ControleUtilisateur\RendezVousForm.xaml"
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
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
        {
            this._contentLoaded = true;
        }

        internal System.Windows.Controls.DataGrid DtgRDV;
        internal System.Windows.Controls.TextBox TxtIdRDV;
        internal System.Windows.Controls.ComboBox CboUtilisateur;
        internal System.Windows.Controls.TextBox TxtIdUti;
        internal System.Windows.Controls.TextBox TxtNom;
        internal System.Windows.Controls.TextBox TxtPrenom;
        internal System.Windows.Controls.TextBox TxtMail;
        internal System.Windows.Controls.TextBox TxtTel;
        internal System.Windows.Controls.TextBox TxtContenu;
        internal System.Windows.Controls.DatePicker DpRDV;
        internal System.Windows.Controls.Button BtnAjouter;
        internal System.Windows.Controls.Button BtnModifier;
        internal System.Windows.Controls.Button BtnSupprimer;
    }
}

