using System.Configuration;
using System.Windows.Forms;

namespace WinFormsApp2
{
    internal static class Config
    {
        internal static string ConnectionString =>
            ConfigurationManager.ConnectionStrings["MyDbConnection"]?.ConnectionString ?? string.Empty;

        internal static bool TryGetConnectionString(out string connectionString, IWin32Window owner = null)
        {
            connectionString = ConnectionString;
            if (string.IsNullOrEmpty(connectionString))
            {
                IWin32Window wnd = owner ?? (Application.OpenForms.Count > 0 ? Application.OpenForms[0] : null);
                MessageBox.Show(wnd,
                    "Database connection string is not configured. Please check your App.config.",
                    "Configuration Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
    }
}
