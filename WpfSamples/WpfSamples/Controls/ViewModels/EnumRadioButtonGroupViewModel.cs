namespace WpfSamples.Controls.ViewModels
{
    using System;
    using System.Collections.ObjectModel;
    using System.Windows.Controls;

    using Largeniu.DoNetCommon.Helpers;

    using WpfCommon.ModelBase;

    /// <summary>
    /// The enum radio button view model.
    /// </summary>
    /// <typeparam name="T">
    /// Enum Type
    /// </typeparam>
    public class EnumRadioButtonGroupViewModel<T> : ViewModelBase
        where T : struct
    {
        /// <summary>
        ///     The _enum radio button view model list.
        /// </summary>
        private ObservableCollection<EnumRadioButtonViewModel<T>> _enumRadioButtonViewModelList =
            new ObservableCollection<EnumRadioButtonViewModel<T>>();

        /// <summary>
        ///     Gets or sets the enum radio button view model list.
        /// </summary>
        public ObservableCollection<EnumRadioButtonViewModel<T>> EnumRadioButtonViewModelList
        {
            get
            {
                return this._enumRadioButtonViewModelList;
            }

            set
            {
                this._enumRadioButtonViewModelList = value;
                this.NotifyPropertyChanged();
            }
        }

        /// <summary>
        ///     The _selected value.
        /// </summary>
        private T _selectedValue;

        /// <summary>
        ///     Gets or sets the selected value.
        /// </summary>
        public T SelectedValue
        {
            get
            {
                return this._selectedValue;
            }

            set
            {
                this._selectedValue = value;
                this.NotifyPropertyChanged();
            }
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="EnumRadioButtonGroupViewModel{T}" /> class.
        /// </summary>
        public EnumRadioButtonGroupViewModel()
        {
            var enumArray = EnumHelper.ConvertEnumToArray<T>();
            foreach (T enumValue in enumArray)
            {
                EnumRadioButtonViewModel<T> button = new EnumRadioButtonViewModel<T>(enumValue);
                this.EnumRadioButtonViewModelList.Add(button);
            }
        }

        /// <summary>
        /// Gets the select item changed.
        /// </summary>
        public RelayCommand SelectItemChanged
        {
            get
            {
                Action<object> action = obj =>
                    {
                        T enumValue = (T)obj;
                        this.SelectedValue = enumValue;
                    };

                return new RelayCommand(action);
            }
        }
    }

    /// <summary>
    /// The enum radio button view model.
    /// </summary>
    /// <typeparam name="T">
    /// Enum Type
    /// </typeparam>
    public class EnumRadioButtonViewModel<T> : ViewModelBase
        where T : struct
    {
        /// <summary>
        ///     The _enum value.
        /// </summary>
        private T _enumValue;

        /// <summary>
        ///     The _display text.
        /// </summary>
        private string _displayText = string.Empty;

        /// <summary>
        ///     The _is checked.
        /// </summary>
        private bool _isChecked;

        /// <summary>
        ///     Gets or sets a value indicating whether is checked.
        /// </summary>
        public bool IsChecked
        {
            get
            {
                return this._isChecked;
            }

            set
            {
                this._isChecked = value;
                this.NotifyPropertyChanged();
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EnumRadioButtonViewModel{T}"/> class.
        /// </summary>
        /// <param name="enumValue">
        /// The enum value.
        /// </param>
        public EnumRadioButtonViewModel(T enumValue)
        {
            this.EnumValue = enumValue;
            this.DisplayText = EnumHelper.GetEnumDescription(enumValue);
        }

        /// <summary>
        ///     Gets or sets the enum value.
        /// </summary>
        public T EnumValue
        {
            get
            {
                return this._enumValue;
            }

            set
            {
                this._enumValue = value;
                this.NotifyPropertyChanged();
            }
        }

        /// <summary>
        ///     Gets or sets the display text.
        /// </summary>
        public string DisplayText
        {
            get
            {
                return this._displayText;
            }

            set
            {
                this._displayText = value;
                this.NotifyPropertyChanged();
            }
        }
    }

    public class DesignTimeEnumRadioButtonGroupViewModel : EnumRadioButtonGroupViewModel<DummyData.DebugDummyData.DummyEnum>
    {
        public DesignTimeEnumRadioButtonGroupViewModel()
        {
        }
    }
}