using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomePage.Components
{
    public class TestViewComponent : ViewComponent
    {
        public string Invoke()
        {
            return "Hellllooooo";
        }
    }
}
