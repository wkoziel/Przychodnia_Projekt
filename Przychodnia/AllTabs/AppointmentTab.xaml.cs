﻿using Przychodnia.DAL.Encje;
using System;
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
using Przychodnia.DAL;
using Przychodnia.DAL.Repozytoria;
namespace Przychodnia.Tabs
{
    using System.Collections.ObjectModel;

    public partial class AppointmentTab : UserControl
    {
        public AppointmentTab()
        {
            InitializeComponent();
            List<Appointment> AppointmentList = AppointmentRepo.GetAllAppoitments();
            AppointmentListView.ItemsSource = AppointmentList;
        }

    }
}