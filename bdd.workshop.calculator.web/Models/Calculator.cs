using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bdd.workshop.calculator.web.Models
{
    public class Calculator
    {
        public Number A { get; set; } = new Number();
        public Number B { get; set; } = new Number();
        public string Command { get; set; }

    }
}
