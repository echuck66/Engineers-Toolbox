using CommunityToolkit.Mvvm.Input;
using EngineersToolbox.Views;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngineersToolbox.ViewModels
{
    public partial class AngleConverterViewModel : ToolboxBaseViewModel
    {


        [RelayCommand]
        private async Task CloseTool()
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

        public void Bind()
        {

        }
    }
}
