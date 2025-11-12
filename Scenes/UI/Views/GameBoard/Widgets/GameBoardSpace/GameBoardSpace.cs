using Godot;
using System;
using System.Collections.Generic;

public partial class GameBoardSpace : Area2D
{

    public string Id { get; private set; } = Guid.NewGuid().ToString();

    public int Index;
    public List<int> TreasureValues = [];

    public override void _Ready() {
        base._Ready();
    }

}
