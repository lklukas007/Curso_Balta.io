﻿using System.Runtime.Loader;

namespace UtmBuilder.Core.ValueObjects
{
    public class Url : ValueObject
    {

        /// <summary>
        /// Address of URL (Website link)
        /// </summary>
        /// <param name="address">Address of URL (Website link)</param>
        public Url(string address)
        {
            Address = address;
        }

        /// <summary>
        /// Address of URL (Website link)
        /// </summary>
        public string Address { get; }

    }
}
