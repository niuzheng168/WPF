namespace WpfCommon.Model
{
    using System;
    using System.ComponentModel;
    using System.Linq.Expressions;
    using System.Runtime.CompilerServices;

    /// <summary>
    /// The property changed base extension.
    /// </summary>
    public static class PropertyChangedBaseExtension
    {
        #region Public Methods and Operators

        /// <summary>
        /// The notify property changed.
        /// </summary>
        /// <param name="propertyChangedBase">
        /// The property changed base.
        /// </param>
        /// <param name="expression">
        /// The expression.
        /// </param>
        /// <typeparam name="T">
        /// The Type.
        /// </typeparam>
        /// <typeparam name="TProperty">
        /// The Property.
        /// </typeparam>
        /// <exception cref="NotImplementedException">
        /// </exception>
        public static void NotifyPropertyChanged<T, TProperty>(
            this T propertyChangedBase, 
            Expression<Func<T, TProperty>> expression)
            where T : ViewModelBase
        {
            var memberExpression = expression.Body as MemberExpression;
            if (memberExpression != null)
            {
                string propertyName = memberExpression.Member.Name;
                propertyChangedBase.NotifyPropertyChanged(propertyName);
            }
            else
            {
                throw new NotImplementedException();
            }
        }

        #endregion
    }

    /// <summary>
    /// The view model base.
    /// </summary>
    public abstract class ViewModelBase : INotifyPropertyChanged
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
