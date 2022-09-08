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
	public class StringRenameCache // TypeDefIndex: 9369
	{
		// Fields
		private Dictionary<string, string> _stringRenameMap; // 0x10
		private Func<string, string> _renameDelegate; // 0x18
	
		// Constructors
		public StringRenameCache() {} // Dummy constructor
		public StringRenameCache(Func<string, string> inRenameDelegate) {} // 0x00000001853E1C80-0x00000001853E1D30
	
		// Methods
		// [XID] // 0x000000018984EBE0-0x000000018984EC00
		public void Flush() {} // 0x00000001853E1AA0-0x00000001853E1B50
		// [XID] // 0x0000000189855D30-0x0000000189855D50
		public string GetRenameString(string originalStr) => default; // 0x00000001853E1B50-0x00000001853E1C80
	}
}
