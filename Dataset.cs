using System.Collections.Generic;

namespace Landis.Library.InitialCommunities.Universal
{
    public class Dataset
        : IDataset
    {
        private List<ICommunity> communities;

        //---------------------------------------------------------------------

        public Dataset()
        {
            communities = new List<ICommunity>();
        }

        //---------------------------------------------------------------------

        public void Add(ICommunity community)
        {
            communities.Add(community);
        }

        //---------------------------------------------------------------------

        public ICommunity Find(uint mapCode)
        {
            foreach (ICommunity community in communities)
                if (community.MapCode == mapCode)
                    return community;
            return null;
        }
    }
}
