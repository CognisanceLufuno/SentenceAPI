using System;
using Sentence.Domain;
using Sentence.Domain.Entities;

namespace Sentence.Application
{
	public interface IWordService
	{
        List<Word> GetWordsByWordType(int wordTypeId);
        Word CreateWord(Word word);
    }
}

