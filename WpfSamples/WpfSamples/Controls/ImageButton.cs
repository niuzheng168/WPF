namespace WpfSamples.Controls
{
    using System.Windows;
    using System.Windows.Media;

    /// <summary>
    /// The image button.
    /// </summary>
    public class ImageButton
    {
        /// <summary>
        /// The image property.
        /// </summary>
        public static readonly DependencyProperty ImageProperty = DependencyProperty.RegisterAttached(
                "Image",
                typeof(ImageSource),
                typeof(ImageButton),
                new FrameworkPropertyMetadata((ImageSource)null));

        /// <summary>
        /// Gets the <see cref="ImageProperty"/> for a given
        ///     <see cref="DependencyObject"/>, which provides an
        ///     <see cref="ImageSource"/> for arbitrary WPF elements.
        /// </summary>
        /// <param name="obj">
        /// The obj.
        /// </param>
        /// <returns>
        /// The <see cref="ImageSource"/>.
        /// </returns>
        public static ImageSource GetImage(DependencyObject obj)
        {
            return (ImageSource)obj.GetValue(ImageProperty);
        }

        /// <summary>
        /// Sets the attached <see cref="ImageProperty"/> for a given
        ///     <see cref="DependencyObject"/>, which provides an
        ///     <see cref="ImageSource"/> for arbitrary WPF elements.
        /// </summary>
        /// <param name="obj">
        /// The obj.
        /// </param>
        /// <param name="value">
        /// The value.
        /// </param>
        public static void SetImage(DependencyObject obj, ImageSource value)
        {
            obj.SetValue(ImageProperty, value);
        }
    }
}