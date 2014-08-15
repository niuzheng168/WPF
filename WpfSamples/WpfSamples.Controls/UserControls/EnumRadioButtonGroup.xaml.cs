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
        ///     Initializes a new instance of the <see cref="EnumRadioButtonGroup" /> class.
        /// </summary>
        public EnumRadioButtonGroup()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Gets or sets the button list orientation.
        /// </summary>
        public Orientation ButtonListOrientation
        {
            get
            {
                return (Orientation)this.GetValue(ButtonListOrientationProperty);
            }

            set
            {
                this.SetValue(ButtonListOrientationProperty, value);
            }
        }

        /// <summary>
        /// The button list orientation property.
        /// </summary>
        public static readonly DependencyProperty ButtonListOrientationProperty =
            DependencyProperty.Register(
                "ButtonListOrientation", 
                typeof(Orientation), 
                typeof(EnumRadioButtonGroup), 
                new PropertyMetadata(Orientation.Horizontal));

        /// <summary>
        /// Gets or sets the view model.
        /// </summary>
        public ViewModelBase ViewModel { get; set; }
    }
}