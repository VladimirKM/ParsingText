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
using System.Collections;

namespace ParsingText
{
    public partial class Form1 : Form
    {
      public Form1()
        {
            InitializeComponent();
            listVal = new ArrayList();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            Reading(tboxFileName.Text, listVal);
            
        }
        //static async Task Reading(string[] args)
        
        static async Task Reading(string pathFile, ArrayList listVal )
        {
            string[] arrayVal = {};
            //ArrayList listVal = new ArrayList();
            int count = 0;
            using (StreamReader sr = new StreamReader(pathFile, Encoding.UTF8))
            {
                string line;
                //string regularExpression = "#.*?:"; // строка от # до :
                string regularExpression = "#.*"; // строка от # до 
                //listVal = new ArrayList();
                while ((line = await sr.ReadLineAsync()) != null)
                {
                    Match m = Regex.Match(line, regularExpression); 
                    if (m.Success)   // совпадение
                    {
                        listVal.Add(m.Value);
                        count++;
                    }
                    Console.WriteLine(line);
                }
            }
            Console.WriteLine(count);
        }

        static async Task Writing(string pathFile, ArrayList listVal)
        {
            var LenthList = listVal.Count;
            if (LenthList > 0)
            {
                using (StreamWriter outputFile = new StreamWriter(pathFile))
                {
                    for (int i = 0; i < LenthList; i++)
                    {
                        await outputFile.WriteAsync(listVal[i].ToString() + "\n");

                    }
                }
            }
        }

        private void ChoiceFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            tboxFileName.Text = openFileDialog1.FileName;
            MessageBox.Show("Файл открыт");
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            string filename = saveFileDialog1.FileName;
            // сохраняем текст в файл
            Writing(filename, listVal);
            //.........................
            MessageBox.Show("Файл сохранен");

        }
    }
}
