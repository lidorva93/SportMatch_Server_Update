﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SportMatch_1.Models;

namespace SportMatch_1.Controllers
{
    public class LanguageController : ApiController
    {
        // GET: Language
        public List<Language> Get()
        {
            Language l = new Language();
            return l.getLanguage();
        }
      
    }
}