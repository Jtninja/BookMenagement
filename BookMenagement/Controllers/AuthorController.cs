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
    [Route("api/Author")]
    public class AuthorController : Controller
    {
        #region fields & ctr
        private readonly IAuthorService _service;
        public AuthorController(IAuthorService service)
        {
            this._service = service;
        }

        #endregion

        #region CRUD
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                List<AuthorResponse> list = _service.GetAll().Select(a => Parser.Parse(a)).ToList();
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
                AuthorResponse response = Parser.Parse(_service.GetById(id));
                return Ok(response);
            }
            catch (Exception ex)
            {
                LoggingService.LogError(ex.Message);
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public IActionResult Post([FromBody]AuthorRequest value)
        {
            try
            {
                _service.Create(Parser.Parse(value));
                return Created("", null);
            }
            catch (Exception ex)
            {
                LoggingService.LogError(ex.Message);
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        public IActionResult Put([FromBody]AuthorRequest value)
        {
            try
            {
                _service.Update(Parser.Parse(value));
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
