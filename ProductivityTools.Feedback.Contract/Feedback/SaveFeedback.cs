﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductivityTools.Feedback.Contract.Feedback
{
    public class SaveFeedback
    {
        public List<string> Initials { get; set; }
        public string Value { get; set; }
    }
}
