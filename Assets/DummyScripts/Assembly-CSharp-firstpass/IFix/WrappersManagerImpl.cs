/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace IFix
{
	public class WrappersManagerImpl : WrappersManager // TypeDefIndex: 10699
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
	
		// Constructors
		public WrappersManagerImpl() {} // Dummy constructor
		public WrappersManagerImpl(VirtualMachine virtualMachine) {} // 0x0000000187DC3460-0x0000000187DC34D0
	
		// Methods
		public static ILFixDynamicMethodWrapper GetPatch(int id) => default; // 0x0000000187DC31E0-0x0000000187DC32A0
		public static bool IsPatched(int id) => default; // 0x0000000187DC3360-0x0000000187DC3460
		public Delegate CreateDelegate(System.Type type, int id, object anon) => default; // 0x0000000187DC3050-0x0000000187DC3140
		public object CreateWrapper(int id) => default; // 0x0000000187DC3140-0x0000000187DC31E0
		public object InitWrapperArray(int len) => default; // 0x0000000187DC32A0-0x0000000187DC3360
		public AnonymousStorey CreateBridge(int fieldNum, int[] slots, VirtualMachine virtualMachine) => default; // 0x0000000187DC2FB0-0x0000000187DC3050
	}
}
