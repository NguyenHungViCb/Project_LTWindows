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
        public EventHandler<EventArgs> sendAction;
        public EventHandler<EventArgs> returnAction;
        public void OnAction(object sender, EventArgs e)
        {
            var del = sendAction;
            if(del!=null)
            {
                del(sender, e);
            }    
        }
        public void OnReturnAction(object sender, EventArgs e)
        {
            var del = returnAction;
            if(del!=null)
            {
                del(sender, e);
            }    
        }
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
