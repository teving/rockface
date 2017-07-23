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

                if (MinimumGrade != null)
                {
                    if (MaximumGrade != null)
                    {
                        return MinimumGrade != MaximumGrade
                            ? $"{MinimumGrade}-{MaximumGrade}"
                            : MinimumGrade.ToString();
                    }

                    return MinimumGrade.ToString();
                }

                return MaximumGrade.ToString();
            }
        }

        public override string ToString()
        {
            return $"{Id}: {LocationId} {Colour ?? Description} {GradeDescription}";
        }
    }
}