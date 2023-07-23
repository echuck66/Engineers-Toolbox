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
    public partial class MainPageViewModel : ToolboxBaseViewModel
    {
        public MainPageViewModel()
        {
            Title = "Engineer's Toolbox";
            Bind();
        }

        [RelayCommand]
        private async Task OpenToolboxPage()
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
