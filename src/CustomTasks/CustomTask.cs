using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using Microsoft.Build.Framework;
using Microsoft.Build.Utilities;

namespace CustomTasks;

public class CustomTask : Task
{
    [Required] public string StringParameter { get; set; }
    public ITaskItem[] FileItems { get; set; }

    public override bool Execute()
    {
        System.IO.File.WriteAllText("C:\\Users\\Achi\\Desktop\\Read me.txt", "Hello world");

        return true;
    }
}
