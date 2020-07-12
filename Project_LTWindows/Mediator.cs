using System;
using System.Collections;
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

        public EventHandler<int> login;
        public EventHandler<EventArgs> reloadPanel;
        public EventHandler<Student> deleteStraints;
        public EventHandler<FacultyLogin> profileImgTransferer;
        public void OnProfileImgTransferer(object sender, FacultyLogin faculty)
        {
            var del = profileImgTransferer;
            if(del!=null)
            {
                del(sender, faculty);
            }
        }
        public void OnDeleteStraints(object sender, Student _student)
        {
            var del = deleteStraints;
            if(del!=null)
            {
                del(sender, _student);
            }    
        }
        public void OnLogin(object sender, int e)
        {
            var del = login;
            if(del!=null)
            {
                del(sender, e);
            }    
        }
        
        public void OnReloadPanel(object sender, EventArgs e)
        {
            var del = reloadPanel;
            if(del!=null)
            {
                del(sender, e);
            }    
        }
    }
}
