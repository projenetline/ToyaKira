using System;

namespace Rent.WinUI.RentControls
{
    public class DateEditFormatter : IFormatProvider, ICustomFormatter
    {
        public object GetFormat(Type formatType)
        {
            if (formatType == typeof(ICustomFormatter))
                return this;
            else
                return null;
        }

        //private bool IsNewValueValid(object value)
        //{
        //    try
        //    {
        //        DateTime date = DateTime.Parse(value.ToString());
        //        DateTime defaultDate = new DateTime(2000, 01, 01);
        //        if (DateTime.Compare(date, defaultDate) != 0)
        //            return true;
        //        else
        //            return false;
        //    }
        //    catch
        //    {
        //        return false;
        //    }
        //}
        private bool IsNewValueValid(object value)
        {
            try
            {
                bool result = false;
                DateTime date = DateTime.Parse(value.ToString());
                DateTime minDate = new DateTime(1999, 12, 31);
                DateTime maxDate = new DateTime(2100, 12, 31);
                //minumun value-1 ise yanlış tarihtir.
                int minumumValue = DateTime.Compare(date, minDate);
                int maxValue = DateTime.Compare(date, maxDate);
                if (minumumValue == -1 || maxValue == 1)
                {
                    result = false;
                }
                else
                {
                    result = true;
                }

                return result;
            }
            catch
            {
                return false;
            }
        }
        public string Format(string format, object arg, IFormatProvider formatProvider)
        {
            // Check whether this is an appropriate callback   
            if (!this.Equals(formatProvider))
                return null;
            if (!IsNewValueValid(arg))
            {
                return "01.01.2000";
            }
            else
            {
                DateTime date = DateTime.Parse(arg.ToString());
                return date.ToString(format);
            }
        }
    }
}
