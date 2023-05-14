namespace WinFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //declaração das variáveis
            double nota1, nota2, nota3, media;

            //entrada de dados
            //as variáveis nota1, nota2, nota3, recebem o valor que foi digitado no TextBox
            //Convert.ToDouble, faz a conversão do tipo texto para double
            nota1 = Convert.ToDouble(txtNota1.Text);
            nota2 = Convert.ToDouble(txtNota2.Text);
            nota3 = Convert.ToDouble(txtNota3.Text);

            //processamento, calculando a média:
            //soma-se as três notas e dividi por 3.
            media = (nota1 + nota2 + nota3) / 3;

            //apresenta a média na lblMedia
            //ToString, converte o valor double que está armazenado na variável
            //média e converte para texto.
            lblMedia.Text = media.ToString();

            //verifica a situação do aluno, analisando o valor da variável média

            if (media >= 7.0)
            {
                //instruções se a condição (media >= 7.0) for verdadeira 
                lblSituacao.Text = "Aluno Aprovado!";
            }
            else
            {
                //instruções se a condição (media >= 7.0) for falsa 
                lblSituacao.Text = "Aluno Reprovado!";

            }  //fim da instrução if/else
        }
    }
}