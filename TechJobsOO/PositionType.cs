using System;
namespace TechJobsOO
{
    public class PositionType : JobField
    {
        public PositionType(string value) : base(value)
        {
            Value = value;
        }



        
        public override bool Equals(object obj)
        {
            return obj is PositionType positionType &&
                   Id == positionType.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

        public override string ToString()
        {
            return "Position Type: " + Value;
        }
    }
}