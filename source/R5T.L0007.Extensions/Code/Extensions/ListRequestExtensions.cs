using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

using Google.Apis.Gmail.v1.Data;
using Google.Apis.Requests;



namespace Google.Apis.Gmail.v1
{
    public static class ListRequestExtensions
    {
        public static async Task<List<Message>> ListAll(this UsersResource.MessagesResource.ListRequest request)
        {
            var pageStreamer = new PageStreamer<Message, UsersResource.MessagesResource.ListRequest, ListMessagesResponse, string>(
                (zRequest, zToken) => zRequest.PageToken = zToken,
                zResponse => zResponse.NextPageToken,
                zResponse => zResponse.Messages);

            var messages = await pageStreamer.FetchAllAsync(request, CancellationToken.None);

            return messages.ToList();
        }
    }
}
