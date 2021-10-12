namespace MediatorPatternExample.Objects
{
    public abstract class Component
    {
        private IMediator Mediator { get; }

        protected Component(IMediator mediator)
        {
            Mediator = mediator;
        }

        public void Click()
        {
            Mediator.Notify(this, "click");
        }

        public void KeyPress()
        {
            Mediator.Notify(this, "keyPress");
        }

        public abstract bool Validate();
    }
}