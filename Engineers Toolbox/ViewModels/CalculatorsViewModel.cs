using CommunityToolkit.Mvvm.Input;
using EngineersToolbox.Models.Selectors;
using EngineersToolbox.Views;
using EngineersToolbox.Views.Calculators;
using EngineersToolbox.Views.Converters;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngineersToolbox.ViewModels
{
    public partial class CalculatorsViewModel : ToolboxBaseViewModel
    {
        public CalculatorsViewModel()
        {
            Title = "Calculators";
            Bind();
        }

        [RelayCommand]
        private async Task OpenPaymentCalculatorPage()
        {
            if (IsBusy)
                return;
            IsBusy = true;

            try
            {
                await Shell.Current.GoToAsync(nameof(PaymentCalculatorPage));
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
            
        }
    }
}
