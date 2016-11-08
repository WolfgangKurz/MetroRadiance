﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using MetroRadiance.UI;

namespace MetroRadiance.Showcase
{
	public partial class App
	{
		protected override void OnStartup(StartupEventArgs e)
		{
			base.OnStartup(e);

			ThemeService.Current.Register(this, Theme.Windows, Accent.Windows);
		}
	}
}
