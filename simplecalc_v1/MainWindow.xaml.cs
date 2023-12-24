using System;
using System.Data;
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
using System.Security.Cryptography.X509Certificates;
using System.Diagnostics.Eventing.Reader;
using Microsoft.VisualBasic;

namespace simplecalc_v1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            foreach(UIElement el in MainRoot.Children) { 
                if(el is Button)
                {
                    ((Button)el).Click += Button_Click;
                }
            
            }

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string str = (string)((Button)e.OriginalSource).Content;

            if (str == "AC")
                textLabel.Text = "";



            else if (str == "=") {
                string value = new DataTable().Compute(textLabel.Text, null).ToString();
                textLabel.Text = value;
            }





            else if (str == "C") {
                if (textLabel.Text.Length != 0)
                {
                    textLabel.Text = textLabel.Text.Remove(textLabel.Text.Length - 1);
                }

                else
                    textLabel.Text = textLabel.Text.Insert(textLabel.Text.Length, "0");
                              
            }


            else if (str == "sqrt")
            {
                string sqrt = Math.Sqrt(textLabel.Sqrt);
                textLabel.Text = sqrt;
            }

            //else if (str == "C") {
            //    textLabel.Text = textLabel.Text.Remove(textLabel.Text.Length - 1);
            //}


            else
                textLabel.Text += str;
        }
    }
}


//if (str == "C")
//    textLabel.Text = textLabel.Text.Remove(textLabel.Text.Length - 1);