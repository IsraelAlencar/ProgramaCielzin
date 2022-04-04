using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barcode
{
    internal class Pacote
    {
        public string Codigo { get; set; }
        public int NumOrigem { get; set; }
        public int NumDestino { get; set; }
        public int CodigoLoggi { get; set; }
        public int CodigoVendedor { get; set; }
        public int NumTipoProduto { get; set; }
        public string RegiaoOrigem { get; set; }
        public string RegiaoDestino { get; set; }
        public string TipoProduto { get; set; }
        public Boolean Valido { get; set; }

        public Pacote() {

        }

        public Pacote(string codigo)
        {
            Codigo = codigo;

            SeparaTrinca();
        }

        private void SeparaTrinca() {
            int codigoOrigem = int.Parse(Codigo.Substring(0, 3));
            int codigoDestino = int.Parse(Codigo.Substring(3, 3));
            int codigoLoggi = int.Parse(Codigo.Substring(6, 3));
            int codigoVendedor = int.Parse(Codigo.Substring(9, 3));
            int codigoProduto = int.Parse(Codigo.Substring(12, 3));

            NumOrigem = codigoOrigem;
            NumDestino = codigoDestino;
            CodigoLoggi = codigoLoggi;
            CodigoVendedor = codigoVendedor;
            NumTipoProduto = codigoProduto;

            //Determinar regiao

            RegiaoOrigem = VerificaRegiao(codigoOrigem);
            RegiaoDestino = VerificaRegiao(codigoDestino);

            //Determina o tipo do produto

            TipoProduto = VerificaTipoProduto(codigoProduto);

            //Verifica validade do pacote

            if (RegiaoOrigem == null || RegiaoDestino == null || codigoVendedor == 367 || TipoProduto == null)
            {
                Valido = false;
            }

            else
            {
                Valido = true;
            }
        }

        public string VerificaRegiao(int x) {

            if (1 <= x && x <= 99)
            {
                return "Sudeste";
            }

            else if (100 <= x && x <= 199)
            {
                return "Sul";
            }

            else if (201 <= x && x <= 299)
            {
                return "Centro-oeste";
            }

            else if (300 <= x && x <= 399)
            {
                return "Nordeste";
            }

            else if (400 <= x && x <= 499)
            {
                return "Norte";
            }

            else {
                return null;
            }
        }

        public string VerificaTipoProduto(int x) {
            if (x == 1)
            {
                return "Jóias";
            }

            else if (x == 111)
            {
                return "Livros";
            }

            else if (x == 333)
            {
                return "Eletrônicos";
            }

            else if (x == 555)
            {
                return "Bebidas";
            }

            else if (x == 888) {
                return "Brinquedos";
            }

            else {
                return null;
            }
        }
    }
}