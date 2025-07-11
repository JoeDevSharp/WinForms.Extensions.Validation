﻿using Net.Extensions.FormsValidation.Interfaces;

namespace Net.Extensions.FormsValidation.Rules
{
    public class NotContainsRule : IValidationRule<string>
    {
        private readonly string _substring;
        private readonly string _message;
        public NotContainsRule(string substring, string? message = null)
        {
            _substring = substring;
            _message = message ?? $"Value must not contain '{_substring}'.";
        }
        public ValidationResult Validate(string value)
        {
            if (value == null) value = string.Empty;
            if (value.ToLower().Contains(_substring.ToLower()))
                return ValidationResult.Fail(_message);
            return ValidationResult.Success();
        }
    }
}
