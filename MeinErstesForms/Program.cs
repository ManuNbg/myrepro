using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeinErstesForms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Öffnen wir ein Window");
            //Form myForm = new Form();
            //Application.Run(myForm);

            //myForm zweitesFenster = new myForm();
            //Application.Run(zweitesFenster);

            Fenster drittesFenster = new Fenster();


            Application.Run(drittesFenster);
        }
    }
}
