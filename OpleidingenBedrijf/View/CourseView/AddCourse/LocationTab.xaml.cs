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

namespace BedrijfsOpleiding.View.CourseView.AddCourse
{
    /// <summary>
    /// Interaction logic for LocationTab.xaml
    /// </summary>
    public partial class LocationTab : UserControl
    {
        public LocationTab()
        {
            InitializeComponent();
        }

        private void MaxParticipants_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            //MaxParticipantsLabel.Content = Math.Round(MaxParticipants.Value, 0);
        }
    }
}
