using Godot;
using System;
using System.Diagnostics;

public partial class Player : CharacterBody2D
{
public int speed = 420;
public bool isRight = true;
	public override void _Ready()
	{
	
	}

public override void _Process(double delta)
	{
		movement();
	}

	void movement()
	{
		if (Input.IsActionPressed("ui_right"))
		{
			Velocity = new Vector2(speed, 0);
			isRight = true;
			MoveAndSlide();
		}
		if (Input.IsActionPressed("ui_left"))
		{
			Velocity = new Vector2(-speed, 0);
			isRight = false;
			MoveAndSlide();
		}
		if (Input.IsActionPressed("ui_down"))
		{
			Velocity = new Vector2(0, 350);
			MoveAndSlide();
		}
		if (Input.IsActionPressed("ui_up"))
		{
			Velocity = new Vector2(0, -350);
			MoveAndSlide();
		}
	}
}

