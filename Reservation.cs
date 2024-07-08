using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment10._1
{
    internal class Reservation
    {

        int customerID {  get; set; }
        DateOnly DateOnly { get; set; }
        TimeOnly TimeOnly { get; set; }
        int Adults { get; set; }
        int Kids { get; set; }
    }
}
