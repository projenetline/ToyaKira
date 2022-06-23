using DevExpress.XtraEditors;
using Rent.Core.Concrete.Helpers;
using Rent.Core.Concrete.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rent.WinUI.Concrete.Helpers
{
    public class MessageHelper
    {
        public static bool QuestionMessage(string cCaption, string cMsg)
        {
            return XtraMessageBox.Show(cMsg, cCaption, MessageBoxButtons.YesNo) == DialogResult.Yes;
        }
        public static bool DeleteQuestionMessage
        {
            get
            {
                return XtraMessageBox.Show(AppStrings.DeleteContinue, AppStrings.DeleteRecordWarning, MessageBoxButtons.YesNo) == DialogResult.Yes;
            }
        }
        public static bool DeleteRowQuestionMessage
        {
            get
            {
                return XtraMessageBox.Show(AppStrings.DeleteContinue, AppStrings.DeleteRows, MessageBoxButtons.YesNo) == DialogResult.Yes;
            }
        }
        public static void StringMessage(string caption, string msg)
        {
            XtraMessageBox.Show(msg, caption);
        }
        public static void SuccessfulSaveMessage()
        {
            XtraMessageBox.Show(AppStrings.SuccessfulSaveMessage, AppStrings.Warning);
        }
        public static void DuplicateDataWarning()
        {
            XtraMessageBox.Show(AppStrings.DuplicateDataMessage, AppStrings.Warning);
        }
        public static void ExeptionMessage(Exception ex)
        {
            XtraMessageBox.Show(MsgExceptionDetailHelper.Details(ex), AppStrings.Error);
        }
    }
}
