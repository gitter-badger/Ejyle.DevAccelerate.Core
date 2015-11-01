// ----------------------------------------------------------------------------------------------------------------------
// Copyright © Ejyle Technologies (P) Ltd (www.ejyle.com)
// Licensed under the MIT license. See the LICENSE file in the project's root directory for complete license information.
// ----------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejyle.DevAccelerate.Core.Files
{
    /// <summary>
    /// Defines the properties of an uploaded file.
    /// </summary>
    public interface IUploadedFile
    {
        /// <summary>
        /// Gets or sets the name of the file.
        /// </summary>
        string FileName
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the content type of the file.
        /// </summary>
        string ContentType
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the content length of the file.
        /// </summary>
        int ContentLength
        {
            get;
            set;
        }

        /// <summary>
        /// Represents the data of the file as a <see cref="System.IO.Stream"/> object.
        /// </summary>
        System.IO.Stream Stream
        {
            get;
            set;
        }        
    }
}
