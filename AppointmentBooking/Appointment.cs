using System;
using System.Collections.Generic;
using System.Text;

namespace ENSE707_AppointmentBooking
{
    public class Appointment
    {
        // Properties for appointment details:
        public string Id { get; }
        public Doctor Doctor { get; }
        public Patient Patient { get; }
        public DateTime AppointmentDate { get; }
        public bool IsCancelled { get; private set; }
        public Appointment(string id, Doctor doctor, Patient patient, DateTime appointmentDate)
        {
            // Validate input parameters
            if (string.IsNullOrWhiteSpace(id))
                throw new ArgumentException("Appointment ID is required.");
            Doctor = doctor ?? throw new ArgumentNullException(nameof(doctor));
            Patient = patient ?? throw new ArgumentNullException(nameof(patient));
            AppointmentDate = appointmentDate;
            IsCancelled = false;
        }

        // Method to cancel the appointment
        public void Cancel()
        {
            if (IsCancelled)
                throw new InvalidOperationException("Appointment has already been cancelled.")
                ;
            IsCancelled = true;
        }
    }
}
