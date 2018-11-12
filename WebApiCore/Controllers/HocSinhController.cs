using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApiCore.DataProvider;
using WebApiCore.Helper;
using WebApiCore.Models;

namespace WebApiCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HocSinhController : ControllerBase
    {
        public readonly IHocSinhProvider hsProvider;

        public HocSinhController(IHocSinhProvider hsDataProvider)
        {
            this.hsProvider = hsDataProvider;
        }
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<HocSinh>> Get()
        {
            var lstData = hsProvider.getAllHocSinh();
            Common com = new Common();
            var response = com.ResponseAPI(lstData);
            return Ok(response);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<HocSinh> Get(int id)
        {
            var lst = hsProvider.getHocSinh(id);
            ResponseModal response = new ResponseModal();
            response.Status = "OK";
            response.ResponseData = lst;
            return Ok(response);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] HocSinh hs)
        {
            hsProvider.CreateHocSinh(hs);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            hsProvider.DeleteHocSinh(id);
        }
    }
}
