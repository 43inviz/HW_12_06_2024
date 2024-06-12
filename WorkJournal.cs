using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_12_06_2024
{
    internal class WorkJournal
    {

        //клас «Журнал». Додайте до вже створеного класу
        //інформацію про кількість працівників.Виконайте навантаження операторiв
        public string Title { get; set; }
        public string PublYear { get; set; }

        public int CountOfEmployee { get; set; }

        public WorkJournal() { }
        public WorkJournal(string title, string publYear, int countOfEmployee)
        {
            Title = title;
            PublYear = publYear;
            CountOfEmployee = countOfEmployee;
        }

        public static int operator+(WorkJournal left, int right)
        {
            left.CountOfEmployee += right;
            return left.CountOfEmployee;
        }

        public static int operator-(WorkJournal left, int right)
        {
            left.CountOfEmployee -= right;
            return left.CountOfEmployee;
        }


        public static bool operator ==(WorkJournal left, WorkJournal right)
        {
            return left.CountOfEmployee == right.CountOfEmployee;
        }

        public static bool operator !=(WorkJournal left, WorkJournal right)
        {
            return left.CountOfEmployee!= right.CountOfEmployee;
        }

        public static bool operator <(WorkJournal left, WorkJournal right)
        {
            return left.CountOfEmployee < right.CountOfEmployee;

        }


        public static bool operator >(WorkJournal left, WorkJournal right)
        {
            return left.CountOfEmployee > right.CountOfEmployee;
        }

        public override bool Equals(object obj)
        {
            if(this.CountOfEmployee!= ((obj as WorkJournal).CountOfEmployee)){
                return false;
            }
            return true;
        }
    }
}
