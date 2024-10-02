using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behave_Patterns.Command
{
    public class ApplyFilterCommand : ICommand
    {
        private readonly ImageEditor _imageEditor;
        private readonly string _imagePath;

        public ApplyFilterCommand(ImageEditor imageEditor, string imagePath)
        {
            _imageEditor=imageEditor;
            _imagePath=imagePath;
        }

        public void Execute()
        {
            _imageEditor.ApplyFilter(_imagePath);
        }

        public void Undo()
        {
            _imageEditor.RemoveFilter(_imagePath);
        }

    }
}
