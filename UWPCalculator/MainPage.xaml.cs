using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

//“空白页”项模板在 http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409 上有介绍

namespace UWPCalculator
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        public string a = "0";
        public string b = "";
        public bool c;
        public string d = "0";
        private bool isShiftKeyPressed;

        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            if (b != "Error!")
            {
                if (B.Text == "0")
                {
                    d = "1";
                }
                else
                {
                    d += "1";
                }
                B.Text = d;
            }
            else
                B.Text = "Please clear it.";
            c = true;
        }

        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            if (b != "Error!")
            {
                if (B.Text == "0")
                {
                    d = "2";
                }
                else
                {
                    d += "2";
                }
                B.Text = d;
            }
            else
                B.Text = "Please clear it.";
            c = true;
        }

        private void Button_Click3(object sender, RoutedEventArgs e)
        {
            if (b != "Error!")
            {
                if (B.Text == "0")
                {
                    d = "3";
                }
                else
                {
                    d += "3";
                }
                B.Text = d;
            }
            else
                B.Text = "Please clear it.";
            c = true;
        }

        private void Button_Click4(object sender, RoutedEventArgs e)
        {
            if (b != "Error!")
            {
                if (B.Text == "0")
                {
                    d = "4";
                }
                else
                {
                    d += "4";
                }
                B.Text = d;
            }
            else
                B.Text = "Please clear it.";
            c = true;
        }

        private void Button_Click5(object sender, RoutedEventArgs e)
        {
            if (b != "Error!")
            {
                if (B.Text == "0")
                {
                    d = "5";
                }
                else
                {
                    d += "5";
                }
                B.Text = d;
            }
            else
                B.Text = "Please clear it.";
            c = true;
        }

        private void Button_Click6(object sender, RoutedEventArgs e)
        {
            if (b != "Error!")
            {
                if (B.Text == "0")
                {
                    d = "6";
                }
                else
                {
                    d += "6";
                }
                B.Text = d;
            }
            else
                B.Text = "Please clear it.";
            c = true;
        }

        private void Button_Click7(object sender, RoutedEventArgs e)
        {
            if (b != "Error!")
            {
                if (B.Text == "0")
                {
                    d = "7";
                }
                else
                {
                    d += "7";
                }
                B.Text = d;
            }
            else
                B.Text = "Please clear it.";
            c = true;
        }

        private void Button_Click8(object sender, RoutedEventArgs e)
        {
            if (b != "Error!")
            {
                if (B.Text == "0")
                {
                    d = "8";
                }
                else
                {
                    d += "8";
                }
                B.Text = d;
            }
            else
                B.Text = "Please clear it.";
            c = true;
        }

        private void Button_Click9(object sender, RoutedEventArgs e)
        {
            if (b != "Error!")
            {
                if (B.Text == "0")
                {
                    d = "9";
                }
                else
                {
                    d += "9";
                }
                B.Text = d;
            }
            else
                B.Text = "Please clear it.";
            c = true;
        }

        private void Button_Click0(object sender, RoutedEventArgs e)
        {
            if (b != "Error!")
            {
                if (B.Text != "0")
                {
                    d += "0";
                }
                B.Text = d;
            }
            else
                B.Text = "Please clear it.";
            c = true;
        }

        bool point = true;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (b != "Error!")
            {
                if (point == true)
                {
                    if (d != "")
                    {
                        d += ".";
                    }
                    else
                    {
                        d = "0.";
                    }
                    point = false;
                }
                B.Text = d;
            }
            else
                B.Text = "Please clear it.";
            c = true;
        }

        double num1 = 0;

        private void Button_ClickA(object sender, RoutedEventArgs e)
        {
            if (b != "Error!")
            {
                if (c == false) { }
                else
                {
                    d = Convert.ToDouble(d).ToString();
                    b = b + d + " + ";
                    d = "";
                    if (b.Contains("÷ 0 "))
                    {
                        b = "Error!";
                        A.Text = b;
                        B.Text = b;
                    }
                    else
                    {
                        A.Text = b;
                        point = true;
                        switch (a)
                        {
                            case "0":
                                num1 = Convert.ToDouble(B.Text);
                                break;
                            case "A":
                                num1 += Convert.ToDouble(B.Text);
                                B.Text = num1.ToString();
                                break;
                            case "B":
                                num1 -= Convert.ToDouble(B.Text);
                                B.Text = num1.ToString();
                                break;
                            case "C":
                                num1 *= Convert.ToDouble(B.Text);
                                B.Text = num1.ToString();
                                break;
                            case "D":
                                num1 /= Convert.ToDouble(B.Text);
                                B.Text = num1.ToString();
                                break;
                        }
                        a = "A";
                    }
                }
            }
            else
                B.Text = "Please clear it.";
            c = false;
        }

        private void Button_ClickB(object sender, RoutedEventArgs e)
        {
            if (b != "Error!")
            {
                if (c == false) { }
                else
                {
                    d = Convert.ToDouble(d).ToString();
                    b = b + d + " - ";
                    d = "";
                    if (b.Contains("÷ 0 "))
                    {
                        b = "Error!";
                        A.Text = b;
                        B.Text = b;
                    }
                    else
                    {
                        A.Text = b;
                        point = true;
                        switch (a)
                        {
                            case "0":
                                num1 = Convert.ToDouble(B.Text);
                                break;
                            case "A":
                                num1 += Convert.ToDouble(B.Text);
                                B.Text = num1.ToString();
                                break;
                            case "B":
                                num1 -= Convert.ToDouble(B.Text);
                                B.Text = num1.ToString();
                                break;
                            case "C":
                                num1 *= Convert.ToDouble(B.Text);
                                B.Text = num1.ToString();
                                break;
                            case "D":
                                num1 /= Convert.ToDouble(B.Text);
                                B.Text = num1.ToString();
                                break;
                        }
                        a = "B";
                    }
                }
            }
            else
                B.Text = "Please clear it.";
            c = false;
        }

        private void Button_ClickC(object sender, RoutedEventArgs e)
        {
            if (b != "Error!")
            {
                if (c == false) { }
                else
                {
                    d = Convert.ToDouble(d).ToString();
                    b = b + d + " × ";
                    d = "";
                    if (b.Contains("÷ 0 "))
                    {
                        b = "Error!";
                        A.Text = b;
                        B.Text = b;
                    }
                    else
                    {
                        A.Text = b;
                        point = true;
                        switch (a)
                        {
                            case "0":
                                num1 = Convert.ToDouble(B.Text);
                                break;
                            case "A":
                                num1 += Convert.ToDouble(B.Text);
                                B.Text = num1.ToString();
                                break;
                            case "B":
                                num1 -= Convert.ToDouble(B.Text);
                                B.Text = num1.ToString();
                                break;
                            case "C":
                                num1 *= Convert.ToDouble(B.Text);
                                B.Text = num1.ToString();
                                break;
                            case "D":
                                num1 /= Convert.ToDouble(B.Text);
                                B.Text = num1.ToString();
                                break;
                        }
                        a = "C";
                    }
                }
            }
            else
                B.Text = "Please clear it.";
            c = false;
        }

        private void Button_ClickD(object sender, RoutedEventArgs e)
        {
            if (b != "Error!")
            {
                if (c == false) { }
                else
                {
                    d = Convert.ToDouble(d).ToString();
                    b = b + d + " ÷ ";
                    d = "";
                    if (b.Contains("÷ 0 "))
                    {
                        b = "Error!";
                        A.Text = b;
                        B.Text = b;
                    }
                    else
                    {
                        A.Text = b;
                        point = true;
                        switch (a)
                        {
                            case "0":
                                num1 = Convert.ToDouble(B.Text);
                                break;
                            case "A":
                                num1 += Convert.ToDouble(B.Text);
                                B.Text = num1.ToString();
                                break;
                            case "B":
                                num1 -= Convert.ToDouble(B.Text);
                                B.Text = num1.ToString();
                                break;
                            case "C":
                                num1 *= Convert.ToDouble(B.Text);
                                B.Text = num1.ToString();
                                break;
                            case "D":
                                num1 /= Convert.ToDouble(B.Text);
                                B.Text = num1.ToString();
                                break;
                        }
                        a = "D";
                    }
                }
            }
            else
                B.Text = "Please clear it.";
            c = false;
        }

        private void Button_ClickE(object sender, RoutedEventArgs e)
        {
            if (b != "Error!")
            {
                if (c == false) { }
                else
                {
                    if (A.Text.EndsWith("= "))
                    {
                        b = B.Text + " = ";
                    }
                    else
                    {
                        d = Convert.ToDouble(d).ToString();
                        b = b + d + " = ";
                        if (b.Contains("÷ 0 "))
                        {
                            b = "Error!";
                            A.Text = b;
                            B.Text = b;
                        }
                        else
                        {
                            A.Text = "";
                            point = true;
                            switch (a)
                            {
                                case "0":
                                    num1 = Convert.ToDouble(B.Text);
                                    break;
                                case "A":
                                    num1 += Convert.ToDouble(B.Text);
                                    B.Text = num1.ToString();
                                    break;
                                case "B":
                                    num1 -= Convert.ToDouble(B.Text);
                                    B.Text = num1.ToString();
                                    break;
                                case "C":
                                    num1 *= Convert.ToDouble(B.Text);
                                    B.Text = num1.ToString();
                                    break;
                                case "D":
                                    num1 /= Convert.ToDouble(B.Text);
                                    B.Text = num1.ToString();
                                    break;
                            }
                        }
                        a = "0";
                    }
                    if (B.Text != "Error!")
                    {
                        his.Insert(0, new His { Head = b, Score = B.Text });
                        records.ItemsSource = his;
                    }
                    b = "";
                    d = "";
                }
            }
            else
                B.Text = "Please clear it.";
            c = false;
        }

        private void Pivot_KeyDown(object sender, KeyRoutedEventArgs e)
        {
            if (e.Key == Windows.System.VirtualKey.Shift) isShiftKeyPressed = true;
            else if (isShiftKeyPressed == false)
            {
                if (e.Key == Windows.System.VirtualKey.Number1 || e.Key == Windows.System.VirtualKey.NumberPad1)
                    Button_Click1(sender, e);
                if (e.Key == Windows.System.VirtualKey.Number2 || e.Key == Windows.System.VirtualKey.NumberPad2)
                    Button_Click2(sender, e);
                if (e.Key == Windows.System.VirtualKey.Number3 || e.Key == Windows.System.VirtualKey.NumberPad3)
                    Button_Click3(sender, e);
                if (e.Key == Windows.System.VirtualKey.Number4 || e.Key == Windows.System.VirtualKey.NumberPad4)
                    Button_Click4(sender, e);
                if (e.Key == Windows.System.VirtualKey.Number5 || e.Key == Windows.System.VirtualKey.NumberPad5)
                    Button_Click5(sender, e);
                if (e.Key == Windows.System.VirtualKey.Number6 || e.Key == Windows.System.VirtualKey.NumberPad6)
                    Button_Click6(sender, e);
                if (e.Key == Windows.System.VirtualKey.Number7 || e.Key == Windows.System.VirtualKey.NumberPad7)
                    Button_Click7(sender, e);
                if (e.Key == Windows.System.VirtualKey.Number8 || e.Key == Windows.System.VirtualKey.NumberPad8)
                    Button_Click8(sender, e);
                if (e.Key == Windows.System.VirtualKey.Number9 || e.Key == Windows.System.VirtualKey.NumberPad9)
                    Button_Click9(sender, e);
                if (e.Key == Windows.System.VirtualKey.Number0 || e.Key == Windows.System.VirtualKey.NumberPad0)
                    Button_Click0(sender, e);
                if (e.Key == Windows.System.VirtualKey.Add)
                    Button_ClickA(sender, e);
                if (e.Key == Windows.System.VirtualKey.Subtract || (int)e.Key == 189)
                    Button_ClickB(sender, e);
                if (e.Key == Windows.System.VirtualKey.Multiply)
                    Button_ClickC(sender, e);
                if (e.Key == Windows.System.VirtualKey.Divide || (int)e.Key == 191)
                    Button_ClickD(sender, e);
                if (e.Key == Windows.System.VirtualKey.Decimal || (int)e.Key == 190)
                    Button_Click(sender, e);
                if (e.Key == Windows.System.VirtualKey.Enter || (int)e.Key == 187)
                    Button_ClickE(sender, e);
            }
            else if (isShiftKeyPressed == true)
            {
                if ((int)e.Key == 187)
                    Button_ClickA(sender, e);
                if (e.Key == Windows.System.VirtualKey.Number8)
                    Button_ClickC(sender, e);
            }
        }

        private void Pivot_KeyUp(object sender, KeyRoutedEventArgs e)
        {
            if (e.Key == Windows.System.VirtualKey.Shift) isShiftKeyPressed = false;
        }

        private void AppBarButtonC_Click(object sender, RoutedEventArgs e)
        {
            A.Text = "";
            B.Text = "0";
            a = "0";
            b = "";
            d = "0";
            c = true;
        }

        private void AppBarButton_Click(object sender, RoutedEventArgs e)
        {
            his.Clear();
            records.ItemsSource = his;
        }

        public class His
        {
            public string Head { get; set; }
            public string Score { get; set; }
        }

        public ObservableCollection<His> his = new ObservableCollection<His>();

        private void records_ItemClick(object sender, ItemClickEventArgs e)
        {
            A.Text = ((His)e.ClickedItem).Head.Substring(0, ((His)e.ClickedItem).Head.Length - 3);
            B.Text = ((His)e.ClickedItem).Score;
        }
    }
}
