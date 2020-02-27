namespace StatePattern.Interfaces
{

    public interface ITelevisionState
    {

        void PressOnOffButton();
        void PressLockButton();
        void PressVolumePlusButton();
        void PressVolumeMinusButton();
        void PressNextChannelButton();
        void PressPreviousChannelButton();
        void PressSleepingButton(int millisecondsDelay);

    }

}