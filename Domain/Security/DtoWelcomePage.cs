using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Security
{
    public class DtoWelcomePage
    {
        public string Name
        {
            get;set;
        }
        public string WelcomeMessage
        {
            get
            {
                return "Hola "+  Name + " " + "bienvenido nuevamente a teacher hiring!";
            }
        }

        public int UserTypeID
        {
            get;set;
        }

        public string ImagePath
        {
            get
            {
                string imagePath = string.Empty;

                if (UserTypeID == 1)
                {
                    imagePath = "teacher.jpg";
                }
                else
                {
                    imagePath = "student_reading.jpg";
                }

                return imagePath;
            }
        }
    }
}
