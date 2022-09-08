/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace RuntimeInspectorNamespace
{
	public struct ExposedMethod // TypeDefIndex: 10021
	{
		// Fields
		private readonly MethodInfo method; // 0x00
		private readonly RuntimeInspectorButtonAttribute properties; // 0x08
		private readonly bool isExtensionMethod; // 0x10
	
		// Properties
		public string Label { /* [XID] */ /* 0x00000001899CCDC0-0x00000001899CCDE0 */ get => default; } // 0x00000001867EE7F0-0x00000001867EE8C0 
		public bool IsInitializer { /* [XID] */ /* 0x00000001898C6680-0x00000001898C66A0 */ get => default; } // 0x00000001867EE730-0x00000001867EE7F0 
		public bool VisibleWhenInitialized { /* [XID] */ /* 0x000000018974E710-0x000000018974E730 */ get => default; } // 0x00000001867EE8C0-0x00000001867EE990 
		public bool VisibleWhenUninitialized { /* [XID] */ /* 0x00000001898D5730-0x00000001898D5750 */ get => default; } // 0x00000001867EE990-0x00000001867EE9C0 
	
		// Constructors
		public ExposedMethod(MethodInfo method, RuntimeInspectorButtonAttribute properties, bool isExtensionMethod) : this() {
			this.method = default;
			this.properties = default;
			this.isExtensionMethod = default;
		} // 0x00000001867EE670-0x00000001867EE730
	
		// Methods
		// [XID] // 0x00000001898DD0D0-0x00000001898DD0F0
		public void Call(object source) {} // 0x00000001867EE5D0-0x00000001867EE670
		// [XID] // 0x0000000189A26780-0x0000000189A267A0
		public object CallAndReturnValue(object source) => default; // 0x00000001867EE410-0x00000001867EE5D0
	}
}
