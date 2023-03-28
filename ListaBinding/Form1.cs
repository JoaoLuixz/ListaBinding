using BLL;
namespace ListaBinding
{
    public partial class Form1 : Form
    {
        public Repositorio Repositorio { get; set; } = new Repositorio();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bsItens.DataSource = Repositorio;
        }

        private void btnIncluirModelo_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            cliente.Nome = "Cliente exemplo";
            cliente.Telefone = "000000000";
            cliente.Endereco = "Endereço exemplo";

            Repositorio.Incluir(cliente);
            bsItens.ResetBindings(false);

        }
    }
}