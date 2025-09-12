using Godot;
using System;
using System.Threading.Tasks;

public partial class Player : Entity
{

    public bool _isPlaying { get; private set; } = false;

    public override void _Ready()
    {
        base._Ready();

    }

    public override void _PhysicsProcess(double delta)
    {
        base._PhysicsProcess(delta);

        MoveAndSlide();
    }

    public void SetPlayingStatus(bool isPlaying)
    {
        _isPlaying = isPlaying; 
    }
}