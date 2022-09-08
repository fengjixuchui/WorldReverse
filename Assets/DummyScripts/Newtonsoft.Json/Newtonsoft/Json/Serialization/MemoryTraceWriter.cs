/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
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
	public class MemoryTraceWriter : ITraceWriter // TypeDefIndex: 5355
	{
		// Fields
		private readonly Queue<string> _traceMessages; // 0x10
	
		// Properties
		public TraceLevel LevelFilter { get; set; } // 0x0000000185E5F3F0-0x0000000185E5F450 0x0000000185E5F450-0x0000000185E5F4B0
	
		// Constructors
		public MemoryTraceWriter() {} // 0x0000000185E5F320-0x0000000185E5F3F0
	
		// Methods
		public void Trace(TraceLevel level, string message, Exception ex) {} // 0x0000000185E5F100-0x0000000185E5F320
		public override string ToString() => default; // 0x0000000185E5EF70-0x0000000185E5F100
	}
}
