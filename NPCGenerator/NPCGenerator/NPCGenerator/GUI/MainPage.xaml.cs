﻿using NPCGenerator.GUI;
using NPCGenerator.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace NPCGenerator.GUI
{
	public partial class MainPage : ContentPage
	{
        AppModel AppModel => AppModel.Instance;
		public MainPage()
		{
			InitializeComponent();
        }

        async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new GeneratorPage());

        }
    }
}
