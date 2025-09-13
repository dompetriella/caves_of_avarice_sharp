using Godot;
using System;

public partial class TitleScreen : Control
{
    [Export]
    public PackedScene NextPage;

    private Button _startButton;
    private Button _settingsButton;

    public override void _Ready()
    {
        base._Ready();

        _startButton = GetNode<Button>("%StartButton");
        _settingsButton = GetNode<Button>("%SettingsButton");

        _startButton.Pressed += NavigateToNextPage;
    }

    private void NavigateToNextPage()
    {
        ScaffoldManager.Instance.ScaffoldNewSceneTree(newSceneTree: NextPage);
    }
}
