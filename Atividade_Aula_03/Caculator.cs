namespace Atividade_Aula_03
{
    public class Caculator
    {
        public static float Extra(float paycheck, int timeExtra)
        {
            return (float)((paycheck + ((paycheck / 220) * timeExtra)) * 0.85);
        }
    }
}
