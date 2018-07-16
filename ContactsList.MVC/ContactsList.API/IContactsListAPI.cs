
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using ContactsList.MVC;
using Microsoft.Rest;

namespace ContactsList.MVC
{
    public partial interface IContactsListAPI : IDisposable
    {
        /// <summary>
        /// The base URI of the service.
        /// </summary>
        Uri BaseUri
        {
            get; set; 
        }
        
        /// <summary>
        /// Credentials for authenticating with the service.
        /// </summary>
        ServiceClientCredentials Credentials
        {
            get; set; 
        }
        
        IContacts Contacts
        {
            get; 
        }
        
        /// <param name='id'>
        /// Required.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        Task<HttpOperationResponse<object>> GetContactByIdWithOperationResponseAsync(int id, CancellationToken cancellationToken = default(System.Threading.CancellationToken));
    }
}
