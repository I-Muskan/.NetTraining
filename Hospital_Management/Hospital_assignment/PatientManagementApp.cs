using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_assignment
{
    class PatientManagementApp
    {
        static void Main(string[] args)
        {
            PatientManagementIO patientManagementIO = new PatientManagementIO();
            bool flag = true;
            int option = patientManagementIO.Menu();


            do
            {
                switch (option)
                {

                    case 1:
                        {
                            patientManagementIO.AddPatient();
                            break;
                        }
                    case 2:
                        {
                            patientManagementIO.UpdatePatient();
                            break;
                        }
                    case 3:
                        {
                            patientManagementIO.DisplayAllPatient();
                            break;
                        }
                    case 4:
                        {
                            patientManagementIO.DeletePatient();
                            break;
                        }
                    case 5:
                        {
                            flag = false;
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Enter correct option");
                            break;
                        }
                }
            }
            while (flag);
            }
        }
    }


