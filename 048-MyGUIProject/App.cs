using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _048_MyGUIProject
{
    internal class App
    {
        public static void Main()
        {
            Application.Run(new MainForm());
        }
    }

    class MainForm : Form
    {
        private Button m_buttonOk;
        private TextBox m_textBoxName;
        private ListBox m_listBox;

        public MainForm()
        {
            Text = "Sample Window";

            m_textBoxName = new TextBox();
            m_textBoxName.Location = new System.Drawing.Point(5, 5);
            m_textBoxName.Width = 250;
            m_textBoxName.Font = new System.Drawing.Font("Times New Roman", 14);
            m_textBoxName.ForeColor = System.Drawing.Color.Red;
            m_textBoxName.Parent = this;

            m_buttonOk = new Button();
            m_buttonOk.Text = "Ok";
            m_buttonOk.Location = new Point(5, 40);
            m_buttonOk.Click += new EventHandler(buttonOkClickHandler);
            m_buttonOk.Parent = this;

            m_listBox = new ListBox();
            m_listBox.Parent = this;
            m_listBox.Location = new Point(100, 40);
            m_listBox.Width = 100;
            m_listBox.Height = 200;
            m_listBox.DoubleClick += listBoxDoubleClickHandler;

            m_listBox.Items.Add("Ali");
            m_listBox.Items.Add("Veli");
            m_listBox.Items.Add("Selami");

        }

        private void listBoxDoubleClickHandler(object sender, EventArgs e)
        {
            MessageBox.Show(m_listBox.SelectedItem.ToString());
        }
        private void buttonOkClickHandler(object o, EventArgs e)
        {
            MessageBox.Show(m_textBoxName.Text);
        }
    }
}
