using System.Data.Common;

namespace LIST_STRUCTURE
{
    internal class Program
    {
        public class sehır : IComparable<sehır>
        {
            public int plaka_NO { get; set; }
            public string sehır_ADI { get; set; }
            public sehır(int plaka_NO, string sehır_ADI)
            {
                this.plaka_NO = plaka_NO;
                this.sehır_ADI = sehır_ADI;
            }

            public override string? ToString()
            {
                return $"{plaka_NO,-5} - {sehır_ADI,5}"; 
            }

            int IComparable<sehır>.CompareTo(sehır? other)
            {
                if (this.plaka_NO < other.plaka_NO)
                {
                    return -1;
                }
                else if (this.plaka_NO == other.plaka_NO)
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        static void Main(string[] args)
        {
            //LİST 

            var sayılar=new List<int>() {45,85,76,752,5445,545,5121,2121,12,10,45};

            sayılar.Sort();
            sayılar.ForEach(a  => Console.WriteLine(a));

            //ŞEHİR LİSTESİ

            var sehırler=new List<sehır>()
            {
                new sehır(6, "ankara"),
                new sehır(34, "istanbul"),
                new sehır(50, "nevsehır"),
                new sehır(35, "izmir"),
                new sehır(51, "niğde"),
            };
            sehırler.Add(new sehır(1,"adana"));
            sehırler.Sort();
            Console.WriteLine();
            sehırler.ForEach(a => Console.WriteLine(a));




            Console.ReadLine();
        }
    }
}
