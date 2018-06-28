using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearningCore.Controller
{
    [Route("about")]
    public class AboutController
    {
        [Route("Phone")]
        public string Phone()
        {
            return "+49-333-3333333";
        }
        [Route("Country")]
        public string Country()
        {
            return "Germany";
        }
    }
}
