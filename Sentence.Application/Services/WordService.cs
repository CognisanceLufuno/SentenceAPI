using System;
using Sentence.Application.Repositories;
using Sentence.Domain;
using Sentence.Domain.Entities;

namespace Sentence.Application
{
	public class WordService : IWordService
	{
        private readonly IWordRepository _wordRepository;

        public WordService(IWordRepository wordRepository)
		{
            _wordRepository = wordRepository;
		}

        public Word CreateWord(Word word)
        {
            _wordRepository.CreateWord(word);
            return word;
        }

        public List<Word> GetWordsByWordType(int wordTypeId)
        {
            var words = _wordRepository.GetWordsByWordType(wordTypeId);
            return words;
        }
    }
}

