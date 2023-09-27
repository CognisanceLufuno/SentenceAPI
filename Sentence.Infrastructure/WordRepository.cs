using System;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using Sentence.Application.Repositories;
using Sentence.Domain;
using Sentence.Domain.Entities;

namespace Sentence.Infrastructure
{
	public class WordRepository : IWordRepository
    {
        private readonly DBContext _dBContext;
		public WordRepository(DBContext dBContext)
		{
            _dBContext = dBContext;

        }

        public List<Word> GetWordsByWordType(int wordTypeId)
        {
            var words =  _dBContext.Words.Where(x => (int)x.WordTypeId == wordTypeId).ToList();
            return words;
        }

        public Word CreateWord(Word word)
        {
            _dBContext.Words.Add(word);
            _dBContext.SaveChanges();
            return word;
        }
    }
}

