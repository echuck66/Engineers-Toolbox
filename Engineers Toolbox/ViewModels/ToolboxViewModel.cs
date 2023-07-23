using CommunityToolkit.Mvvm.Input;
using EngineersToolbox.Models.Selectors;
using EngineersToolbox.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngineersToolbox.ViewModels
{
    public partial class ToolboxViewModel : ToolboxBaseViewModel
    {
        public ToolboxViewModel()
        {
            Title = "Tool Sets";
            Bind();
        }

        [RelayCommand]
        private async Task OpenConvertersPage()
        {
            if (IsBusy)
                return;
            IsBusy = true;

            try
            {
                await Shell.Current.GoToAsync(nameof(ConvertersPage));

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
        private async Task OpenCalculatorsPage()
        {
            if (IsBusy)
                return;
            IsBusy = true;

            try
            {
                await Shell.Current.GoToAsync(nameof(CalculatorsPage));

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
