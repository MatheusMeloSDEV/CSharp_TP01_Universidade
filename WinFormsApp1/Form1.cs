namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Funcionarios funcionario = new Funcionarios();
            funcionario.CPF = mtxtCPF.Text;
            funcionario.Nome = txtNome.Text;
            funcionario.DTrabalhados = double.Parse(txtDTrabalhados.Text);
            funcionario.VDiaria = double.Parse(txtVDiaria.Text);

            funcionario.SalarioBase();
            funcionario.ValordeIR();
            funcionario.SalarioLiquido();

            txtSBase.Text = funcionario.SBase.ToString();
            txtValorIR.Text = funcionario.ValorIR.ToString();
            txtSLiquido.Text = funcionario.SLiquido.ToString();
        }
    }
}