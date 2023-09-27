using System;
using Sentence.Domain;
using Sentence.Domain.Entities;

namespace Sentence.Application.Repositories
{
    public interface IWordRepository
    {
        List<Word> GetWordsByWordType(int wordTypeId);
        Word CreateWord(Word word);
    }
}

