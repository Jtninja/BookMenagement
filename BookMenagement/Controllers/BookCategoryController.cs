using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookMenagement.Bll.Interfaces;
using BookMenagement.Logging;
using BookMenagement.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookMenagement.Api.Controllers
{
    [Produces("application/json")]
    [Route("api/BookCategory")]
    public class BookCategoryController : Controller
    {
        private readonly IBookCategoryService _service;

        public BookCategoryController(IBookCategoryService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
               
                return Ok(_service.GetAll());
            }
            catch (Exception ex)
            {
                LoggingService.LogError(ex.Message);
                return BadRequest();
            }
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            try
            {

                return Ok(_service.GetById(id) );
            }
            catch (Exception ex)
            {
                LoggingService.LogError(ex.Message);
                return BadRequest();
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
                return BadRequest();
            }
        }

        [HttpPost]
        public IActionResult Create([FromBody]BookCategoryModel model)
        {
            try
            {
                _service.Create(model);
                return Created("",model);
            }
            catch (Exception ex)
            {
                LoggingService.LogError(ex.Message);
                return BadRequest();
            }
        }
        [HttpPut]
        public IActionResult Update([FromBody]BookCategoryModel model)
        {
            try
            {
                _service.Update(model);
                return Ok();
            }
            catch (Exception ex)
            {
                LoggingService.LogError(ex.Message);
                return BadRequest();
            }
        }

    }
}