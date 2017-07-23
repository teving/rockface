namespace RockFace.Core.Problem
{
    public class HuecoGrade : Grade
    {
        public int Number { get; set; }

        public override string ToString()
        {
            return $"V{Number}";
        }
    }
}