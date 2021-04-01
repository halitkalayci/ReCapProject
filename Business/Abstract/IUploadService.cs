using Core.Utilities.Results;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IUploadService
    {
        string Add(IFormFile file);
        IResult Remove(string path);
        string Update(string oldPath, IFormFile file);
    }
}
