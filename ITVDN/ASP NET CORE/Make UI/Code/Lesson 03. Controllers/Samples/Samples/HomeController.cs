using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Samples
{
    // Каждый public класс имя которого заканчивается на Controller является контроллером
    // Каждый public метод в таком классе является методом действия
    public class HomeController 
    {
        public string Index() => "Hello world";
    }
}
