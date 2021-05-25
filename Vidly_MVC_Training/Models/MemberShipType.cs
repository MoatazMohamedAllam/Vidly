using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vidly_MVC_Training.Models
{
    public class MemberShipType
    {
        public byte Id { get; set; }
        public string Name { get; set; }
        public short SignUpFee { get; set; }
        public byte DurationInMonths { get; set; }
        public byte DiscountRate { get; set; }

        public static readonly byte Unknown = 0;
        public static readonly byte PayAsYouGo = 1;
    }
}