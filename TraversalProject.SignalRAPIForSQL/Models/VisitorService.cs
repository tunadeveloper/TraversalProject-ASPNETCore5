using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TraversalProject.SignalRAPIForSQL.DataAccess;
using TraversalProject.SignalRAPIForSQL.Hubs;

namespace SignalRAPIForSQL.Models
{
    public class VisitorService
    {
        private readonly Context _context;
        private readonly IHubContext<VisitorHub> _hubContext;
        public VisitorService(Context context, IHubContext<VisitorHub> hubContext)
        {
            _context = context;
            _hubContext = hubContext;
        }
        public IQueryable<Visitor> GetList()
        {
            return _context.Visitors.AsQueryable();
        }

        public async Task SaveVisitor(Visitor visitor)
        {
            await _context.Visitors.AddAsync(visitor);
            await _context.SaveChangesAsync();
            await _hubContext.Clients.All.SendAsync("ReceiveVisitorList", GetVisitorChartList());
        }
        public List<VisitorChart> GetVisitorChartList()
        {
            try
            {
                var visitorCharts = new List<VisitorChart>();
                var conn = _context.Database.GetDbConnection();
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();
                using (var command = conn.CreateCommand())
                {
                    command.CommandText = "SELECT tarih,[1],[2],[3],[4],[5] FROM (SELECT [City], CityVisitCount, CAST([VisitDate] AS DATE) AS tarih FROM Visitors) AS visitTable PIVOT (SUM(CityVisitCount) FOR City IN ([1],[2],[3],[4],[5])) AS pivottable ORDER BY tarih ASC";
                    command.CommandType = System.Data.CommandType.Text;
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var visitorChart = new VisitorChart();
                            visitorChart.VisitDate = reader.GetDateTime(0).ToShortDateString();
                            for (var x = 1; x <= 5; x++)
                            {
                                visitorChart.Counts.Add(reader.IsDBNull(x) ? 0 : reader.GetInt32(x));
                            }
                            visitorCharts.Add(visitorChart);
                        }
                    }
                }
                return visitorCharts;
            }
            catch
            {
                return new List<VisitorChart>();
            }
        }
    }
}
