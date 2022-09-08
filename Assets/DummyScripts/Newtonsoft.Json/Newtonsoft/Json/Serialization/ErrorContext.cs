/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using Newtonsoft.Json.Shims;

// Image 47: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=8.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5228-5529

namespace Newtonsoft.Json.Serialization
{
	[Preserve] // 0x00000001897D5F50-0x00000001897D5F60
	public class ErrorContext // TypeDefIndex: 5380
	{
		// Properties
		internal bool Traced { get; set; } // 0x00000001863490A0-0x0000000186349100 0x0000000186349280-0x00000001863492E0
		public Exception Error { get; private set; } // 0x0000000186348FE0-0x0000000186349040 0x0000000186349100-0x0000000186349160
		private object OriginalObject { get; set; } // 0x00000001863491C0-0x0000000186349220
		private object Member { get; set; } // 0x0000000186349160-0x00000001863491C0
		private string Path { get; set; } // 0x0000000186349220-0x0000000186349280
		public bool Handled { get; } // 0x0000000186349040-0x00000001863490A0 
	
		// Constructors
		public ErrorContext() {} // Dummy constructor
		internal ErrorContext(object originalObject, object member, string path, Exception error) {} // 0x0000000186348E70-0x0000000186348FE0
	}
}
