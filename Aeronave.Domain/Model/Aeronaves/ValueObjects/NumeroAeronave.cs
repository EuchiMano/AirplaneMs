using Aeronave.ShareKernel.Core;
using Aeronave.ShareKernel.Rules;

namespace Aeronave.Domain.Model.Aeronaves.ValueObjects
{
    public record NumeroAeronave : ValueObject
    {
        public string Value { get; }
        public NumeroAeronave(string value)
        {
            CheckRule(new StringNotNullOrEmptyRule(value));
            Value = value;
        }

        public static implicit operator string (NumeroAeronave value)
        {
            return value.Value;
        }

        public static implicit operator NumeroAeronave(string value)
        {
            return new NumeroAeronave(value);
        }
    }
}