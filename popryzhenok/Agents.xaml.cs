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

namespace popryzhenok
{
    /// <summary>
    /// Логика взаимодействия для Agents.xaml
    /// </summary>
    public partial class Agents : Page
    {
        public Agents()
        {
            InitializeComponent();
            var alltypes = DemoEntities.GetContext().AgentType.ToList();
        }

        private void TBoxSearch_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void ComboFilter_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ComboSorting_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
