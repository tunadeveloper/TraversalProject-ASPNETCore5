using System;

namespace TraversalProject.SignalRAPIForSQL.DataAccess
{
    /// <summary>
    /// SignalRLayer ile uyumluluk için aynı enum.
    /// VisitorService SignalRLayer.DataAccess.Entities.Visitor beklediği için
    /// VisitorService'e verirken TraversalProject.SignalRLayer.DataAccess.Entities.Visitor kullanın
    /// veya bu enum değerini o taraftaki ECity ile aynı sayısal değerlere sahip tutun.
    /// </summary>
    public enum ECity
    {
        Berlin = 1,
        Paris = 2,
        London = 3,
        Madrid = 4,
        Rome = 5
    }

    /// <summary>
    /// Yerel kullanım için. VisitorService (SignalRLayer) ile kullanmak için
    /// TraversalProject.SignalRLayer.DataAccess.Entities.Visitor tipine dönüştürün veya o tipi kullanın.
    /// </summary>
    public class Visitor
    {
        public int VisitorId { get; set; }
        public ECity City { get; set; }
        public int CityVisitCount { get; set; }
        public DateTime VisitDate { get; set; }
    }
}
