/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace InControl
{
	public class MouseBindingSourceListener : BindingSourceListener // TypeDefIndex: 7608
	{
		// Fields
		public static float ScrollWheelThreshold; // 0x00
		private Mouse detectFound; // 0x10
		private int detectPhase; // 0x14
	
		// Constructors
		public MouseBindingSourceListener() {} // 0x000000018886ABB0-0x000000018886AC10
		static MouseBindingSourceListener() {} // 0x000000018886AB50-0x000000018886ABB0
	
		// Methods
		// [XID] // 0x00000001896153B0-0x00000001896153D0
		public void Reset() {} // 0x000000018886AAB0-0x000000018886AB50
		// [XID] // 0x00000001898B1990-0x00000001898B19B0
		public BindingSource Listen(BindingListenOptions listenOptions, InputDevice device) => default; // 0x000000018886A960-0x000000018886AAB0
		// [XID] // 0x00000001898B9500-0x00000001898B9520
		private bool IsPressed(Mouse control) => default; // 0x000000018886A5C0-0x000000018886A770
		// [XID] // 0x00000001898C09A0-0x00000001898C09C0
		private Mouse ListenForControl(BindingListenOptions listenOptions) => default; // 0x000000018886A770-0x000000018886A960
	}
}
