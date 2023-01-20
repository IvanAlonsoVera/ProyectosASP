using ClasesLinQ;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LinQConLibrerias
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //JOIN
            //GridView1.DataSource =
            //    (from publisher in SampleData.Publishers
            //    join book in SampleData.Books
            //    on publisher equals book.Publisher
            //    select new
            //    {
            //        publisher = publisher.Name,
            //        book = book.Title,

            //    }).ToList();
            GridView1.DataSource =
                SampleData.Publishers
                .Join(SampleData.Books,
                publisher => publisher,
                book => book.Publisher,
                (publisher, book) => new
                {
                    publisher = publisher.Name,
                    book = book.Title,

                });


            GridView1.DataBind();

            //var librosOrdenados = from book in Books.GetBooks()
            //                      orderby book.Author, book.Price descending, book.Title
            //                      select new
            //                      {
            //                          Autor = book.Author,
            //                          Precio = book.Price,
            //                          Titulo = book.Title
            //                      };
            //GridView1.DataSource = librosOrdenados;
            //GridView1.DataBind();

            //var minPrice = Books.GetBooks().Min(book=>book.Price);
            //var maxPrice = Books.GetBooks().Max(book => book.Price);
            //var totalPrice = Books.GetBooks().Sum(book => book.Price);
            //var librosBaratos = Books.GetBooks().Where(book => book.Price < 300).Count();

            //txtMin.Text=minPrice.ToString();
            //txtMax.Text=maxPrice.ToString();
            //txtTotal.Text = totalPrice.ToString();
            //txtA.Text=librosBaratos.ToString();

            //var books = Books.GetBooks().Select((book,index) => new
            //{
            //    index ,
            //    book.Title
            //}).OrderBy(book=>book.Title).ToList();

            //GridView1.DataSource = books;
            //GridView1.DataBind();

            //IEnumerable<Books> book = Books.GetBooks()
            //    .Where(b => b.Price <= 1500);
            //var books = from b in Books.GetBooks()
            //            where b.Price<=1500
            //            select b;

            //GridView1.DataSource = books;
            //GridView1.DataBind();

            //List<Books> books = Books.GetBooks();

            //var bookTitles = (from b in books
            //                 where b.Title.Length > 10
            //                 orderby b.Price
            //                 select new
            //                 {
            //                     Titulo = b.Title,
            //                     Precio = b.Price
            //                 }).ToList();
            //GridView1.DataSource = bookTitles;
            //GridView1.DataBind();

            //Book[] books =
            //{
            //    new Book{Title="Linq in action"},
            //    new Book{Title="Linq for fun"},
            //    new Book{Title="Linq Extreme"}
            //};
            //var titles = books
            //    .Where(book=>book.Title.Contains("action"))
            //    .Select(book=>book.Title);

            //GridView1.DataSource = titles;
            //GridView1.DataBind();
        }
    }
}