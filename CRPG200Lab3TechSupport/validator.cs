using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRPG200Lab3TechSupport

{
    /// <summary>
    /// a repository of user input validation methods for Windows Forms projects
    /// </summary>
    public static class validator
    {
        /// <summary>
        /// validates if text box is not empty
        /// </summary>
        /// <param name="tb"> text bos to validate </param>
        /// <returns> true if not empty and false if empty </returns>
        public static bool IsPresent(TextBox tb)
        {
            bool isValid = true;
            if (tb.Text == "") // empty
            {
                isValid = false;
                MessageBox.Show(tb.Tag + " is required");
                tb.Focus();
            }
            return isValid;
        }

        /// <summary>
        /// validates if text box contains non-negative int value
        /// </summary>
        /// <param name="tb">text box</param>
        /// <returns>true if valid and false if not</returns>
        public static bool IsNonNegativeInt(TextBox tb)
        {
            bool isValid = true;
            int result; // for TryParse
            if (!Int32.TryParse(tb.Text, out result)) //  TryParse returned false
            {
                isValid = false;
                MessageBox.Show(tb.Tag + " must be a whole number");
                tb.SelectAll(); // select all content for replacement
                tb.Focus();
            }
            else // it's an int, but could be negative
            {
                if (result < 0)
                {
                    isValid = false;
                    MessageBox.Show(tb.Tag + " must be positive or zero");
                    tb.SelectAll();
                    tb.Focus();
                }
            }
            return isValid;
        }

        /// <summary>
        /// validates if text box contains non-negative decimal value
        /// </summary>
        /// <param name="tb">text box</param>
        /// <returns>true if valid and false if not</returns>
        public static bool IsNonNegativeDecimal(TextBox tb)
        {
            bool isValid = true;
            decimal result; // for TryParse
            if (!Decimal.TryParse(tb.Text, out result)) //  TryParse returned false
            {
                isValid = false;
                MessageBox.Show(tb.Tag + " must be a number");
                tb.SelectAll(); // select all content for replacement
                tb.Focus();
            }
            else // it's decimal, but could be negative
            {
                if (result < 0)
                {
                    isValid = false;
                    MessageBox.Show(tb.Tag + " must be positive or zero");
                    tb.SelectAll();
                    tb.Focus();
                }
            }
            return isValid;
        }
        /// <summary>
        /// validates if text box contains non-negative decimal value
        /// </summary>
        /// <param name="tb">text box</param>
        /// <returns>true if valid and false if not</returns>
        public static bool IsDoubleInRange(TextBox tb, double minValue, double maxValue)
        {
            bool isValid = true;
            double result; // for TryParse
            if (!Double.TryParse(tb.Text, out result)) //  TryParse returned false
            {
                isValid = false;
                MessageBox.Show(tb.Tag + " must be a number");
                tb.SelectAll(); // select all content for replacement
                tb.Focus();
            }
            else // it's double, but could be negative
            {
                if (result < minValue || result > maxValue)
                {
                    isValid = false;
                    MessageBox.Show($"{tb.Tag} must be between {minValue} and {maxValue}");
                    tb.SelectAll();
                    tb.Focus();
                }
            }
            return isValid;
        }

        /// <summary>
        /// validates if text box contains decimal within range
        /// </summary>
        /// <param name="tb">text box</param>
        /// <returns>true if valid and false if not</returns>
        public static bool IsDecimalInRange(TextBox tb, decimal minValue, decimal maxValue)
        {
            bool isValid = true;
            decimal result; // for TryParse
            if (!decimal.TryParse(tb.Text, out result)) //  TryParse returned false
            {
                isValid = false;
                MessageBox.Show(tb.Tag + " must be a number");
                tb.SelectAll(); // select all content for replacement
                tb.Focus();
            }
            else // it's decimal, check the range
            {
                if (result < minValue || result > maxValue)
                {
                    isValid = false;
                    MessageBox.Show($"{tb.Tag} must be between {minValue} and {maxValue}");
                    tb.SelectAll();
                    tb.Focus();
                }
            }
            return isValid;
        }

        /// <summary>
        /// validates that text box contains valid date
        /// </summary>
        /// <param name="tb">text box</param>
        /// <returns>true if valid and false if not</returns>
        public static bool IsValidDate(TextBox tb)
        {
            bool isValid = true;
            DateTime tempDate;
            if (!DateTime.TryParse(tb.Text, out tempDate))
            {
                isValid = false;
                MessageBox.Show(tb.Tag + " must be a valid date");
                tb.SelectAll();
                tb.Focus();
            }
            return isValid;
        }
    }
}
