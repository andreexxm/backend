using System;
namespace AbstractClasses.Entities
{
    public class DevOps : Human
    {
        public bool AWSCertified { get; set; }

        public bool AzureCertified { get; set; }


        public DevOps()
        {
        }

        public DevOps (string fullName, int age, long phone, bool awsCertified, bool azureCertified)
            :base(fullName, age, phone)
        {
            AWSCertified = awsCertified;
            AzureCertified = azureCertified;
        }

        public void CheckInfrastructure(int status)
        {
            switch (status)
            {
                case 200:
                    Console.WriteLine("Ok");
                    break;
                case 204:
                    Console.WriteLine("NotFound");
                    break;
                case 500:
                    Console.WriteLine("Internal Server Error!");
                    break;
                default:
                    Console.WriteLine("Something went wrong");
                    break;
            }
        }

        public override string GetInfo()
        {
            string result = $"{FullName} ({Age}) - Has: ";
            result += AWSCertified ? "AWS Certificate" : "";
            result += AzureCertified ? "Azure Certificate" : "";
            return result;

        }


    }
}
