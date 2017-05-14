// ----------------------------------------------------------------------------------------------------------------------
// Copyright © Ejyle Technologies (P) Ltd (www.ejyle.com)
// Licensed under the MIT license. See the LICENSE file in the project's root directory for complete license information.
// ----------------------------------------------------------------------------------------------------------------------

namespace Ejyle.DevAccelerate.Core
{
    /// <summary>
    /// An interface for a validation result.
    /// </summary>
    public interface IValidationResult
    {
        /// <summary>
        /// Determines if the result of the validation is success.
        /// </summary>
        bool IsSuccessful { get; }
    }
}
