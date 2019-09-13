using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Site.Data;

namespace Site.Controllers
{
    [Route("api/[controller]/{id}")]
    [ApiController]
    public class PostalCodesController : ControllerBase
    {
        private readonly IPostalCodesRepository _postalCodesRepository;

        public PostalCodesController(IPostalCodesRepository postalCodesRepository)
        {
            _postalCodesRepository = postalCodesRepository;
        }

        [HttpGet]
        public async Task<string> Get(int id) => await _postalCodesRepository.Get(id);
    }
}
