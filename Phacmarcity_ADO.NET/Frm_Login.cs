namespace Phacmarcity_ADO.NET
{
    public partial class Frm_Login : Form
    {
        public Frm_Login()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click_1(object sender, EventArgs e)
        {
            Form form = new Frm_Home();
            form.ShowDialog();
        }
    }
}