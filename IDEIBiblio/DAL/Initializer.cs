using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using IDEIBiblio.Models;

namespace IDEIBiblio.DAL
{
    public class Initializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<IDEIBiblioContext>
    {
    }
}