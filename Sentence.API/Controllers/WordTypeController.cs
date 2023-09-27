using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Sentence.Application;
using Sentence.Domain.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Sentence.API.Controllers
{
    [Route("api/[controller]")]
    public class WordTypeController : Controller
    {
        private readonly IWordTypeService _wordTypeService;
        public WordTypeController(IWordTypeService wordTypeService)
        {
            _wordTypeService = wordTypeService;
        }

        [HttpGet]
        public ActionResult<WordType> Get()
        {
            return Ok(_wordTypeService.GetWordsTypes());
        }

        [HttpPost]
        public ActionResult<WordType> Post(WordType wordType)
        {
            return Ok(_wordTypeService.CreateWordType(wordType));
        }
    }
}

