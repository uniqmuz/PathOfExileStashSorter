//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace POEStashSorter
{
    using System;
    using System.Collections.Generic;
    
    public partial class Race
    {
        public Race()
        {
            this.TrackHill = new HashSet<TrackHill>();
        }
    
        public long Id { get; set; }
        public Nullable<long> RegionId { get; set; }
        public Nullable<long> PrizePool { get; set; }
        public string CityName { get; set; }
        public Nullable<long> IsAvailable { get; set; }
    
        public virtual Region Region { get; set; }
        public virtual ICollection<TrackHill> TrackHill { get; set; }
    }
}
