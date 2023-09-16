


using System;
using Godot;

public partial class GDConsole : Node
{
    public static GDConsole instance;
    public static Node consoleRef;
    public override void _Ready()
    {
        instance = this;
        consoleRef = GetNode("/root/Console");
    }
    public static void AddCommand(string command, Action callable){
        instance.LinkCommandToConsole(command, callable);
    }

    public void LinkCommandToConsole(string command, Action callable){
		consoleRef.Call("add_command", command, Callable.From(callable));
    }
}