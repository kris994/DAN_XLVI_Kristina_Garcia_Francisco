﻿using DAN_XLIII_Kristina_Garcia_Francisco.Helper;
using DAN_XLIII_Kristina_Garcia_Francisco.ViewModel;
using System;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Input;

namespace DAN_XLIII_Kristina_Garcia_Francisco.View
{
    /// <summary>
    /// Interaction logic for AddManager.xaml
    /// </summary>
    public partial class AddManager : Window
    {
        /// <summary>
        /// Add manager
        /// </summary>
        public AddManager()
        {
            InitializeComponent();
            this.DataContext = new AddManagerViewModel(this);
        }

        /// <summary>
        /// User can only imput numbers
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }


        /// <summary>
        /// Calcualtes the birth date and places it in the textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            InputCalculator iv = new InputCalculator();
            string text = "";
            if (txtJMBG.Text.Length >= 7)
            {
                text = iv.CountDateOfBirth(txtJMBG.Text).ToString("dd.MM.yyy.");
            }
            else
            {
                text = "";
            }

            txtDateOfBirth.Text = text;
        }
    }
}
