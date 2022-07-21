using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// takes away green squiggle underneath
#nullable disable

namespace NestedObjects
{
    /// <summary>
    /// Represents a individual college student
    /// </summary>
    internal class Student
    {
        /// <summary>
        /// The legal first name
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// The legal last name
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// The assigned school email address
        /// </summary>
        public string SchoolEmail { get; set; }

        /// <summary>
        /// Date of Birth
        /// </summary>
        public DateOnly DateOfBirth { get; set; }

        /// <summary>
        /// Students preferred contact number
        /// </summary>
        public string PhoneNumber { get; set; }

        /// <summary>
        /// The advisor who is assigned to the student
        /// </summary>
        public Advisor AssignedAdvisor { get; set; }
    }
}
