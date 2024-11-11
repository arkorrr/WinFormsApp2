using System;
using static System.Net.Mime.MediaTypeNames;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Label label = new Label();
            Label label2 = new Label();
            List<CheckBox> info = new List<CheckBox>() { checkBox1, checkBox2, checkBox3 };
            foreach (CheckBox checkBox in info)
            {
                if (checkBox.Checked)
                {
                    label.Text += checkBox.Text + ", ";
                }
            }
            List<RadioButton> radioButtons = new List<RadioButton>() { radioButton1, radioButton2, radioButton3 };
            foreach (RadioButton radioButton in radioButtons)
            {
                if (radioButton.Checked)
                {
                    label2.Text = radioButton.Text + ", ";
                }
            }
            if (dateTimePicker2.Value < dateTimePicker1.Value)
            {
                MessageBox.Show("���� ��������� ������� �� ����� ���� ������ ���� ������ �������.", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (string.IsNullOrEmpty(label1.Text) || string.IsNullOrEmpty(label2.Text) || string.IsNullOrEmpty(comboBox1.Text))
            {
                MessageBox.Show("���������� ��������� ��� ����", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                textBox1.AppendText($"���� ������ �������: {dateTimePicker1.Text}" + Environment.NewLine);
                textBox1.AppendText($"���� ����� �������: {dateTimePicker2.Text}" + Environment.NewLine);
                textBox1.AppendText($"��������� �� ������� ����� �������������� �������: {label2.Text}" + Environment.NewLine);
                textBox1.AppendText($"����� �������: {comboBox1.Text}" + Environment.NewLine);
                textBox1.AppendText($"�������������� ������: {label.Text}" + Environment.NewLine);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
