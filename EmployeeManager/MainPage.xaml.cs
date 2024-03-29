// ----------------------------------------------------------------------------------
// Microsoft Developer & Platform Evangelism
// 
// Copyright (c) Microsoft Corporation. All rights reserved.
// 
// THIS CODE AND INFORMATION ARE PROVIDED "AS IS" WITHOUT WARRANTY OF ANY KIND, 
// EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE IMPLIED WARRANTIES 
// OF MERCHANTABILITY AND/OR FITNESS FOR A PARTICULAR PURPOSE.
// ----------------------------------------------------------------------------------
// The example companies, organizations, products, domain names,
// e-mail addresses, logos, people, places, and events depicted
// herein are fictitious.  No association with any real company,
// organization, product, domain name, email address, logo, person,
// places, or events is intended or should be inferred.
// ----------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.Collections.ObjectModel;

namespace EmployeeManager
{
    public partial class MainPage : UserControl
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnUnGroup_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Data.CollectionViewSource cvs =
                this.Resources["employeeManagerEmployeesViewSource"] as System.Windows.Data.CollectionViewSource;
            cvs.View.GroupDescriptions.Clear();
        }

        private void btnGroup_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Data.CollectionViewSource cvs =
                this.Resources["employeeManagerEmployeesViewSource"] as System.Windows.Data.CollectionViewSource;

            if (cvs.View.GroupDescriptions.Count == 0)
                cvs.View.GroupDescriptions.Add(new System.Windows.Data.PropertyGroupDescription("Group"));
            else
                cvs.View.Refresh();
        }
    }
}