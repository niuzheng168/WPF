namespace WpfSamples
{
    using WpfCommon.ModelBase;

    using WpfSamples.Controls.ViewModels;
    using WpfSamples.DummyData;

    /// <summary>
    ///     The main window view model.
    /// </summary>
    public class MainWindowViewModel : ViewModelBase
    {
        /// <summary>
        /// The dummy.
        /// </summary>
        private EnumRadioButtonGroupViewModel<DebugDummyData.DummyEnum> dummy =
            new EnumRadioButtonGroupViewModel<DebugDummyData.DummyEnum>();

        /// <summary>
        /// Gets or sets the dummy.
        /// </summary>
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