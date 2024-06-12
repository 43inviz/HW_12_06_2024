using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_12_06_2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //WorkJournal journal = new WorkJournal("Blo","Blo",200);
                //WorkJournal journal1 = new WorkJournal("Vlo", "Vlo", 300);

                ////int result =  journal + 20;
                //bool result = journal == journal1;

                //Console.WriteLine(result);

                Bookshelf bookshelf = new Bookshelf();
                Book book = new Book("VLO", "ALO");

                bookshelf.addBookOnShelf(book, 0);




                bookshelf.showShelf();
                //Console.WriteLine("After delete book: \n");
                //bookshelf.removeBookFromShelf(book);
                //bookshelf.showShelf();

                bool result = bookshelf.isBookOnShelf(book);
                Console.WriteLine($"RESULT: {result}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();

        }
    }
}
