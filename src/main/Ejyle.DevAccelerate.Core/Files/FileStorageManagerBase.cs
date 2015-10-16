// ----------------------------------------------------------------------------------------------------------------------
// Copyright © Ejyle Technologies (P) Ltd (www.ejyle.com)
// Licensed under the MIT license. See the LICENSE file in the project's root directory for complete license information.
// ----------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejyle.DevAccelerate.Core.Files
{
    public abstract class FileStorageManagerBase : IFileStorageManager
    {
        public FileStorageManagerBase()
        {
            ExtendedProperties = new NameValueCollection();
        }

        public NameValueCollection ExtendedProperties
        {
            get;
            set;
        }

        public abstract void Upload(string containerName, string fileName, IUploadedFile file);
        public abstract byte[] DownloadToByteArray(string container, string fileName);
        public abstract bool IsExists(string container, string fileName);
        public abstract void Delete(string container, string fileName);
    }
}
