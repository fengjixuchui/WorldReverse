/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace IFix
{
	public class WrappersManagerImpl : WrappersManager // TypeDefIndex: 32496
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
	
		// Constructors
		public WrappersManagerImpl() {} // Dummy constructor
		public WrappersManagerImpl(VirtualMachine virtualMachine) {} // 0x000000018153CF30-0x000000018153CFA0
	
		// Methods
		public static ILFixDynamicMethodWrapper GetPatch(int id) => default; // 0x000000018153CCB0-0x000000018153CD70
		public static bool IsPatched(int id) => default; // 0x000000018153CE30-0x000000018153CF30
		public Delegate CreateDelegate(System.Type type, int id, object anon) => default; // 0x000000018153CB20-0x000000018153CC10
		public object CreateWrapper(int id) => default; // 0x000000018153CC10-0x000000018153CCB0
		public object InitWrapperArray(int len) => default; // 0x000000018153CD70-0x000000018153CE30
		public AnonymousStorey CreateBridge(int fieldNum, int[] slots, VirtualMachine virtualMachine) => default; // 0x000000018153CA80-0x000000018153CB20
	}
}
