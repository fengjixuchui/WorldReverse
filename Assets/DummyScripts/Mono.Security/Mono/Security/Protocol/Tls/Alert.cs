/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Image 1: Mono.Security.dll - Assembly: Mono.Security, Version=2.0.0.0, Culture=neutral, PublicKeyToken=0738eb9f132ed756 - Types 1030-1183

namespace Mono.Security.Protocol.Tls
{
	internal class Alert // TypeDefIndex: 1107
	{
		// Fields
		private AlertLevel level; // 0x10
		private AlertDescription description; // 0x11
	
		// Properties
		public AlertLevel Level { get => default; } // 0x00000001873A91B0-0x00000001873A9210 
		public AlertDescription Description { get => default; } // 0x00000001873A9040-0x00000001873A90A0 
		public bool IsWarning { get => default; } // 0x00000001873A9150-0x00000001873A91B0 
		public bool IsCloseNotify { get => default; } // 0x00000001873A90A0-0x00000001873A9150 
	
		// Constructors
		public Alert() {} // Dummy constructor
		public Alert(AlertDescription description) {} // 0x00000001873A8FC0-0x00000001873A9040
		public Alert(AlertLevel level, AlertDescription description) {} // 0x00000001873A8F30-0x00000001873A8FC0
	
		// Methods
		private void inferAlertLevel() {} // 0x00000001873A9210-0x00000001873A92E0
		public static string GetAlertMessage(AlertDescription description) => default; // 0x00000001873A8ED0-0x00000001873A8F30
	}
}
