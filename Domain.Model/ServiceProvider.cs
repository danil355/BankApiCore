﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Model
{
    public class ServiceProvider
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ServiceType ServiceType { get; set; }
    }
}
