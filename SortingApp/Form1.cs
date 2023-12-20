using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SortingApp
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //int[] arr = new int[15];
            //int[] arr_new = new int[15];
            List<int> arr = new List<int>();
            List<float> arr2 = new List<float>();
            List<string> arr3 = new List<string>();
            List<char> arr4 = new List<char>();

            foreach (string line in richTextBox1.Lines)
            {
                if (comboBox1.SelectedIndex == 0)
                {
                   if(int.TryParse(line, out int number))
                    {
                        arr.Add(number);
                    }


                }
                if (comboBox1.SelectedIndex == 1)
                {
                    if (float.TryParse(line, out float number))
                    {
                        arr2.Add(number);
                    }


                }
                if (comboBox1.SelectedIndex == 2)
                {
                        arr3.Add(line);

                }
                if (comboBox1.SelectedIndex == 3)
                {
                    if (char.TryParse(line, out char number))
                    {
                        arr4.Add(number);
                    }
                }
                

            }
            bool checked_ = false;
            if (radioButton1.Checked)
            {
                checked_ = true; }
                if (radioButton2.Checked)
                {
                    checked_ = false; }

            richTextBox2.Text = "";
            if (comboBox1.SelectedIndex == 0) {
                int[] arr_new = SortArrayLibrary.SortArrayClass.SortIntArray(arr.ToArray(), checked_);
                richTextBox2.Text = string.Join("\n", arr_new);
            }
            if (comboBox1.SelectedIndex == 1)
            {
                float[] arr_new = SortArrayLibrary.SortArrayClass.SortFloatArray(arr2.ToArray(), checked_);
                richTextBox2.Text = string.Join("\n", arr_new);
            }
            if (comboBox1.SelectedIndex == 2)
            {
                string[] arr_new = SortArrayLibrary.SortArrayClass.SortStringArray(arr3.ToArray(), checked_);
                richTextBox2.Text = string.Join("\n", arr_new);
            }
            if (comboBox1.SelectedIndex == 3)
            {
                char[] arr_new = SortArrayLibrary.SortArrayClass.SortCharArray(arr4.ToArray(), checked_);
                richTextBox2.Text = string.Join("\n", arr_new);
            }
           


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
