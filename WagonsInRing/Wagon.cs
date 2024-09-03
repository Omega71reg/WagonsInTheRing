namespace WagonsInRing
{
    public class Wagon
    {
        public bool IsLightOn { get; set; }

        public Wagon()
        {
            // Изначально свет может быть включен или выключен
            IsLightOn = new Random().Next(2)==1;
        }
    }
}
