using System;
namespace TechJobsOO
{
    public class PositionType : JobField
    {
        /*public int Id { get; }
        private static int nextId = 1;
        public string Value { get; set; }*/

        /*public PositionType()
        {
            Id = nextId;
            nextId++;
        }*/

        /*public PositionType(string value) : this()
        {
            Value = value;
        }*/
        public PositionType(string value) : base(value)
        {
            Value = value;
        }

        /*public override string ToString()
        {
            return Value;
        }

        public override bool Equals(object obj)
        {
            return obj is PositionType type &&
                   Id == type.Id &&
                   Value == type.Value;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Value);
        }*/

        // TODO: Add custom Equals(), GetHashCode(), and ToString() methods.
    }
}
