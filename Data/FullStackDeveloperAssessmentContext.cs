using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FullStackDeveloperAsessmentDDL.Models;

namespace FullStackDeveloperAssessment.Data
{
    public class FullStackDeveloperAssessmentContext : DbContext
    {
        public FullStackDeveloperAssessmentContext (DbContextOptions<FullStackDeveloperAssessmentContext> options)
            : base(options)
        {
        }

        public DbSet<FullStackDeveloperAsessmentDDL.Models.Locations> Locations { get; set; }
    }
}
