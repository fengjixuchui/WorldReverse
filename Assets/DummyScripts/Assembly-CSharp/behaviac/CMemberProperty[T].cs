/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace behaviac
{
	public class CMemberProperty<T> : CProperty<T> // TypeDefIndex: 27226
	{
		// Fields
		private SetFunctionPointer _sfp;
		private GetFunctionPointer _gfp;
	
		// Nested types
		public delegate void SetFunctionPointer(Agent a, T v); // TypeDefIndex: 27227; 0x00000000-0x00000000
	
		public delegate T GetFunctionPointer(Agent a); // TypeDefIndex: 27228; 0x00000000-0x00000000
	
		// Constructors
		public CMemberProperty() {} // Dummy constructor
		public CMemberProperty(string name, SetFunctionPointer sfp, GetFunctionPointer gfp) {}
	
		// Methods
		public override T GetValue(Agent self) => default;
		public override void SetValue(Agent self, T value) {}
	}
}
