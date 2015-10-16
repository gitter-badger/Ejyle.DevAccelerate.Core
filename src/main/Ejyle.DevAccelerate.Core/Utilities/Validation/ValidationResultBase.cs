﻿// ----------------------------------------------------------------------------------------------------------------------
// Copyright © Ejyle Technologies (P) Ltd (www.ejyle.com)
// Licensed under the MIT license. See the LICENSE file in the project's root directory for complete license information.
// ----------------------------------------------------------------------------------------------------------------------

namespace Ejyle.DevAccelerate.Core.Utilities.Validation
{
    public abstract class ValidationResultBase : IValidationResult
    {
        public ValidationResultBase(bool isSuccessful)
        {
            IsSuccessful = isSuccessful;
        }

        public bool IsSuccessful
        {
            get;
            private set;
        }
    }
}
