using Godot;

[Tool]
public partial class GDConsolePlugin : EditorPlugin
{
    public override void _EnterTree()
    {
        base._EnterTree();
        AddAutoloadSingleton("GDConsole",  "res://addons/GDConsoleWrapper/GDConsole.cs");
    }

    public override void _ExitTree()
    {
        base._ExitTree();
        RemoveAutoloadSingleton("GDConsole");
    }
}
