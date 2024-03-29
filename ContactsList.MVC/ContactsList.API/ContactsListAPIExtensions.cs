﻿using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using ContactsList.MVC;
using Microsoft.Rest;

namespace ContactsList.MVC
{
    public static partial class ContactsListAPIExtensions
    {
        /// <param name='operations'>
        /// Reference to the ContactsList.MVC.IContactsListAPI.
        /// </param>
        /// <param name='id'>
        /// Required.
        /// </param>
        public static object GetContactById(this IContactsListAPI operations, int id)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IContactsListAPI)s).GetContactByIdAsync(id);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <param name='operations'>
        /// Reference to the ContactsList.MVC.IContactsListAPI.
        /// </param>
        /// <param name='id'>
        /// Required.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        public static async Task<object> GetContactByIdAsync(this IContactsListAPI operations, int id, CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Microsoft.Rest.HttpOperationResponse<object> result = await operations.GetContactByIdWithOperationResponseAsync(id, cancellationToken).ConfigureAwait(false);
            return result.Body;
        }
    }
}
