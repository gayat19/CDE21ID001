using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Azure.Storage.Blobs;
using System.IO;
using System.Threading.Tasks;

namespace BlobExampleProject.Controllers
{
    public class PicController : Controller
    {
        public async Task<ActionResult> Index()
        {
            var connectionString = "DefaultEndpointsProtocol=https;AccountName=blobg3may;AccountKey=ih4a7vG6KbEGY/8HgOLwMY7ifiyCBHR0YiGrElCzOuejh1e7LugelwH1XA1GVswHWciEY77JBtRBzpnrqjOYpw==;EndpointSuffix=core.windows.net";
            string containerName = "picscontainer";
            var serviceClient = new BlobServiceClient(connectionString);
            var containerClient = serviceClient.GetBlobContainerClient(containerName);
            string path = @"D:\Pics";
            string fileName = "MinionPic1.jpg";
            var myFile = Path.Combine(path, fileName);
            var blobClient = containerClient.GetBlobClient(fileName);
            using FileStream uploadFileStream = System.IO.File.OpenRead(myFile);
            await blobClient.UploadAsync(uploadFileStream, true);
            uploadFileStream.Close();
            return View();
        }
        public async Task<ActionResult> GetImage()
        {
            var connectionString = "DefaultEndpointsProtocol=https;AccountName=blobg3may;AccountKey=ih4a7vG6KbEGY/8HgOLwMY7ifiyCBHR0YiGrElCzOuejh1e7LugelwH1XA1GVswHWciEY77JBtRBzpnrqjOYpw==;EndpointSuffix=core.windows.net";
            string containerName = "picscontainer";
            var serviceClient = new BlobServiceClient(connectionString);
            var containerClient = serviceClient.GetBlobContainerClient(containerName);
            string fileName = "MinionPic1.jpg";
            var blobClient = containerClient.GetBlobClient(fileName);
            var download = await blobClient.DownloadAsync();
            using(FileStream downloadFileStream = System.IO.File.OpenWrite("wwwroot/images/myPic.jpg"))
            {
                await download.Value.Content.CopyToAsync(downloadFileStream);
                downloadFileStream.Close();
            }
            return View();
        }
    }
}
