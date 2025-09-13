using Godot;
using System;
using System.Collections.Generic;
using System.Linq;

public partial class Game : Node
{
    public static Game Instance { get; private set; }

    public override void _Ready()
    {
        base._Ready();
        Instance = this;
    }

}
