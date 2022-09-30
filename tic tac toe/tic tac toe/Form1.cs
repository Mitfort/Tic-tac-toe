using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tic_tac_toe
{
    public partial class Form1 : Form
    {
        Random rand = new Random();
        string playerSign, aiSign;
        public Form1()
        {
            InitializeComponent();
            lista.Add(b1);
            lista.Add(b2);
            lista.Add(b3);
            lista.Add(b4);
            lista.Add(b5);
            lista.Add(b6);
            lista.Add(b7);
            lista.Add(b8);
            lista.Add(b9);

            int num1 = rand.Next(1, 3);
            if(num1 == 1)
            {
                playerSign = "X";
                aiSign = "O";
            }
            else
            {
                playerSign = "O";
                aiSign = "X";
            }
        }
       
        string[] array = new string[9];
        
        
        List<Button> lista = new List<Button>();
       

        private void playerClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.Text = playerSign;
            button.BackColor = System.Drawing.Color.Green;
            button.Enabled = false;

            

            array.Append(button.Name);
            bool search = false;
            do
            {
                int number = rand.Next(1, 9);
                string id = "b" + number;
                if (!Array.Exists(array, element => element == id))
                {
                    var btn = lista.ElementAt(number);
                    if(btn.Enabled == true)
                    {
                        btn.Text = aiSign;
                        btn.BackColor = System.Drawing.Color.Red;
                        btn.Enabled = false;
                        search = true;
                    }
                    
                }
                var counter = 0;
                for(int i= 0; i < lista.Count();i++)
                {
                    if(lista[i].Enabled == false)
                    {
                        counter++;
                    }
                }
                if(counter == 9)
                {
                    break;
                }
            } while (search == false);
            check();
        }

        private void check()
        {
            if (b1.Text == "X" && b2.Text == "X" && b3.Text == "X" ||
                b4.Text == "X" && b5.Text == "X" && b6.Text == "X" ||
                b7.Text == "X" && b8.Text == "X" && b9.Text == "X" ||
                b1.Text == "X" && b4.Text == "X" && b7.Text == "X" ||
                b2.Text == "X" && b5.Text == "X" && b8.Text == "X" ||
                b3.Text == "X" && b6.Text == "X" && b9.Text == "X" ||
                b1.Text == "X" && b5.Text == "X" && b9.Text == "X" ||
                b7.Text == "X" && b5.Text == "X" && b3.Text == "X"
                )
            {
                for (int i = 0; i < lista.Count(); i++)
                {
                    lista[i].Enabled = false;
                }
                if (playerSign == "X") label1.Text = "!You win!";
                else label1.Text = "!Bot win!";
            }
            else if (b1.Text == "O" && b2.Text == "O" && b3.Text == "O" ||
            b4.Text == "O" && b5.Text == "O" && b6.Text == "O" ||
            b7.Text == "O" && b8.Text == "O" && b9.Text == "O" ||
            b1.Text == "O" && b4.Text == "O" && b7.Text == "O" ||
            b2.Text == "O" && b5.Text == "O" && b8.Text == "O" ||
            b3.Text == "O" && b6.Text == "O" && b9.Text == "O" ||
            b1.Text == "O" && b5.Text == "O" && b9.Text == "O" ||
            b7.Text == "O" && b5.Text == "O" && b3.Text == "O"
            )
            {
                for (int j = 0; j < lista.Count(); j++)
                {
                    lista[j].Enabled = false;
                }
                if (playerSign == "O") label1.Text = "!You win!";
                else label1.Text = "!Bot win!";
            }
            else
            {
                var counter = 0;
                for (int i = 0; i < lista.Count(); i++)
                {
                    if (lista[i].Enabled == false)
                    {
                        counter++;
                    }
                }
                if (counter == 9)
                {
                    label1.Text = "!Draw!";
                }
            }
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AImoves_Tick(object sender, EventArgs e)
        {

        }
    }
}
