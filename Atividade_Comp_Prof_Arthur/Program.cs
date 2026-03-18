using Atividade_Comp_Prof_Arthur;
using System;
using System.ComponentModel;

namespace atividade01
{
    class Program
    {
        static void Main(string[] args)
        {

            string mensagem = "";
            int opcao = -1;

            while (opcao != 0)
            {
                string continuar = "s";

                while (continuar != "n")
                {

                    Console.WriteLine(@$"
                      +-------------------------------------------+
                      |        ATIVIDADE COMPLEMENTAR             |
                      +-------------------------------------------+
                      |  0. Digite o número 0 para sair           |          
                      |  1. Conversor de Medidas                  |          
                      |  2. Calculadora de Desconto               |          
                      |  3. Analisador de Nome                    |      
                      |  4. Cálculo de Idade em Dias              |              
                      |  5. Reajuste Salarial                     |      
                      |  6. Par ou Ímpar                          |  
                      |  7. Maior de Três (Sem funções prontas)   |                      
                      |  8. Tabuada com Laço For                  |          
                      |  9. Validador de Senha com While          |                  
                      |  10. Estatísticas de Array                |          
                      |  11. Busca em Lista (List)                |          
                      |  12. Desafio Final – Sistema de Cadastro  |
                      +-------------------------------------------+
                      {mensagem}
");
                    Console.Write("                Digite o numero de uma das opções acima: ");

                    string entrada = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(entrada) ||
                            !int.TryParse(entrada, out opcao) ||
                            opcao < 0 || opcao > 12)
                    {
                        Console.Clear();
                        mensagem = "Opção invalida! Digite o numero de uma das opções acima: ";
                        continue;

                    }

                    mensagem = "";
                    Console.Clear();

                    switch (opcao)
                    {
                        case 0:
                            continuar = "n";
                            break;
                        case 1:
                            while (continuar != "n")
                            {
                                Console.WriteLine("************* Conversor de Medidas  ***************\n\n\n\n");

                                Console.Write("Digite um valor em metros: ");
                                double metros = double.Parse(Console.ReadLine());
                                double centimetros = metros * 100;
                                double milimetros = metros * 1000;

                                Console.WriteLine($"\n{metros} metros equivalem a {centimetros} centímetros ou {milimetros} centímetros.");


                                Console.WriteLine("\n\n\n\nDeseja repetir digite 's', se quiser sair digite 'n'.");
                                continuar = Console.ReadLine();
                                Console.Clear();

                            }
                            break;
                        case 2:
                            while (continuar != "n")
                            {
                                Console.WriteLine("************* Calculadora de Desconto  ***************\n\n\n\n");

                                Console.Write("Digite o valor do produto: ");
                                double valorProduto = double.Parse(Console.ReadLine());
                                Console.Write("Digite a porcentagem de desconto: ");
                                double porcentagemDesconto = double.Parse(Console.ReadLine());
                                double valorDesconto = valorProduto * (porcentagemDesconto / 100);
                                double valorFinal = valorProduto - valorDesconto;
                                Console.WriteLine($"\nEm um produto de {valorProduto:C2} com um desconto de {porcentagemDesconto}% você vai economizar: {valorDesconto:C2}");


                                Console.WriteLine("\n\n\n\nDeseja repetir digite 's', se quiser sair digite 'n'.");
                                continuar = Console.ReadLine();
                                Console.Clear();

                            }
                            break;
                        case 3:
                            while (continuar != "n")
                            {
                                Console.WriteLine("************* Analisador de Nome  ***************\n\n\n\n");

                                Console.Write("Digite seu nome completo: ");
                                string nomeCompleto = Console.ReadLine();
                                int quantidadecaracteres = nomeCompleto.Replace(" ", "").Length;


                                Console.WriteLine($"Seu nome {nomeCompleto.ToUpper()} agora está em maiusculo.");
                                Console.WriteLine($"Seu nome tem {quantidadecaracteres} caracteres sem os espaços.");
                                Console.WriteLine($"Seu nome tem {nomeCompleto.Length} caracteres com os espaços.");


                                Console.WriteLine("\n\n\n\nDeseja repetir digite 's', se quiser sair digite 'n'.");
                                continuar = Console.ReadLine();
                                Console.Clear();

                            }
                            break;
                        case 4:
                            while (continuar != "n")
                            {
                                Console.WriteLine("************* Cálculo de Idade em Dias  ***************\n\n\n\n");

                                Console.Write("Digite seu nome: ");
                                string nomeCompleto = Console.ReadLine();
                                Console.Write("Digite sua idade: ");
                                int idade = int.Parse(Console.ReadLine());

                                int idadeEmDias = idade * 365;


                                Console.WriteLine($"\nOlá {nomeCompleto.ToUpper()}, você ja viveu aproximadamente {idadeEmDias} dias");


                                Console.WriteLine("\n\n\n\nDeseja repetir digite 's', se quiser sair digite 'n'.");
                                continuar = Console.ReadLine();
                                Console.Clear();

                            }
                            break;
                        case 5:
                            while (continuar != "n")
                            {
                                Console.WriteLine("************* Reajuste Salarial  ***************\n\n\n\n");

                                Console.Write("Digite o valor do salário do funcionario: R$ ");
                                double salario = double.Parse(Console.ReadLine());
                                Console.Write("Digite a porcentagem de reajuste: ");
                                double porcentagemReajuste = double.Parse(Console.ReadLine());

                                double valorReajuste = salario * (porcentagemReajuste / 100);

                                Console.WriteLine(@$"
===========================================================================
O salário do funcionario era R$ {salario:C2} com um reajuste de {porcentagemReajuste}%
O valor do reajuste é de R$ {valorReajuste:C2} e o novo salário é de R$ {(salario + valorReajuste):C2}
===========================================================================
");

                                Console.WriteLine("\n\n\n\nDeseja repetir digite 's', se quiser sair digite 'n'.");
                                continuar = Console.ReadLine();
                                Console.Clear();

                            }
                            break;
                        case 6:
                            while (continuar != "n")
                            {
                                Console.WriteLine("************* Descubra se um numaero é Par ou Ímpar  ***************\n\n\n\n");

                                Console.Write("Digite um número inteiro:");
                                int numero = int.Parse(Console.ReadLine());

                                if (numero % 2 == 0)
                                {
                                    Console.WriteLine($"\nO número {numero} é par.");
                                }
                                else
                                {
                                    Console.WriteLine($"\nO número {numero} é ímpar.");
                                }

                                Console.WriteLine("\n\n\n\nDeseja repetir digite 's', se quiser sair digite 'n'.");
                                continuar = Console.ReadLine();
                                Console.Clear();

                            }
                            break;
                        case 7:
                            while (continuar != "n")
                            {
                                Console.WriteLine("************* Maior de Três (Sem funções prontas)  ***************\n\n\n\n");

                                Console.Write("Digite o primeiro número: ");
                                int num1 = int.Parse(Console.ReadLine());
                                Console.Write("Digite o segundo número: ");
                                int num2 = int.Parse(Console.ReadLine());
                                Console.Write("Digite o terceiro número: ");
                                int num3 = int.Parse(Console.ReadLine());

                                if (num1 > num2 && num1 > num3)
                                {
                                    Console.WriteLine($"\nO maior número é: {num1}");
                                }
                                else if (num2 > num1 && num2 > num3)
                                {
                                    Console.WriteLine($"\nO maior número é: {num2}");
                                }
                                else
                                {
                                    Console.WriteLine($"\nO maior número é: {num3}");
                                }


                                Console.WriteLine("\n\n\n\nDeseja repetir digite 's', se quiser sair digite 'n'.");
                                continuar = Console.ReadLine();
                                Console.Clear();

                            }
                            break;
                        case 8:
                            while (continuar != "n")
                            {
                                Console.WriteLine("************* Tabuada com Laço For  ***************\n\n\n\n");

                                Console.Write("digite um numero: ");
                                int numero = int.Parse(Console.ReadLine());

                                for (int i = 1; i <= 10; i++)
                                {
                                    int resultado = numero * i;
                                    Console.WriteLine($"{numero} x {i} = {resultado}");
                                }


                                Console.WriteLine("\n\n\n\nDeseja repetir digite 's', se quiser sair digite 'n'.");
                                continuar = Console.ReadLine();
                                Console.Clear();

                            }
                            break;
                        case 9:
                            while (continuar != "n")
                            {
                                int parar = -1;
                                string mensagem1 = "";
                                while (parar != 0)
                                {
                                    Console.WriteLine("************* Validador de Senha com While  ***************\n\n\n");
                                    Console.Write($"{mensagem1} \nDigite uma senha (mínimo 8 caracteres): ");
                                    string senha = Console.ReadLine();

                                    if (senha.Length >= 8 && senha == "Java2026")
                                    {
                                        mensagem1 = "";
                                        Console.WriteLine($"A senha digitada foi '{senha}'\nAcesso garantido!");

                                        parar = 0;
                                    }
                                    else
                                    {
                                        Console.Clear();
                                        mensagem1 = "Senha inválida! A senha deve conter pelo menos 8 caracteres. Tente novamente.";
                                    }
                                }





                                Console.WriteLine("\n\n\n\nDeseja repetir digite 's', se quiser sair digite 'n'.");
                                continuar = Console.ReadLine();
                                Console.Clear();

                            }
                            break;
                        case 10:
                            while (continuar != "n")
                            {
                                Console.WriteLine("************* Estatísticas de Array  ***************\n\n\n\n");

                                int[] numeros = new int[5];
                                int soma = 0;

                                for (int i = 0; i < numeros.Length; i++)
                                {
                                    Console.Write($"Digite o {i + 1}º número: ");
                                    int numero = int.Parse(Console.ReadLine());
                                    numeros[i] = numero;
                                    soma += numero;

                                }

                                double mediafinal = soma / numeros.Length;

                                int maior = numeros[0];
                                int menor = numeros[0];

                                for (int i = 0; i < numeros.Length; i++)
                                {
                                    if (numeros[i] > maior)
                                    {
                                        maior = numeros[i];
                                    }
                                    if (numeros[i] < menor)
                                    {
                                        menor = numeros[i];
                                    }
                                }

                                Console.WriteLine($"\nO maior número é {maior} e o menor número é {menor}.");
                                Console.WriteLine($"media dos valores é {mediafinal:F2}");


                                Console.WriteLine("\n\n\n\nDeseja repetir digite 's', se quiser sair digite 'n'.");
                                continuar = Console.ReadLine();
                                Console.Clear();

                            }
                            break;
                        case 11:
                            while (continuar != "n")
                            {
                                Console.WriteLine("************* Busca em Lista (List)  ***************\n\n\n\n");
                                
                                List<string> produtos = new List<string> { "Arroz", "Feijão", "Macarrão", "Açúcar", "Sal" };
                               
                                Console.Write("Digite o nome de um produto para verificar se ele está na lista: ");
                                string produtoUsuario = Console.ReadLine();
                                
                                foreach (string produto in produtos)
                                {
                                    if (produto.ToLower() == produtoUsuario.ToLower())
                                    {
                                        Console.WriteLine($"O produto {produto} esta na lista.");
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine($"O produto {produtoUsuario} não esta na lista.");
                                        break;
                                    }

                                }

                                Console.WriteLine("\n\n\n\nDeseja repetir digite 's', se quiser sair digite 'n'.");
                                continuar = Console.ReadLine();
                                Console.Clear();

                            }
                            break;
                        case 12:
                            while (continuar != "n")
                            {
                                Console.WriteLine("************* Desafio Final – Sistema de Cadastro  ***************\n\n\n\n");

                                Aluno aluno = new Aluno();                                

                                Console.Write("Digite o nome do aluno: ");
                                aluno.Nome = Console.ReadLine();
                                Console.Write("Digite a idade do aluno: ");
                                aluno.Idade = int.Parse(Console.ReadLine());

                                for (int i = 0; i < 3; i++)
                                {
                                    Console.Write($"Digite a {i + 1}ª nota do aluno: ");
                                    aluno.Notas[i] = double.Parse(Console.ReadLine());
                                    aluno.somaNotas += aluno.Notas[i];
                                }
                                
                                aluno.mediaNotas = aluno.somaNotas / aluno.Notas.Length;

                                if (aluno.mediaNotas >= 7)
                                {
                                    Console.WriteLine($"{aluno} foi aprovado!");
                                }
                                if (aluno.mediaNotas >= 5 && aluno.mediaNotas < 7)
                                {
                                    Console.WriteLine($"{aluno} está de recuperação.");
                                }
                                else if (aluno.mediaNotas < 5)
                                {
                                    Console.WriteLine($"{aluno} foi reprovado.");
                                }


                                Console.WriteLine("\n\n\n\nDeseja repetir digite 's', se quiser sair digite 'n'.");
                                continuar = Console.ReadLine();
                                Console.Clear();

                            }
                            break;

                    }


                }
            }

        }
    }
}