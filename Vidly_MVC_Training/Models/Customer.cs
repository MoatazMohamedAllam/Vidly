using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vidly_MVC_Training.Models
{
    public class Customer
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public bool IsSubscribedToNewLetter { get; set; }

        public MemberShipType MemberShipType { get; set; }

        public byte MemberShipTypeId { get; set; }

        [Min18YearsIfAMember]
        public DateTime? BirthDate { get; set; }
    }
}