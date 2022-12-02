using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.IO;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfApp13
{
    /// <summary>
    /// Логика взаимодействия для _2ndWindow.xaml
    /// </summary>
    public partial class _2ndWindow : Window
    {
        public _2ndWindow()
        {
            InitializeComponent();
        }

        private void btnEntr_Click(object sender, RoutedEventArgs e)
        {
           
            StreamReader sr = new StreamReader(@"C:\note\1.txt");
            while (sr.ReadLine() != txtLogin1.Text)
            {
                sr.ReadLine();
            } 

            for (int i = 0; i < 2; i++)
            {
                sr.ReadLine();
                if (txtPassword1.Password == sr.ReadLine())
                {
                    
                    _3rdWindow trdWin = new _3rdWindow();
                    this.Hide();
                    trdWin.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Возможно вы ввели неверный логин или пароль");
                   
                }

            }
          
            
        }

            private void btnPwd_Click(object sender, RoutedEventArgs e)
            {
                MessageBox.Show("В данный моменд это не робiт");
            }

            private void btnReg_Click(object sender, RoutedEventArgs e)
            {
                MainWindow mnWin = new MainWindow();
                this.Hide();
                mnWin.ShowDialog();
                this.Show();
            }
        
        }
    } 
