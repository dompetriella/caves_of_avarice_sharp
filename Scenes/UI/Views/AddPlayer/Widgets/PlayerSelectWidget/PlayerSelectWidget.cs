using Godot;
using System;

public partial class PlayerSelectWidget : Node
{
    [Export]
    public int PlayerIndex;

    private Label _playerNumberLabel;
    private Button _addPlayerButton;
    private Button _changeCharacterButton;
    private Label _characterNameLabel;
    private Control _characterImageContainer;
    private TextureRect _characterImage;

    private Player playerData;

    public override void _Ready()
    {
        base._Ready();

        _playerNumberLabel = GetNode<Label>("%PlayerNumberLabel");
        _addPlayerButton = GetNode<Button>("%AddPlayerButton");
        _changeCharacterButton = GetNode<Button>("%ChangeCharacterButton");
        _characterNameLabel = GetNode<Label>("%CharacterNameLabel");
        _characterImage = GetNode<TextureRect>("%CharacterImage");
        _characterImageContainer = GetNode<Control>("%CharacterImageContainer");

        _playerNumberLabel.Text = PlayerIndex.ToString();

        _addPlayerButton.Pressed += TogglePlayerInitialization;
    }

    private void TogglePlayerInitialization()
    {
        if (playerData == null)
        {
            var player = new Player();
            playerData = player;            

            PlayerManager.Instance.AddPlayerToGame(player);

            _changeCharacterButton.Visible = true;
            _characterNameLabel.Visible = true;
            _characterImageContainer.Visible = true;
            _addPlayerButton.Text = "Remove Player -";

        }
        else
        {
            
            PlayerManager.Instance.RemovePlayerFromGame(playerData.Id);
            playerData = null;

            _changeCharacterButton.Visible = false;
            _characterNameLabel.Visible = false;
            _characterImageContainer.Visible = false;
            _addPlayerButton.Text = "Add Player -";
        }
    }

}


