using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Sentence.Application;
using Sentence.Application.Repositories;
using Sentence.Domain.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Sentence.API.Controllers
{
    [Route("api/[controller]")]
    public class WordController : Controller
    {
        private readonly IWordService _wordService;
        public WordController(IWordService wordService)
        {
            _wordService = wordService;
        }
        // GET: api/values
        [HttpGet]
        public ActionResult<List<Word>> Get(int wordTypeId)
        {
            return Ok(_wordService.GetWordsByWordType(wordTypeId));
        }

        // POST api/values
        [HttpPost]
        public ActionResult<Word> Post(Word word)
        {
            return Ok(_wordService.CreateWord(word));
        }
    }
}

