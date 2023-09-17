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

    //0 params
    public static void AddCommand(string command, Action callable){
        instance.LinkCommandToConsole(command, callable);
    }
    public void LinkCommandToConsole(string command, Action callable){
		consoleRef.Call("add_command", command, Callable.From(callable));
    }
    public static void RemoveCommand(string command, Action callable){
        instance.UnlinkCommandToConsole(command, callable);
    }
    public void UnlinkCommandToConsole(string command, Action callable){
		consoleRef.Call("remove_command", command, Callable.From(callable));
    }

    //1 param
    public static void AddCommand<T>(string command, Action<T> callable){
        instance.LinkCommandToConsole(command, callable, 1);
    }
    public void LinkCommandToConsole<T>(string command, Action<T> callable, int paramCount = 0){
		consoleRef.Call("add_command", command, Callable.From(callable), 1);
    }
    public static void RemoveCommand<T>(string command, Action<T> callable){
        instance.UnlinkCommandToConsole(command, callable, 1);
    }
    public void UnlinkCommandToConsole<T>(string command, Action<T> callable, int paramCount = 0){
		consoleRef.Call("remove_command", command, Callable.From(callable), 1);
    }

    
    //2 params
    public static void AddCommand<T, I>(string command, Action<T, I> callable){
        instance.LinkCommandToConsole(command, callable, 2);
    }
    public void LinkCommandToConsole<T, I>(string command, Action<T, I> callable, int paramCount = 0){
		consoleRef.Call("add_command", command, Callable.From(callable), 2);
    }
    public static void RemoveCommand<T, I>(string command, Action<T, I> callable){
        instance.UnlinkCommandToConsole(command, callable, 2);
    }
    public void UnlinkCommandToConsole<T, I>(string command, Action<T, I> callable, int paramCount = 0){
		consoleRef.Call("remove_command", command, Callable.From(callable), 2);
    }

    //3 params
    public static void AddCommand<T, I, J>(string command, Action<T, I, J> callable){
        instance.LinkCommandToConsole(command, callable, 3);
    }
    public void LinkCommandToConsole<T, I, J>(string command, Action<T, I, J> callable, int paramCount = 0){
		consoleRef.Call("add_command", command, Callable.From(callable), 3);
    }
    public static void RemoveCommand<T, I, J>(string command, Action<T, I, J> callable){
        instance.UnlinkCommandToConsole(command, callable, 3);
    }
    public void UnlinkCommandToConsole<T, I, J>(string command, Action<T, I, J> callable, int paramCount = 0){
		consoleRef.Call("remove_command", command, Callable.From(callable), 3);
    }
}