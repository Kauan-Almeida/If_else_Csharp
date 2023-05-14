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
            //declara��o das vari�veis
            double nota1, nota2, nota3, media;

            //entrada de dados
            //as vari�veis nota1, nota2, nota3, recebem o valor que foi digitado no TextBox
            //Convert.ToDouble, faz a convers�o do tipo texto para double
            nota1 = Convert.ToDouble(txtNota1.Text);
            nota2 = Convert.ToDouble(txtNota2.Text);
            nota3 = Convert.ToDouble(txtNota3.Text);

            //processamento, calculando a m�dia:
            //soma-se as tr�s notas e dividi por 3.
            media = (nota1 + nota2 + nota3) / 3;

            //apresenta a m�dia na lblMedia
            //ToString, converte o valor double que est� armazenado na vari�vel
            //m�dia e converte para texto.
            lblMedia.Text = media.ToString();

            //verifica a situa��o do aluno, analisando o valor da vari�vel m�dia

            if (media >= 7.0)
            {
                //instru��es se a condi��o (media >= 7.0) for verdadeira 
                lblSituacao.Text = "Aluno Aprovado!";
            }
            else
            {
                //instru��es se a condi��o (media >= 7.0) for falsa 
                lblSituacao.Text = "Aluno Reprovado!";

            }  //fim da instru��o if/else
        }
    }
}