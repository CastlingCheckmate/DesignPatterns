using StatePattern.Interfaces;

namespace StatePattern.Implementations
{

    public sealed class TelevisionSwitchedOffState : ITelevisionState
    {

        public void PressLockButton()
        {

        }

        public void PressNextChannelButton()
        {
            throw new System.NotImplementedException();
        }

        public void PressOnOffButton()
        {
            throw new System.NotImplementedException();
        }

        public void PressPreviousChannelButton()
        {
            throw new System.NotImplementedException();
        }

        public void PressSleepingButton(int millisecondsDelay)
        {
            throw new System.NotImplementedException();
        }

        public void PressVolumeMinusButton()
        {
            throw new System.NotImplementedException();
        }

        public void PressVolumePlusButton()
        {
            throw new System.NotImplementedException();
        }

    }

}