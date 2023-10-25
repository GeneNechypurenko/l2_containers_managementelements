using Microsoft.VisualBasic.ApplicationServices;

namespace l2_containers_managementelements
{
    public partial class Form1 : Form
    {
        List<Recipe> list = new List<Recipe>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string description = textBox2.Text;
            DateTime nowTime = DateTime.Now;

            Recipe recipe = new Recipe()
            {
                Name = name,
                Description = description,
                addDate = nowTime
            };

            list.Add(recipe);
            listBox1.Items.Add(recipe.ToString());

            textBox1.Clear();
            textBox2.Clear();
        }
    }
}