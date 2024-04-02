using System;
using System.Collections.Generic;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace OOP_18
{
    public partial class Form1 : Form
    {
        double[] firstArray;// одновимірний масив
        double[,] secondArray;// двовимірний масив

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_rndm_Click(object sender, EventArgs e)//при натисканні на кнопку
        {
            try
            {
                firstArray = new double[int.Parse(textBoxLength.Text)];//ініціалізуємо масив та задаємо йому довжину
                Random rand = new Random();//об'єкт для випадкового заповнення масиву
                Console.OutputEncoding = UTF8Encoding.UTF8;//для виведення української мови в консоль
                for (int i = 0; i < firstArray.Length; i++)
                {
                    firstArray[i] = Math.Round(rand.NextDouble() * (10.0 + 10.0) - 10.0, 1);//випадкове заповнення
                }
                Console.Write("Згенерированый масив: ");
                for (int i = 0; i < firstArray.Length; i++)
                {
                    Console.Write(firstArray[i] + " ");
                }
            }
            catch (FormatException)//виключення
            {
                MessageBox.Show("Невірний тип введених даних!");
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Введіть дані!");
            }

        }

        private void btn_a_Click(object sender, EventArgs e)//при натисканні на кнопку
        {
            try
            {
                double digit = 1;//змінна для добутку
                Console.WriteLine();
                for (int i = 0; i < firstArray.Length; i++)
                {
                    if (firstArray[i] > 0)
                    {
                        digit = digit * firstArray[i];// розрахунок добутку
                    }
                }
                Console.WriteLine("Добуток додатних елементів масиву: " + digit);
            }
            catch (FormatException)
            {
                MessageBox.Show("Введено інший тип даних!");
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Введіть дані!");
            }
            
        }

        private void btn_b_Click(object sender, EventArgs e)//при натисканні на кнопку
        {
            try
            {
                double min;// змінна для мінімального елемента
                double sum = 0;//змінна для суми
                int indexOfMin = 0;//змінна для пошуку індексу мінімального числа
                min = firstArray[0];
                for (int i = 0; i < firstArray.Length; i++)
                {
                    if (firstArray[i] < min)
                    {
                        indexOfMin = i;
                        min = firstArray[i];
                    }
                }
                for (int i = 0; i < indexOfMin; i++)
                {
                    sum += firstArray[i];//розрахунок суми
                }
                Console.WriteLine("Сума елементів масиву, розташованих до мінімального елементу: " + sum);
            }
            catch (FormatException)
            {
                MessageBox.Show("Введено інший тип даних!");
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Введіть дані!");
            }
        }

        private void btn_c_Click(object sender, EventArgs e)//при натисканні на кнопку
        {
            try
            {
                Console.Write("Елементи на парних місцях: ");
                for (int i = 0; i < firstArray.Length; i++)
                {
                    if (i % 2 == 0)//умова при якій знаходяться парні індекси
                    {

                        Console.Write(firstArray[i] + " ");
                    }
                }
                Console.WriteLine();
                Console.Write("Елементи на непарних місцях: ");
                for (int i = 0; i < firstArray.Length; i++)
                {
                    if (i % 2 == 1)//умова при якій знаходяться не парні індекси
                    {

                        Console.Write(firstArray[i] + " ");
                    }
                }
                Array.Sort(firstArray);//метод для сортування масиву
                Console.WriteLine();
            }
            catch (FormatException)
            {
                MessageBox.Show("Введено інший тип даних!");
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Введіть дані!");
            }

        }

        private void btn_rndm_2_Click(object sender, EventArgs e)//при натисканні на кнопку
        {
            try
            {
                secondArray = new double[int.Parse(txtBoxGetLenght_0.Text), int.Parse(txtBoxGetLenght_1.Text)];//ініціалізація масиву
                Random rand = new Random();
                for (int i = 0; i < secondArray.GetLength(0); i++)
                {
                    for (int j = 0; j < secondArray.GetLength(1); j++)
                    {
                        secondArray[i, j] = Math.Round(rand.NextDouble() * (10.0 + 10.0) - 10.0, 1);//випадкове заповнення 
                    }
                }
            }
            catch (FormatException)//виключення
            {
                MessageBox.Show("Невірно введений формат!");
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Введіть дані!");
            }
        }

        private void btn_1_Click(object sender, EventArgs e)// при натисканні на кнопку
        {
            try
            {
                for (int i = 0; i < secondArray.GetLength(0); i++)
                {
                    for (int j = 0; j < secondArray.GetLength(1); j++)
                    {
                        lblMassive.Text += secondArray[i, j].ToString() + "  ";
                    }
                    lblMassive.Text += "\n";
                }
            }
            catch (NullReferenceException)// виключення
            {
                MessageBox.Show("Масив не введено!");
            }
            catch (FormatException)//виключення
            {
                MessageBox.Show("Невірно введений формат!");
            }

        }

        private void btn_2_Click(object sender, EventArgs e)// при натисканні на кнопку
        {
            try
            {
                double last = 0;// змінна для знаходження останього елементу
                last = secondArray[secondArray.GetLength(0) - 1, secondArray.GetLength(1) - 1];
                lbl_8.Text += last;
            }
            catch (FormatException)//виключення
            {
                MessageBox.Show("Невірно введений формат!");
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Масив не введено!");
            }
        }

        private void btn_3_Click(object sender, EventArgs e)// при натисканні на кнопку 
        {
            try
            {
                double first = 0;//змінна для пошуку першого лементу масиву
                first = secondArray[0, 0];
                lbl_9.Text += first;
            }
            catch (FormatException)//виключення
            {
                MessageBox.Show("Невірно введений формат!");
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Масив не введено!");
            }
        }
    }
}
