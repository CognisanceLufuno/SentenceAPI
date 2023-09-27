using System;
namespace Sentence.Domain.Entities
{
	public class Sentence : BaseEntity
    {
        public string Text { get; set; } = string.Empty;
        public ICollection<Word> WordsList { get; set; } = new List<Word>();
    }
}

