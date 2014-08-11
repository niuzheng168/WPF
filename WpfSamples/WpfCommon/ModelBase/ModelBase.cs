namespace WpfCommon.ModelBase
{
    using System.ComponentModel;
    using System.Runtime.CompilerServices;

    /// <summary>
    /// The model base.
    /// </summary>
    public abstract class ModelBase : INotifyPropertyChanged
    {
        #region Public Events

        /// <summary>
        /// Property change event.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        #endregion

        #region Public Methods and Operators

        /// <summary>
        /// The notify property changed.
        /// </summary>
        /// <param name="propertyName">
        /// The property name.
        /// </param>
        public void NotifyPropertyChanged([CallerMemberName] string propertyName = null)
        {
            if (this.PropertyChanged != null)
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        #endregion
    }
}
