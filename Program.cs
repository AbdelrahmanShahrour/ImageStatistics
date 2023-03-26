using SixLabors.ImageSharp;
using SixLabors.ImageSharp.PixelFormats;
using System;

namespace ImageStatistics
{
    public class ImageStatisticsCalculator
    {
        private readonly Image<Rgba32> _image;

        // read image from path
        public ImageStatisticsCalculator(string imagePath)
        {
            _image = Image.Load<Rgba32>(imagePath);
        }

        public (double mean, double stdDev, int min, int max) CalculateStatistics()
        {
            double sum = 0;
            double sumSquared = 0;
            int min = int.MaxValue;
            int max = int.MinValue;
            int count = 0;
            // operation 1: the image height
            for (int y = 0; y < _image.Height; y++)
            {
                Span<Rgba32> pixelRowSpan = _image.GetPixelRowSpan(y);

                // operation 2: the image width
                for (int x = 0; x < _image.Width; x++)
                {
                    Rgba32 pixel = pixelRowSpan[x];

                    int grayValue = (int)((pixel.R + pixel.G + pixel.B) / 3.0);
                    // get sum, sumSquared, min and max
                    sum += grayValue;
                    sumSquared += grayValue * grayValue;
                    min = Math.Min(min, grayValue);
                    max = Math.Max(max, grayValue);
                    count++;
                }
            }
            // count mean
            double mean = sum / count;
            // count variance
            double variance = (sumSquared / count) - (mean * mean);
            // count stdDev
            double stdDev = Math.Sqrt(variance);
            // return values
            return (mean, stdDev, min, max);
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            // create image obj 
            ImageStatisticsCalculator calculator = new ImageStatisticsCalculator("image.png");
            (double mean, double stdDev, int min, int max) = calculator.CalculateStatistics();
            // display the results
            Console.WriteLine($"Mean: {mean:F2}");
            Console.WriteLine($"Standard Deviation: {stdDev:F2}");
            Console.WriteLine($"Minimum Gray Value: {min}");
            Console.WriteLine($"Maximum Gray Value: {max}");
        }
    }
}