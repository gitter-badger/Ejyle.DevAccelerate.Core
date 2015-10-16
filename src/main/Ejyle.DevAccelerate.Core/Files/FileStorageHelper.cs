// ----------------------------------------------------------------------------------------------------------------------
// Copyright © Ejyle Technologies (P) Ltd (www.ejyle.com)
// Licensed under the MIT license. See the LICENSE file in the project's root directory for complete license information.
// ----------------------------------------------------------------------------------------------------------------------

using Ejyle.DevAccelerate.Core.Configuration;
using Ejyle.DevAccelerate.Core.Files;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejyle.DevAccelerate.Core.Files
{
    public class FileStorageHelper
    {
        public PathType SourcePath
        {
            get;
            set;
        }

        public string RootPath
        {
            get;
            set;
        }

        public string BuildFileNameWithPath(File file, bool includeRoothPath = false, bool includeLocationPath = false, bool includeUserPath = false)
        {
            if (file == null)
            {
                throw new ArgumentNullException("file");
            }

            if(file.Location == null)
            {
                return BuildFileNameWithPath<string, string, File>(file, null, includeRoothPath, includeLocationPath, includeUserPath);
            }

            return BuildFileNameWithPath<string, string, File>(file, file.Location.Path, includeRoothPath, includeLocationPath, includeUserPath);
        }

        public string BuildFileNameWithPath<TKey, TOptionalKey, TFile>(TFile file, string path, bool includeRoothPath = false, bool includeLocationPath = false, bool includeUserPath = false)
            where TFile : IFile<TKey, TOptionalKey>
        {
            if (file == null)
            {
                throw new ArgumentNullException("file");
            }

            var pathSeparator = "/";

            if (SourcePath == PathType.Physical)
            {
                pathSeparator = @"\";
            }

            var sFileName = file.FileName;

            if (includeUserPath)
            {
                if (!string.IsNullOrEmpty(file.UserPath))
                {
                    sFileName = string.Format("{0}{1}{2}", file.UserPath, pathSeparator, sFileName);
                }
            }

            if (includeLocationPath)
            {
                if (!string.IsNullOrEmpty(path))
                {
                    sFileName = string.Format("{0}{1}{2}", path, pathSeparator, sFileName);
                }
            }

            if (includeRoothPath)
            {
                if (!string.IsNullOrEmpty(RootPath))
                {
                    sFileName = string.Format("{0}{1}{2}", RootPath, pathSeparator, sFileName);
                }
            }

            return sFileName;
        }
    }
}
