using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Emlak.Helper
{
    public static class ExtensionMethods
    {
        public static void DoubleBuffered(this DataGridView dataGridView, bool setting)
        {
            Type dgType = dataGridView.GetType();
            PropertyInfo pi = dgType.GetProperty("DoubleBuffered",
                BindingFlags.Instance | BindingFlags.NonPublic);
            pi.SetValue(dataGridView, setting, null);
        }
    }
}
