/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Reflection;
using System.Runtime.CompilerServices;

// Image 45: IFix.Core.dll - Assembly: IFix.Core, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5033-5067

namespace IFix.Core
{
	internal class ReflectionMethodInvoker // TypeDefIndex: 5057
	{
		// Fields
		private int paramCount; // 0x10
		private bool hasThis; // 0x14
		private bool hasReturn; // 0x15
		private bool[] refFlags; // 0x18
		private bool[] outFlags; // 0x20
		private System.Type[] rawTypes; // 0x28
		private MethodBase method; // 0x30
		private ConstructorInfo ctor; // 0x38
		private System.Type returnType; // 0x40
		private bool isNullableHasValue; // 0x48
		private bool isNullableValue; // 0x49
	
		// Constructors
		public ReflectionMethodInvoker() {} // Dummy constructor
		public ReflectionMethodInvoker(MethodBase method) {} // 0x0000000189418AD0-0x0000000189419100
	
		// Methods
		public void Invoke(VirtualMachine virtualMachine, ref Call call, bool isInstantiate) {} // 0x00000001894184B0-0x0000000189418AD0
	}
}
