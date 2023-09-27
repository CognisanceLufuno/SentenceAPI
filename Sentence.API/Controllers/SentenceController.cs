using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Sentence.Application;
using Sentence.Application.Repositories;
using Sentence.Domain;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Sentence.API.Controllers
{
    [Route("api/[controller]")]
    public class SentenceController : Controller
    {
        private readonly ISentenceService _sentenceService;
        public SentenceController(ISentenceService sentenceService)
        {
            _sentenceService = sentenceService;
        }
        // GET: api/values
        [HttpGet]
        public ActionResult<List<Domain.Entities.Sentence>> Get()
        {
            return Ok(_sentenceService.GetSentences());
        }

        [HttpPost]
        public ActionResult<Domain.Entities.Sentence> Post([FromBody] Domain.Entities.Sentence sentence)
        {
            var Sentence = _sentenceService.CreateSentence(sentence);
            return Ok(sentence);
        }
    }
}
