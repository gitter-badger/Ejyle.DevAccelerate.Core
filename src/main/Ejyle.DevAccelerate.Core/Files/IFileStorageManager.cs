// ----------------------------------------------------------------------------------------------------------------------
// Copyright © Ejyle Technologies (P) Ltd (www.ejyle.com)
// Licensed under the MIT license. See the LICENSE file in the project's root directory for complete license information.
// ----------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejyle.DevAccelerate.Core.Configuration;
using System.Collections.Specialized;

namespace Ejyle.DevAccelerate.Core.Files
{
    public interface IFileStorageManager
    {
        NameValueCollection ExtendedProperties { get; set; }

        void Upload(string containerName, string fileName, IUploadedFile file);
        byte[] DownloadToByteArray(string container, string fileName);
        bool IsExists(string container, string fileName);
        void Delete(string container, string fileName);
    }
}
