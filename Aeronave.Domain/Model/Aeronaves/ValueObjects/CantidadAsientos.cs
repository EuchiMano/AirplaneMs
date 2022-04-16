using Aeronave.ShareKernel.Core;
using Aeronave.ShareKernel.Rules;

namespace Aeronave.Domain.Model.Aeronaves.ValueObjects
{
    public record CantidadAsientos : ValueObject
    {
        public int Value { get; }
        public CantidadAsientos(int value)
        {
            CheckRule(new IntBePositiveRule(value));
            Value = value;
        }

        public static implicit operator int(CantidadAsientos value)
        {
            return value.Value;
        }

        public static implicit operator CantidadAsientos(int value)
        {
            return new CantidadAsientos(value);
        }
    }
}