using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using wLightBoxLibrary;

namespace wLightBoxGUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string connectingMethod = "";
        private wLightBoxLibrary.Color color = new wLightBoxLibrary.Color();
        private Rgbw rgbw = new Rgbw();
        
        public MainWindow()
        {
            InitializeComponent();
            ApiHelper.InitializeClient();
            DataContext = new ViewModel();
        }

        private void RedSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            updateDesiredColor();
        }

        private void GreenSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            updateDesiredColor();
        }

        private void BlueSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            updateDesiredColor();
        }

        private void WWhiteSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            updateDesiredColor();
        }

        private void CWhiteSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            updateDesiredColor();
        }

        private void updateDesiredColor()
        {
            color.RedValue = (int)RedSlider.Value;
            color.GreenValue = (int)GreenSlider.Value;
            color.BlueValue = (int)BlueSlider.Value;
            color.WarmWhiteValue = (int)WWhiteSlider.Value;
            color.ColdWhiteValue = (int)CWhiteSlider.Value;

            DesiredColorTextBox.Text = color.GetHexColor(color.RedValue, color.GreenValue, color.BlueValue, color.WarmWhiteValue, color.ColdWhiteValue);
        }

        private async Task updateRgbw()
        {
            await LightProcessor.ChangeLight(connectingMethod, rgbw);
            StatusTextBox.Text = StatusProcessor.LoadState(connectingMethod).ToString();
        }

        private void CheckStatusButton_Click(object sender, RoutedEventArgs e)
        {
            StatusTextBox.Text = StatusProcessor.LoadState(connectingMethod).ToString();
        }
        private async void ChangeColorButton_Click(object sender, RoutedEventArgs e)
        {
            rgbw.DesiredColor = DesiredColorTextBox.Text;
            await updateRgbw();
        }  

        private async void ChangeEffectButton_Click(object sender, RoutedEventArgs e)
        {
            rgbw.EffectId = int.Parse(DesiredEffectComboBox.Text);
            await updateRgbw();
        }

        private void ConnectingMethod_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            connectingMethod = ConnectingMethod.Text;
        }
    }
}
