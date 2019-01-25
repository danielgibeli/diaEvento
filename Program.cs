using System;

namespace diaevento
{
    class Program
    {
        static void Main(string[] args)
        {
            string dia, ponto;
            int diaInicio, diaFim, hhi, mmi, ssi, hhf, mmf, ssf;

            string[] vet;
            vet = Console.ReadLine().Split(' ');
            dia = vet[0];
            diaInicio = int.Parse(vet[1]);
            vet = Console.ReadLine().Split(' ');
            hhi = int.Parse(vet[0]);
            mmi = int.Parse(vet[4]);
            ssi = int.Parse(vet[8]);
            ponto = vet[2];
            ponto = vet[6];

            vet = Console.ReadLine().Split(' ');
            dia = vet[0];
            diaFim = int.Parse(vet[1]);
            vet = Console.ReadLine().Split(' ');
            hhf = int.Parse(vet[0]);
            mmf = int.Parse(vet[4]);
            ssf = int.Parse(vet[8]);
            ponto = vet[2];
            ponto = vet[6];

            Console.WriteLine(dia + diaInicio);
            Console.WriteLine(hhi + " : " + mmi + " : " + ssi);
            Console.WriteLine(dia + diaFim);
            Console.WriteLine(hhf + " : " + mmf + " : " + ssf);



        }
    }
}
