// ----------------------------------------------------------------------------------------------------------------------
// Copyright © Ejyle Technologies (P) Ltd (www.ejyle.com)
// Licensed under the MIT license. See the LICENSE file in the project's root directory for complete license information.
// ----------------------------------------------------------------------------------------------------------------------

namespace Ejyle.DevAccelerate.Core
{
    /// <summary>
    /// A basic and general-purpose interface for a validator.
    /// </summary>
    /// <typeparam name="TValidationResult">The type type of the validation result.</typeparam>
    /// <typeparam name="TValue">The type of the value to be validated.</typeparam>
    public interface IValidator<TValidationResult, TValue>
        where TValidationResult : IValidationResult
    {
        /// <summary>
        /// Validates a value.
        /// </summary>
        /// <param name="value">The value to be validated.</param>
        /// <returns>Returns an instance of the <see cref="IValidationResult"/> type.</returns>
        TValidationResult Validate(TValue value);
    }
}
