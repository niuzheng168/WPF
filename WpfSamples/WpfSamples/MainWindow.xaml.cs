﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MainWindow.xaml.cs" company="">
//   
// </copyright>
// <summary>
//   Interaction logic for MainWindow.xaml
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace WpfSamples
{
    using System.Windows;

    using WpfCommon.ModelBase;

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="MainWindow"/> class.
        /// </summary>
        public MainWindow()
        {
            this.InitializeComponent();

            DemoViewModel m  = new DemoViewModel();
            m.A = 3;

        }

        #endregion
    }

    /// <summary>
    /// The demo view model.
    /// </summary>
    public class DemoViewModel : ModelBase
    {
        #region Fields

        /// <summary>
        /// The _a.
        /// </summary>
        private int _a = -1;

        #endregion

        #region Public Properties

        /// <summary>
        /// Gets or sets the a.
        /// </summary>
        public int A
        {
            get
            {
                return this._a;
            }

            set
            {
                this._a = value;
                this.NotifyPropertyChanged(p => p.A);
            }
        }

        #endregion
    }
}
