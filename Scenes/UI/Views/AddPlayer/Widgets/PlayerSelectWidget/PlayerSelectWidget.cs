using Godot;
using System;

public partial class PlayerSelectWidget : Node
{
    [Export]
    public int PlayerIndex;

    private Label PlayerNumberLabel;
    private Button AddPlayerButton;
    private Button ChangeCharacterButton;
    private Label CharacterNameLabel;
    private Texture CharacterImage;

    public override void _Ready()
    {
        base._Ready();

        PlayerNumberLabel = GetNode<Label>("%PlayerNumberLabel");
    }

}


