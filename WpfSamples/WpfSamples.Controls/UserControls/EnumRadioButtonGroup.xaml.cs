namespace WpfSamples.Controls.UserControls
{
    using System.Windows;
    using System.Windows.Controls;

    using WpfCommon.ModelBase;
    using WpfCommon.ViewBase;

    /// <summary>
    ///     Interaction logic for EnumRadioButtonGroup.xaml
    /// </summary>
    public partial class EnumRadioButtonGroup : UserControl, IView
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EnumRadioButtonGroup"/> class.
        /// </summary>
        public EnumRadioButtonGroup()
        {
            this.InitializeComponent();
        }

        public Orientation ButtonListOrientation 
        {
            get { return (Orientation)GetValue(ButtonListOrientationProperty); }
            set { SetValue(ButtonListOrientationProperty, value); }
        }

        public static readonly DependencyProperty ButtonListOrientationProperty =
            DependencyProperty.Register("ButtonListOrientation", typeof(Orientation), typeof(EnumRadioButtonGroup), new PropertyMetadata((System.Windows.Controls.Orientation)(Orientation.Horizontal)));

        public ViewModelBase ViewModel { get; set; }
    }
}