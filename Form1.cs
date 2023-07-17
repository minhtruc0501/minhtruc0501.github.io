using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex3
{

    

    public partial class Form1 : Form
    {
        string path=@"D:\form.xml";
        public Form1()
        {
            InitializeComponent();
        }
        public void Write(InfoWindows iw){
            XmlSerializer writer = new XmlSerializer(typeof(InfoWindows));
            StreamWriter file = new StreamWriter(path);
            writer.Serialize(file,iw);
            file.Close();}

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_ResizeEnd(object sender, EventArgs e)
        {

        }
    }
string path=@"D:\form.xml";

public void Write(InfoWindows iw){
    XmlSerializer writer = new XmlSerializer(typeof(InfoWindows));
    StreamWriter file = new StreamWriter(path);
    writer.Serialize(file,iw);
    file.Close();
    }
}
