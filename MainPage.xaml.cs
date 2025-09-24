namespace MauiAppMeuCombustivel
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                double etanol = Convert.ToDouble(txt_etanol.Text);
                double gasolina = Convert.ToDouble(txt_gasolina.Text);
                string mensagem = string.Empty;


                if (etanol <= 0 || gasolina <= 0)
                {
                    DisplayAlert("Atenção", "Por favor, insira valores maiores que zero.", "Fechar");
                    return;
                }

                if (etanol <= (gasolina * 0.7))
                {
                    mensagem = "O etanol é a melhor opção.";
                }
                else
                {
                    mensagem = "A gasolina é a melhor opção.";
                }

                DisplayAlert("Resultado", mensagem, "OK");
            }
            catch (Exception ex)
            {
                DisplayAlert("Opa rs", $"Tivemos um erro: {ex.Message}", "Fechar");
            }
        }
    }
}
