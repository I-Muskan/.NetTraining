using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_assignment
{
    class PatientServices:IPatientServices
    {
        List<Patient> PatientList = new List<Patient>();
        public void AddPatient(int id,string name,int age,string address,string disease,string doctor,string roomNo)
        {
            Patient patient = new Patient(id,name, age, address, disease, doctor, roomNo);
            PatientList.Add(patient);
            Console.WriteLine("Patient with id "+id+" added  successfully");
            
        }
        public void UpdatePatientName(int id,string name)
        {
            bool isUpdated = false;
           foreach(var patient in PatientList)
            {
                if(patient.GetId()==id)
                {
                    patient.SetName(name);
                    isUpdated = true;
                }
            }
           if(isUpdated==false)
            {
                Console.WriteLine("No such patient exit");
            }
           else
            {
                Console.WriteLine("Patient Details Updated Successfully");
            }
          
        }
        public void UpdatePatientAge(int id,int age)
        {
            bool isUpdated = false;
            foreach (var patient in PatientList)
            {
                if (patient.GetId() == id)
                {
                    patient.SetAge(age);
                    isUpdated = true;
                }
            }
            if (isUpdated == false)
            {
                Console.WriteLine("No such patient exit");
            }
            else
            {
                Console.WriteLine("Patient Details Updated Successfully");
            }
        }
        public void UpdatePatientAddress(int id, string address)
        {
            bool isUpdated = false;
            foreach (var patient in PatientList)
            {
                if (patient.GetId() == id)
                {
                    patient.SetAddress(address);
                    isUpdated = true;
                }
            }
            if (isUpdated == false)
            {
                Console.WriteLine("No such patient exit");
            }
            else
            {
                Console.WriteLine("Patient Details Updated Successfully");
            }
        }
        public void UpdatePatientDisease(int id, string disease)
        {
            bool isUpdated = false;
            foreach (var patient in PatientList)
            {
                if (patient.GetId() == id)
                {
                    patient.SetDisease(disease);
                    isUpdated = true;
                }
            }
            if (isUpdated == false)
            {
                Console.WriteLine("No such patient exit");
            }
            else
            {
                Console.WriteLine("Patient Details Updated Successfully");
            }
        }
        public void UpdatePatientDoctor(int id, string doctor)
        {
            bool isUpdated = false;
            foreach (var patient in PatientList)
            {
                if (patient.GetId() == id)
                {
                    patient.SetDoctor(doctor);
                    isUpdated = true;
                }
            }
            if (isUpdated == false)
            {
                Console.WriteLine("No such patient exit");
            }
            else
            {
                Console.WriteLine("Patient Details Updated Successfully");
            }
        }
        public void UpdatePatientRoomNo(int id, string roomNo)
        {
            bool isUpdated = false;
            foreach (var patient in PatientList)
            {
                if (patient.GetId() == id)
                {
                    patient.SetRoomNo(roomNo);
                    isUpdated = true;
                }
            }
            if (isUpdated == false)
            {
                Console.WriteLine("No such patient exit");
            }
            else
            {
                Console.WriteLine("Patient Details Updated Successfully");
            }
        }
        public void DisplayAllPatient()
        {
           
            foreach (var patient in PatientList)
            {
                Console.WriteLine("Name: "+ patient.GetName() + "\nAge : "+ patient.GetAge() + "\nAddress: "+ patient.GetAddress()+"\nDisease: "+patient.GetDisease()+"\nDoctor:  "+patient.GetDoctor()+"\nRoom No: "+ patient.GetRoomNo()+"\n");
            }
            
        }
        public void DeletePatient(int id)
        {
            bool isDeleted = false;

            foreach (var patient in PatientList)
            {
                if(patient.GetId()==id)
                {
                    PatientList.Remove(patient);
                    Console.WriteLine("Patient with id {0} ", id + " deleted successfully");
                }
               
            }
            if(isDeleted==false)
            {
                Console.WriteLine("No such patient Exist");
            }


        }

    }
}
