﻿using System;
using System.Net;

namespace UdemyTestProject.Mocking
{
    public class InstallerHelper
    {
        private readonly IFileDownloader _fileDownloader;
        private string _setupDestinationFile;

        public InstallerHelper(IFileDownloader fileDownloader)
        {
            _fileDownloader = fileDownloader;
        }

        public bool DownloadInstaller(string customerName, string installerName)
        {
           
            try
            {
                _fileDownloader.DownloadFile($"http://example.com/{customerName}/{installerName}", _setupDestinationFile);
                return true;
            }
            catch (WebException)
            {
                return false;
            }
        }
    }
}