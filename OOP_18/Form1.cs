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
        double[] firstArray;// ����������� �����
        double[,] secondArray;// ���������� �����

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_rndm_Click(object sender, EventArgs e)//��� ��������� �� ������
        {
            try
            {
                firstArray = new double[int.Parse(textBoxLength.Text)];//���������� ����� �� ������ ���� �������
                Random rand = new Random();//��'��� ��� ����������� ���������� ������
                Console.OutputEncoding = UTF8Encoding.UTF8;//��� ��������� ��������� ���� � �������
                for (int i = 0; i < firstArray.Length; i++)
                {
                    firstArray[i] = Math.Round(rand.NextDouble() * (10.0 + 10.0) - 10.0, 1);//��������� ����������
                }
                Console.Write("�������������� �����: ");
                for (int i = 0; i < firstArray.Length; i++)
                {
                    Console.Write(firstArray[i] + " ");
                }
            }
            catch (FormatException)//����������
            {
                MessageBox.Show("������� ��� �������� �����!");
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("������ ���!");
            }

        }

        private void btn_a_Click(object sender, EventArgs e)//��� ��������� �� ������
        {
            try
            {
                double digit = 1;//����� ��� �������
                Console.WriteLine();
                for (int i = 0; i < firstArray.Length; i++)
                {
                    if (firstArray[i] > 0)
                    {
                        digit = digit * firstArray[i];// ���������� �������
                    }
                }
                Console.WriteLine("������� �������� �������� ������: " + digit);
            }
            catch (FormatException)
            {
                MessageBox.Show("������� ����� ��� �����!");
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("������ ���!");
            }
            
        }

        private void btn_b_Click(object sender, EventArgs e)//��� ��������� �� ������
        {
            try
            {
                double min;// ����� ��� ���������� ��������
                double sum = 0;//����� ��� ����
                int indexOfMin = 0;//����� ��� ������ ������� ���������� �����
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
                    sum += firstArray[i];//���������� ����
                }
                Console.WriteLine("���� �������� ������, ������������ �� ���������� ��������: " + sum);
            }
            catch (FormatException)
            {
                MessageBox.Show("������� ����� ��� �����!");
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("������ ���!");
            }
        }

        private void btn_c_Click(object sender, EventArgs e)//��� ��������� �� ������
        {
            try
            {
                Console.Write("�������� �� ������ �����: ");
                for (int i = 0; i < firstArray.Length; i++)
                {
                    if (i % 2 == 0)//����� ��� ��� ����������� ���� �������
                    {

                        Console.Write(firstArray[i] + " ");
                    }
                }
                Console.WriteLine();
                Console.Write("�������� �� �������� �����: ");
                for (int i = 0; i < firstArray.Length; i++)
                {
                    if (i % 2 == 1)//����� ��� ��� ����������� �� ���� �������
                    {

                        Console.Write(firstArray[i] + " ");
                    }
                }
                Array.Sort(firstArray);//����� ��� ���������� ������
                Console.WriteLine();
            }
            catch (FormatException)
            {
                MessageBox.Show("������� ����� ��� �����!");
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("������ ���!");
            }

        }

        private void btn_rndm_2_Click(object sender, EventArgs e)//��� ��������� �� ������
        {
            try
            {
                secondArray = new double[int.Parse(txtBoxGetLenght_0.Text), int.Parse(txtBoxGetLenght_1.Text)];//����������� ������
                Random rand = new Random();
                for (int i = 0; i < secondArray.GetLength(0); i++)
                {
                    for (int j = 0; j < secondArray.GetLength(1); j++)
                    {
                        secondArray[i, j] = Math.Round(rand.NextDouble() * (10.0 + 10.0) - 10.0, 1);//��������� ���������� 
                    }
                }
            }
            catch (FormatException)//����������
            {
                MessageBox.Show("������ �������� ������!");
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("������ ���!");
            }
        }

        private void btn_1_Click(object sender, EventArgs e)// ��� ��������� �� ������
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
            catch (NullReferenceException)// ����������
            {
                MessageBox.Show("����� �� �������!");
            }
            catch (FormatException)//����������
            {
                MessageBox.Show("������ �������� ������!");
            }

        }

        private void btn_2_Click(object sender, EventArgs e)// ��� ��������� �� ������
        {
            try
            {
                double last = 0;// ����� ��� ����������� ��������� ��������
                last = secondArray[secondArray.GetLength(0) - 1, secondArray.GetLength(1) - 1];
                lbl_8.Text += last;
            }
            catch (FormatException)//����������
            {
                MessageBox.Show("������ �������� ������!");
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("����� �� �������!");
            }
        }

        private void btn_3_Click(object sender, EventArgs e)// ��� ��������� �� ������ 
        {
            try
            {
                double first = 0;//����� ��� ������ ������� ������� ������
                first = secondArray[0, 0];
                lbl_9.Text += first;
            }
            catch (FormatException)//����������
            {
                MessageBox.Show("������ �������� ������!");
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("����� �� �������!");
            }
        }
    }
}
