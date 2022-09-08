/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Runtime.CompilerServices;

// Image 45: IFix.Core.dll - Assembly: IFix.Core, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5033-5067

namespace IFix.Core
{
	internal class ThreadStackInfo // TypeDefIndex: 5059
	{
		// Fields
		public unsafe UnmanagedStack* UnmanagedStack; // 0x10
		public object[] ManagedStack; // 0x18
		private IntPtr evaluationStackHandler; // 0x20
		private IntPtr unmanagedStackHandler; // 0x28
		private static LocalDataStoreSlot localSlot; // 0x00
	
		// Properties
		internal static ThreadStackInfo Stack { get => default; } // 0x00000001894193F0-0x00000001894195A0 
	
		// Constructors
		public ThreadStackInfo() {} // 0x00000001894192B0-0x00000001894193F0
		static ThreadStackInfo() {} // 0x0000000189419220-0x00000001894192B0
	}
}
