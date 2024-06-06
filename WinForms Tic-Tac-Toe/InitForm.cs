namespace WinForms_Tic_Tac_Toe
{
    public partial class InitForm : Form
    {
        public InitForm()
        {
            InitializeComponent();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            this.Hide();

            GameForm gameForm = new GameForm();

            gameForm.ShowDialog();

            this.Show();
        }
    }
}
