﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WindowsWebAdmin.Core;

namespace WindowsWebAdmin.Models
{
    public class Disk : ModelBase
    {
        public List<WindowsWebAdmin.Core.Disk.Info> Disks { get; set; }
    }
}