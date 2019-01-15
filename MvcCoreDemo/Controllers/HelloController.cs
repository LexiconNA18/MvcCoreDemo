using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MvcCoreDemo.Controllers
{
    public class HelloController : Controller
    {
        public IActionResult Index(int? age, string id = "Index")
        {
            //var ret = $"Hello {id}!";
            //if (age != null) ret += $" You don't look one day older than {age - 1}!";
            //return HtmlEncoder.Default.Encode(ret);

            //ViewData["name"] = id;
            //if (age != null) ViewData["compliment"] = $" You don't look one day older than {age - 1}!";
            //else ViewData["insult"] = $"You old hag!";

            var person = new Person(id, age);
            return View(person);
        }

        public IActionResult World()
        {
            return View("Index", new Person());
        }
    }

    public class Person
    {
        public string Name;
        public int? Age;

        public Person() { }

        public Person(string name, int? age)
        {
            Name = name;
            Age = age;
        }
    }
}