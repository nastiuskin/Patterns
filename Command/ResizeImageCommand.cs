using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behave_Patterns.Command
{
    public class ResizeImageCommand : ICommand
    {
        private readonly ImageEditor _editor;
        private readonly string _imagePath;
        private readonly int _width;
        private readonly int _height;
        public ResizeImageCommand(ImageEditor editor, string imagePath, int width, int height)
        { 
            _editor= editor;
            _imagePath= imagePath;
            _width= width;
        }

        public void Execute()
        {
            _editor.ResizeImage(_imagePath, _width, _height);
        }

        public void Undo()
        {
            Console.WriteLine("\"Undo operation not supported for image resizing.\"");
        }
    }
}
