using System;
using System.Collections.Generic;
using System.Text;

namespace XamContacs.Services
{
    public interface IFileHelper
    {
        string GetLocalFilePath(string fileName);
    }
}
