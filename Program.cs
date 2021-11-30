using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaDiscurciva
{
    class Program
    {
        static void Main(string[] args)
        {
            Intro();
            Jovem j = new Jovem();
            j.HomensTrab();
            j.HomensNaoTrab();
            j.MulhesTrab();
            j.MulhesNaoTrab();
            Calculo();
            Console.ReadLine();

        }

        static void Intro()
        {
            Console.WriteLine(" Prova Discurciva da Matéria de Programação Orintada a Objeto!!!\n");
            Console.WriteLine("Aluno: Leonardo Gattis Boratti");
            Console.WriteLine("\n");
        }
        static void Calculo()
        {
            float HomensTrab, MulheresTrab, naoTrabMulheres, naoTrabHomens, Total;
            float PerceHomensTrab, PerceHomensNao, PerceMulheresTrab, PerceMulheresNao;


            HomensTrab = 19.1f;

            MulheresTrab = 7.6f;

            naoTrabMulheres = 13.05f;

            naoTrabHomens = 8.8f;


            Total = HomensTrab + MulheresTrab + naoTrabHomens + naoTrabMulheres;
            PerceHomensTrab = HomensTrab / Total * 100;
            PerceMulheresTrab = MulheresTrab / Total * 100;
            PerceHomensNao = naoTrabHomens / Total * 100;
            PerceMulheresNao = naoTrabMulheres / Total * 100;

           
            Console.WriteLine("A porcentagem de Homens que trabalham é " + PerceHomensTrab + "%");
            Console.WriteLine("A porcentangem de Mulheres que trabalham é " + PerceMulheresTrab + "%");
            Console.WriteLine("A porcentagem de Homens que Não trabalham é " + PerceHomensNao + "%");
            Console.WriteLine("A porcentangem de Mulheres que Não trabalham é " + PerceMulheresNao + "%");
        }

    }
}
