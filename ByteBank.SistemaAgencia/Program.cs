using ByteBank.Modelos;
using System;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {


            Lista<int> idades = new Lista<int>();

            idades.Adicionar(5);
            idades.AdicionarVarios(4, 3, 66, 5, 7, 8);

            int idadeSoma = 0;
            for (int i = 0; i < idades.Tamanho; i++)
            {
                int idadeAtual = idades[i];
            }

            Console.ReadLine();
        }

        static void TestaListaDeObject()
        {
            ListaDeObject listaDeIdades = new ListaDeObject();

            listaDeIdades.Adicionar(10);
            listaDeIdades.Adicionar(5);
            listaDeIdades.Adicionar(4);

            listaDeIdades.AdicionarVarios(16, 23, 60);

            for (int i = 0; i < listaDeIdades.Tamanho; i++)
            {
                int idade = (int)listaDeIdades[i];
                Console.WriteLine($"Idade no indice {i}: {idade}");
            }


            Console.WriteLine(SomarVarios(2, 4, 5, 6, 6, 444, 7, 777, 12435465, 546));
            Console.WriteLine(SomarVarios(2, 4, 5, 6, 6));
        }

        static int SomarVarios(params int[] numeros)
        {
            int acumulador = 0;
            foreach (var numero in numeros)
            {
                acumulador += numero;
            }

            return acumulador;
        }

        static void TestaListaDeContaCorrente()
        {
            ListaDeContaCorrente lista = new ListaDeContaCorrente();

            ContaCorrente contadoGui = new ContaCorrente(123, 111111);

            lista.Adicionar(contadoGui);



            ContaCorrente[] contas = new ContaCorrente[]
                {
                    contadoGui,
                    new ContaCorrente(234, 2343242),
                    new ContaCorrente(234, 4534543)
                };

            lista.AdicionarVarios(contadoGui, new ContaCorrente(234, 2343242),
                    new ContaCorrente(234, 4534543));

            for (int i = 0; i < lista.Tamanho; i++)
            {
                ContaCorrente itemAtual = lista[i];
                Console.WriteLine($"Item na posição {i} =  Conta {itemAtual.Numero}/{itemAtual.Numero}");
            }
        }

        static void TestaArrayDeContaCorrente()
        {

            ContaCorrente[] contas = new ContaCorrente[]
                {
                    new ContaCorrente(865, 456456),
                    new ContaCorrente(865, 263546),
                    new ContaCorrente(865, 56545)
                };

            for (int indice = 0; indice < contas.Length; indice++)
            {
                ContaCorrente contaAtual = contas[indice];
                Console.WriteLine($"Conta {indice} {contaAtual.Numero}");
            }

        }

        static void TestaArrayInt()
        {
            //Array de inteiros, com 5 posições

            int[] idades = null;
            idades = new int[3];

            idades[0] = 15;
            idades[1] = 28;
            idades[2] = 35;


            Console.WriteLine(idades.Length);

            int acumulador = 0;

            for (int indice = 0; indice < idades.Length; indice++)
            {
                int idade = idades[indice];

                Console.WriteLine($"Acessando o array idades no índice {indice}");
                Console.WriteLine($"Valor de idades [{indice}] = {idade}");

                acumulador += idade;
            }

            int media = acumulador / idades.Length;
            Console.WriteLine($"Média de idades = {media}");
        }
    }
}
