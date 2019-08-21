using System.Collections.Generic;
using Biblioteca.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace Biblioteca.API.Controllers
{
    [Route("api/books")]
    public class BooksController : Controller
    {
        [HttpGet()]
        public JsonResult GetBooks()
        {
            return new JsonResult(BooksDataStore.Current.Books);
        }

    }
}