using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_assignment
{
    interface IPatientServices
    {
        void AddPatient(int id, string name, int age, string address, string disease, string doctor, string roomNo);
        void UpdatePatientName(int id, string name);
        void UpdatePatientAge(int id, int age);
        void UpdatePatientAddress(int id, string address);
        void UpdatePatientDisease(int id, string disease);
        void UpdatePatientDoctor(int id, string doctor);
        void UpdatePatientRoomNo(int id, string roomNo);
        void DisplayAllPatient();
        void DeletePatient(int id);

    }
}
