﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngineersToolbox.Views
{
    public abstract class BasePage : ContentPage
    {
        protected BasePage(object viewModel = null)
        {
            BindingContext = viewModel;
            Padding = 12;

            SetDynamicResource(BackgroundColorProperty, "AppBackgroundColor");

            if (string.IsNullOrWhiteSpace(Title))
            {
                Title = GetType().Name;
            }
        }

        public virtual void Reset()
        {

        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            Debug.WriteLine($"OnAppearing: {Title}");
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();

            Debug.WriteLine($"OnDisappearing: {Title}");
        }
    }
}
