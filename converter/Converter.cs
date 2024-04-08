namespace Converter
{
    public class Converter : IConverter
	{
        const double feetInMeters = 0.33;

		public Converter()
		{
		}

        public double ConvertFeetInMeters(double feet)
        {
            return feetInMeters * feet;
        }

        public double ConvertMetersInFeet(double meters)
        {
            return  meters / feetInMeters;
        }
    }
}

