using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behave_Patterns.Command
{
    public class RotateImageCommand : ICommand
    {
        private readonly ImageEditor _editor;
        private readonly string _imagePath;
        private readonly int _angle;

        public RotateImageCommand(ImageEditor editor, string imagePath, int angle)
        {
            _editor = editor;
            _imagePath = imagePath;
            _angle = angle;
        }

        public void Execute()
        {
            _editor.RotateImage(_imagePath, _angle);
        }

        public void Undo()
        {
            Console.WriteLine("Undo operation not supported for image rotation.");
        }
    }
}
