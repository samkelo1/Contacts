﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using ContactsList.MVC;
using ContactsList.MVC.Models;
using Microsoft.Rest;

namespace ContactsList.MVC
{
    public static partial class ContactsExtensions
    {
        /// <param name='operations'>
        /// Reference to the ContactsList.MVC.IContacts.
        /// </param>
        /// <param name='id'>
        /// Required.
        /// </param>
        public static bool Delete(this IContacts operations, int id)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IContacts)s).DeleteAsync(id);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <param name='operations'>
        /// Reference to the ContactsList.MVC.IContacts.
        /// </param>
        /// <param name='id'>
        /// Required.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        public static async Task<bool> DeleteAsync(this IContacts operations, int id, CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Microsoft.Rest.HttpOperationResponse<bool> result = await operations.DeleteWithOperationResponseAsync(id, cancellationToken).ConfigureAwait(false);
            return result.Body;
        }
        
        /// <param name='operations'>
        /// Reference to the ContactsList.MVC.IContacts.
        /// </param>
        public static IList<Contact> Get(this IContacts operations)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IContacts)s).GetAsync();
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <param name='operations'>
        /// Reference to the ContactsList.MVC.IContacts.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        public static async Task<IList<Contact>> GetAsync(this IContacts operations, CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Microsoft.Rest.HttpOperationResponse<System.Collections.Generic.IList<ContactsList.MVC.Models.Contact>> result = await operations.GetWithOperationResponseAsync(cancellationToken).ConfigureAwait(false);
            return result.Body;
        }
        
        /// <param name='operations'>
        /// Reference to the ContactsList.MVC.IContacts.
        /// </param>
        /// <param name='contact'>
        /// Required.
        /// </param>
        public static Contact Post(this IContacts operations, Contact contact)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IContacts)s).PostAsync(contact);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <param name='operations'>
        /// Reference to the ContactsList.MVC.IContacts.
        /// </param>
        /// <param name='contact'>
        /// Required.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        public static async Task<Contact> PostAsync(this IContacts operations, Contact contact, CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Microsoft.Rest.HttpOperationResponse<ContactsList.MVC.Models.Contact> result = await operations.PostWithOperationResponseAsync(contact, cancellationToken).ConfigureAwait(false);
            return result.Body;
        }
        
        /// <param name='operations'>
        /// Reference to the ContactsList.MVC.IContacts.
        /// </param>
        /// <param name='contact'>
        /// Required.
        /// </param>
        public static Contact Put(this IContacts operations, Contact contact)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IContacts)s).PutAsync(contact);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <param name='operations'>
        /// Reference to the ContactsList.MVC.IContacts.
        /// </param>
        /// <param name='contact'>
        /// Required.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        public static async Task<Contact> PutAsync(this IContacts operations, Contact contact, CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Microsoft.Rest.HttpOperationResponse<ContactsList.MVC.Models.Contact> result = await operations.PutWithOperationResponseAsync(contact, cancellationToken).ConfigureAwait(false);
            return result.Body;
        }
    }
}
