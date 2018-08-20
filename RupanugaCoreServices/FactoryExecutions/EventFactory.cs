using RupanugaCoreServices.FactoryContracts;
using RupanugaCoreServices.SharedModels;
using System.Linq;

namespace RupanugaCoreServices.FactoryExecutions
{
    public class EventFactory : Factory<RupanugaOKCDBContext, Events>, IEventFactory
    {
        public Events GetSingleEvent(int eventID)
        {
            
            var results=   GetAll().ToList();//.FirstOrDefault(evnt => evnt.Eventd == eventID);
            return results.FirstOrDefault(evnt => evnt.Eventd == eventID);
        }
    }
}
