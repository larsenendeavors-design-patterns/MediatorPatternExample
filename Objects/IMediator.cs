namespace MediatorPatternExample.Objects
{
    public interface IMediator
    {
        public void Notify(Component sender, string eventString);
    }
}