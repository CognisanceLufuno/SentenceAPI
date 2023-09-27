using System;
namespace Sentence.Domain
{
	public abstract class BaseEntity
	{
        public int Id { get; set; }
        public DateTimeOffset DateCreated { get; set; }
    }
}
