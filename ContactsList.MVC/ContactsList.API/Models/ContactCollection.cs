﻿
using System;
using System.Collections.Generic;
using System.Linq;
using ContactsList.MVC.Models;
using Newtonsoft.Json.Linq;

namespace ContactsList.MVC.Models
{
    public static partial class ContactCollection
    {
        /// <summary>
        /// Deserialize the object
        /// </summary>
        public static IList<Contact> DeserializeJson(JToken inputObject)
        {
            IList<Contact> deserializedObject = new List<Contact>();
            foreach (JToken iListValue in ((JArray)inputObject))
            {
                Contact contact = new Contact();
                contact.DeserializeJson(iListValue);
                deserializedObject.Add(contact);
            }
            return deserializedObject;
        }
    }
}
