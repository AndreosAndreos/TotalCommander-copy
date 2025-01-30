using System.Diagnostics;

namespace TotalCommander
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void browser2_Load(object sender, EventArgs e)
        {

        }

        private void lkopiuj_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Name == lkopiuj.Name)
            {
                try
                {
                    String source = browser1.selected();
                    String destination = browser2.current();
                    if (source == "-1" || destination == "-1")
                    {
                        throw new Exception("Brak wybranego pliku");
                    }
                    else
                    {
                        String name = browser1.selected();
                        name = name.Substring(name.LastIndexOf("\\"));
                        destination += name;
                        File.Copy(source, destination, true);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Błąd kopiowania\n" + ex.Message);
                }
            }
            else
            {
                try
                {
                    String source = browser2.selected();
                    String destination = browser1.current();
                    if (source == "-1" || destination == "-1")
                    {
                        throw new Exception("Brak wybranego pliku");
                    }
                    else
                    {
                        String name = browser2.selected();
                        name = name.Substring(name.LastIndexOf("\\"));
                        destination += name;
                        File.Copy(source, destination, true);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Błąd kopiowania\n" + ex.Message);
                }
            }
            browser1.odswiez();
            browser2.odswiez();
        }

        private void lprzenies_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Name == lprzenies.Name)
            {
                try
                {
                    String source = browser1.selected();
                    String destination = browser2.current();
                    if (source == "-1" || destination == "-1")
                    {
                        throw new Exception("Brak wybranego pliku");
                    }
                    else
                    {
                        String name = browser1.selected();
                        name = name.Substring(name.LastIndexOf("\\"));
                        destination += name;
                        File.Move(source, destination);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Błąd przenoszenia\n" + ex.Message);
                }
            }
            else
            {
                try
                {
                    String source = browser2.selected();
                    String destination = browser1.current();
                    if (source == "-1" || destination == "-1")
                    {
                        throw new Exception("Brak wybranego pliku");
                    }
                    else
                    {
                        String name = browser2.selected();
                        name = name.Substring(name.LastIndexOf("\\"));
                        destination += name;
                        File.Move(source, destination);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Błąd przenoszenia\n" + ex.Message);
                }
            }
            browser1.odswiez();
            browser2.odswiez();
        }

        private void lusun_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Name == lusun.Name)
            {
                try
                {
                    String source = browser1.selected();
                    if (source == "-1")
                    {
                        throw new Exception("Brak wybranego katalogu");
                    }
                    else
                    {
                        Directory.Delete(source);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Błąd usuwania\n" + ex.Message);
                }
            }
            else
            {
                try
                {
                    String source = browser2.selected();
                    if (source == "-1")
                    {
                        throw new Exception("Brak wybranego katalogu");
                    }
                    else
                    {
                        Directory.Delete(source);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Błąd usuwania\n" + ex.Message);
                }
            }
            browser1.odswiez();
            browser2.odswiez();
        }

        private void lzmien_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Name == lzmien.Name)
            {
                try
                {
                    String source = browser1.selected();
                    if (source == "-1")
                    {
                        throw new Exception("Brak wybranego pliku");
                    }
                    else
                    {
                        String destination = source.Remove(source.LastIndexOf("\\") + 1);
                        destination += zmienNazweBox.Text;
                        if (File.Exists(destination))
                        {
                            MessageBox.Show("Plik o takiej nazwie istnieje");
                        }
                        else
                            File.Move(source, destination);
                    }
                }
                catch (Exception ex)
                {
                }
                try
                {
                    String source = browser1.selected();
                    if (source == "-1")
                    {
                        throw new Exception("Brak wybranego katalogu");
                    }
                    else
                    {
                        String destination = source.Remove(source.LastIndexOf("\\") + 1);
                        destination += zmienNazweBox.Text;
                        if (Directory.Exists(destination))
                        {
                            MessageBox.Show("Katalog o takiej nazwie istnieje");
                        }
                        else
                            Directory.Move(source, destination);
                    }
                }
                catch (Exception ex)
                {
                }
            }
            else
            {
                try
                {
                    String source = browser2.selected();
                    if (source == "-1")
                    {
                        throw new Exception("Brak wybranego pliku");
                    }
                    else
                    {
                        String destination = source.Remove(source.LastIndexOf("\\") + 1);
                        destination += zmienNazweBox.Text;
                        if (File.Exists(destination))
                        {
                            MessageBox.Show("Plik o takiej nazwie istnieje");
                        }
                        else
                            File.Move(source, destination);
                    }
                }
                catch (Exception ex)
                {
                }
                try
                {
                    String source = browser2.selected();
                    if (source == "-1")
                    {
                        throw new Exception("Brak wybranego katalogu");
                    }
                    else
                    {
                        String destination = source.Remove(source.LastIndexOf("\\") + 1);
                        destination += zmienNazweBox.Text;
                        if (Directory.Exists(destination))
                        {
                            MessageBox.Show("Katalog o takiej nazwie istnieje");
                        }
                        else
                            Directory.Move(source, destination);
                    }
                }
                catch (Exception ex)
                {
                }
            }
            browser1.odswiez();
            browser2.odswiez();
        }

        private void latrybuty_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Name == latrybuty.Name)
            {
                try
                {
                    String source = browser1.selected();
                    if (source == "-1")
                    {
                        throw new Exception("Brak wybranego pliku");
                    }
                    else
                    {
                        FileAttributes atrybuty = File.GetAttributes(source);
                        String wiadomosc = "";
                        if ((atrybuty & FileAttributes.Hidden) == FileAttributes.Hidden)
                        {
                            wiadomosc += "Hidden - tak\n";
                        }
                        else
                        {
                            wiadomosc += "Hidden - nie\n";
                        }
                        if ((atrybuty & FileAttributes.ReadOnly) == FileAttributes.ReadOnly)
                        {
                            wiadomosc += "Read only - tak\n";
                        }
                        else
                        {
                            wiadomosc += "Read only - nie\n";
                        }
                        if ((atrybuty & FileAttributes.System) == FileAttributes.System)
                        {
                            wiadomosc += "Systemowy - tak\n";
                        }
                        else
                        {
                            wiadomosc += "Systemowy - nie\n";
                        }
                        if ((atrybuty & FileAttributes.Temporary) == FileAttributes.Temporary)
                        {
                            wiadomosc += "Tymczasowy - tak\n";
                        }
                        else
                        {
                            wiadomosc += "Tymczasowy - nie\n";
                        }
                        if ((atrybuty & FileAttributes.Encrypted) == FileAttributes.Encrypted)
                        {
                            wiadomosc += "Szyfrowany - tak\n";
                        }
                        else
                        {
                            wiadomosc += "Szyfrowany - nie\n";
                        }
                        MessageBox.Show(wiadomosc);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Błąd wyświetlenia atrybutów\n" + ex.Message);
                }
            }
            else
            {
                try
                {
                    String source = browser2.selected();
                    if (source == "-1")
                    {
                        throw new Exception("Brak wybranego pliku");
                    }
                    else
                    {
                        FileAttributes atrybuty = File.GetAttributes(source);
                        String wiadomosc = "";
                        if ((atrybuty & FileAttributes.Hidden) == FileAttributes.Hidden)
                        {
                            wiadomosc += "Hidden - tak\n";
                        }
                        else
                        {
                            wiadomosc += "Hidden - nie\n";
                        }
                        if ((atrybuty & FileAttributes.ReadOnly) == FileAttributes.ReadOnly)
                        {
                            wiadomosc += "Read only - tak\n";
                        }
                        else
                        {
                            wiadomosc += "Read only - nie\n";
                        }
                        if ((atrybuty & FileAttributes.System) == FileAttributes.System)
                        {
                            wiadomosc += "Systemowy - tak\n";
                        }
                        else
                        {
                            wiadomosc += "Systemowy - nie\n";
                        }
                        if ((atrybuty & FileAttributes.Temporary) == FileAttributes.Temporary)
                        {
                            wiadomosc += "Tymczasowy - tak\n";
                        }
                        else
                        {
                            wiadomosc += "Tymczasowy - nie\n";
                        }
                        if ((atrybuty & FileAttributes.Encrypted) == FileAttributes.Encrypted)
                        {
                            wiadomosc += "Szyfrowany - tak\n";
                        }
                        else
                        {
                            wiadomosc += "Szyfrowany - nie\n";
                        }
                        MessageBox.Show(wiadomosc);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Błąd wyświetlenia atrybutów\n" + ex.Message);
                }
            }
        }

        private void ldodajkatalog_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Name == ldodajkatalog.Name) 
            {
                try
                {
                    String path = browser1.current() + "\\" + lkatalognazwa.Text;
                    if(!Directory.Exists(path))
                    {
                        Directory.CreateDirectory(path);
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Błąd tworzenia katalogu\n" + ex.Message);
                }
            }
            else
            {
                try
                {
                    String path = browser2.current()+"\\"+pkatalognazwa.Text;
                    if (!Directory.Exists(path))
                    {
                        Directory.CreateDirectory(path);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Błąd tworzenia katalogu\n" + ex.Message);
                }
            }
            browser1.odswiez();
            browser2.odswiez();
        }
    }
}