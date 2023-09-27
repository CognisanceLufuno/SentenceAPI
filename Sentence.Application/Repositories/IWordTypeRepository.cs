using System;
using Sentence.Domain;
using Sentence.Domain.Entities;

namespace Sentence.Application.Repositories
{
    public interface IWordTypeRepository
    {
        List<WordType> GetWordTypes();
        WordType CreateWordType(WordType word);
    }
}

