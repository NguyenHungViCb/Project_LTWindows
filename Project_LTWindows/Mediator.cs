using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_LTWindows
{
    class Mediator
    {
        public static readonly Mediator _Instance = new Mediator();
        public Mediator()
        {

        }
        public static Mediator GetInstance()
        {
            return _Instance;
        }

        public EventHandler<studentEventArgs> _studentTransferer;
        public void OnStudentTransferer(object sender, Student st)
        {
            var del = _studentTransferer;
            if(del!=null)
            {
                del(sender, new studentEventArgs { _student = st });
            }    
        }
    }
}
