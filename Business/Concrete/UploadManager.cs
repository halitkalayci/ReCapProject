using Business.Abstract;
using Core.Utilities.Helpers;
using Core.Utilities.Results;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class UploadManager : IUploadService
    {
        public string Add(IFormFile file)
        {
            return FileHelper.Add(file);
        }

        public IResult Remove(string path)
        {
            return FileHelper.Remove(path);
        }
        public string Update(string oldPath, IFormFile file)
        {
            return FileHelper.Update(oldPath, file);
        }
    }
}
