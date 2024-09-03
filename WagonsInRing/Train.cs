namespace WagonsInRing
{
    public class Train
    {
        public Wagon[] Wagons { get; private set; }

        public Train(int numberOfWagons)
        {
            Wagons = new Wagon[numberOfWagons];
            for (int i = 0; i < numberOfWagons; i++)
            {
                Wagons[i] = new Wagon();
            }
        }
    }
}
