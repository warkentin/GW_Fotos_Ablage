using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace GW_Fotos_Ablage
{
    public partial class frm_main : Form
    {
        string g_path = @"C:\Temp\";
        string g_path_ziel = @"C:\Temp\Export\";

        public frm_main()
        {
            InitializeComponent();
            this.Text = this.Text + " - " + System.Security.Principal.WindowsIdentity.GetCurrent().Name + " - " + System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();
        }

        private void Btn_pfad_Click(object sender, EventArgs e)
        {            
            OpenFileDialog folderBrowser = new OpenFileDialog
            {                
                ValidateNames = false,
                CheckFileExists = false,
                CheckPathExists = true,                
                FileName = "Folder Selection."
            };
            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                g_path = Path.GetDirectoryName(folderBrowser.FileName) + @"\";
                txt_pfad.Text = g_path;
                g_path_ziel = g_path + @"Export\";
                txt_pfad_export.Text = g_path_ziel;
            }

            // Auflistung der gefundenden Verzeichnisse in der Listbox
            DirectoryInfo dirPrograms = new DirectoryInfo(g_path);            

            var dirs = from dir in dirPrograms.EnumerateDirectories()                       
                       select new
                       {
                           ProgDir = dir,
                       };

            // Listbox initialisieren
            lv_daten.Items.Clear();
            int nummer = 1;
            string[] arr = new string[4];
            ListViewItem itm;
            lv_daten.View = View.Details;
            lv_daten.GridLines = true;

            foreach (var di in dirs)
            {
                arr[0] = di.ProgDir.Name.ToString();
                arr[1] = nummer.ToString();
                arr[2] = CountFiles(g_path + @"\" + di.ProgDir.Name.ToString()).ToString();
                itm = new ListViewItem(arr);
                lv_daten.Items.Add(itm);
                nummer++;
            }

            btn_export.Enabled = true;
        }
               
        private void Btn_export_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            foreach (ListViewItem item in lv_daten.Items)
            {
                // Verzeichnis auslesen
                DirectoryInfo di = new DirectoryInfo(g_path + item.Text.ToString());

                // Dateien verschieben                
                foreach (var fi in di.GetFiles())
                {
                    string quelle = di.FullName + @"\" + fi.ToString();
                    string export = g_path_ziel;
                    string ziel = g_path_ziel + item.Text.ToString() + "_" + fi.ToString();
                    // Export-Verzeichnis anlegen
                    try
                    {
                        if (!Directory.Exists(export))
                        {
                            DirectoryInfo dii = Directory.CreateDirectory(export);
                        }
                    }
                    catch (Exception ex)
                    {
                        // Do nothing
                        MessageBox.Show(ex.ToString());
                    }
                    
                    // Datei kopieren
                    File.Copy(quelle, ziel);                    
                }                             
            }
            Cursor = Cursors.Default;
            MessageBox.Show("Done!");
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog folderBrowser = new OpenFileDialog
            {
                ValidateNames = false,
                CheckFileExists = false,
                CheckPathExists = true,
                FileName = "Folder Selection."
            };
            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                g_path_ziel = Path.GetDirectoryName(folderBrowser.FileName) + @"\Export\";                
                txt_pfad_export.Text = g_path_ziel + @"\Export\";
            }
        }

        private static int CountFiles(string path)
        {
            DirectoryInfo di = new DirectoryInfo(path);
            return di.GetFiles().Length;
        }
    }
}