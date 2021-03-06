﻿using System;
using System.Collections.Generic;
using TechJobs.Models;
using TechJobs.ViewModels;

namespace TechJobs.ViewModels
{
    public class JobFieldsViewModel : BaseViewModel
    {
        // #7.2 - Extract members common to SearchJobsViewModel
        // to BaseViewModel

        // All fields in the given column
        public IEnumerable<JobField> Fields { get; set; }

    }
}