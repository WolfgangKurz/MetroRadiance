﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace MetroRadiance.Core.Win32
{
	[Obsolete]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public static class NativeExtensions
	{
		public static ushort ToLoWord(this IntPtr dword)
		{
			return (ushort)((uint)dword & 0xffff);
		}

		public static ushort ToHiWord(this IntPtr dword)
		{
			return (ushort)((uint)dword >> 16);
		}

		public static Point ToPoint(this IntPtr dword)
		{
			return new Point((short)((uint)dword & 0xffff), (short)((uint)dword >> 16));
		}
	}
}
