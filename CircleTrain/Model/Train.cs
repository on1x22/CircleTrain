namespace CircleTrain.Model
{
    internal class Train
    {
        private readonly List<Carriage> carriages;

        internal Train()
        {
            carriages = CreateCarriages();
        }

        private static List<Carriage> CreateCarriages()
        {
            Random rnd = new Random();
            int amountOfCarriages = rnd.Next(20);
            List<Carriage> newCarriages = new List<Carriage>();

            for (int i = 0; i < amountOfCarriages; i++)
            {
                var light = rnd.Next(2) == 0 ? false : true;
                newCarriages.Add(new Carriage(i, light));
            }

            return newCarriages;
        }

        internal void ShowCarriagesInfo()
        {
            foreach (var carriage in carriages)
            {
                Console.WriteLine(carriage.ToString());
            }
        }

        internal int GetNumberOfCarriages()
        {
            int numberOfCarriages;
            int lastCarriage = 1;

            carriages[0].Light = true;

            while (true)
            {
                numberOfCarriages = lastCarriage;
                if (lastCarriage == carriages.Count)
                    lastCarriage = 0;

                if (carriages[lastCarriage].Light == true)
                {
                    carriages[lastCarriage].Light = false;
                    lastCarriage = 0;
                }

                if (carriages[0].Light == false)
                    return numberOfCarriages;

                lastCarriage++;
            }
        }
    }
}
