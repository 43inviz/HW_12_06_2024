using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_12_06_2024
{
    /// <summary>
    /// Створіть додаток «Список книг до прочитання». Додаток
   // має дозволяти додавати книги до списку, видаляти книги
    //зі списку, перевіряти чи є книга у списку, і т.д.Використовуйте механізм властивостей, навантаження операторів,
    //індексаторів. 

    /// </summary>
    internal class Bookshelf
    {
        public Book[] BookArr {  get; set; }
        private int _size;
        

        public Bookshelf() {
            BookArr = new Book[1];

        }


        public Book this[int index]
        {
            get
            {
                if(index > 0 && index < BookArr.Length)
                {
                    return BookArr[index];
                }
                else
                {
                    throw new Exception("Invalid index\n");
                }

               
            }
            set
            {
                if (index > 0 && value != null)
                {
                    BookArr[index] = value;
                }
                else 
                {
                    throw new Exception("Invalid index\n");
                }
            }
        }

        

        public void addBookOnShelf(Book book,int index)
        {
            BookArr[index] = book;
        }

        //public int getSearchedIndex(Book book)
        //{
        //    int index;
        //    for(int i = 0; i < BookArr.Length; i++)
        //    {
        //        index = i;
        //        if (BookArr[i] == book)
        //        {
        //            return i;
        //        }
        //    }
        //}

        public int getIndexOfBook(Book book) {

            for (int i = 0; i < BookArr.Length; i++)
            {
                if (BookArr[i] == book)
                {
                    return i;
                }

            }   

            return -1;
        }

        public void removeBookFromShelf(Book book)
        {
            if (!isBookOnShelf(book))
            {
                throw new Exception("Cant find book on shelf\n");
            }
            else
            {
                Book[] arr = new Book[BookArr.Length];
                int index = getIndexOfBook(book);
                if(index!= -1)
                {
                    for(int i = 0; i < BookArr.Length-1; i++)
                    {
                        if(i > index)
                        {
                            arr[i] = BookArr[i];
                        }
                        else if(i <= index)
                        {
                            arr[i] = BookArr[i + 1];
                        }
                    }
                }

                BookArr = arr;
            }
        }

        

        public bool isBookOnShelf(Book book)
        {
            foreach(Book book1 in BookArr)
            {
                if (book1 == book)
                {
                    return true;
                }
            }

            return false;
        }

        public void showShelf()
        {
            foreach(Book book in BookArr)
            {
                Console.WriteLine(book);
            }
        }

        
    }
}
