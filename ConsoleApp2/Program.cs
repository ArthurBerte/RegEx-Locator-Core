using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace RegExLocator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Selecione a opção:");
            Console.WriteLine("1) Nr.Conta, 2) CPF, 3) Grupo, 4) Sair");
            String userValue = Console.ReadLine();
            if (userValue == "1")
            {
                string message = "Digite o Nr. Conta:";
                List<int> foundValues = new List<int>();
                try
                {
                    var valores = File.ReadLines(@"C:\Users\berte.arthur\Downloads\entrada_legado_cyber_v3_3_2.xlsx")
                                      .Select(line => line.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries))
                                      .Where(split => split.Length == 25)
                                      .Select(split => split[2])
                                      .ToList();

                }
                catch (IOException)
                {
                    //mostrar erro
                }
                Read();
                Console.ReadLine();                
            }

            else if (userValue == "2")
            {
                string message = "Digite o CPF:";
                List<int> foundValues = new List<int>();
                try
                {
                    var valores = File.ReadLines(@"C:\Users\berte.arthur\Downloads\entrada_legado_cyber_v3_3_2.xlsx")
                                      .Select(line => line.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries))
                                      .Where(split => split.Length == 25)
                                      .Select(split => split[2])
                                      .ToList();

                }
                catch (IOException)
                {
                    //mostrar erro
                }
                Read();
                Console.ReadLine();
                Console.WriteLine(message);                
            }

            else if (userValue == "3")
            {
                string message = "Digite o Grupo:";                
                List<int> foundValues = new List<int>();
                try
                {
                    var valores = File.ReadLines(@"C:\Users\berte.arthur\Downloads\entrada_legado_cyber_v3_3_2.xlsx")
                                      .Select(line => line.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries))
                                      .Where(split => split.Length == 25)
                                      .Select(split => split[2])
                                      .ToList();

                }
                catch (IOException)
                {
                    //mostrar erro
                }
                Read();
                Console.ReadLine();
                Console.WriteLine(message);
            }
            else if (userValue == "4")
            {
                string message = "Fechando a aplicação.";
                Console.WriteLine(message);
            }

        }

    public static void Read()
        {
            StreamReader readme = null;

            try
            {
                readme = File.OpenText(@"C:\Users\berte.arthur\Downloads\entrada_legado_cyber_v3_3_2.xlsx");
                Console.WriteLine(readme.ReadToEnd());
            }
            // will return an invalid file name error
            catch (FileNotFoundException errorMsg)
            {
                Console.WriteLine("Erro, " + errorMsg.Message);
            }
            // will return an invalid path error
            catch (Exception errorMsg)
            {
                Console.WriteLine("Erro, " + errorMsg.Message);
            }
            finally
            {
                if (readme != null)
                {
                    readme.Close();
                }
            }
        }
    }
}
