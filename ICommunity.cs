using Landis.Library.UniversalCohorts;
using System.Collections.Generic;

namespace Landis.Library.InitialCommunities.Universal
{
    /// <summary>
    /// An initial community.
    /// </summary>
    public interface ICommunity
    {
        /// <summary>
        /// The code that represents the community on maps.
        /// </summary>
        uint MapCode
        {
            get;
        }

        //---------------------------------------------------------------------

        /// <summary>
        /// The site cohorts in the community.
        /// </summary>
        List<ISpeciesCohorts> Cohorts
        {
            get;
        }
    }
}
