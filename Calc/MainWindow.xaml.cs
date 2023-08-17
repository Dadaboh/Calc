using System;
using System.Collections.Generic;
using System.Windows;


namespace Calc
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double firstoperand;
        double secondoperand;
        double result;
        int preop = 4;
        char[] Preop = new char[] { '+', '-', '*', '/' };

        List <string> History = new List <string> ();

        public MainWindow()
        {
            InitializeComponent();
            L2.Content = "Введіть перший\nоперанд:";
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void B1_Click(object sender, RoutedEventArgs e)
        {
            GetButtonValue("1");
        }

        private void B2_Click(object sender, RoutedEventArgs e)
        {
            GetButtonValue("2");
        }

        private void B3_Click_1(object sender, RoutedEventArgs e)
        {
            GetButtonValue("3");
        }

        private void B4_Click(object sender, RoutedEventArgs e)
        {
            GetButtonValue("4");
        }

        private void B5_Click(object sender, RoutedEventArgs e)
        {
            GetButtonValue("5");
        }

        private void B6_Click(object sender, RoutedEventArgs e)
        {
            GetButtonValue("6");
        }

        private void B7_Click(object sender, RoutedEventArgs e)
        {
            GetButtonValue("7");
        }

        private void B8_Click(object sender, RoutedEventArgs e)
        {
            GetButtonValue("8");
        }

        private void B9_Click(object sender, RoutedEventArgs e)
        {
            GetButtonValue("9");
        }

        private void B10_Click(object sender, RoutedEventArgs e)
        {
            double tmp = Convert.ToDouble(L1.Content);
            tmp *= -1;
            L1.Content = tmp;
        }

        private void B11_Click(object sender, RoutedEventArgs e)
        {
            GetButtonValue("0");
        }

        private void B12_Click(object sender, RoutedEventArgs e)
        {
            string check = Convert.ToString(L1.Content);

            if (check == "")
            {
                L1.Content = "0,";
            }
            else if (check.Contains(','))
            {
                L3.Content = "В числі не може бути більше однієї коми.";
            }
            else
            {
                L1.Content += ",";
            }
        }

        private void LabelsUpdate()
        {
            if(firstoperand == 0)
            {
                L2.Content = "Введіть перший\nоперанд:";
            }
            else
            {
                L2.Content = "Введіть другий\nоперанд:";
            }
        }

        private void Op1_Click(object sender, RoutedEventArgs e)
        {
            GetFirstOpValue(preop);
            L3.Content = $"{firstoperand}  + ";
            L1.Content = "0";
            LabelsUpdate();
            preop = 0;            
        }
        private void Op2_Click(object sender, RoutedEventArgs e)
        {
            GetFirstOpValue(preop);
            L3.Content = $"{firstoperand}  - ";
            L1.Content = "0";
            LabelsUpdate();
            preop = 1;
        }

        private void Op3_Click(object sender, RoutedEventArgs e)
        {
            GetFirstOpValue(preop);
            L3.Content = $"{firstoperand}  * ";
            L1.Content = "0";
            LabelsUpdate();
            preop = 2;

        }

        private void Op4_Click(object sender, RoutedEventArgs e)
        {
            GetFirstOpValue(preop);
            L3.Content = $"{firstoperand}  / ";
            L1.Content = "0";
            LabelsUpdate();
            preop = 3;

        }

        private void GetFirstOpValue(int operationtype)
        {
            switch (operationtype)
            {
                case 0:
                    firstoperand += Convert.ToDouble(L1.Content);
                    break;

                case 1:
                    firstoperand -= Convert.ToDouble(L1.Content);
                    break;

                case 2:
                    firstoperand *= Convert.ToDouble(L1.Content);
                    break;

                case 3:
                    if(Convert.ToDouble(L1.Content) == 0)
                    {
                        break;
                    }
                    firstoperand /= Convert.ToDouble(L1.Content);
                    break;
                case 4:
                    firstoperand = Convert.ToDouble(L1.Content);
                    break;
            }
        }



        private void BResult_Click(object sender, RoutedEventArgs e)
        {
            if (preop != 4)
            {
                if(preop == 3 && L1.Content == "0")
                {
                    L3.Content = "На нуль ділити не можна.";
                    L2.Content = "Введіть перший операнд:";

                    firstoperand = secondoperand = result = 0;
                    preop = 4;
                }
                else
                {
                    secondoperand = Convert.ToDouble(L1.Content);

                    string res = $"{firstoperand} {Preop[preop]} {secondoperand} = ";

                    GetFirstOpValue(preop);
                    result = firstoperand;

                    res += result.ToString();
                    L3.Content = res;
                    ShowHistory(res);

                    L1.Content = "0";
                    L2.Content = "Результат:";

                    firstoperand = secondoperand = 0;
                    preop = 4;
                }
                
            }
            //else
            //{
            //    L3.Content = "На нуль ділити не можна.";
            //    firstoperand = secondoperand = result = 0;
            //    preop = 4;
            //}
        }
        
        private void GetButtonValue(string num)
        {
            if (L1.Content == "0")
            {
                L1.Content = $"{num}";
            }
            else
            {
                L1.Content += $"{num}";
            }
        }

        private void ShowHistory(string res)
        {
            History.Add(res);
            L4.Content += $"\n{res}";
        }

        private void BSin_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int value = Convert.ToInt32(L1.Content);
                string binary = Convert.ToString(value, 2);
                L2.Content = "";
                string res = $"{value} в двійковій системі: {binary}";
                ShowHistory(res);
                L3.Content = res;
            }
            catch
            {
                L2.Content = "Має бути вказане ціле число.";
            }
        }

        private void BCos_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int value = Convert.ToInt32(L1.Content);
                string hex = Convert.ToString(value, 16); 
                L2.Content = "";
                string res = $"{value} в Hex системі: {hex}";
                ShowHistory(res);
                L3.Content = res;
            }
            catch
            {
                L2.Content = "Має бути вказане ціле число.";

            }

        }

        private void BOct_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int value = Convert.ToInt32(L1.Content);
                string oct = Convert.ToString(value, 8);
                L2.Content = "";
                string res = $"{value} в Oct системі: {oct}";
                ShowHistory(res);
                L3.Content = res;
            }
            catch
            {
                L2.Content = "Має бути вказане ціле число.";

            }
        }

        private void BClear_Click(object sender, RoutedEventArgs e)
        {
            firstoperand = secondoperand = result = 0;
            History.Clear();
            L1.Content = "0";
            L3.Content = "";
            L4.Content = "";
            LabelsUpdate();
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            if(L1.Content is not null && L1.Content != "")
            {
                string tmpres = Convert.ToString(L1.Content);
                L1.Content = tmpres.Substring(0, tmpres.Length - 1);
            }  
        }
    }
}
