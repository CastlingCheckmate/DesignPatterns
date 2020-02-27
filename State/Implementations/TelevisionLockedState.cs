using StatePattern.Interfaces;

namespace StatePattern.Implementations
{

    public sealed class TelevisionLockedState : ITelevisionState
    {

        public TelevisionLockedState(ITelevisionContext context)
        {
            Context = context;
        }

        private ITelevisionContext Context
        {
            get;

            set;
        }

        public int Volume
        {
            get;

            private set;
        }

        public void PressOnOffButton()
        {
            Context.State = new TelevisionSwitchedOffState(Context);
        }

        public void PressLockButton()
        {

        }

        public void PressVolumePlusButton()
        {

        }

        public void PressVolumeMinusButton()
        {

        }

        public void PressNextChannelButton()
        {
            
        }

        public void PressPreviousChannelButton()
        {

        }

        public void PressSleepingButton(int millisecondsDelay)
        {
            Context.State = new TelevisionSwitchedOnState();
        }

    }

}