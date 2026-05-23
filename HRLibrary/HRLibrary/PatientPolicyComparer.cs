using System.Collections.Generic;

namespace HRLibrary
{
    public class PatientPolicyComparer : IComparer<Patient>
    {
        public int Compare(Patient x, Patient y)
        {
            if (x == null && y == null) return 0;
            if (x == null) return -1;
            if (y == null) return 1;

            return string.Compare(x.PolicyNumber, y.PolicyNumber, System.StringComparison.OrdinalIgnoreCase);
        }
    }
}