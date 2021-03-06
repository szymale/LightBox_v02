#pragma checksum "..\..\..\MainWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "00BB6DB99C5483A983A93E4C621F117EE4A7008A"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ten kod został wygenerowany przez narzędzie.
//     Wersja wykonawcza:4.0.30319.42000
//
//     Zmiany w tym pliku mogą spowodować nieprawidłowe zachowanie i zostaną utracone, jeśli
//     kod zostanie ponownie wygenerowany.
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
using wLightBoxGUI;


namespace wLightBoxGUI {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 47 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ConnectingMethod;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox StatusTextBox;
        
        #line default
        #line hidden
        
        
        #line 95 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider RedSlider;
        
        #line default
        #line hidden
        
        
        #line 97 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider GreenSlider;
        
        #line default
        #line hidden
        
        
        #line 99 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider BlueSlider;
        
        #line default
        #line hidden
        
        
        #line 101 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider WWhiteSlider;
        
        #line default
        #line hidden
        
        
        #line 103 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider CWhiteSlider;
        
        #line default
        #line hidden
        
        
        #line 105 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox DesiredColorTextBox;
        
        #line default
        #line hidden
        
        
        #line 108 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox DesiredEffectComboBox;
        
        #line default
        #line hidden
        
        
        #line 114 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Rectangle ColorRectangle;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.1.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/wLightBoxGUIWPF;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\MainWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.1.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.ConnectingMethod = ((System.Windows.Controls.ComboBox)(target));
            
            #line 51 "..\..\..\MainWindow.xaml"
            this.ConnectingMethod.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ConnectingMethod_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.StatusTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            
            #line 56 "..\..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.CheckStatusButton_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.RedSlider = ((System.Windows.Controls.Slider)(target));
            
            #line 95 "..\..\..\MainWindow.xaml"
            this.RedSlider.ValueChanged += new System.Windows.RoutedPropertyChangedEventHandler<double>(this.RedSlider_ValueChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.GreenSlider = ((System.Windows.Controls.Slider)(target));
            
            #line 97 "..\..\..\MainWindow.xaml"
            this.GreenSlider.ValueChanged += new System.Windows.RoutedPropertyChangedEventHandler<double>(this.GreenSlider_ValueChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.BlueSlider = ((System.Windows.Controls.Slider)(target));
            
            #line 99 "..\..\..\MainWindow.xaml"
            this.BlueSlider.ValueChanged += new System.Windows.RoutedPropertyChangedEventHandler<double>(this.BlueSlider_ValueChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.WWhiteSlider = ((System.Windows.Controls.Slider)(target));
            
            #line 101 "..\..\..\MainWindow.xaml"
            this.WWhiteSlider.ValueChanged += new System.Windows.RoutedPropertyChangedEventHandler<double>(this.WWhiteSlider_ValueChanged);
            
            #line default
            #line hidden
            return;
            case 8:
            this.CWhiteSlider = ((System.Windows.Controls.Slider)(target));
            
            #line 103 "..\..\..\MainWindow.xaml"
            this.CWhiteSlider.ValueChanged += new System.Windows.RoutedPropertyChangedEventHandler<double>(this.CWhiteSlider_ValueChanged);
            
            #line default
            #line hidden
            return;
            case 9:
            this.DesiredColorTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 10:
            
            #line 106 "..\..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ChangeColorButton_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.DesiredEffectComboBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 12:
            
            #line 113 "..\..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ChangeEffectButton_Click);
            
            #line default
            #line hidden
            return;
            case 13:
            this.ColorRectangle = ((System.Windows.Shapes.Rectangle)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

