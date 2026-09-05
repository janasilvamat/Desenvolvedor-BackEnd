using CasasBahia2.Classes.Contextos;


namespace CasasBahia2
{
    public partial class Form1 : Form
    {
        //Campos
        Form2 janela1;
        public Form1()
        {
            InitializeComponent();
        }
     
        private void button1_Click(object sender, EventArgs e)
        {
            var contexto = new LoginsContexto();
            var usuario = contexto.Logins.FirstOrDefault(u => u.Usuario == textBox1.Text);
            var senha = contexto.Logins.FirstOrDefault(s => s.Senha == textBox2.Text);
          

            bool login = (usuario != null) & (senha != null);

            if (login)
            {
                //Abre a segunda tela
                MessageBox.Show("Login bem sucedido");
                janela1 = new Form2();
                Hide();
                janela1.Show();
            }
            else
            {
                MessageBox.Show("Usuário ou senha incorretos.");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}