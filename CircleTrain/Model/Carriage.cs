namespace CircleTrain.Model
{
    internal class Carriage
    {
        private int Number { get; set; }
        internal bool Light { get; set; }
        
        internal Carriage(int number, bool light)
        {
            Number = number;
            Light = light;
        }

        public override string ToString()
        {
            return $"Вагон номер {Number}, свет включен: {Light}";
        }
    }
}
