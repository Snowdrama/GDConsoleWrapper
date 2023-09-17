# GDConsoleWrapper
This is a C# wrapper for jitspoe's Godot Console: 
https://github.com/jitspoe/godot-console

This is intended just to be a wrapper for the console written in C# for mixed codebases that
have some C# and some GDScript and want both to be able to use the console. 

For a full reimplementation of the console in C# check out this written by MolikoDeveloper
https://github.com/MolikoDeveloper/Csharp-Console-Godot/tree/main/addons/csharpConsole

# Usage
If you haven't, First install the godot console from [jitspoe's Repo](https://github.com/jitspoe/godot-console)
Drop the `GDConsoleWrapper` folder into the `addons` folder the structure should look like: `addons/GDConsoleWrapper` 
Then enable both the godot-console and GDConsoleWrapper in the project settings under plugins.

You should be all set! Leave an issue if you run into any problems!

# Version
Quick note this was built on 4.1.1 and while it might work with earlier versions I've only tested on 4.1.1

# How To Use
In your code you can use it by calling AddCommand like this:
```cs
public partial class SomeNode : Node{
    int hp = 100;
    public override void _Ready()
    {
        GDConsole.AddCommand<int>("SetHP", SetHP)
    }

    public void SetHP(int hp){
        this.hp = hp;
    }
}
```
Note how you declare the type in the generic parameter. This supports up to 3 parameters:
```cs
public partial class SomeNode : Node{
    int hp = 100;
    public override void _Ready()
    {
        //this takes 3 params! 
        GDConsole.AddCommand<int, string, bool>("SetHP", DoSomething)
    }

    public void DoSomething(int someInt, string someString, bool someBool){
        //whatever
    }
}
```