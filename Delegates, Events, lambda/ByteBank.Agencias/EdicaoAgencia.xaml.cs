using ByteBank.Agencias.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ByteBank.Agencias
{
    /// <summary>
    /// Lógica interna para EdicaoAgencia.xaml
    /// </summary>
    public partial class EdicaoAgencia : Window
    {
        private readonly Agencia _agencia;
        public EdicaoAgencia(Agencia agencia)
        {
            InitializeComponent();
            this._agencia = agencia ?? throw new ArgumentNullException(nameof(agencia));
        }

        public void AtualizarCamposDeTexto()
        {
            txtNumero.Text = _agencia.Numero;
            txtNome.Text = _agencia.Nome;
            txtTelefone.Text = _agencia.Telefone;
            txtEndereco.Text = _agencia.Endereco;
            txtDescricao.Text = _agencia.Descricao;
        }

        public void AtualizarControles()
        {
            RoutedEventHandler dialogResultTrue = (o, e) => DialogResult = true;
            RoutedEventHandler dialogResultFalse = (o, e) => DialogResult = false;

            btnOK.Click += new RoutedEventHandler(dialogResultTrue);
            btnCancelar.Click += new RoutedEventHandler(dialogResultFalse);

            btnOK.Click += new RoutedEventHandler(Fechar);
            btnCancelar.Click += new RoutedEventHandler(Fechar);

            txtNome.Validacao += ContruirDelegateValidacaoCampoNullo(txtNome);

            txtNumero.TextChanged += ContruirDelegateValidacaoCampoNullo(txtNome);
            txtNumero.Validacao += ValidarSomenteDigito;
        }

        private bool ValidarSomenteDigito(string text)
        {
            return text.All(char.IsDigit);
        }

        private TextChangedEventHandler ContruirDelegateValidacaoCampoNullo(TextBox txt)
        {
            return (o, a) =>
            {
                if (String.IsNullOrEmpty(txt.Text)) txt.Background = new SolidColorBrush(Colors.Red);
                else txt.Background = new SolidColorBrush(Colors.White);
            };
        }

        private bool ValidarCamposNulo(string text)
        {
            return !string.IsNullOrEmpty(text);
        }

        //private void TxtNome_TextChanged(object sender, TextChangedEventArgs e)
        //{
        //    if (String.IsNullOrEmpty(txtNome.Text)) txtNome.Background = new SolidColorBrush(Colors.Red);
        //    else txtNome.Background = new SolidColorBrush(Colors.White);
        //}
        private void Fechar(object sender, RoutedEventArgs e) => Close();
    }
}
