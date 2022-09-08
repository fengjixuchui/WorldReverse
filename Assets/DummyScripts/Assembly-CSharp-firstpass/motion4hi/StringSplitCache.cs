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

namespace motion4hi
{
	public class StringSplitCache // TypeDefIndex: 9370
	{
		// Fields
		private Dictionary<string, string[]> _stringSplitMap; // 0x10
		private Func<string, string[]> _splitDelegate; // 0x18
	
		// Constructors
		public StringSplitCache() {} // Dummy constructor
		public StringSplitCache(Func<string, string[]> inSplitDelegate) {} // 0x00000001853E1F10-0x00000001853E1FC0
	
		// Methods
		// [XID] // 0x00000001898D19B0-0x00000001898D19D0
		public void Flush() {} // 0x00000001853E1D30-0x00000001853E1DE0
		// [XID] // 0x0000000189A6BD00-0x0000000189A6BD20
		public string[] GetSplitString(string originalStr) => default; // 0x00000001853E1DE0-0x00000001853E1F10
	}
}
