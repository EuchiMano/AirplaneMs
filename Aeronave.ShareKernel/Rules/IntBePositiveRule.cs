using Aeronave.ShareKernel.Core;

namespace Aeronave.ShareKernel.Rules
{
    public class IntBePositiveRule : IBussinessRule
    {
        private readonly int _value;
        public IntBePositiveRule(int value)
        {
            _value = value;
        }

        public string Message => "integer cannot be negative";

        public bool IsValid()
        {
            return _value > 0;
        }
    }
}