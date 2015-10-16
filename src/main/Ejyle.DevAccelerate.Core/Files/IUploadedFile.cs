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
    public interface IUploadedFile
    {
        string FileName
        {
            get;
            set;
        }

        string ContentType
        {
            get;
            set;
        }

        int ContentLength
        {
            get;
            set;
        }

        System.IO.Stream Stream
        {
            get;
            set;
        }        
    }
}
