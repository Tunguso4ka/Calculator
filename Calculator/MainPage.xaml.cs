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
        double FirstNum;
        double SecondNum;
        int AMMD;
        bool AddBtnIsTapped;
        bool EqualIsTapped;
        bool MinOrPlusIsTapped;
        bool CommaIsTapped;
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void a0Btn_Click(object sender, RoutedEventArgs e)
        {
            ATextBox.Text = ATextBox.Text + "0";
            EqualIsTapped = false;
        }

        private void a1Btn_Click(object sender, RoutedEventArgs e)
        {
            ATextBox.Text = ATextBox.Text + "1";
            EqualIsTapped = false;
        }

        private void a2Btn_Click(object sender, RoutedEventArgs e)
        {
            ATextBox.Text = ATextBox.Text + "2";
            EqualIsTapped = false;
        }

        private void a3Btn_Click(object sender, RoutedEventArgs e)
        {
            ATextBox.Text = ATextBox.Text + "3";
            EqualIsTapped = false;
        }

        private void a4Btn_Click(object sender, RoutedEventArgs e)
        {
            ATextBox.Text = ATextBox.Text + "4";
            EqualIsTapped = false;
        }

        private void a5Btn_Click(object sender, RoutedEventArgs e)
        {
            ATextBox.Text = ATextBox.Text + "5";
            EqualIsTapped = false;
        }

        private void a6Btn_Click(object sender, RoutedEventArgs e)
        {
            ATextBox.Text = ATextBox.Text + "6";
            EqualIsTapped = false;
        }

        private void a7Btn_Click(object sender, RoutedEventArgs e)
        {
            ATextBox.Text = ATextBox.Text + "7";
            EqualIsTapped = false;
        }

        private void a8Btn_Click(object sender, RoutedEventArgs e)
        {
            ATextBox.Text = ATextBox.Text + "8";
            EqualIsTapped = false;
        }

        private void a9Btn_Click(object sender, RoutedEventArgs e)
        {
            ATextBox.Text = ATextBox.Text + "9";
            EqualIsTapped = false;
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            if(ATextBox.Text != "")
            {
                ATextBox.Text = ATextBox.Text.Remove(ATextBox.Text.Length - 1);
                if(ATextBox.Text.Contains('.') == false)
                {
                    CommaIsTapped = false;
                }
            }
        }

        private void CBtn_Click(object sender, RoutedEventArgs e)
        {
            ATextBox.Text = "";
            ATextBox.PlaceholderText = "Result.";
            AddBtnIsTapped = false;
            MinOrPlusIsTapped = false;
            CommaIsTapped = false;
        }

        private void CEBtn_Click(object sender, RoutedEventArgs e)
        {
            if(EqualIsTapped == false)
            {
                ATextBox.Text = "";
                MinOrPlusIsTapped = false;
                CommaIsTapped = false;
            }
            else
            {
                ATextBox.Text = "";
                ATextBox.PlaceholderText = "Result.";
                AddBtnIsTapped = false;
                EqualIsTapped = false;
                MinOrPlusIsTapped = false;
                CommaIsTapped = false;
            }
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            if (AddBtnIsTapped == false && ATextBox.Text != "")
            {
                FirstNum = Convert.ToDouble(ATextBox.Text);
                ATextBox.PlaceholderText = ATextBox.Text + " + ";
                ATextBox.Text = "";
                AddBtnIsTapped = true;
                MinOrPlusIsTapped = false;
                EqualIsTapped = false;
                AMMD = 0;
            }
        }

        private void MinBtn_Click(object sender, RoutedEventArgs e)
        {
            if (AddBtnIsTapped == false && ATextBox.Text != "")
            {
                FirstNum = Convert.ToDouble(ATextBox.Text);
                ATextBox.PlaceholderText = ATextBox.Text + " - ";
                ATextBox.Text = "";
                AddBtnIsTapped = true;
                MinOrPlusIsTapped = false;
                EqualIsTapped = false;
                AMMD = 1;
            }
        }

        private void MulBtn_Click(object sender, RoutedEventArgs e)
        {
            if (AddBtnIsTapped == false && ATextBox.Text != "")
            {
                FirstNum = Convert.ToDouble(ATextBox.Text);
                ATextBox.PlaceholderText = ATextBox.Text + " x ";
                ATextBox.Text = "";
                AddBtnIsTapped = true;
                MinOrPlusIsTapped = false;
                EqualIsTapped = false;
                AMMD = 2;
            }
        }

        private void DivBtn_Click(object sender, RoutedEventArgs e)
        {
            if(AddBtnIsTapped == false && ATextBox.Text != "")
            {
                FirstNum = Convert.ToDouble(ATextBox.Text);
                ATextBox.PlaceholderText = ATextBox.Text + " : ";
                ATextBox.Text = "";
                AddBtnIsTapped = true;
                MinOrPlusIsTapped = false;
                EqualIsTapped = false;
                AMMD = 3;
            }
        }
        private void PointBtn_Click(object sender, RoutedEventArgs e)
        {
            if(CommaIsTapped == false && ATextBox.Text != "")
            {
                ATextBox.Text = ATextBox.Text + ".";
                CommaIsTapped = true;
                EqualIsTapped = false;
            }
        }

        private void xIn2Btn_Click(object sender, RoutedEventArgs e)
        {
            if (ATextBox.Text != "")
            {
                ATextBox.Text = Convert.ToString(Convert.ToDouble(ATextBox.Text) * Convert.ToDouble(ATextBox.Text)) ;
                EqualIsTapped = false;
            }
        }

        private void PlOrMiBtn_Click(object sender, RoutedEventArgs e)
        {
            if (ATextBox.Text[0] == '-')
            {
                ATextBox.Text = ATextBox.Text.Remove(0, 1);
                MinOrPlusIsTapped = true;
                EqualIsTapped = false;
            }
            if (ATextBox.Text != "" && MinOrPlusIsTapped == false)
            {
                ATextBox.Text = "-" + ATextBox.Text;
                MinOrPlusIsTapped = true;
                EqualIsTapped = false;
            }
            else if (ATextBox.Text != "" && MinOrPlusIsTapped == true)
            {
                MinOrPlusIsTapped = false;
                EqualIsTapped = false;
            }
        }
        private void a2CFxBtn_Click(object sender, RoutedEventArgs e)
        {
            if (ATextBox.Text != "")
            {
                ATextBox.Text = Convert.ToString(Math.Sqrt(Convert.ToDouble(ATextBox.Text)));
                EqualIsTapped = false;
            }
        }

        private void OneDXBtn_Click(object sender, RoutedEventArgs e)
        {
            if (ATextBox.Text != "")
            {
                ATextBox.Text = Convert.ToString(1.0 / Convert.ToDouble(ATextBox.Text));
                EqualIsTapped = false;
            }
        }

        private void EqualBtn_Click(object sender, RoutedEventArgs e)
        {
            if(AddBtnIsTapped == true && ATextBox.Text != "")
            {
                if(AMMD == 0)
                {
                    SecondNum = Convert.ToDouble(ATextBox.Text);
                    ATextBox.Text = Convert.ToString(FirstNum + SecondNum);
                }
                else if (AMMD == 1)
                {
                    SecondNum = Convert.ToDouble(ATextBox.Text);
                    ATextBox.Text = Convert.ToString(FirstNum - SecondNum);
                }
                else if (AMMD == 2)
                {
                    SecondNum = Convert.ToDouble(ATextBox.Text);
                    ATextBox.Text = Convert.ToString(FirstNum * SecondNum);
                }
                else if (AMMD == 3)
                {
                    SecondNum = Convert.ToDouble(ATextBox.Text);
                    ATextBox.Text = Convert.ToString(FirstNum / SecondNum);
                }
                EqualIsTapped = true;
                AddBtnIsTapped = false;
                MinOrPlusIsTapped = false;
                CommaIsTapped = false;
            }
        }
    }
}
