using Godot;
using System;

public partial class NodeLocator : Node
{
    public static NodeLocator Instance { get; private set; }

    public override void _Ready()
    {
        base._Ready();
        Instance = this;
    }

    public Entity FindEntityById(string Id)
    {
        Node node = GetTree().GetFirstNodeInGroup(Groups.Entity);
        if (node == null || node is not Entity)
        {
            GD.PushWarning($"No entity found with id: {Id}");
            return null;
        }
        return node as Entity;
    }

        public Entity FindPlayerById(string Id)
    {
        Node node = GetTree().GetFirstNodeInGroup(Groups.Player);
        if (node == null || node is not Player)
        {
            GD.PushWarning($"No player found with id: {Id}");
            return null;
        }

    
        return node as Player;
    }

}
