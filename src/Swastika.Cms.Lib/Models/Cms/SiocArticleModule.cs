﻿using System;
using System.Collections.Generic;

namespace Swastika.Cms.Lib.Models.Cms
{
    public partial class SiocArticleModule
    {
        public SiocArticleModule()
        {
            SiocModuleAttributeSet = new HashSet<SiocModuleAttributeSet>();
            SiocModuleData = new HashSet<SiocModuleData>();
        }

        public int ModuleId { get; set; }
        public string ArticleId { get; set; }
        public string Specificulture { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public int Position { get; set; }
        public int Priority { get; set; }
        public int Status { get; set; }

        public SiocArticle SiocArticle { get; set; }
        public SiocModule SiocModule { get; set; }
        public ICollection<SiocModuleAttributeSet> SiocModuleAttributeSet { get; set; }
        public ICollection<SiocModuleData> SiocModuleData { get; set; }
    }
}
