using Godot;
using System;
using System.Diagnostics;

public partial class truck : Sprite2D
{
public int speed = 5;
	public override void _Ready()
	{
		GD.Print("test");
	}

public void _process(double delta)
	{
		movement();
	}

	void movement ()
	{
		if (Input.IsActionPressed("ui_right"))
		{
			Position += new Vector2(speed, 0);
		}
		if (Input.IsActionPressed("ui_left"))
		{
			Position += new Vector2(-speed, 0);
		}
		if (Input.IsActionPressed("ui_down"))
		{
			Position += new Vector2(0, speed);
		}
		if (Input.IsActionPressed("ui_up"))
		{
			Position += new Vector2(0, -speed);
		}
	}
}
