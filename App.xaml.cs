﻿namespace MauiFlyoutPage;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new AppFlyoutPage();
	}
}
