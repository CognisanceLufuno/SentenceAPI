using System;
using Sentence.Application.Repositories;
using Sentence.Domain;
using Sentence.Domain.Entities;

namespace Sentence.Application
{
	public class SentenceService : ISentenceService
    {
        private readonly ISentenceRepository _sentenceRepository;

        public SentenceService(ISentenceRepository sentenceRepository)
		{
            _sentenceRepository = sentenceRepository;
		}

        public Domain.Entities.Sentence CreateSentence(Domain.Entities.Sentence sentence)
        {
            _sentenceRepository.CreateSentence(sentence);
            return sentence;
        }

        public List<Domain.Entities.Sentence> GetSentences()
        {
            var sentence = _sentenceRepository.GetSentences();
            return sentence;
        }
    }
}

