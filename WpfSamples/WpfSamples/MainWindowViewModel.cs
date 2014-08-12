namespace WpfSamples
{
    using WpfCommon.ModelBase;

    using WpfSamples.Controls.UserControls;
    using WpfSamples.Controls.ViewModels;
    using WpfSamples.DummyData;

    /// <summary>
    /// The main window view model.
    /// </summary>
    public class MainWindowViewModel : ViewModelBase
    {
        private EnumRadioButtonGroupViewModel<DebugDummyData.DummyEnum> dummy=new EnumRadioButtonGroupViewModel<DebugDummyData.DummyEnum>();

        public EnumRadioButtonGroupViewModel<DebugDummyData.DummyEnum> Dummy
        {
            get
            {
                return this.dummy;
            }
            set
            {
                this.dummy = value;
                this.NotifyPropertyChanged();
            }
        }
    }
}