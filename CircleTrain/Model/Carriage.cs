namespace CircleTrain.Model
{
    internal class Carriage
    {
        private int _number;
        private bool _light;

        internal bool Light 
        { 
            get => _light; 
            set => _light = value; 
        }

        internal Carriage(int number, bool light)
        {
            _number = number;
            Light = light;
        }

        public override string ToString()
        {
            return $"Вагон номер {_number}, свет включен: {Light}";
        }
    }
}
