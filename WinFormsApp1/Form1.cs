using System.Text.Json;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            User user = new()
            {
                Name = textBox1.Text,
                Surname = textBox2.Text,
                NickName = textBox3.Text,
                Country = textBox4.Text,
                City = textBox6.Text,
                PhoneNumber = textBox5.Text,
            };
            var json=JsonSerializer.Serialize(user);
            File.WriteAllText($"{user.Name}.json",json);
            
        }
    }
}