using System;

namespace FrequenciaDeNumeros.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputQuantidadeNumeros;
            int quantidadeNumeros = 0;
            int[] arrayNumeros;
            string[] inputNumerosNaArray;
            int cont = 1;
            int horaDeParar = 0;
            int pegarNumero = 0;

            string fecharBotao;
            bool opcaoValida = false;
            bool fecharApp = false;
            while (fecharApp == false)
            {
                Console.WriteLine("===== Programa Frequancia de Numeros =====");
                Console.WriteLine("");
                Console.WriteLine("Utilize esse programa para descobrir a frequencia de numeros que aparecem.");
                Console.WriteLine("");
                Console.WriteLine("===================================");
                Console.WriteLine("");

                Console.WriteLine("Bem vindo ao menu de Frequencia de Numeros.");
                Console.WriteLine("");
                Console.Write("Digite a quantidade de numeros a digitar: ");
                inputQuantidadeNumeros = Console.ReadLine();

                quantidadeNumeros = int.Parse(inputQuantidadeNumeros);
                arrayNumeros = new int[quantidadeNumeros];
                inputNumerosNaArray = new string[quantidadeNumeros];

                if (quantidadeNumeros < 1 || quantidadeNumeros > 2000)
                {
                    Console.WriteLine("");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Selecione um numero entre 1 e 2000!");
                    Console.ResetColor();
                    Console.WriteLine("");
                    Console.WriteLine("Aperte ENTER para prosseguir.");
                    Console.ReadLine();
                    Console.Clear();
                    continue;
                }

                Console.WriteLine("");

                Console.WriteLine("Digite o numero e aperte ENTER.");
                for (int i = 0; i < arrayNumeros.Length; i++)
                {
                    Console.Write("Numero: ");
                    inputNumerosNaArray[i] = Console.ReadLine();
                    arrayNumeros[i] = int.Parse(inputNumerosNaArray[i]);
                }

                horaDeParar = arrayNumeros.Length;

                Array.Sort(arrayNumeros);

                Console.WriteLine("");

                for (int i = 0; i < arrayNumeros.Length; i++)
                {
                    if(i == horaDeParar - 1)
                    {
                        if(arrayNumeros[i] == arrayNumeros[i - 1])
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("O numero {0}, aparece {1} vez(es).", arrayNumeros[i], 1);
                            break;
                        }
                    }

                    if (arrayNumeros[i] == arrayNumeros[i + 1])
                    {
                        cont++;
                        pegarNumero = arrayNumeros[i];  

                    }
                    else
                    {
                        if(cont == 1)
                        {
                            Console.WriteLine("O numero {0}, aparece {1} vez(es).", arrayNumeros[i], 1);
                        }
                        else
                        {
                            Console.WriteLine("O numero {0}, aparece {1} vez(es).", pegarNumero, cont);
                            cont = 1;
                        }
                    }
                }

                Console.WriteLine();

                opcaoValida = false;
                while (opcaoValida == false)
                {
                    Console.WriteLine("Caso deseje realizar rodar o programa novamente e inserir novos comandos, digite 1 e aperte ENTER.");
                    Console.WriteLine("Caso deseje fechar o programa, digite 0 e aperte ENTER.");
                    Console.Write("Opcao escolhida: ");
                    fecharBotao = Console.ReadLine();

                    if (fecharBotao == "0")
                    {
                        fecharApp = true;
                        opcaoValida = true;
                    }
                    else if (fecharBotao == "1")
                    {
                        Console.Clear();
                        opcaoValida = true;
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Opcao invalida, selecione uma opcao valida!");
                        Console.ResetColor();
                        Console.WriteLine("");
                        Console.WriteLine("Aperte ENTER para prosseguir.");
                        Console.ReadLine();
                        continue;
                    }
                }
            }
        }
    }
}
