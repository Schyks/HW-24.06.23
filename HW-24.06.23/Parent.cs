namespace HW_24._06._23
{
    public partial class Parent : Form
    {
        private Child child;

        public Parent()
        {
            InitializeComponent();
            child = new Child(this);
            child.Show();
            textBox1.TextChanged += Parent_TextChanged;
        }
        public void SetText(string text)
        {
            textBox1.Text = text;
        }

        private void Parent_TextChanged(object sender, EventArgs e)
        {
            child.SetText(textBox1.Text);
        }
    }
}