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
using SqListCAI.Dialogs;
using SqListCAI.Events;
using SqListCAI.Entities;
using SqListCAI.AlgorithmThread;
namespace SqListCAI.Pages.MainPage
{
    /// <summary>
    /// MianDemon.xaml 的交互逻辑
    /// </summary>
    public partial class MainDemon : Page
    {
        SqList sqLiist;
        public MainDemon()
        {
            InitializeComponent();
        }
        public MainDemon(string demon_name)
        {
            InitializeComponent();
            this.demon_lable_name.Content = demon_name;//初始化当前操作内容
        }
        public MainDemon(string demon_name,string srcData, char insertData,int pisition)
        {
            InitializeComponent();
            this.demon_lable_name.Content = demon_name;//初始化当前操作内容
            //initUI();
        }
        //该窗体是否被改变
        public void changeUI(bool isMax)
        {
            if(isMax)
            {
                this.demon_border.Width += 200;
                Thickness margin_demo_drop = new Thickness(this.demo_drop.Margin.Left + 200, 0, 0, 0);
                this.demo_drop.Margin = margin_demo_drop;

                this.grid_code_value.ColumnDefinitions[0].Width = new GridLength(550d);
                this.grid_code_value.ColumnDefinitions[1].Width = new GridLength(401d);
                Thickness margin_code_drop = new Thickness(this.code_drop.Margin.Left + 98, 0, 0, 0);
                this.code_drop.Margin = margin_code_drop;
                Thickness margin_value_drop = new Thickness(this.value_drop.Margin.Left + 100, 0, 0, 0);
                this.value_drop.Margin = margin_value_drop;
            }
            else
            {

                this.demon_border.Width -= 200;
                Thickness margin_demo_drop = new Thickness(this.demo_drop.Margin.Left - 200, 0, 0, 0);
                this.demo_drop.Margin = margin_demo_drop;

                this.grid_code_value.ColumnDefinitions[0].Width = new GridLength(450d);
                this.grid_code_value.ColumnDefinitions[1].Width = new GridLength(300d);
                Thickness margin_code_drop = new Thickness(this.code_drop.Margin.Left - 98, 0, 0, 0);
                this.code_drop.Margin = margin_code_drop;
                Thickness margin_value_drop = new Thickness(this.value_drop.Margin.Left - 100, 0, 0, 0);
                this.value_drop.Margin = margin_value_drop;
            }
        }
        private void data_Click(object sender, RoutedEventArgs e)
        {
            string currentOperator = this.demon_lable_name.Content.ToString();
            switch (currentOperator)
            {
                case "SqListInsert":
                    {
                        InsertWindow insertWindow = new InsertWindow();
                        insertWindow.PassValuesEvent += new InsertWindow.PassValuesHandler(RecieveOrderInsert);
                        insertWindow.ShowDialog();
                        break;
                    }
                default:
                    break;
            }
        }

        private void RecieveOrderInsert(object sender, PassValuesEventArgs e)
        {
            this.demon_lable_name.Content = "SqListInsert";
            string srcData = e.srcData;
            char insData = e.insertData;
            int position = e.insertPosition;
            this.algorithm_lable_name.Content = srcData + "-" + insData + "-" + position;
        }

        private void explain_Click(object sender, RoutedEventArgs e)
        {
            new ThreadWindow().ShowDialog();
        }

        private void pause_Click(object sender, RoutedEventArgs e)
        {

        }

        private void run_Click(object sender, RoutedEventArgs e)
        {

        }

        private void oneStep_Click(object sender, RoutedEventArgs e)
        {

        }

        private void follow_Click(object sender, RoutedEventArgs e)
        {

        }

        private void runTo_Click(object sender, RoutedEventArgs e)
        {

        }

        private void resume_Click(object sender, RoutedEventArgs e)
        {

        }

        private void breakPoint_Click(object sender, RoutedEventArgs e)
        {

        }

        private void set_Click(object sender, RoutedEventArgs e)
        {

        }
        private void initDemon_code_value(string srcData, string insertData, int pisition)
        {

        }
        //显示当前动画
        public void showDemon()
        {

        }
        //显示当前代码
        public void showCode()
        {

        }
        //显示当前变量
        public void showValue()
        {

        }
    }
}