using System;
using System.Collections.Generic;
using System.Text;

namespace TechJobsOO
{
    public abstract class JobField
    {
        public int Id { get; set; }
        private static int nextId = 1;
        public string Value { get; set; }

        public JobField()
        {
            Id = nextId++;
        }
        public JobField(string value)
        {
            Value = value;
        }

        public override bool Equals(object obj)
        {
            return obj is JobField field &&
                   Id == field.Id &&
                   Value == field.Value;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

        public override string ToString()
        {
            return Value;
        }
    }
}
