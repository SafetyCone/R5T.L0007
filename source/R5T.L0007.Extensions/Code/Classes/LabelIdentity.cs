using System;

using R5T.Stagira;


namespace Google.Apis.Gmail.v1
{
    public class LabelIdentity : TypedString
    {
        #region Static

        public static LabelIdentity From(string value)
        {
            var output = new LabelIdentity(value);
            return output;
        }

        #endregion


        public LabelIdentity(string value)
            : base(value)
        {
        }
    }
}
