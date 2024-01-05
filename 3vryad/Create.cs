using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace _3vryad
{
    internal class Create
    {
        public const int Width = 40;
        public const int Height = 40;
        public const int Right = 43;
        public static List<TextBox> GetTextBox(string word)
        {
            int length = word.Length;
            List<TextBox> result = new List<TextBox>();
            int horizontal = 0;
            for (int i = 0; i < length; i++)
            {
                TextBox textBox = new TextBox();
                textBox.Size = new Size(Width, Height);
                textBox.Location = new Point(horizontal,10);
                textBox.Font = new Font(FontFamily.GenericSerif, 25);
                textBox.MaxLength = 1;
                horizontal += Right;
                result.Add(textBox);
            }
            return result;
            
        }

        public static List<Button> GetButtons()
        {
            List<Button> buttons = new List<Button>();
            int horizontal = 0;
            int value = 65;
            int vertical = 100;
            while (value<=90)
            {
                if (value%5==0 && value !=65)
                {
                    vertical += Height + 5;
                    horizontal = 0;
                }
                Button button = new Button();
                char x = (char)value;
                button.Text = x.ToString();
                button.Size = new Size(Width, Height);
                button.Location = new Point(horizontal,vertical);
                horizontal += Right;
                buttons.Add(button);
                value++;

            }
            return buttons;

        }
    }
}
