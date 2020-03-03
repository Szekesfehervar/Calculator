using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Calculator
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        string input = string.Empty;
        string x = string.Empty;
        string y = string.Empty;
        char operation;
        double result = 0.0;

        public MainPage()
        {
            this.InitializeComponent();
        }

        private void but1_Click(object sender, RoutedEventArgs e)
        {
            this.textbox.Text = " ";
            input += "1";
            this.textbox.Text += input;
        }

        private void but2_Click(object sender, RoutedEventArgs e)
        {
            this.textbox.Text = " ";
            input += "2";
            this.textbox.Text += input;
        }

        private void but3_Click(object sender, RoutedEventArgs e)
        {
            this.textbox.Text = " ";
            input += "3";
            this.textbox.Text += input;
        }

        private void but4_Click(object sender, RoutedEventArgs e)
        {
            this.textbox.Text = " ";
            input += "4";
            this.textbox.Text += input;
        }

        private void but5_Click(object sender, RoutedEventArgs e)
        {
            this.textbox.Text = " ";
            input += "5";
            this.textbox.Text += input;
        }

        private void but6_Click(object sender, RoutedEventArgs e)
        {
            this.textbox.Text = " ";
            input += "6";
            this.textbox.Text += input;
        }

        private void but7_Click(object sender, RoutedEventArgs e)
        {
            this.textbox.Text = " ";
            input += "7";
            this.textbox.Text += input;
        }

        private void but8_Click(object sender, RoutedEventArgs e)
        {
            this.textbox.Text = " ";
            input += "8";
            this.textbox.Text += input;
        }

        private void but9_Click(object sender, RoutedEventArgs e)
        {
            this.textbox.Text = " ";
            input += "9";
            this.textbox.Text += input;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }


    }
}
