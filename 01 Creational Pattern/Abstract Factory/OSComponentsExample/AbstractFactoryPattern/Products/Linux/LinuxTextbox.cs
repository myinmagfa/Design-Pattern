using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactoryPattern.Factory;

namespace AbstractFactoryPattern.Products.Linux
{
    public class LinuxTextbox:ITextbox {
        public void Render()
        {
            Console.WriteLine("Rendering Linux Textbox.");
        }
    }
}
