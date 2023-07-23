using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngineersToolbox.ViewModels
{
    public partial class ToolboxViewModel : BaseViewModel
    {

        [RelayCommand]
        private async Task OpenConvertersPage()
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
                //await AppShell.Alert(ex.Message);
            }
            finally
            {
                IsBusy = false;
            }
        }
    }
}
