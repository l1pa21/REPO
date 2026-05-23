using System.Collections;
using System.Collections.Generic;

namespace HRLibrary
{
    public class Department : IEnumerable<Patient>
    {
        public string Title { get; set; }

        private List<Patient> _patients;
        public int Count => _patients.Count;

        public Department(string title, IEnumerable<Patient> patients)
        {
            Title = title;
            _patients = new List<Patient>();

            if (patients != null)
            {
                foreach (var patient in patients)
                {
                    if (!_patients.Contains(patient))
                    {
                        _patients.Add(patient);
                    }
                }
            }
        }

        public IEnumerator<Patient> GetEnumerator()
        {
            return _patients.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}