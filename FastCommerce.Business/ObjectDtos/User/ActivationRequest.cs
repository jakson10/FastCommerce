﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FastCommerce.Business.ObjectDtos.User
{
    public class ActivationRequest
    {
        [Required]
        public string ActivationCode { get; set; }
    }
}
