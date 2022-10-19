using SharedKernel.Rules;
using Xunit;

namespace Aeronave.Test.SharedKernel.Rules;

public class IntBePositiveRuleTests
{
    [Fact]
    public void IntBePositiveRuleCorrectly()
    {
        var positive = 10;
        var message = "integer cannot be negative";
        var intBePositiveObject = new IntBePositiveRule(positive);
        Assert.Equal(message, intBePositiveObject.Message);
        Assert.True(intBePositiveObject.IsValid());
    }
}