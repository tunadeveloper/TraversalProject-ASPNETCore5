using System;

namespace TraversalProject.SignalRAPIForSQL.DataAccess
{
    public enum ECity
    {
        Berlin = 1,
        Paris = 2,
        London = 3,
        Madrid = 4,
        Rome = 5

    }
    public class Visitor
    {
        public int VisitorId { get; set; }
        public ECity City { get; set; }
        public int CityVisitCount { get; set; }
        public DateTime VisitDate { get; set; }
    }
}