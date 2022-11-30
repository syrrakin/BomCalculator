using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Telerik.Windows.Controls;
using BomCalculator.View;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.DependencyInjection;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using Microsoft.Extensions.DependencyInjection;
using BomLib.Model;

namespace BomCalculator
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            StyleManager.ApplicationTheme = new VistaTheme();
            Ioc.Default.ConfigureServices(new ServiceCollection()
                .AddDbContext<ApplicationContext>()
                .BuildServiceProvider()
                );
            InitializeComponent();
        }

        private void Application_Startup(object sender, StartupEventArgs e)
        {
            var mw = new MainWindow();
            mw.Show();
        }
    }
}
