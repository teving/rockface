using RockFace.Core.Problem;
using Xunit;

namespace RockFace.Core.Tests.Problem
{

    public class CircuitListItemDtoTests
    {
        [Fact]
        public void GradeDescription_MinimumGradeAndMaximumGradeAreNull_ReturnsEmptyString()
        {
            var target = new CircuitListItemDto
            {
                MinimumGrade = null,
                MaximumGrade = null
            };

            string result = target.GradeDescription;

            Assert.Empty(result);
        }

        [Fact]
        public void GradeDescription_MinimumGradeHasValueButMaximumGradeIsNull_ReturnsMinimumGradeDescription()
        {
            var target = new CircuitListItemDto
            {
                MinimumGrade = new HuecoGrade{Number = 1},
                MaximumGrade = null
            };

            string result = target.GradeDescription;

            Assert.Equal("V1", result);
        }

        [Fact]
        public void GradeDescription_MaximumGradeHasValueButMinimumGradeIsNull_ReturnsMaximumGradeDescription()
        {
            var target = new CircuitListItemDto
            {
                MinimumGrade = null,
                MaximumGrade = new HuecoGrade { Number = 17 }
            };

            string result = target.GradeDescription;

            Assert.Equal("V17", result);
        }

        [Fact]
        public void GradeDescription_MinimumAndMaximumGradesAreTheSame_ReturnsMinimumGradeDescription()
        {
            var grade = new HuecoGrade {Id = 1, Number = 1};
            var target = new CircuitListItemDto
            {
                MinimumGrade = grade,
                MaximumGrade = grade
            };

            string result = target.GradeDescription;

            Assert.Equal("V1", result);
        }

        [Fact]
        public void GradeDescription_MinimumAndMaximumGradesAreDifferent_ReturnsGradeRange()
        {
            var target = new CircuitListItemDto
            {
                MinimumGrade = new HuecoGrade { Number = 1 },
                MaximumGrade = new HuecoGrade { Number = 17 }
            };

            string result = target.GradeDescription;

            Assert.Equal("V1-V17", result);
        }
    }
}
