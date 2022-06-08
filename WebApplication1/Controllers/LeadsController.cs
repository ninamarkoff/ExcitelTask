using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Excitel.Data;
using Excitel.Data.EFCore;
using Excitel.Models;
using Excitel.Data.FileRepository;

namespace Excitel.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class LeadsController : BaseController<Lead, EFCoreLeadRepository>
    {
        public LeadsController(EFCoreLeadRepository repository) : base(repository)
        {
        }
    }
}
