namespace IMCv2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

 

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double peso, altura, imc;

            peso = double.Parse(txtpeso.Text);
            altura = double.Parse(txtaltura.Text);

            imc = (peso / (altura * altura));

            imc = double.Parse(String.Format("{0:N2}", imc));

           txtresultado.Text = imc.ToString();

            if (imc < 18.5) 
                MessageBox.Show("Seu IMC é " + imc + ", você precisa comer mais");
            else if (imc < 25)
                MessageBox.Show("Seu IMC é " + imc + ", você ta legal, show de bola");
            else if (imc < 30)
                MessageBox.Show("Seu IMC é " + imc + ", você não ta ruim, mas precisa manerar um pouco na comida e correr um pouco");
            else if (imc < 35)
                MessageBox.Show("Seu IMC é " + imc + ", você precisa ir pra academia e parar de comer besteira");
            else
                MessageBox.Show("Seu IMC é " + imc + ", você precisa tem que malhar muito e fazer um regime sério");


        }

  
    }
}