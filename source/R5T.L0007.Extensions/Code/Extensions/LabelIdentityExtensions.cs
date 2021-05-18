using System;
using System.Collections.Generic;
using System.Linq;


namespace Google.Apis.Gmail.v1
{
    public static class LabelIdentityExtensions
    {
        public static IList<string> GetValues(this IEnumerable<LabelIdentity> labelIdentities)
        {
            var values = labelIdentities
                .Select(x => x.Value)
                .ToList();

            return values;
        }
    }
}
