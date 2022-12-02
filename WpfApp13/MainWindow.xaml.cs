using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp13
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public static string Login;
        public static string Password;
        Random rnd = new Random();
        private string CaptchaString;

        private void CaptchaCreate()
        {
            txtCp1.Text = Convert.ToString((char)rnd.Next(65, 90));
            txtCp2.Text = Convert.ToString((char)rnd.Next(65, 90));
            txtCp3.Text = Convert.ToString((char)rnd.Next(65, 90));
            txtCp4.Text = Convert.ToString((char)rnd.Next(65, 90));
            txtCp5.Text = Convert.ToString((char)rnd.Next(65, 90));
            txtCp6.Text = Convert.ToString((char)rnd.Next(65, 90));
            CaptchaString = txtCp1.Text + txtCp2.Text + txtCp3.Text + txtCp4.Text + txtCp5.Text + txtCp6.Text;
            CaptchaColorFont(txtCp1);
            CaptchaColorFont(txtCp2);
            CaptchaColorFont(txtCp3);
            CaptchaColorFont(txtCp4);
            CaptchaColorFont(txtCp5);
            CaptchaColorFont(txtCp6);
        }
        private void CaptchaColorFont(TextBlock TB)
        {

            TB.Foreground = Brushes.Black;
            TB.FontFamily = new FontFamily("Times New Roman");

        }







        public MainWindow()
        {
            InitializeComponent();
            CaptchaCreate();
        }


        private void Window_Closed(object sender, EventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            CaptchaCreate();
        }
       
        private void Send_Click(object sender, RoutedEventArgs e)
        {
            if (txtLogin.Text != " ")
            {
               
                if (txtNum.Text != " ")
                {
                    if (txtMail.Text != " ")
                    {
                        if (txtAdress.Text != " ")
                        {
                            if (txtName.Text != " "&& txtLogin.Text != " "&& txtNum.Text != " " && txtMail.Text != " " && txtAdress.Text != " ")
                            {
                                if (txtPassword.SecurePassword != txtConfPassword.SecurePassword)
                                {
                                   
                                    MessageBox.Show("верно");
                                    StreamWriter sw = new StreamWriter(@"C:\note\1.txt", true); 
                                    sw.WriteLine(txtName.Text + "\n" + txtNum.Text + "\n" + txtLogin.Text + "\n" + txtMail.Text + "\n" + txtPassword.Password + "\n" + txtAdress.Text  );
                                    sw.Close();
                                    _2ndWindow sndWin = new _2ndWindow();
                                    this.Hide();
                                   

                                }
                                else
                                {
                                    MessageBox.Show("неверно введены данные");

                                }
                                
                            }
                            else
                            {
                                MessageBox.Show("неверно введены данные");
                            }
                        }
                        else
                        {
                            MessageBox.Show("неверно введены данные");
                        }
                    }
                    else
                    {
                        MessageBox.Show("неверно введены данные");
                    }
                }
                else
                {
                    MessageBox.Show("неверно введены данные");
                }
            }
            else
            {

                MessageBox.Show("неверно введены данные");

            }
            
        }



     
    }
    
}

