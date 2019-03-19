﻿using System;
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

namespace _304555fileReadExample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnReadFile_Click(object sender, RoutedEventArgs e)
        {
            try {
                System.IO.StreamReader sr =
                    new System.IO.StreamReader("birthdayList.txt");
                lblOutput.Content = "";
                while(!sr.EndOfStream)
                {
                    lblOutput.Content += sr.ReadLine() + Environment.NewLine; 
                }//end while
                sr.Close();
            }//end try
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }//end catch

        }

        private void BtnReadFile2_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                System.IO.StreamReader sr =
                    new System.IO.StreamReader("bl2.txt");
                lblOutput.Content = "";
                string output = "";
                while (!sr.EndOfStream)
                {
                    string fullName = sr.ReadLine();
                   string[] names =
                        fullName.Split(new char[]  {  ','  });
                    output += names[0] + Environment.NewLine;

                   
                }//end while
                lblOutput.Content = output;
                sr.Close();
            }//end try
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }//end catch
        }
    }
}
