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
	public class FingerPool // TypeDefIndex: 7289
	{
		// Fields
		private static Queue<Finger> _cache; // 0x00
	
		// Constructors
		public FingerPool() {} // 0x0000000180B338B0-0x0000000180B33910
		static FingerPool() {} // 0x0000000180B33820-0x0000000180B338B0
	
		// Methods
		// [XID] // 0x00000001895EB850-0x00000001895EB870
		public static Finger Get() => default; // 0x0000000180B335E0-0x0000000180B33730
		// [XID] // 0x00000001895F2BF0-0x00000001895F2C10
		public static void Return(Finger finger) {} // 0x0000000180B33730-0x0000000180B33820
	}
}
