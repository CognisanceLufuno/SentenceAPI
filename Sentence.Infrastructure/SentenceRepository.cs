using System;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using Sentence.Application.Repositories;
using Sentence.Domain;
using Sentence.Domain.Entities;

namespace Sentence.Infrastructure
{
	public class SentenceRepository : ISentenceRepository
    {
        private readonly DBContext _dBContext;
		public SentenceRepository(DBContext dBContext)
		{
            _dBContext = dBContext;
        }

        public List<Word> GetWordsByWordType(int wordTypeId)
        {
            var words =  _dBContext.Words.Where(x => (int)x.WordTypeId == wordTypeId).ToList();
            return words;
        }

        public List<Domain.Entities.Sentence> GetSentences()
        {
            var sentences = _dBContext.Sentences.ToList();
            return sentences;
        }

        public Domain.Entities.Sentence CreateSentence(Domain.Entities.Sentence sentence)
        {
            if (sentence.DateCreated.Year == 0001)
                sentence.DateCreated = DateTime.Now;

            _dBContext.Sentences.Add(sentence);
            _dBContext.SaveChanges();
            return sentence;
        }
    }
}

