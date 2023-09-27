using System;
namespace Sentence.Domain.Entities
{
	public class Word : BaseEntity
    {
        public string Name { get; set; } = string.Empty;
        public string ShortDescription { get; set; } = string.Empty;
        public required WordType WordType { get; set; }
        public WordTypeId WordTypeId { get; set; }
    }
}