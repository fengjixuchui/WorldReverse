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
	public class DiagnosticsTraceWriter : ITraceWriter // TypeDefIndex: 5351
	{
		// Properties
		public TraceLevel LevelFilter { get; } // 0x0000000186348A00-0x0000000186348A60 
	
		// Constructors
		public DiagnosticsTraceWriter() {} // 0x00000001863489A0-0x0000000186348A00
	
		// Methods
		private TraceEventType GetTraceEventType(TraceLevel level) => default; // 0x0000000186348600-0x00000001863486D0
		public void Trace(TraceLevel level, string message, Exception ex) {} // 0x00000001863486D0-0x00000001863489A0
	}
}
