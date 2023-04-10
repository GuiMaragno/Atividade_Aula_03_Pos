using System;

namespace Atividade_Aula_03
{
    /// <summary>
    /// TODO
    ///     -> Verificaçao da validade dos dados inseridos!
    /// </summary>

    public class TextView
    {
        public static string GetCode()
        {
            Console.Write("Informe o Código: ");
            return Console.ReadLine();
        }

        public static string GetName()
        {
            Console.Write("Informe o Nome: ");
            return Console.ReadLine();
        }

        public static string GetAddress()
        {
            Console.Write("Informe o Endereço: ");
            return Console.ReadLine();
        }

        public static string GetCity()
        {
            Console.Write("Informe a Cidade: ");
            return Console.ReadLine();
        }

        public static string GetCEP()
        {
            Console.Write("Informe o CEP: ");
            return Console.ReadLine();
        }

        public static string GetEmail()
        {
            Console.Write("Informe o E-mail: ");
            return Console.ReadLine();
        }

        public static float GetPaycheck()
        {
            Console.Write("Informe o Salário: ");
            return float.Parse(Console.ReadLine().Replace('.', ','));
        }

        public static int GetExtra()
        {
            Console.Write("Informe a Quantidade de Horas Extras (em horas): ");
            return int.Parse(Console.ReadLine());
        }

        public static void ShowPaycheck(float value)
        {
            Console.Write($"O Valor que deverá ser recebido é de: R${value.ToString("F2")}");
        }
    }
}
