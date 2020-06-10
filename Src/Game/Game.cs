using Godot;

public class Game : Node
{
  [Signal]
  delegate void ResourceChanged(Resources r);

  private Resources resources = new Resources();

  public override void _Ready()
  {
    EmitSignal("ResourceChanged", resources);
  }
}
