/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace HedgehogTeam.EasyTouch
{
	public class GesturePool // TypeDefIndex: 7290
	{
		// Fields
		private static Queue<Gesture> _cache; // 0x00
	
		// Constructors
		public GesturePool() {} // 0x0000000180B33C40-0x0000000180B33CA0
		static GesturePool() {} // 0x0000000180B33BB0-0x0000000180B33C40
	
		// Methods
		// [XID] // 0x00000001895FA4C0-0x00000001895FA4E0
		public static Gesture Get() => default; // 0x0000000180B33970-0x0000000180B33AC0
		// [XID] // 0x0000000189601E90-0x0000000189601EB0
		public static void Return(Gesture gesture) {} // 0x0000000180B33AC0-0x0000000180B33BB0
	}
}
