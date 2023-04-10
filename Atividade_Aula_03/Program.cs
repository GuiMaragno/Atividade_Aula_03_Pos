using System;

namespace Atividade_Aula_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Atividade_Aula_03.Objects.Person person = new Atividade_Aula_03.Objects.Person();

            person.Code = TextView.GetCode();

            person.Name = TextView.GetName();

            person.Address = TextView.GetAddress();

            person.City = TextView.GetCity();

            person.CEP = TextView.GetCEP();

            person.Email = TextView.GetEmail();

            person.Paycheck = TextView.GetPaycheck();

            int timeExtra = TextView.GetExtra();

            TextView.ShowPaycheck(Caculator.Extra(person.Paycheck, timeExtra));

            Console.ReadKey();
        }
    }
}
