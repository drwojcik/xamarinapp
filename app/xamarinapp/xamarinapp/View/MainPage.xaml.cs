﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace xamarinapp
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            var vm = new MainViewModel();
            this.BindingContext = vm;
        }

        private  void Button_Clicked(object sender, EventArgs e)
        {
           // await Navigation.PushAsync(new Lista()); para dar certo assim precisa do metodo async
            Application.Current.MainPage.Navigation.PushAsync(new Lista());
            
        }
     
    }
}
