﻿using Net.Extensions.FormsValidation.Interfaces;

namespace Net.Extensions.FormsValidation.Rules
{
    public class NotEmptyCollectionRule : IValidationRule<ICollection<object>>
    {
        private readonly string _message;
        public NotEmptyCollectionRule(string? message = null)
        {
            _message = message ?? "Collection must not be empty.";
        }
        public ValidationResult Validate(ICollection<object> value)
        {
            if (value == null || value.Count == 0)
                return ValidationResult.Fail(_message);
            return ValidationResult.Success();
        }
    }
}
