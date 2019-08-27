using System.Collections.Generic;
using DAL.Interface;
using Microsoft.AspNetCore.Mvc;

namespace CoreDI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly IValueRepository _valueRepository;
        public ValuesController(IValueRepository valueRepository)
        {
            _valueRepository = valueRepository;
        }
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
            => _valueRepository.GetValues();
    }
}
