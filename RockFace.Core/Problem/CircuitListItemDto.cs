using RockFace.Core.Base;

namespace RockFace.Core.Problem
{
    public class CircuitListItemDto : BaseEntity
    {
        public int LocationId { get; set; }

        public string Colour { get; set; }

        public string Description { get; set; }

        public Grade MinimumGrade { get; set; }

        public Grade MaximumGrade { get; set; }

        public string GradeDescription
        {
            get
            {
                if (MinimumGrade == null && MaximumGrade == null)
                {
                    return "";
                }

                if (MinimumGrade == null)
                {
                    return MaximumGrade.ToString();
                }

                if (MaximumGrade != null)
                {
                    return !Equals(MinimumGrade, MaximumGrade)
                        ? $"{MinimumGrade}-{MaximumGrade}"
                        : MinimumGrade.ToString();
                }

                return MinimumGrade.ToString();
            }
        }

        public override string ToString()
        {
            return $"{Id}: {LocationId} {Colour ?? Description} {GradeDescription}";
        }
    }
}