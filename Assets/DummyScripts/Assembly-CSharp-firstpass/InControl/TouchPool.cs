/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace InControl
{
	public class TouchPool // TypeDefIndex: 7839
	{
		// Fields
		public readonly ReadOnlyCollection<Touch> Touches; // 0x10
		private List<Touch> usedTouches; // 0x18
		private List<Touch> freeTouches; // 0x20
	
		// Constructors
		public TouchPool(int capacity) {} // 0x00000001877E13A0-0x00000001877E14E0
		public TouchPool() {} // 0x00000001877E14E0-0x00000001877E1550
	
		// Methods
		// [XID] // 0x00000001898A86A0-0x00000001898A86C0
		public Touch FindOrCreateTouch(int fingerId) => default; // 0x00000001877E0DF0-0x00000001877E0F50
		// [XID] // 0x00000001898B0340-0x00000001898B0360
		public Touch FindTouch(int fingerId) => default; // 0x00000001877E0F50-0x00000001877E1070
		// [XID] // 0x0000000189BB89A0-0x0000000189BB89C0
		private Touch NewTouch() => default; // 0x00000001877E1270-0x00000001877E13A0
		// [XID] // 0x00000001897B2B50-0x00000001897B2B70
		public void FreeTouch(Touch touch) {} // 0x00000001877E1190-0x00000001877E1270
		// [XID] // 0x00000001898C6870-0x00000001898C6890
		public void FreeEndedTouches() {} // 0x00000001877E1070-0x00000001877E1190
	}
}
