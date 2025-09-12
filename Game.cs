using Godot;
using System;
using System.Collections.Generic;
using System.Linq;

public partial class Game : Node
{
    public static Game Instance { get; private set; }

    public List<Player> players = [];

    public override void _Ready()
    {
        base._Ready();
    }

    public List<Player> AddPlayerToGame(Player player)
    {
        players.Add(player);
        return players;
    }

    public List<Player> RemovePlayerFromGame(string playerId)
    {
        players.RemoveAll(player => player.Id == playerId);
        return players;
    }

}
