using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Linq
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        class person
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
        }

        public class Student
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int[] Scores { get; set; }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            //sin necesidad de class 
            var Persona = new { FirstName = "Javier", LastName = "Vazquez" };

            //ejemplo de array
            var ejemploArray = new[] {
                new {name="apple",diam=4},
                new {name="grape",diam=1},
            };
            foreach (var item in ejemploArray)
            {
                string nombre = item.name;
            }

            person person = new person() { FirstName="Javier", LastName="Vazquez"};

            List<person> friends = new List<person>()
            {
                new person {FirstName="Javier", LastName="Vazquez"},
                new person {FirstName="segundo", LastName="apsec"}
            };

            //linq
            int[] fiboNumbers = new int[] { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34 };

            var data = from n in fiboNumbers
                       where n % 2 == 0
                       select n;
            List<int> lista = data.ToList();

            for(int i = 0; i < lista.Count; i++)
            {
                Response.Write(lista[i]);
                Response.Write("</br>");
            }

            string[] words = { "pala", "palabra2", "pal", "palabr" };

            //sinLinQ
            foreach(string word in words)
            {
                if (word.Length <= 5)
                {
                    Response.Write(word);
                }
            }
            //con LinQ
            var shortWorks =
                from work in words
                where work.Length <= 5
                select words;

            ArrayList arrayList = new ArrayList();
            arrayList.Add(
                new Student
                {
                    FirstName = "Svetlana",
                    LastName = "Omelchenko",
                    Scores = new int[] { 98, 92, 81, 60 }
                });
           arrayList.Add(
               new Student
                {
                    FirstName = "Claire",
                    LastName = "O Donell",
                    Scores = new int[] { 75, 84, 91, 39 }
                });
           arrayList.Add(
               new Student
                {
                    FirstName = "Steb",
                    LastName = "Mortensen",
                    Scores = new int[] { 88, 94, 65, 91 }
                });
           arrayList.Add(
               new Student
                {
                    FirstName = "Cesar",
                    LastName = "Garcia",
                    Scores = new int[] { 97, 89, 85, 82 }
                });

            var notas = (from Student student in arrayList
                        where student.Scores[1] >= 90
                        select student).ToList();

            string aString = "ABCDE99F-J74-12-89A";

            IEnumerable<char> strinqQuery =
                (from c in aString
                where Char.IsDigit(c)
                select c).ToList();

            int count = strinqQuery.Count();

            IEnumerable<char> stringQuery2 =
                aString.TakeWhile(c => c != '-').ToList();
             
            string[] tools = { "tablesaw", "bandsaw", "planer", "jointer", "brill", "bander" };

            var toolsquery = (from tool in tools
                              select tool.ToUpper()
                              ).ToList();

            List<int> listado = new List<int>();
            listado.Add(1);
            listado.Add(22);
            listado.Add(23);
            listado.Add(65);
            listado.Add(2);
            listado.Add(12);
            
            var datalist = (from n in lista
                       where n == 3
                       select n).FirstOrDefault();

            int cantidad = lista.Count;
            int suma = listado.Sum();
            decimal media = Convert.ToDecimal(listado.Average());


            string[] Birds = { "Indigo Bunting", "Rose Breasted Grosbeak", "Robin",
                "House Finch", "Gold Finch", "Ruby Throated Hummingbird", 
                "Rufous Hummingbird", "Downy Woodpecker" };

            var BirdsR = (from b in Birds
                         where b.StartsWith("R")
                         select b).ToList();

            var BirdGold = (from b in Birds
                          where b == "Gold Finch"
                          select b).FirstOrDefault();

            var BirdAsc = (from b in Birds
                           orderby b ascending
                           select b).ToList();
        }
    }
}