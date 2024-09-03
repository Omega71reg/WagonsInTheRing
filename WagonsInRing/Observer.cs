namespace WagonsInRing
{
    public class Observer
    {
        private int currentPosition;
        private Train train;

        public Observer(Train train, int currentPosition = 0)
        {
            this.train = train;
            this.currentPosition = currentPosition == 0 ? 0 : currentPosition - 1;
        }

        public int CountWagons()
        {
            // Если вагонов нет
            if (train.Wagons.Count() == 0)
                return 0;

            // Записываем начальный
            int InitialPosition = currentPosition++;
            int Count = 0;

            bool firstLightState = train.Wagons[InitialPosition].IsLightOn;

            // Включаем свет в начальном вагоне, если он выключен
            if (!firstLightState)
            {
                train.Wagons[InitialPosition].IsLightOn = true;
            }

            // Двигаемся вперед, пока горит свет в начальном вагоне
            while (train.Wagons[InitialPosition].IsLightOn)
            {
                // Вычисляем индекс для движения по кольцу
                int index = currentPosition % train.Wagons.Length;

                // Если свет включен, выключаем его
                if (train.Wagons[index].IsLightOn)
                {
                    train.Wagons[index].IsLightOn = false;
                }
                // Двигаемся вперед
                currentPosition++;

                // Считаем количество
                Count++;
            }
            return Count;
        }
    }
}
