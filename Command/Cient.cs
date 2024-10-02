using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behave_Patterns.Command
{
    public class Cient
    {
        static void Main(string[] args)
        {
            ImageEditor editor = new ImageEditor();
            CommandExecutor commandExecutor = new CommandExecutor();
            CommandHistory history = new CommandHistory();

            ICommand applyFilterCommand = new ApplyFilterCommand(editor, "image.jpg");
            ICommand rotateFilterCommand = new RotateImageCommand(editor, "image1.jpg", 20);
            ICommand resizeFilterCommand = new ResizeImageCommand(editor, "image1.jpg", 20, 20);

            List<ICommand> commands = new List<ICommand>();
            commands.Add(applyFilterCommand);
            commands.Add(rotateFilterCommand);
            commands.Add(resizeFilterCommand);
            foreach (var command in commands)
            {
                commandExecutor.ExecuteCommand(command);
                history.Push(command);
            }

            ICommand lastCommand = history.Pop();
            lastCommand.Undo();

            int[] array = { 0,1,2,4,5,6,7,5,6,7,5,6,7,5,8,9,10,11,9,10,11,9,10,11,9,12,13};
            foreach (int num in array){
                Console.WriteLine(num);
            }
        }
    }
}
