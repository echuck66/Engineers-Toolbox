using CommunityToolkit.Mvvm.Input;
using EngineersToolbox.Views;
using System.Diagnostics;

namespace EngineersToolbox.ViewModels
{
    public partial class SettingsViewModel : ToolboxBaseViewModel
    {
        //private DistanceConverter _converter;

        public SettingsViewModel()
        {
            //_converter = new DistanceConverter();
            Title = "Estimations";
            Bind();
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
