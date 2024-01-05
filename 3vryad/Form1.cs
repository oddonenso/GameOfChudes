using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3vryad
{
    public partial class Form1 : Form
    {
        public string answer;
        public List<TextBox> _textBox;
        public Form1()
        {
            InitializeComponent();
            var tuple = GeneratorWords.Create();
            label1.Text = tuple.Item1;
            answer = tuple.Item2;
            _textBox= Create.GetTextBox(answer);
            foreach (var item in _textBox)
            {
                Controls.Add(item);
            }

            var button = Create.GetButtons();
            foreach (var item in button)
            {
                Controls.Add(item);
                item.Click += Item_Click;
            }

        }
     
        private void Item_Click(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                button.Enabled = false;
                string text = button.Text;
                if (answer.Contains(text))
                {
                    for(var i =0; i<answer.Length; i++)
                    {
                        if (answer[i] == text[0])
                        {
                            _textBox[i].Text = text;
                        }
                    }
                }
               
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
