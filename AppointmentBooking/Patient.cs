using System;
using System.Collections.Generic;
using System.Text;

namespace ENSE707_AppointmentBooking
{
    //Before the improvement:
    /*public class Patient
    {
        public string Id
        {
            get;
            set;
        }
        public string FullName
        {
            get;
            set;
        }
    }*/

    //Step 11: With the improvement:

    public class Patient
    {
        public string Id { get; }
        public string LegalName { get; }
        public string PreferredName { get; }
        public string DisplayName
        {
            get
            {
                if (string.IsNullOrWhiteSpace(PreferredName))
                    return LegalName;
                return PreferredName;
            }
        }
        public Patient(string id, string legalName, string preferredName = "")
        {
            if (string.IsNullOrWhiteSpace(id))
                throw new ArgumentException("Patient ID is required.");
            if (string.IsNullOrWhiteSpace(legalName))
                throw new ArgumentException("Legal name is required.");
            Id = id;
            LegalName = legalName;
            PreferredName = preferredName;
        }
    }

}
