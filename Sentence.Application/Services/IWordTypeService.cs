using System;
using Sentence.Domain;
using Sentence.Domain.Entities;

namespace Sentence.Application
{
	public interface IWordTypeService
	{
        List<WordType> GetWordsTypes();
        WordType CreateWordType(WordType wordType);
    }
}

