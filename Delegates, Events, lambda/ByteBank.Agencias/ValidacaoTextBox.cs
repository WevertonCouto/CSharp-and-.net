using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;

namespace ByteBank.Agencias
{
    public delegate bool ValidacaoEventHandler(string text);
    public class ValidacaoTextBox : TextBox
    {
        public event ValidacaoEventHandler Validacao;

        public ValidacaoTextBox()
        {
            TextChanged += ValidacaoTextBox_TextChanged;
        }

        private void ValidacaoTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Validacao == null) return;
            bool eValido = Validacao(Text);
            Background = eValido ? new System.Windows.Media.SolidColorBrush(Colors.White)
                : new SolidColorBrush(Colors.Orange);
        }
    }

}
