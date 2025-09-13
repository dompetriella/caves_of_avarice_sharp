using Godot;
using System.Collections.Generic;

public partial class PlayerManager : Node
{
    public static PlayerManager Instance { get; private set; }

    public List<Player> Players {get; private set; } = [];

    public override void _Ready()
    {
        base._Ready();

        Instance = this;
    }

        public List<Player> AddPlayerToGame(Player player)
    {
        Players.Add(player);
        return Players;
    }

    public List<Player> RemovePlayerFromGame(string playerId)
    {
        Players.RemoveAll(player => player.Id == playerId);
        return Players;
    }

}