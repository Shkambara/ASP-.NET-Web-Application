using KolokwiumWEB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KolokwiumWEB.ViewModels
{
    public class PeopleIndexViewModel
    {
        public IEnumerable<Person> People { get; set; }
        public IEnumerable<Models.Rabat> Rabats { get; set; }

        public Person Person { get; set; }

        public IEnumerable<SelectListItem> RabatsSelectList
        {
            get
            {
                return Rabats?.Select(t => new SelectListItem
                {
                    Value = t.IdRabat.ToString(),
                    Text = t.Name
                }) ?? new List<SelectListItem>();
            }
        }

    }
}