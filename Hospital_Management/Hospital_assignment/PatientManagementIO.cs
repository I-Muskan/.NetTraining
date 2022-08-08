using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_assignment
{
    class PatientManagementIO
    {
        PatientServices patientService = new PatientServices();
        public byte Menu()
        {
            Console.WriteLine("press 1: Add Patient");
            Console.WriteLine("press 2: Update Patient Details");
            Console.WriteLine("press 3: Display All Patient");
            Console.WriteLine("press 4: Delete Patient");
            Console.WriteLine("press 5: EXIT");
            byte option = byte.Parse(Console.ReadLine());
            return option;


        }
        public void AddPatient()
        {
            Console.WriteLine("Enter Id");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Age");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Address");
            string address  = Console.ReadLine();
            Console.WriteLine("Enter Disease");
            string disease = Console.ReadLine();
            Console.WriteLine("Enter Doctor");
            string doctor = Console.ReadLine();
            Console.WriteLine("Enter Room No");
            string roomNo = Console.ReadLine();
            patientService.AddPatient(id, name, age, address, disease, doctor, roomNo);
            

        }
        public void UpdatePatient()
        {
            Console.WriteLine("press 1: update Patient Name");
            Console.WriteLine("press 2: Update Patient Age");
            Console.WriteLine("press 3: Update Patient Address");
            Console.WriteLine("press 4: Update Patient Disease");
            Console.WriteLine("press 5: Update Patient Doctor");
            Console.WriteLine("press 6: Update Patient RoomNo");
            Console.WriteLine("press 7: EXIT");
            int option = int.Parse(Console.ReadLine());
            switch (option)
            {
                case 1:
                    {
                        Console.WriteLine("Enter Id");
                        int id = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter Name");
                        string name = Console.ReadLine();
                        patientService.UpdatePatientName(id, name);
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Enter Id");
                        int id = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter Age");
                        int age = int.Parse(Console.ReadLine());
                        patientService.UpdatePatientAge(id, age);
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Enter Id");
                        int id = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter Address");
                        string address = Console.ReadLine();
                        patientService.UpdatePatientAddress(id, address);
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("Enter Id");
                        int id = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter Disease");
                        string disease = Console.ReadLine();
                        patientService.UpdatePatientDisease(id, disease);
                        break;
                    }
                case 5:
                    {
                        Console.WriteLine("Enter Id");
                        int id = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter Doctor");
                        string doctor = Console.ReadLine();
                        patientService.UpdatePatientName(id, doctor);
                        break;
                    }
                case 6:
                    {
                        Console.WriteLine("Enter Id");
                        int id = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter Room No");
                        string roomNo = Console.ReadLine();
                        patientService.UpdatePatientName(id, roomNo);
                        break;
                    }
                case 7:
                    {

                        break;
                    }
                default:
                    {
                        Console.WriteLine("Enter Correct Option");
                        break;
                    }
            }
        }
            public void DisplayAllPatient()
            {
                patientService.DisplayAllPatient();
            }
         public void DeletePatient()
        {
            Console.WriteLine("Enter Id");
            int id = int.Parse(Console.ReadLine());
            patientService.DeletePatient(id);
        }




    }

  }

