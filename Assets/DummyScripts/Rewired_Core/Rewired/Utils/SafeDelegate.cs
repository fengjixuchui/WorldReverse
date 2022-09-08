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
	[CustomClassObfuscation] // 0x0000000189699A10-0x0000000189699A60
	[CustomObfuscation] // 0x0000000189699A10-0x0000000189699A60
	internal abstract class SafeDelegate : ICloneable // TypeDefIndex: 4362
	{
		// Fields
		private static Action<Exception> GVtfpblPxyirPHgZUfEtBovvWuZ; // 0x00
	
		// Properties
		internal abstract int Count { get; }
		internal static Action<Exception> S_ExceptionHandler { get; set; } // 0x00000001862F2E20-0x00000001862F2E80 0x00000001862F2E80-0x00000001862F2EE0
	
		// Constructors
		protected SafeDelegate() {} // 0x00000001862F2DC0-0x00000001862F2E20
	
		// Methods
		internal abstract void Clear();
		public abstract object Clone();
	}
}
