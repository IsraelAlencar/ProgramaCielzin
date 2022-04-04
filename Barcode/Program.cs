using System;
using System.Collections.Generic;
using System.Globalization;

namespace Barcode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string codigo;
            int contador = 0;

            List<Pacote> list = new List<Pacote>();
            List<Pacote> listSuldeste = new List<Pacote>();
            List<Pacote> listSul = new List<Pacote>();
            List<Pacote> listCentro = new List<Pacote>();
            List<Pacote> listNordeste = new List<Pacote>();
            List<Pacote> listNorte = new List<Pacote>();
            List<Pacote> listValido = new List<Pacote>();
            List<Pacote> listInvalido = new List<Pacote>();

            while ((codigo = Console.ReadLine()) != null)
            {

                Pacote pacote = new Pacote(codigo);

                list.Add(pacote);

                if (pacote.RegiaoDestino == "Suldeste")
                {
                    listSuldeste.Add(pacote);
                }

                else if (pacote.RegiaoDestino == "Sul")
                {
                    listSul.Add(pacote);
                }

                else if (pacote.RegiaoDestino == "Centro-oeste")
                {
                    listCentro.Add(pacote);
                }

                else if (pacote.RegiaoDestino == "Nordeste")
                {
                    listNordeste.Add(pacote);
                }

                else
                {
                    listNorte.Add(pacote);
                }

                if (pacote.Valido == true)
                {
                    listValido.Add(pacote);
                }

                else
                {
                    listInvalido.Add(pacote);
                }

                contador += 1;
            }

            //A Loggi precisa:

            //1.
            Console.WriteLine();
            Console.WriteLine("1.");

            Console.WriteLine("Suldeste: " + listSuldeste.Count);
            Console.WriteLine();

            Console.WriteLine("Sul: " + listSul.Count);
            Console.WriteLine();

            Console.WriteLine("Centro-oeste: " + listCentro.Count);
            Console.WriteLine();

            Console.WriteLine("Nordeste: " + listNordeste.Count);
            Console.WriteLine();

            Console.WriteLine("Norte: " + listNorte.Count);

            //2.
            Console.WriteLine();
            Console.WriteLine("2.");

            Console.WriteLine("Pacotes validos:");

            foreach (Pacote x in listValido)
            {
                Console.WriteLine(x.Codigo);
            }

            foreach (Pacote x in listInvalido)
            {
                Console.WriteLine(x.Codigo);
            }

            //3.
            Console.WriteLine();
            Console.WriteLine("3.");

            Console.WriteLine("Pacotes postados na região Sul contendo brinquedos:");

            foreach (Pacote x in listSul)
            {
                if (x.TipoProduto == "Brinquedos")
                {
                    Console.WriteLine(x.Codigo);
                }
            }

            //4
            Console.WriteLine();
            Console.WriteLine("4.");

            Console.WriteLine("Pacotes validos agrupados por região:");
            Console.WriteLine();
            Console.WriteLine("Suldeste:");

            foreach (Pacote x in listSuldeste)
            {
                if (x.Valido == true)
                {
                    Console.WriteLine(x.Codigo);
                }
            }

            Console.WriteLine();
            Console.WriteLine("Sul:");

            foreach (Pacote x in listSul)
            {
                if (x.Valido == true)
                {
                    Console.WriteLine(x.Codigo);
                }
            }

            Console.WriteLine();
            Console.WriteLine("Centro-oeste:");

            foreach (Pacote x in listCentro)
            {
                if (x.Valido == true)
                {
                    Console.WriteLine(x.Codigo);
                }
            }

            Console.WriteLine();
            Console.WriteLine("Nordeste:");

            foreach (Pacote x in listNordeste)
            {
                if (x.Valido == true)
                {
                    Console.WriteLine(x.Codigo);
                }
            }

            Console.WriteLine();
            Console.WriteLine("Norte:");

            foreach (Pacote x in listNorte)
            {
                if (x.Valido == true)
                {
                    Console.WriteLine(x.Codigo);
                }
            }

            //5.
            Console.WriteLine();
            Console.WriteLine("5.");

            List<Pacote> listValidoAux = listValido;

            int count = 0;

            Console.WriteLine(listValidoAux[0].CodigoVendedor + ": ");

            while (listValidoAux.Count <= 0)
            {
                foreach (Pacote x in listValidoAux)
                {
                    if (listValidoAux[0].CodigoVendedor == x.CodigoVendedor)
                    {
                        count++;
                        listValidoAux.Remove(x);
                    }
                }

                Console.WriteLine(listValidoAux[0].CodigoVendedor + ": " + count);
                count = 0;
            }

            //6.
            Console.WriteLine();
            Console.WriteLine("6.");

            //Suldeste





        }
        
    }
}
