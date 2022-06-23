using DevExpress.XtraEditors;
using Rent.Core.Concrete.Resources;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Rent.WinUI.Concrete.Helpers
{
    class NetlineAppHelper
    {
        public static DateTime GetDefaultDateTime { get { return Convert.ToDateTime("01.01.2020").Date; } }
        public static void StartProcess(string processName)
        {
            try
            {
                Process.Start(processName);
            }
            catch (Exception ex)
            {

                XtraMessageBox.Show(ex.Message, AppStrings.Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static void SetFormContainerSize(Form form, Control control)
        {
            form.StartPosition = FormStartPosition.Manual;
            form.Size = control.Size;
            var findForm = control.FindForm();
            if (findForm != null) form.Location = findForm.PointToScreen(control.Location);
        }
        public static void ShowFormDialog(Form form, Form parent)
        {
            try
            {
                parent.Enabled = false;
                form.ShowDialog(parent);
            }
            finally
            {
                parent.Enabled = true;
            }
        }
        public static void OpenExportedFile(string fileName)
        {
            if (
                XtraMessageBox.Show(AppStrings.ExportFileOpen, AppStrings.ExportData, MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) != DialogResult.Yes) return;
            var process = new Process();
            try
            {
                process.StartInfo.FileName = fileName;
                process.Start();
            }
            catch { }
        }
        public static void ShowExportErrorMessage()
        {
            XtraMessageBox.Show(AppStrings.Error, AppStrings.ExportData, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static string GetPossibleFileName(string name) { return name.Replace("/", ""); }
        public static string GetFileName(string extension, string filter) { return GetFileName(extension, filter, string.Empty); }
        public static string GetFileName(string extension, string filter, string fileName)
        {
            using (var dialog = new SaveFileDialog())
            {
                dialog.Filter = filter;
                dialog.FileName = fileName;
                dialog.DefaultExt = extension;
                if (dialog.ShowDialog() == DialogResult.OK)
                    return dialog.FileName;
            }
            return String.Empty;
        }
    }
}
