using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JobSeekingNetCore.Models.DB;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JobSeekingNetCore.Controllers
{
  
    [ApiController]
    [Route("api/[controller]")]
    public class UTEJob_JobsController : ControllerBase
    {
        JobSeekingContext db = new JobSeekingContext();
       [HttpGet]
        public IEnumerable<UtesysComboboxList> Get()
        {
            var x = db.UtesysComboboxLists.Select(p => p).ToList();
            return x;
        }
    }
}
