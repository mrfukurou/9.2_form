using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;


namespace WindowsFormsApp22
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
			try
			{
				string fileName = Convert.ToString(wayout.Text);
				string fileName1 = Convert.ToString(wayin.Text);
				StreamReader fileIn = new StreamReader(fileName);
				string text = fileIn.ReadToEnd();
				alltxt.Text += text;
				fileIn.Close();
				using (StreamReader sr = new StreamReader(fileName, System.Text.Encoding.Default))
				{
					if (!String.IsNullOrWhiteSpace(fileName1))
					{
						string line;
						while ((line = sr.ReadLine()) != null)
						{
							rez.Items.Add( line + " - " + line.Length + "\n");
							FileStream aFile = new FileStream(fileName1, FileMode.OpenOrCreate);
							StreamWriter sw = new StreamWriter(aFile);
							aFile.Seek(0, SeekOrigin.End);
							sw.WriteLine(line + " - " + line.Length);
							sw.Close();
						}
					}

					else { throw new Exception(); }
				}
			}

			catch { rez.Items.Add ("Некорректный ввод!"); }

		}

		private void button2_Click(object sender, EventArgs e)
		{
			wayin.Clear();
			wayout.Clear();
			alltxt.Clear();
			rez.Items.Clear();
		}
	}
}
