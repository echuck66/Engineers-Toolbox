
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using EngineersToolbox.Services.Converters;
using EngineersToolbox.Views;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngineersToolbox.ViewModels
{
    public partial class Base64ConverterViewModel : ToolboxBaseViewModel
    {
        private Base64Converter _converter;

        public Base64ConverterViewModel()
        {
            _converter = new Base64Converter();
            Title = "Distance Converter";
            Bind();
        }

        [ObservableProperty]
        private string value;
        [ObservableProperty]
        private string hashedValue;

        [RelayCommand]
        public async Task HashValue()
        {
            if (IsBusy)
                return;
            IsBusy = true;

            try
            {
                if (!string.IsNullOrEmpty(Value))
                {
                    var hashedObj = _converter.HashValue(Value);
                    HashedValue = hashedObj?.HashedValue;
                }
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
        public async Task DeHashValue()
        {
            if (IsBusy)
                return;
            IsBusy = true;

            try
            {
                if (!string.IsNullOrEmpty(HashedValue))
                {
                    var deHashedObj = _converter.GetValue(HashedValue);
                    Value = deHashedObj?.Value;
                }
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
