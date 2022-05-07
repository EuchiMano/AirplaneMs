using Aeronave.ShareKernel.Core;

namespace Aeronave.Domain.Model.Aeronaves.ValueObjects
{
    public record CantidadAsientos : ValueObject
    {
        public int Value { get; }
        public CantidadAsientos(int value)
        {
            if (value < 0)
            {
                throw new BussinessRuleValidationException("La cantidad no puede ser negativa o cero");
            }
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