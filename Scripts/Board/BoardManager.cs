using Godot;
using System;
using System.Collections.Generic;

public partial class BoardManager : Node
{
    public static BoardManager Instance { get; private set; }


    [Export]
    public int MaxBoardIntegrity;

    [Export]
    public int SmallTreasureSpaces;

    [Export]
    public int MediumTreasureSpaces;

    [Export]
    public int LargeTreasureSpaces;

    [Export]
    public int HugeTreasureSpaces;

    public override void _Ready()
    {
        base._Ready();
        Instance = this;
    }

    public List<GameBoardSpace> GameBoardSpaces;

    public int CurrentBoardIntegrity;

    public void GenerateGameBoard()
    {
        CurrentBoardIntegrity = MaxBoardIntegrity;

        GameBoardSpaces = GenerateGameBoardSpaces();

    }

    public List<GameBoardSpace> GenerateGameBoardSpaces()
    {
        return [];
    }
}
