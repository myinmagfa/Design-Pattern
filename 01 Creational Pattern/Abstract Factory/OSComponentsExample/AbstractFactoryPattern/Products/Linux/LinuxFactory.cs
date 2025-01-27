using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactoryPattern.Factory;

namespace AbstractFactoryPattern.Products.Linux
{
    public class LinuxFactory:IUiFactory
    {
        public IButton CreateButton()
        {
            return new LinuxButton();
        }

        public ICheckbox CreateCheckbox()
        {
            return new LinuxCheckbox();
        }

        public ITextbox CreateTextBox()
        {
            return new LinuxTextbox();
        }
    }
}
