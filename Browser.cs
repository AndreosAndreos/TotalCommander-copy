using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TotalCommander
{
    public partial class Browser : UserControl
    {

        public Browser()
        {
            InitializeComponent();
        }
        private String lastdir = "";
        private String currdir = "";

        private void Browser_Load(object sender, EventArgs e)
        {
            DriveInfo[] d = System.IO.DriveInfo.GetDrives();
            foreach (DriveInfo d2 in d)
            {
                cdrivers.Items.Add(d2.Name);
            }
        }
        public String selected()
        {
            if((String)lbrowser.SelectedItem == null)
            {
                return "-1";
            }
            return (String)lbrowser.SelectedItem;
        }
        public String current()
        {
            if (currdir == "")
            {
                return "-1";
            }
            return currdir;
        }
        public void odswiez()
        {
            String path = currdir;
            if (path != "")
            {
                lbrowser.Items.Clear();

                lbrowser.Items.Add("...");
                String[] dirs = System.IO.Directory.GetDirectories(path);
                foreach (String dir in dirs)
                {
                    lbrowser.Items.Add(dir);
                }
                String[] files = System.IO.Directory.GetFiles(path);
                foreach (String file in files)
                {
                    lbrowser.Items.Add(file);
                }
            }
        }

        private void cdrivers_SelectedIndexChanged(object sender, EventArgs e)
        {
            String path = cdrivers.SelectedItem.ToString();

            lbrowser.Items.Clear();
            String[] dirs = System.IO.Directory.GetDirectories(path);
            foreach (String dir in dirs)
            {
                lbrowser.Items.Add(dir);
            }
            String[] files = System.IO.Directory.GetFiles(path);
            foreach (String file in files)
            {
                lbrowser.Items.Add(file);
            }
            currdir = path;
            currentdir.Text = "dir: "+currdir;
            lastdir = path;
            DriveInfo[] alldreives = System.IO.DriveInfo.GetDrives();
            foreach(DriveInfo d in alldreives)
            {
                if (d.Name.Equals(path))
                {
                    dysk.Text = "Miejsce na dysku: " + d.TotalFreeSpace + " / " + d.TotalSize+ " B";
                }
            }

        }

        private void lbrowser_DoubleClick(object sender, EventArgs e)
        {
            if ((String)lbrowser.SelectedItem != null) 
            {
                if (lbrowser.SelectedItem.ToString() == "...")
                {
                    String path = lastdir;
                    if (path == "C:" || path == "E:")
                    {
                        path = cdrivers.SelectedItem.ToString();
                    }
                    try
                    {
                        String[] dirs = System.IO.Directory.GetDirectories(path);
                        lbrowser.Items.Clear();
                        lbrowser.Items.Add("...");
                        foreach (String dir in dirs)
                        {
                            lbrowser.Items.Add(dir);
                        }
                        String[] files = System.IO.Directory.GetFiles(path);
                        foreach (String file in files)
                        {
                            lbrowser.Items.Add(file);
                        }
                        if (path == "C:" || path == "E:")
                        {
                            lastdir = cdrivers.SelectedItem.ToString();
                            currdir = cdrivers.SelectedItem.ToString();
                            currentdir.Text = "dir: " + currdir;
                        }
                        else
                        {
                            try
                            {
                                lastdir = lastdir.Remove(lastdir.LastIndexOf("\\"));
                                currdir = path;
                                currentdir.Text = "dir: " + currdir;

                            }
                            catch
                            {
                                lastdir = cdrivers.SelectedItem.ToString();
                                currdir = cdrivers.SelectedItem.ToString();
                                currentdir.Text = "dir: " + currdir;
                            }
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("nie mozna otworzyc pliku\n" + ex.Message);
                    }
                }else if (lbrowser.SelectedItem.ToString().EndsWith(".txt"))
                {
                    String path = lbrowser.SelectedItem.ToString();
                    Form2 f2 = new Form2(path);
                    f2.ShowDialog();
                }
                else
                {
                    String path = lbrowser.SelectedItem.ToString();

                    try
                    {
                        String[] dirs = System.IO.Directory.GetDirectories(path);
                        lbrowser.Items.Clear();
                        lbrowser.Items.Add("...");
                        foreach (String dir in dirs)
                        {
                            lbrowser.Items.Add(dir);
                        }
                        String[] files = System.IO.Directory.GetFiles(path);
                        foreach (String file in files)
                        {
                            lbrowser.Items.Add(file);
                        }
                        lastdir = currdir;
                        currdir = path;
                        currentdir.Text = "dir: " + currdir;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("nie mozna otworzyc pliku\n" + ex.Message);
                    }
                }
            }
        }
    }
}
