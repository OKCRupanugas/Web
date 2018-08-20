using RupanugaCoreServices.FactoryContracts;
using System.Linq;

namespace RupanugaCoreServices.FactoryExecutions
{
    public class EventFactory : Factory<RupanugasConn, Events>, IEventFactory
    {
        public Events GetSingleEvent(int eventID)
        {
            
            var results=   GetAll().ToList();//.FirstOrDefault(evnt => evnt.Eventd == eventID);
            return results.FirstOrDefault(evnt => evnt.Eventd == eventID);
        }
    }
}
