/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Image 49: Rewired_Windows.dll - Assembly: Rewired_Windows, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5537-5827

namespace Rewired.Libraries.SharpDX
{
	internal sealed class ResultDescriptor // TypeDefIndex: 5787
	{
		// Fields
		private static readonly object LockDescriptor; // 0x00
		private static readonly List<System.Type> RegisteredDescriptorProvider; // 0x08
		private static readonly Dictionary<jYVOPQCYHiqgKMeoByaWkMeLSnl, ResultDescriptor> Descriptors; // 0x10
	
		// Properties
		public jYVOPQCYHiqgKMeoByaWkMeLSnl Result { get; private set; } // 0x0000000183E8EF50-0x0000000183E8EFB0 0x0000000183E8F130-0x0000000183E8F380
		public string Module { get; private set; } // 0x0000000183E8EE90-0x0000000183E8EEF0 0x0000000183E8F070-0x0000000183E8F0D0
		public string NativeApiCode { get; private set; } // 0x0000000183E8EEF0-0x0000000183E8EF50 0x0000000183E8F0D0-0x0000000183E8F130
		public string ApiCode { get; private set; } // 0x0000000183E8EDD0-0x0000000183E8EE30 0x0000000183E8EFB0-0x0000000183E8F010
		public string Description { get; set; } // 0x0000000183E8EE30-0x0000000183E8EE90 0x0000000183E8F010-0x0000000183E8F070
	
		// Constructors
		public ResultDescriptor() {} // Dummy constructor
		public ResultDescriptor(jYVOPQCYHiqgKMeoByaWkMeLSnl code, string module, string nativeApiCode, string apiCode, string description = null) {} // 0x0000000183E8EC20-0x0000000183E8EDD0
		static ResultDescriptor() {} // 0x0000000183E8EB40-0x0000000183E8EC20
	
		// Methods
		public bool Equals(ResultDescriptor other) => default; // 0x0000000183E8DE10-0x0000000183E8DF50
		public override bool Equals(object obj) => default; // 0x0000000183E8DF50-0x0000000183E8E070
		public override int GetHashCode() => default; // 0x0000000183E8E720-0x0000000183E8E7D0
		public override string ToString() => default; // 0x0000000183E8E7D0-0x0000000183E8EB40
		public static ResultDescriptor Find(jYVOPQCYHiqgKMeoByaWkMeLSnl result) => default; // 0x0000000183E8E070-0x0000000183E8E4D0
		private static void AddDescriptorsFromType(System.Type type) {} // 0x0000000183E8DBC0-0x0000000183E8DE10
		private static string GetDescriptionFromResultCode(int resultCode) => default; // 0x0000000183E8E610-0x0000000183E8E720
		private static extern uint FormatMessageW(int dwFlags, IntPtr lpSource, int dwMessageId, int dwLanguageId, ref IntPtr lpBuffer, int nSize, IntPtr Arguments); // 0x0000000183E8E4D0-0x0000000183E8E610
	}
}
