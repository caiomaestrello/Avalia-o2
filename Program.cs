using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avaliação2
{
    internal class Program
    {
        private static string Mes_extenso(int mm)
        {
            string dt_ext = null;
            switch (mm)
            {
                case 1:
                    dt_ext = "Janeiro ";
                    break;
                case 2:
                    dt_ext = "Fevereiro ";
                    break;
                case 3:
                    dt_ext = "Março ";
                    break;
                case 4:
                    dt_ext = "Abril ";
                    break;
                case 5:
                    dt_ext = "Maio ";
                    break;
                case 6:
                    dt_ext = "Junho ";
                    break;
                case 7:
                    dt_ext = "Julho ";
                    break;
                case 8:
                    dt_ext = "Agosto ";
                    break;
                case 9:
                    dt_ext = "Setembro ";
                    break;
                case 10:
                    dt_ext = "Outubro ";
                    break;
                case 11:
                    dt_ext = "Novembro ";
                    break;
                case 12:
                    dt_ext = "Dezembro ";
                    break;

            }
            return dt_ext;


        }
        static void Main(string[] args)
        {
            string cid = null;
            int cidade, dd, mm, aa;


            Console.WriteLine("Olá, escolha uma das cidades abaixo:\n\n1 - ATIBAIA \n2 - BRAGANÇA PAULISTA \n3 - MAIRIPORÃ \n4 - NAZARÉ \n5 - TERRA PRETA \n6 - EXTREMA \n7 - VARGEM");
            Console.WriteLine("-------------------------------------");
            cidade = Convert.ToInt32(Console.ReadLine());
            if (cidade < 1 || cidade > 7)
            {
                Console.WriteLine("Digite um valor de 1-7 para as cidades.");
                Console.ReadKey();
            }
            else
            {
                Console.Write("Informe uma data com o formato dd/mm/aaaa:");
                var dt = Convert.ToDateTime(Console.ReadLine());

                dd = dt.Day;
                mm = dt.Month;
                aa = dt.Year;

                switch (cidade)
                {
                    case 1:
                        cid = "Atibaia";
                        break;
                    case 2:
                        cid = "Bragança Paulista";
                        break;
                    case 3:
                        cid = "Mairiporã";
                        break;
                    case 4:
                        cid = "Nazaré";
                        break;
                    case 5:
                        cid = "Terra Preta";
                        break;
                    case 6:
                        cid = "Extrema";
                        break;
                    case 7:
                        cid = "Vargem";
                        break;
                }
                Console.WriteLine(cid + ", " + dd + " de " + Mes_extenso(mm) + "de " + aa);
                Console.ReadKey();
            }

        }
    }
}