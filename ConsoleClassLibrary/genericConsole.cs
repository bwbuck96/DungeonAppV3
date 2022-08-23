using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleClassLibrary
{
    public class genericConsole
    {
        //fields

        //props
        public string Text { get; set; }
        public Enum Color { get; set; }

        //ctors

        public genericConsole(Enum color, string text)
        {
            Color = color;
            Text = text;
        }

        //methods


    }
}
