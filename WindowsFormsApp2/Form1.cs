using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Collections;
namespace WindowsFormsApp2
{
    public partial class Guess_the_word : Form
    {

    class Program
    {
    }

    public Guess_the_word()
        {
                     InitializeComponent();
        }

        Random rndm = new Random();
        string[] words = {
    "Penguin",
    "Elephant",
    "Whistle",
    "Puzzle",
    "Rocket",
    "Chimney",
    "Guitar",
    "Lighthouse",
    "Cactus",
    "Sapphire"
};
        string word;
        int word_order;

        public void load_word()
        {

            if (word_order < words.Length)
            {
                word = words[word_order].ToUpper();

                int word_length = word.Length;

                StringBuilder maskedWord = new StringBuilder(word_length);

                int masks = word_length / 2;

                ArrayList letter_masks = new ArrayList();

                for (int i = 0; i < masks; i++)
                {
                    bool can_loop = true;
                    do
                    {
                        int rand_num = rndm.Next(word_length);
                        if (!letter_masks.Contains(rand_num))
                        {
                            letter_masks.Add(rand_num);
                            can_loop = false;
                        }
                    } while (can_loop);
                }
                for (int i = 0; i < word_length; i++)
                {
                    if (letter_masks.Contains(i))
                    {
                        maskedWord.Append("?");
                    }
                    else
                    {
                        maskedWord.Append(word[i]);
                    }

                }
                LB_MaskWord.Text = maskedWord.ToString();
            }
            else
            {
                refresh_words();
                load_word();
            }
        }
        public void refresh_words()
        {
            words  = words.OrderBy(x=> rndm.Next()).ToArray();
            word_order = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random Rand = new Random();
            refresh_words();
            load_word();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tb_guess.Text.Trim().Equals("Play Again?", StringComparison.OrdinalIgnoreCase))
            {
                word_order++;
                load_word();
                tb_guess.Text = "Guess!";
                Wrong_guess_list.Items.Clear();
            }

            if (!Tb_answer.Text.Equals(""))
            {
                if (Tb_answer.Text.ToUpper().Equals(word)){
                    LB_MaskWord.Text = word;
                    tb_guess.Text = "Play Again?";

                    MessageBox.Show("Correct Guess!");
                }
                else
                {
                    Wrong_guess_list.Items.Add(Tb_answer.Text);

                    MessageBox.Show("Wrong Guess!");

                }
                Tb_answer.Text = "";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
