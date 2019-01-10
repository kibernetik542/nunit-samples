﻿using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using UdemyTestProject.Fundamentals;

namespace UdemyTestProject.Mocking
{
    public class VideoService
    {
        private readonly IFileReader _fileReader;
        private readonly IVideoRepository _repository;

        public VideoService(IFileReader fileReader = null, IVideoRepository repository = null)
        {
            _fileReader = fileReader ?? new FileReader();
            _repository = repository ?? new VideoRepository();
        }

        public string ReadVideoTitle()
        {
            var str = _fileReader.Read("video.txt");
            var video = JsonConvert.DeserializeObject<Video>(str);
            if (video == null)
                return "Error parsing the video";
            return video.Title;
        }

        public string GetUnprocessedVideoAsCsv()
        {
            var videoIds = new List<int>();
            var videos = _repository.GetUnprocessedVideos();

            foreach (var v in videos)
                videoIds.Add(v.Id);

            return String.Join(",", videoIds);
        }
    }
}