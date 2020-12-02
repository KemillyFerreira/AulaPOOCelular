using System;
using Aula3.;


namespace Aula3
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno();

            Console.WriteLine("Digite o nome do aluno");
            aluno.nome = Console.ReadLine();

            Console.WriteLine("Digite o RG do aluno");
            aluno.rg = Console.ReadLine();

            Console.WriteLine("Digite a idade do aluno");
            aluno.idade = int.Parse (Console.ReadLine());

            Console.WriteLine("Digite a média final do aluno");
            aluno.mediaFinal = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor da mensalidade");
            aluno.valorMensalidade = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite se o aluno é bolsista: s/n");
            string resposta = Console.ReadLine();
            if (resposta == "s"){
                aluno.bolsista = true;
            }else{
                aluno.bolsista = false;
            }

            //Menu
            int opcao = 0
            do
            {
                Console.WriteLine("Selecione uma opção");
                Console.WriteLine("[1] - Ver Média do Aluno");
                Console.WriteLine("[2] - Ver Mensalidade do Aluno");
                Console.WriteLine("[0] - Sair");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.WriteLine($"A média final do aluno {aluno.nome} = {aluno.VerMediaAluno()}");
                        break;
                    case 2:
                        Console.WriteLine($"O valor da mensalidade do aluno fica em: {aluno.VerMensalidade()}");
                        break;
                    case 0:
                        Console.WriteLine("Obrigada por acessar!");
                        break;
                    default:
                        Console.WriteLine("Opção Inválida");
                        break;
                }
            } while (opcao != 0);
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
