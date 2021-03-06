﻿
using System;
using System.Linq;
using Newtonsoft.Json.Linq;

namespace ContactsList.MVC.Models
{
    public partial class Contact
    {
        private string _createdBy;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public string CreatedBy
        {
            get { return this._createdBy; }
            set { this._createdBy = value; }
        }
        
        private string _emailAddress;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public string EmailAddress
        {
            get { return this._emailAddress; }
            set { this._emailAddress = value; }
        }
        
        private int? _id;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public int? Id
        {
            get { return this._id; }
            set { this._id = value; }
        }
        
        private string _name;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the Contact class.
        /// </summary>
        public Contact()
        {
        }
        
        /// <summary>
        /// Deserialize the object
        /// </summary>
        public virtual void DeserializeJson(JToken inputObject)
        {
            if (inputObject != null && inputObject.Type != JTokenType.Null)
            {
                JToken createdByValue = inputObject["CreatedBy"];
                if (createdByValue != null && createdByValue.Type != JTokenType.Null)
                {
                    this.CreatedBy = ((string)createdByValue);
                }
                JToken emailAddressValue = inputObject["EmailAddress"];
                if (emailAddressValue != null && emailAddressValue.Type != JTokenType.Null)
                {
                    this.EmailAddress = ((string)emailAddressValue);
                }
                JToken idValue = inputObject["Id"];
                if (idValue != null && idValue.Type != JTokenType.Null)
                {
                    this.Id = ((int)idValue);
                }
                JToken nameValue = inputObject["Name"];
                if (nameValue != null && nameValue.Type != JTokenType.Null)
                {
                    this.Name = ((string)nameValue);
                }
            }
        }
        
        /// <summary>
        /// Serialize the object
        /// </summary>
        /// <returns>
        /// Returns the json model for the type Contact
        /// </returns>
        public virtual JToken SerializeJson(JToken outputObject)
        {
            if (outputObject == null)
            {
                outputObject = new JObject();
            }
            if (this.CreatedBy != null)
            {
                outputObject["CreatedBy"] = this.CreatedBy;
            }
            if (this.EmailAddress != null)
            {
                outputObject["EmailAddress"] = this.EmailAddress;
            }
            if (this.Id != null)
            {
                outputObject["Id"] = this.Id.Value;
            }
            if (this.Name != null)
            {
                outputObject["Name"] = this.Name;
            }
            return outputObject;
        }
    }
}
