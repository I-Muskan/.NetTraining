using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_assignment
{
    class Patient
    {

        int Id;
        String Name;
        int Age;
        String Address;
        String Disease;
        String Doctor;
        String RoomNo;
        public Patient(int id,string name,int age,string address,string disease,string doctor,string roomNo)
        {
            this.Id = id;
            this.Name = name;
            this.Age = age;
            this.Address = address;
            this.Disease = disease;
            this.Doctor = doctor;
            this.RoomNo = roomNo;

        }
        public int GetId()
        {
            return this.Id;
        }
        public String GetName()
        {
            return this.Name ;
        }
        public int GetAge()
        {
            return this.Age ;
        }
        public String GetAddress()
        {
            return this.Address;
        }
        public String GetDisease()
        {
            return this.Disease;
        }
        public String GetDoctor()
        {
            return this.Doctor;
        }
        public String GetRoomNo()
        {
            return this.RoomNo;
        }
        public void SetId(int id)
        {
            this.Id=id;
        }

        public void SetName(string name)
        {
            this.Name = name;
        }
        public void SetAge(int age)
        {
            this.Age = age;
        }
        public void SetAddress(string address)
        {
            this.Address = address;
        }
        public void SetDisease(string disease)
        {
            this.Disease = disease;
        }
        public void SetDoctor(string doctor)
        {
            this.Doctor = doctor;
        }
        public void SetRoomNo(string roomNo)
        {
            this.RoomNo = roomNo;
        }


    }
}
