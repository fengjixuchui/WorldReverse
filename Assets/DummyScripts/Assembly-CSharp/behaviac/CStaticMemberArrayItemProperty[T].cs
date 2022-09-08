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
	public class CStaticMemberArrayItemProperty<T> : CProperty<T> // TypeDefIndex: 27223
	{
		// Fields
		private SetFunctionPointer _sfp;
		private GetFunctionPointer _gfp;
	
		// Nested types
		public delegate void SetFunctionPointer(T v, int index); // TypeDefIndex: 27224; 0x00000000-0x00000000
	
		public delegate T GetFunctionPointer(int index); // TypeDefIndex: 27225; 0x00000000-0x00000000
	
		// Constructors
		public CStaticMemberArrayItemProperty() {} // Dummy constructor
		public CStaticMemberArrayItemProperty(string name, SetFunctionPointer sfp, GetFunctionPointer gfp) {}
	
		// Methods
		public override T GetValue(Agent self, int index) => default;
		public override void SetValue(Agent self, T value, int index) {}
	}
}
