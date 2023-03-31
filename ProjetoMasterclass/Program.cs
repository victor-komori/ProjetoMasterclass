using System.Runtime.Intrinsics.X86;

namespace ProjetoMasterclass
{
    public class Program
    {
        public static List<Noh> listaNoh = new List<Noh>();
        public static Noh primeiro = null;
        static void Main(string[] args)
        {
            PopularLista();
            //ConsultarPosicao(3);
            ConsultarConteudoStrUsingWhileAndContains("Mat");
            //ConsultarConteudoStrUsingForAndIndexOf("ian");
            //ConsultarId(5);

            Console.ReadLine();
        }

        private static void PopularLista()
        {
            Noh noh = new Noh(1, "Matheus", 2, null);
            Noh noh2 = new Noh(2, "Mariana", 2, null);
            Noh noh3 = new Noh(3, "Mauricio", 1, null);
            Noh noh4 = new Noh(4, "Marcos", 1, null);
            Noh noh5 = new Noh(5, "Maria", 2, null);
            Noh noh6 = new Noh(6, "Matilda", 2, null);
            noh.Proximo = noh2;
            noh2.Proximo = noh3;
            noh3.Proximo = noh4;
            noh4.Proximo = noh5;
            noh5.Proximo = noh6;
            primeiro = noh;
            listaNoh.Add(noh);
            listaNoh.Add(noh2);
            listaNoh.Add(noh3);
            listaNoh.Add(noh4);
            listaNoh.Add(noh5);
            listaNoh.Add(noh6);
        }

        private static void ConsultarPosicao(int posicao)
        {
            Noh aux;
            int index = 0;

            for (aux = listaNoh[0]; index != posicao - 1; index++)
            {
                if (aux != null)
                {
                    aux = aux.Proximo;
                }
            }
            if (aux == null)
            {
                Console.WriteLine("Deu ruim paizão");
            } else
            {
                Console.WriteLine($"Você chegou na posição {index + 1} de nome {aux.Nome}");
            }
        }

        private static void ConsultarConteudoStrUsingWhileAndContains(String conteudo)
        {
            Noh aux = listaNoh[0];
            int posicao = 1;

            while(aux != null)
            {
                if (aux.Nome.Contains(conteudo))
                {
                    Console.WriteLine($"O item da posição {posicao} de nome {aux.Nome} possui o conteudo '{conteudo}'");
                    Console.WriteLine();
                }

                aux = aux.Proximo;
                posicao++;
            }

            Console.WriteLine("Consulta por conteudo finalizada");
        }

        private static void ConsultarConteudoStrUsingForAndIndexOf(String conteudo)
        {
            int posicao = 1;

            for (Noh aux = listaNoh[0]; aux != null; aux = aux.Proximo, posicao++)
            {
                if (aux.Nome.IndexOf(conteudo) >= 0)
                {
                    Console.WriteLine($"O item da posição {posicao} de nome {aux.Nome} possui o conteudo '{conteudo}'");
                    Console.WriteLine();
                }
            }

            Console.WriteLine("Consulta por conteudo finalizada");
        }

        private static void ConsultarId(int id)
        {
            Noh aux = listaNoh[0];
            bool encontrou = false;

            do
            {
                if (aux.Id == id)
                {
                    encontrou = true;
                }
                aux = aux.Proximo;
            } while (aux != null && encontrou == false);

            if (encontrou)
            {
                Console.WriteLine($"O item do id {id} tem o nome {aux.Nome}");
            } else
            {
                Console.WriteLine($"Deu ruim tiu");
            }
        }
    }
}