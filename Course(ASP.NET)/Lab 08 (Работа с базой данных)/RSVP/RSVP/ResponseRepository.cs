using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RSVP
{
    public class ResponseRepository
    {
        protected static ResponseRepository repository = new ResponseRepository();

        protected List<GuestResponse> responses = new List<GuestResponse>();
        public static ResponseRepository GetRepository()
        {
            return repository;
        }
        public IEnumerable<GuestResponse> GetAllResponses()
        {
            return responses;
        }
        public void AddResponse(GuestResponse response)
        {
            responses.Add(response);
        }

    }
    public class Report
    {
        public int ReportId { get; set; }
        public string NameReport { get; set; }
        public string Annotation { get; set; }
        public GuestResponse GuestRes { get; set; }
        public Report() { }
        public Report(string title, string annot)
        {
            NameReport = title;
            Annotation = annot;
        }
    }
}