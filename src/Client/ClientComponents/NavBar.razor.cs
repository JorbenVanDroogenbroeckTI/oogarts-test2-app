﻿using Microsoft.AspNetCore.Components;

namespace Client.ClientComponents;

public partial class NavBar
{
	[Parameter] public bool open { get; set; } = false;
	private void ToggleMenu()
	{
		open = !open;
	}
	private string GetBurgerMenuClass()
	{
		return open ? "nav-links open" : "nav-links";
	}
}
