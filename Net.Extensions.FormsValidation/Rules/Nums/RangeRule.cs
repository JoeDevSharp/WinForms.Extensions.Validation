﻿using Net.Extensions.FormsValidation.Interfaces;

namespace Net.Extensions.FormsValidation.Rules
{
    public class RangeRule : IValidationRule<int>
    {
        private readonly int _min;
        private readonly int _max;
        private readonly string _message;
        public RangeRule(int min, int max, string? message = null)
        {
            if (min > max)
                throw new ArgumentException("Minimum value cannot be greater than maximum value.");
            _min = min;
            _max = max;
            _message = message ?? $"Value must be between {_min} and {_max}.";
        }
        public ValidationResult Validate(int value)
        {
            if (value < _min || value > _max)
                return ValidationResult.Fail(_message);
            return ValidationResult.Success();
        }
    }
}
