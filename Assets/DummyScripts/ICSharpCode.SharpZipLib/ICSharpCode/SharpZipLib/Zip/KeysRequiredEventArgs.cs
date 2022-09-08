/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;

// Image 54: ICSharpCode.SharpZipLib.dll - Assembly: ICSharpCode.SharpZipLib, Version=0.86.0.518, Culture=neutral, PublicKeyToken=1b03e6acf1164f73 - Types 6620-6667

namespace ICSharpCode.SharpZipLib.Zip
{
	public class KeysRequiredEventArgs : EventArgs // TypeDefIndex: 6651
	{
		// Fields
		private string fileName; // 0x10
		private byte[] key; // 0x18
	
		// Properties
		public byte[] Key { get => default; } // 0x000000018947F700-0x000000018947F760 
	
		// Constructors
		public KeysRequiredEventArgs() {} // Dummy constructor
		public KeysRequiredEventArgs(string name, byte[] keyValue) {} // 0x000000018947F660-0x000000018947F700
	}
}
