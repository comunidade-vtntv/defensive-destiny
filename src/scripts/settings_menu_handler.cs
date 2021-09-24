using Godot;
using System;

public class settings_menu_handler : Node
{
	// Declare member variables here. Examples:
	// private int a = 2;
	// private string b = "text";

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		
	}

//  // Called every frame. 'delta' is the elapsed time since the previous frame.
//  public override void _Process(float delta)
//  {
//      
//  }

	private void _on_FullscreenButton_toggled(bool button_pressed)
	{
		OS.WindowFullscreen = button_pressed;
	}
	
	private void _on_MainMenuButton_pressed()
	{
		GetTree().ChangeScene("res://scenes/menus/MainMenu.tscn");
	}

}






