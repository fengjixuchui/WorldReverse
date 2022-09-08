/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using IFix.Core;
using UnityEngine;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace Gaia
{
	public class ScaleTexture // TypeDefIndex: 9336
	{
		// Fields
		private static Color[] texColors; // 0x00
		private static Color[] newColors; // 0x08
		private static int w; // 0x10
		private static float ratioX; // 0x14
		private static float ratioY; // 0x18
		private static int w2; // 0x1C
		private static int finishCount; // 0x20
		private static Mutex mutex; // 0x28
	
		// Nested types
		public class ThreadData // TypeDefIndex: 9337
		{
			// Fields
			public int start; // 0x10
			public int end; // 0x14
	
			// Constructors
			public ThreadData() {} // Dummy constructor
			public ThreadData(int s, int e) {} // 0x0000000185A1D070-0x0000000185A1D0F0
		}
	
		// Constructors
		public ScaleTexture() {} // 0x0000000185A087A0-0x0000000185A08800
	
		// Methods
		// [XID] // 0x0000000189B6E180-0x0000000189B6E1A0
		public static void Point(Texture2D tex, int newWidth, int newHeight) {} // 0x0000000185A08170-0x0000000185A08250
		// [XID] // 0x000000018998FE50-0x000000018998FE70
		public static void Bilinear(Texture2D tex, int newWidth, int newHeight) {} // 0x0000000185A07CD0-0x0000000185A07DB0
		// [XID] // 0x00000001899977F0-0x0000000189997810
		private static void ThreadedScale(Texture2D tex, int newWidth, int newHeight, bool useBilinear) {} // 0x0000000185A08250-0x0000000185A087A0
		// [XID] // 0x000000018999F2B0-0x000000018999F2D0
		public static void BilinearScale(object obj) {} // 0x0000000185A07890-0x0000000185A07CD0
		// [XID] // 0x00000001899A6CD0-0x00000001899A6CF0
		public static void PointScale(object obj) {} // 0x0000000185A07F50-0x0000000185A08170
		// [XID] // 0x00000001899AE4F0-0x00000001899AE510
		private static Color ColorLerpUnclamped(Color c1, Color c2, float value) => default; // 0x0000000185A07DB0-0x0000000185A07F50
	}
}
