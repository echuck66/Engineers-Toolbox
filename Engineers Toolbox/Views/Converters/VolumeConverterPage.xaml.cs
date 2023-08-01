using EngineersToolbox.ViewModels;

namespace EngineersToolbox.Views.Converters;

public partial class VolumeConverterPage : ContentPage
{

        VolumeConverterViewModel _viewModel;

        public VolumeConverterPage()
        {
            InitializeComponent();
            _viewModel = new VolumeConverterViewModel();
            BindingContext = _viewModel;
        }

        public VolumeConverterPage(VolumeConverterViewModel viewModel)
        {
            InitializeComponent();
            _viewModel = viewModel;
            BindingContext = _viewModel;
        }

}