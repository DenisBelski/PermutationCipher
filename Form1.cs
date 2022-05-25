namespace PermutationCipher
{
    public partial class Form1 : Form
    {
        Transposition transposition;

        public Form1()
        {
            InitializeComponent();

            transposition = new Transposition();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            transposition.SetKey(keyTextBox.Text);

            if (encryptRadioButton.Checked)
            {
                outputTextBox.Text = transposition.Encrypt(inputTextBox.Text);
            }
            else
            {
                outputTextBox.Text = transposition.Decrypt(inputTextBox.Text);
            }
        }
    }
}