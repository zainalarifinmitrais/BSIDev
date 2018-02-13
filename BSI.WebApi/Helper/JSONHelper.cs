﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;

namespace BSI.WebApi.Helper
{
    public static class JSONHelper
    {
        public static string ToJSON(this object obj)
        {
            var serializer = new JavaScriptSerializer();
            try
            {
                return serializer.Serialize(obj);
            }
            catch (Exception ex)
            {
                return "";
            }
        }
    }
}