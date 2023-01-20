using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using static Linq.Ej1Linq;
using static Linq.WebForm2;

namespace Linq
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        public class Contact
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Email { get; set; }
            public string Phone { get; set; }
            public DateTime DateOfBirth { get; set; }
            public string State { get; set; }
            public static List<Contact> crearlista()
            {
                List<Contact> contacts = new List<Contact>()
                    {
                        new Contact {FirstName="Alvaro", LastName="Garcia", Email="Alvaro@gmail.com", Phone="653498623", DateOfBirth=Convert.ToDateTime("12/02/1998"), State="AL"},
                        new Contact {FirstName="Pepe", LastName="Alonso", Email="Pepe@gmail.com", Phone="526826526", DateOfBirth=Convert.ToDateTime("27/01/1980"), State="ST"},
                        new Contact {FirstName="Natalia", LastName="Redondo", Email="Natalia@gmail.com", Phone="625895559", DateOfBirth=Convert.ToDateTime("04/04/2003"), State="AL"},
                        new Contact {FirstName="Lucia", LastName="Perez", Email="Lucia@gmail.com", Phone="654169845", DateOfBirth=Convert.ToDateTime("22/12/2000"), State="UK"},

                    };
                return contacts;
            }

        }
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Contact> contacts = Contact.crearlista();

            var Apellidos = (from c in contacts
                             orderby c.LastName
                             select c).ToList();

            var ApellidosLambda= contacts.OrderBy(c => c.LastName).Select(c=>c);

            var EmpiezaA = (from c in contacts
                            where c.FirstName.StartsWith("A")
                            select c).ToList();

            var EmpiezaALambda = contacts.Where(c => c.FirstName.StartsWith("A")).Select(c => c);

            var Email = (from c in contacts
                         where c.Email == "Natalia@gmail.com"
                         select c).ToList();

            var EmailLambda = (from c in contacts
                              where c.State=="AL" && c.Phone== "653498623"
                              select c).ToList();
            Response.Write("---------------APELLIDOS---------------");
            Response.Write("</br>");
            foreach (var contact in Apellidos)
            {
                Response.Write(contact.LastName);
                Response.Write(contact.FirstName);
                Response.Write("</br>");
            }
            foreach (var contact in ApellidosLambda)
            {
                Response.Write(contact.LastName);
                Response.Write(contact.FirstName);
                Response.Write(contact.DateOfBirth.ToShortDateString());
                Response.Write("</br>");
            }
            Response.Write("---------------Empieza por A---------------");
            Response.Write("</br>");
            foreach (var contact in EmpiezaA)
            {
                Response.Write(contact.FirstName);
                Response.Write("</br>");
            }
            foreach (var contact in EmpiezaALambda)
            {
                Response.Write(contact.FirstName);
                Response.Write("</br>");
            }
            Response.Write("---------------Email---------------");
            Response.Write("</br>");
            foreach (var contact in Email)
            {
                Response.Write(contact.Email);
                Response.Write(contact.FirstName);
                Response.Write("</br>");
            }
            foreach (var contact in EmailLambda)
            {
                Response.Write(contact.Email);
                Response.Write(contact.FirstName);
                Response.Write("</br>");
            }









            int[] nums = new int[] { 0, 4, 2, 6, 3, 8, 3, 4, 1 };
            var result = (from n in nums
                         where n < 5
                         orderby n
                         select n).ToList();
            //lambda
            var resultLambda = nums.Where(n => n < 5).OrderByDescending(n => n).Select(n => n).ToList();

            int resultadoSuma = nums.Sum();

            var resultadoSinRepetir5= (from n in nums
                                      where n < 5
                                      orderby n
                                      select n).Distinct().ToList();

            var resultadoSinRepetirLambda= nums.Where(n => n < 5).OrderBy(n=> n).Select(n => n).Distinct().ToList();
        }
    }
}