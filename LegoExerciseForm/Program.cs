using System;
using System.Windows.Forms;
using LegoExerciseForm.Cache;
using LegoExerciseForm.Database;

namespace LegoExerciseForm
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            DatabaseLego db = new DatabaseLego();
            CacheLego cacheLego = new CacheLego(db.GetAllVendors(), db.GetAllMaterials());
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1(cacheLego));
        }
    }
}
