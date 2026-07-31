using Godot;
using System;

public partial class Animations : Sprite2D
{
	bool right;
	
	public override void _Ready()
	{
		FlipH = true;
	}

	
	public override void _Process(double delta)
	{
		Looking();
	}

public void Looking()
	{
		Player player = GetParent<Player>();
		if (player.isRight)
		{
			FlipH = false;
		}
		else
		{
			FlipH = true;
		}
	}

}
