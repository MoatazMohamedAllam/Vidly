using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidly_MVC_Training.Models;

namespace Vidly_MVC_Training.ViewModels
{
    public class NewCustomerViewModel
    {
        public IEnumerable<MemberShipType> MemberShipTypes { get; set; }
        public Customer Customer { get; set; }
    }
}