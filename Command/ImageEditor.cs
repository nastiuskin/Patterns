using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behave_Patterns.Command
{
    public class ImageEditor
    {
        private readonly List<string> _filteredImages = new List<string>();
        public void ApplyFilter(string imagePath)
        {
            Console.WriteLine($"Applying black and white filter to image: {imagePath}");
            _filteredImages.Add(imagePath);
        }

        public void RemoveFilter(string imagePath)
        {
            Console.WriteLine($"Removing black and white filter from image: {imagePath}");
        
            _filteredImages.Remove(imagePath);
        }

        public void PrintFilteredImages()
        {
            Console.WriteLine("Images:");
            foreach(var image in _filteredImages)
            {
                Console.WriteLine(image);
            }
        }

        public void ResizeImage(string imagePath, int width, int height)
        {
            Console.WriteLine($"Resizing image: {imagePath} to {width}x{height}");
        }

        public void RotateImage(string imagePath, int angle)
        {
            Console.WriteLine($"Rotating image: {imagePath} by {angle} degrees");
        }
    }
    }

