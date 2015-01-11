namespace DataStructuresReview
{
    using System;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;


    class Program
    {
        static void Main()
        {
            System.Collections.Generic.List<int> realList = new System.Collections.Generic.List<int>();
            
            List<int> list = new List<int>();
            list.Add(10);
            list.Add(11);
            list.Add(12);
            list.Add(13);
            list.Add(14);
            list.Add(15);

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
