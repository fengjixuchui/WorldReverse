/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace MessagePack.Internal
{
	internal static class InternalMemoryPool // TypeDefIndex: 8429
	{
		// Fields
		[ThreadStatic] // 0x0000000189823E60-0x0000000189823E70
		private static byte[] buffer; // 0xFFFFFFFF
	
		// Constructors
		static InternalMemoryPool() {} // 0x00000001856D2030-0x00000001856D20A0
	
		// Methods
		// [XID] // 0x00000001899BA4A0-0x00000001899BA4C0
		public static byte[] GetBuffer() => default; // 0x00000001856D1ED0-0x00000001856D2030
	}
}
