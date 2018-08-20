namespace RupanugaCoreServices.FactoryContracts
{
    public interface IEventFactory: IFactory<Events>
    {
        Events GetSingleEvent(int eventID);
    }
}
