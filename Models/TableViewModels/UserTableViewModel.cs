using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCCrud1.Models.TableViewModels
{
    public class UserTableViewModel
    {
        public long Id { get; set; }
        public string Email { get; set; }
        public int? Edad { get; set; }
    }
}