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

namespace лр6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        // Создание объекта класса DogList для хранения вводимых значений.
        DogList dl = new DogList();
        private void button1_Click(object sender, EventArgs e)
        {
            // Создание нового объекта класса Dogs и присвоение ему значений из полей формы.
            Dogs D = new Dogs(textBox1.Text, listBox1.SelectedItem.ToString(), Int32.Parse(textBox3.Text), Double.Parse(textBox2.Text));
            // Добавление элемента в коллекцию.
            dl.Add(D);
            // Очищение текстовых полей.
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox3.Clear();
            // Вспомогательная переменная для вывода элементов коллекции в RichTextBox.
            string s = "";
            // цикл присвоения вспомогательной переменной информации об элементах коллекции.
            for (int i = 0; i<dl.Size;i++)
            {
                s += dl.Show(i);
            }
            // Вывод вспомогательной переменной.
            richTextBox1.Text = s;

            label5.Text = "Собака с максимальным весом и минимальной высотой в холке : " + dl.SearchDog().Name + " (Рост: " + dl.SearchDog().Height + "см вес: "+ dl.SearchDog().Weight+ " кг).";
        }
        // Отключение кнопки добавить, если заполнены не все поля.
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && listBox1.SelectedIndex!=-1)
            {
                button1.Enabled = true;
            }
            else button1.Enabled = false;
        }
        // Метод очищения полей формы и коллекции при нажатии кнопки.
        private void button2_Click(object sender, EventArgs e)
        {
            // Очищение текстовых полей.
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            richTextBox1.Clear();
            // Очищение коллекции.
            dl.Clear();
            label5.Text = "Собака с максимальным весом и минимальной высотой в холке : ";
        }
        // Метод сохранения при нажатии на кнопку "Сохранить".
        private void button3_Click(object sender, EventArgs e)
        {
            // Вывод диалогового окна выбора файла сохранения.
            saveFileDialog1.ShowDialog();
            // Запись текста из RichTextBox в текстовы файл.
            StreamWriter sw = new StreamWriter(saveFileDialog1.FileName, false, Encoding.UTF8);
            sw.Write(richTextBox1.Text);
            sw.Close();
        }
        // Метод для вывода предупреждения при закрытии формы.
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog;
            // Вывод окна с предупреждением.
            dialog = MessageBox.Show("Сохранить список?", "Предупреждение", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                button3_Click(this, e);
            }
        }
        // Метод ограничения ввода символов в textBox3.
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Вспомогательная переменная.
            char num = e.KeyChar;
            // Запрет ввода значений, кроме цифр и BackSpace.
            if (!Char.IsDigit(num) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
            // Запрет на ввод более, чем 3 символов.
            if (textBox3.Text.Length >= 3)
            {
                e.Handled = true;
            }
        }
        // Метод ограничения ввода символов в textBox2.
        private void textBox2_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            // Вспомогательная переменная.
            char num = e.KeyChar;
            // Запрет на ввод значений, кроме чисел, запятой и BackSpace.
            if (!Char.IsDigit(num) && e.KeyChar != (char)Keys.Back && e.KeyChar != ',')
            {
                e.Handled = true;
            }
            // Проверка на ввод только одной запятой.
            if (e.KeyChar == ','){
                if (textBox2.Text.IndexOf(',') != -1 || textBox2.Text.Length == 0)
                {
                    e.Handled = true;
                }
            }
        }
        // Метод ограничения ввода символов в textBox1.
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Вспомогательная переменная.
            char p = e.KeyChar;
            // Запрет на ввод символов, кроме символов кириллицы, BackSpace и пробела
            if ((p<'А'||p>'я')&&p!='\b'&& p!=' ')
            {
                e.Handled = true;
            }
            // Запрет на ввод пробела первым символом.
            if(p==' ')
            {
                if (textBox1.Text.Length == 0)
                {
                    e.Handled = true;
                }
            }
        }
    }
}
