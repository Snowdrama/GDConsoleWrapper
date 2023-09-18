# GDConsoleWrapper
This is a C# wrapper for jitspoe's Godot Console: 
https://github.com/jitspoe/godot-console

This is intended just to be a wrapper for the console written in C# for mixed codebases that
have some C# and some GDScript and want both to be able to use the console. 

For a full reimplementation of the console in C# check out this written by MolikoDeveloper
https://github.com/MolikoDeveloper/Csharp-Console-Godot/tree/main/addons/csharpConsole

# Usage
* If you haven't, First install the godot console from [jitspoe's Repo](https://github.com/jitspoe/godot-console)

* Download the project using the big green `<>Code` button on GitHub

* Open the zip and drag and drop the the `GDConsoleWrapper` folder into a folder called `addons` in your project. Your project structure should look like: `/addons/GDConsoleWrapper` 

* Then enable both the godot-console and GDConsoleWrapper in the project settings under plugins.

You should be all set! Leave an issue if you run into any problems!

# Version
Quick note this was built on 4.1.1 and while it might work with earlier versions I've only tested on 4.1.1

# How To Use
In your code you can use it by calling AddCommand like this:
```cs
public partial class SomeNode : Node{
    public override void _Ready()
    {
        GDConsole.AddCommand("hello", Hello)
    }

    public void Hello(){
        GD.Print("Hello from SomeNode!");
    }

    public override void _ExitTree()
    {
        //don't forget to remove the command when this is destroyed!
        GDConsole.RemoveCommand("hello", Hello)
    }
}
```
Note how you declare the type in the generic parameter. This supports up to 3 parameters:
```cs
public partial class SomeNode : Node{
    public override void _Ready()
    {
        //this can take up to 3 params! 
        GDConsole.AddCommand<int>("DoSomething1", DoSomething1)
        GDConsole.AddCommand<int, string>("DoSomething2", DoSomething2)
        GDConsole.AddCommand<int, string, bool>("DoSomething3", DoSomething3)

        //Or no parameters!
        GDConsole.AddCommand("DoSomething", DoSomething)
    }
    public void DoSomething(){}
    public void DoSomething1(int something){}
    public void DoSomething2(int something, string soemString){}
    public void DoSomething3(int something, string soemString, bool someBool){}
}
```
