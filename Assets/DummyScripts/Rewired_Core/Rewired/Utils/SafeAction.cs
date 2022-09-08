/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Rewired;

// Image 39: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3466-4436

namespace Rewired.Utils
{
	[CustomClassObfuscation] // 0x0000000189967760-0x00000001899677B0
	[CustomObfuscation] // 0x0000000189967760-0x00000001899677B0
	internal sealed class SafeAction : SafeDelegate<Action> // TypeDefIndex: 4365
	{
		// Fields
		private static Action<object, Action> JqkKvONojrNrQhtXccOtrbSsnZb; // 0x00
	
		// Properties
		private static Action<object, Action> invokeDelegate { get => default; } // 0x00000001862F2B80-0x00000001862F2C30 
	
		// Constructors
		public SafeAction() {} // 0x00000001862F2AA0-0x00000001862F2B10
		public SafeAction(Action<Exception> exceptionHandler) {} // 0x00000001862F29A0-0x00000001862F2A20
		private SafeAction(SafeAction source) {} // 0x00000001862F2A20-0x00000001862F2AA0
	
		// Methods
		public void Invoke() {} // 0x00000001862F28E0-0x00000001862F29A0
		public override object Clone() => default; // 0x00000001862F2860-0x00000001862F28E0
		private static void bpepNPWIUMvlIWByBwlQNAILiEgd(object param_00009133, Action param_00009134) {} // 0x00000001862F2B10-0x00000001862F2B80
		public static SafeAction operator +(SafeAction eventList, Action listener) => default; // 0x00000001862F2C30-0x00000001862F2D40
		public static SafeAction operator -(SafeAction eventList, Action listener) => default; // 0x00000001862F2D40-0x00000001862F2DC0
	}
}
