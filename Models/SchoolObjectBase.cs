using System;

namespace platziNetCore.Models
{
    public abstract class SchoolObjectBase
    {
        public string Id { get; set; }
        public virtual string Name { get; set; }

        public SchoolObjectBase() 
        {
            Id = Guid.NewGuid().ToString();
        }

        public override string ToString() 
        {
            return $"{Name}, {Id}";
        }
    }
}