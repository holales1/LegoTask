using LegoForm.Cache;
using LegoForm.Database;
using System;
using System.Windows.Forms;

namespace LegoForm
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            DatabaseLego db = new DatabaseLego();
            CacheLego cacheLego = new CacheLego(db.GetAllVendors(), db.GetAllMaterials());
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
