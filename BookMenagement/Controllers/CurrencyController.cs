using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookMenagement.Api.DTO;
using BookMenagement.Api.Helpers;
using BookMenagement.Bll.Interfaces;
using BookMenagement.Logging;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookMenagement.Api.Controllers
{
    [Produces("application/json")]
    [Route("api/Currency")]
    public class CurrencyController : Controller
    {
        #region fields & ctr
        private readonly ICurrencyService _service;

        public CurrencyController(ICurrencyService service)
        {
            _service = service;
        }
        #endregion

        #region CRUD
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                List<CurrencyResponse> list = _service.GetAll().Select(a => Parser.Parse(a)).ToList();
                return Ok(list);
            }
            catch (Exception ex)
            {
                LoggingService.LogError(ex.Message);
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            try
            {
                var model = _service.GetById(id);
                return Ok(Parser.Parse(model));
            }
            catch (Exception ex)
            {
                LoggingService.LogError(ex.Message);
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public IActionResult Post([FromBody] CurrencyRequest model)
        {
            try
            {
                _service.Create(Parser.Parse(model));
                return Created("", null);
            }
            catch (Exception ex)
            {
                LoggingService.LogError(ex.Message);
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        public IActionResult Put([FromBody]CurrencyRequest model)
        {
            try
            {
                _service.Update(Parser.Parse(model));
                return Ok();
            }
            catch (Exception ex)
            {
                LoggingService.LogError(ex.Message);
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                _service.Delete(id);
                return NotFound();
            }
            catch (Exception ex)
            {
                LoggingService.LogError(ex.Message);
                return BadRequest(ex.Message);
            }
        }
        #endregion
    }
}
