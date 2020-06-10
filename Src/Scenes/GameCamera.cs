using Godot;
using System;

public class GameCamera : Camera2D
{
  [Export]
  public float speed = 512.0F;

  [Export]
  public float zoomSpeed = 0.1F;

  public override void _Ready()
  {
  }

  public override void _Process(float delta)
  {
    var moveVector = new Vector2();
    if (Input.IsActionPressed("ui_left"))
    {
      moveVector.x -= 1;
    }
    if (Input.IsActionPressed("ui_right"))
    {
      moveVector.x += 1;
    }
    if (Input.IsActionPressed("ui_up"))
    {
      moveVector.y -= 1;
    }
    if (Input.IsActionPressed("ui_down"))
    {
      moveVector.y += 1;
    }

    Position += moveVector.Normalized() * speed * delta;
  }

  public override void _Input(InputEvent @event)
  {
    if (@event is InputEventMouseButton eventMouseButton && eventMouseButton.IsPressed())
    {
      if (eventMouseButton.ButtonIndex == (int)ButtonList.WheelDown)
      {
        Zoom *= (1 + (1 * zoomSpeed));
      }
      else if (eventMouseButton.ButtonIndex == (int)ButtonList.WheelUp)
      {
        Zoom /= (1 + (1 * zoomSpeed));
      }
    }
  }
}
