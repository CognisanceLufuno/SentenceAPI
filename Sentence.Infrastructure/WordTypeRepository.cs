using System;
using Sentence.Application.Repositories;
using Sentence.Domain;
using Sentence.Domain.Entities;

namespace Sentence.Infrastructure
{
	public class WordTypeRepository : IWordTypeRepository
    {
        private readonly DBContext _dBContext;
		public WordTypeRepository(DBContext dBContext)
		{
            _dBContext = dBContext;

        }

        public List<WordType> GetWordTypes()
        {
            return _dBContext.WordTypes.ToList();
        }

        public WordType CreateWordType(WordType wordType)
        {
            _dBContext.WordTypes.Add(wordType);
            _dBContext.SaveChanges();
            return wordType;

        }
    }
}

