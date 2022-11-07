using WebApplication2.Validation;

namespace ScopecTest
{
    public class UnitTest1
    {
        private readonly NumberValidation _validation;
        public UnitTest1() => _validation = new NumberValidation();
        [Fact]
        public void IsValid_ValidAccountNumber_ReturnsTrue()
            => Assert.True(_validation.IsValid("8 910 523-68-18"));

        [Fact]
        public void IsValid_ValidAccountNumber_ReturnsFalse()
            => Assert.False(_validation.IsValid("8910 523-68-18"));

    }
}