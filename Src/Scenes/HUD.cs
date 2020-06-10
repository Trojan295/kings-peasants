using Godot;
using System;


public class HUD : CanvasLayer
{
  public void SetResources(Resources r)
  {
    GetNode<Label>("foodAmount").Text = r.Food.ToString();
    GetNode<Label>("woodAmount").Text = r.Wood.ToString();
    GetNode<Label>("stoneAmount").Text = r.Stone.ToString();
  }
}