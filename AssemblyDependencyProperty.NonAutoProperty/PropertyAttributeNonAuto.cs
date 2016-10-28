﻿using System.Windows;
using Depattach;

// ReSharper disable CheckNamespace
// ReSharper disable ConvertToAutoProperty

public class PropertyAttributeNonAuto : DependencyObject
{
	private int _nonAuto;

	[DependencyProperty]
	public int NonAuto
	{
		get { return _nonAuto; }
		set { _nonAuto = value; }
	}
}