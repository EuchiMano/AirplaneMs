using SharedKernel.Core;

namespace Aeronave.Domain.Model.Aeronaves.ValueObjects
{
    public record NroAsientos : ValueObject
    {
        public int Value { get; }
        public NroAsientos(int value)
        {
            if (value < 0)
            {
                throw new BussinessRuleValidationException("La cantidad no puede ser negativa o cero");
            }
            Value = value;
        }

        public static implicit operator int(NroAsientos value)
        {
            return value.Value;
        }

        public static implicit operator NroAsientos(int value)
        {
            return new NroAsientos(value);
        }
    }
}