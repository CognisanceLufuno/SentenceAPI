using System;
using System.ComponentModel.DataAnnotations;

namespace Sentence.Domain.Entities
{
	public class WordType
    {
        [Key]
        public WordTypeId WordTypeId { get; set; }
        public string Name { get; set; } = string.Empty;
        public List<Word> Words { get; set; } = new List<Word>();
    }

    public enum WordTypeId : int
    {
        Noun = 1,
        Verb = 2,
        Adjective = 3,
        Adverb = 4,
        Pronoun = 5,
        Prepositions = 6,
        Conjunction = 7,
        Determiner = 8,
        Exclamation = 9
    }
}
