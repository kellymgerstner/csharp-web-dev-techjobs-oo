using System;
namespace TechJobsOO
{
    public class PositionType : JobField
    {
        public PositionType(string value) : base (value)
        {
            
        }


        // TODO: Add custom Equals(), GetHashCode(), and ToString() methods.
        public override bool Equals(object toBeCompared)
        {
            if (toBeCompared == this)
            {
                return true;
            }

            if (toBeCompared == null)
            {
                return false;
            }

            if (toBeCompared.GetType() != this.GetType())
            {
                return false;
            }

            PositionType positionType = toBeCompared as PositionType;
            return positionType.Value == Value;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return "The position type is " + Value;
        }

    }
}
