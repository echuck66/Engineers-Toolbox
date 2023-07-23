using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using EngineersToolbox.Models;
using EngineersToolbox.Models.Selectors;
using EngineersToolbox.Services.Calculators;
using EngineersToolbox.Views;
using EngineersToolbox.Views.Converters;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace EngineersToolbox.ViewModels
{
    public partial class PaymentCalculatorViewModel : ToolboxBaseViewModel
    {
        private PaymentCalculator _calculator;

        public PaymentCalculatorViewModel()
        {
            _calculator = new PaymentCalculator();
            Title = "Payment Calculator";
            Bind();
        }

        [ObservableProperty]
        private decimal principal;

        [ObservableProperty]
        private decimal interestPercent;

        [ObservableProperty]
        private PaymentFrequency frequency;

        [ObservableProperty]
        private int term;

        [ObservableProperty]
        private decimal payment;

        public ObservableCollection<PaymentFrequencySelector> FreqencyOptions { get; set; }


        [ObservableProperty]
        private PaymentFrequencySelector frequencySelector;

        [RelayCommand]
        private async Task CalculatePayment()
        {
            if (IsBusy)
                return;
            IsBusy = true;

            try
            {
                
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"  {ex.Message}");
                await AppShell.Alert(ex.Message);
            }
            finally
            {
                IsBusy = false;
            }
        }

        

        [RelayCommand]
        private async Task CloseTool()
        {
            if (IsBusy)
                return;
            IsBusy = true;

            try
            {
                await Shell.Current.GoToAsync(nameof(ToolboxPage));
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"  {ex.Message}");
                await AppShell.Alert(ex.Message);
            }
            finally
            {
                IsBusy = false;
            }
        }

        public void Bind()
        {
            FreqencyOptions = new ObservableCollection<PaymentFrequencySelector>()
            {
                new PaymentFrequencySelector()
                {
                    Frequency = PaymentFrequency.Daily,
                    FrequencyName = "Daily"
                },
                new PaymentFrequencySelector()
                {
                    Frequency = PaymentFrequency.Weekly,
                    FrequencyName = "Weekly"
                },
                new PaymentFrequencySelector()
                {
                    Frequency = PaymentFrequency.BiWeekly,
                    FrequencyName = "Bi-Weekly"
                },
                new PaymentFrequencySelector()
                {
                    Frequency = PaymentFrequency.SemiMonthly,
                    FrequencyName = "Semi-Monthly"
                },
                new PaymentFrequencySelector()
                {
                    Frequency = PaymentFrequency.Monthly,
                    FrequencyName = "Monthly"
                },
                new PaymentFrequencySelector()
                {
                    Frequency = PaymentFrequency.Annually,
                    FrequencyName = "Annually"
                }
            };


        }
    }
}
