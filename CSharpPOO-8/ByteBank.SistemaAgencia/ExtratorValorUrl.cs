using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia
{
    class ExtratorValorUrl
    {
        public string URL { get; }
        private readonly string _argumentos;
        public ExtratorValorUrl(string url)
        {
            if (string.IsNullOrEmpty(url)) throw new Exception($"O argumento {nameof(url)} não pode estar vazio ou nullo");
            this.URL = url;

            int indiceInterrogacao = this.URL.IndexOf('?');
            _argumentos = URL.Substring(indiceInterrogacao + 1);
        }
    }
}
