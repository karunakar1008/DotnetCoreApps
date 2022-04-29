using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCoreCrudDemo.Models
{
    public class PersonModel
    {
        public int Id { get; set; }
        ///<summary>
        /// Gets or sets Name.
        ///</summary>
        public string Name { get; set; }

        ///<summary>
        /// Gets or sets DateTime.
        ///</summary>
        public string DateTime { get; set; }
    }
}
