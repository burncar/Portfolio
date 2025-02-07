using Microsoft.AspNetCore.Mvc;
using Portfolio.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Portfolio.MyViewComponent
{
    public class ExpListsViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(int count)
        {
            var posts = GetExperienceList(count);
            return View(posts);
        }

        public List<ExpModel> GetExperienceList(int count)
        {
            return new List<ExpModel>
                {
                    new ExpModel { Company = "RipeConcepts", Stack = "Asp.net, Razor Views, Ms Sql Server", Year = " Sept 2024 - Present",Position="Asp.net Web Developer" },
                    new ExpModel { Company = "Inspiro Phils.", Stack = "Asp.net, .Net Core, VB.net, React TS, Ms Sql Server", Year = "Dec 2022 - Sept 2024",Position="Application Support Engr" },
                    new ExpModel { Company = "Yondu inc.", Stack = "Java, DB2, Oracle", Year = "Sept 2022 - Dec 2022",Position="Sofware Engineer" },
                     new ExpModel { Company = "CGI Phils.", Stack = "Java, SQL Lite", Year = " Feb 2022 - Aug 2022",Position="Junior Developer(Consultant)" },
                      new ExpModel { Company = "Cagayan United Doctors Medical Center", Stack = " Ms Sql, Microsoft Server, Routers, Switches", Year = "Mar 2021 - Jan 2022",Position="IT Specialist" },
                       new ExpModel { Company = "Okada Manila", Stack = "Cisco, Ip Cameras, Routers, Switches", Year = " May 2019 - June 2020",Position="Surveillance Technician" },
                        new ExpModel { Company = "Experience BPO Inc.", Stack = "Cisco, Ip Cameras, Routers, Switches", Year = "Aug 2018 - Apr 2019",Position="IT Office Assistant" },
                         new ExpModel { Company = "Succeed Asia Ventures.", Stack = "Cisco, Ip Cameras, Routers, Switches", Year = "Mar 2016 - May 2017",Position="Network Operator" },
                          new ExpModel { Company = "Dr. Domingo Deleon General Hospital.", Stack = "Microsoft Server,Ms Sql, Routers, Switches", Year = "Feb 2012 - June 2015",Position="System Adminstrator" }

                }
            .Take(count)
            .ToList();
        }

    }
}
