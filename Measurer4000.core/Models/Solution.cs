﻿using System.Collections.Generic;

namespace Measurer4000.Core.Models
{
    public class Solution
    {
        public Solution()
        {
            Projects = new List<Project>();
        }

        public List<Project> Projects { get; set; }

        public CodeStats Stats { get; set; }
    }
}
