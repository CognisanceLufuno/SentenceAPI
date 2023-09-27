using System;
using Sentence.Application.Repositories;
using Sentence.Domain;
using Sentence.Domain.Entities;

namespace Sentence.Application
{
	public class WordTypeService : IWordTypeService
	{
        private readonly IWordTypeRepository _wordTypeRepository;

        public WordTypeService(IWordTypeRepository wordTypeRepository)
		{
            _wordTypeRepository = wordTypeRepository;
		}

        public WordType CreateWordType(WordType wordType)
        {
            _wordTypeRepository.CreateWordType(wordType);
            return wordType;
        }

        List<WordType> IWordTypeService.GetWordsTypes()
        {
            var wordtypes = _wordTypeRepository.GetWordTypes();
            return wordtypes;
        }
    }
}

