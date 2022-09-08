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

namespace InControl
{
	[Serializable]
	public struct ActionSetData // TypeDefIndex: 7589
	{
		// Fields
		public int id; // 0x00
		public string name; // 0x08
		public List<ActionData> actions; // 0x10
	
		// Constructors
		public ActionSetData(int id) {
			this.id = default;
			name = default;
			actions = default;
		} // 0x0000000187D9EAC0-0x0000000187D9EAF0
	
		// Methods
		// [XID] // 0x0000000189AD3730-0x0000000189AD3750
		public ActionData? GetAction(int index) => default; // 0x0000000187D9E9B0-0x0000000187D9EAC0
	}
}
