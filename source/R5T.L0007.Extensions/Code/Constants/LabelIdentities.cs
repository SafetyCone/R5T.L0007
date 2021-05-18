using System;


namespace Google.Apis.Gmail.v1
{
    public static class LabelIdentities
    {
        // Examples (from asking via a users.labels.list command: https://developers.google.com/gmail/api/reference/rest/v1/users.labels.
        //CHAT
        //SENT
        //INBOX
        //IMPORTANT
        //TRASH
        //DRAFT
        //SPAM
        //CATEGORY_FORUMS
        //CATEGORY_UPDATES
        //CATEGORY_PERSONAL
        //CATEGORY_PROMOTIONS
        //CATEGORY_SOCIAL
        //STARRED
        //UNREAD
        //founders @getsafetycone.com

        public const string Inbox = "INBOX";
        public const string Sent = "SENT";
        public const string Trash = "TRASH";
        public const string Unread = "UNREAD";
    }
}
