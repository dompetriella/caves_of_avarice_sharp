using Godot;
using System;
using System.Collections.Generic;
using System.Linq;

public partial class AddPlayer : Control
{
    [Export] public Button StartGameButton;
    [Export]
    public PackedScene NextPage;

    public override void _Ready()
    {
        base._Ready();

        StartGameButton.Pressed += NavigateToGameBoard;
    }

    private void NavigateToGameBoard()
    {
        ScaffoldManager.Instance.ScaffoldNewSceneTree(newSceneTree: NextPage);
    }

    private void AlignPlayers()
    {
        var playerManager = PlayerManager.Instance;
        List<Node> playerNodes = [..playerManager.GetChildren()];
        var xOffset = GetViewport().GetVisibleRect().Size;

        if (playerNodes.Count > 0)
        {
            foreach (var item in playerNodes)
            {
                if (item is Player player)
                {
                    
                }
            }
        }
    }
}
