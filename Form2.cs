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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public Form2(String path)
        {
            InitializeComponent();
            TextReader reader = File.OpenText(path);
            richTextBox1.Text = reader.ReadToEnd();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }


        private void richTextBox1_ContentsResized(object sender, ContentsResizedEventArgs e)
        {
            var richTextBox = (RichTextBox)sender;
            richTextBox.Width = e.NewRectangle.Width;
            richTextBox.Height = e.NewRectangle.Height;
        }
    }
}
