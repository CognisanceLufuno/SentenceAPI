using System;
using Sentence.Domain;
using Sentence.Domain.Entities;

namespace Sentence.Application.Repositories
{
	public interface ISentenceService
	{
        List<Domain.Entities.Sentence> GetSentences();
        Domain.Entities.Sentence CreateSentence(Domain.Entities.Sentence sentence);
    }
}

