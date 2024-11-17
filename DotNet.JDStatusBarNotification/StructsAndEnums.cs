using System;
using ObjCRuntime;

namespace DotNet.JDStatusBarNotification
{
	[Native]
	public enum JDStatusBarNotificationIncludedStyle : long
	{
		DefaultStyle = 0,
		Light = 1,
		Dark = 2,
		Success = 3,
		Warning = 4,
		Error = 5,
		Matrix = 6
	}

	[Native]
	public enum JDStatusBarNotificationAnimationType : long
	{
		Move = 0,
		Bounce = 1,
		Fade = 2
	}

	[Native]
	public enum JDStatusBarNotificationBackgroundType : long
	{
		FullWidth = 0,
		Pill = 1
	}

	[Native]
	public enum JDStatusBarNotificationLeftViewAlignment : long
	{
		Left = 0,
		CenterWithText = 1
	}

	[Native]
	public enum JDStatusBarNotificationProgressBarPosition : long
	{
		Bottom = 0,
		Center = 1,
		Top = 2
	}

	[Native]
	public enum JDStatusBarNotificationSystemBarStyle : long
	{
		DefaultStyle = 0,
		LightContent = 1,
		DarkContent = 2
	}
}