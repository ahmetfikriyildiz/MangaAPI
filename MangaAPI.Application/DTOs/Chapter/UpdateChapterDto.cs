﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MangaAPI.Application.DTOs.Chapter
{
    public class UpdateChapterDto
    {
        public Guid Id { get; set; }
        public int? ChapterNumber { get; set; }
        public string? Title { get; set; }
        public DateTime? UploadDate { get; set; }
        public int? Pages { get; set; }
        public Guid MangaId { get; set; }
    }
}
