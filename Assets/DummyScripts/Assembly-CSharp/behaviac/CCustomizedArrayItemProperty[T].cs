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
	public class CCustomizedArrayItemProperty<T> : CProperty<T>, ICustomizedProperty // TypeDefIndex: 27235
	{
		// Fields
		private uint _parentId;
	
		// Constructors
		public CCustomizedArrayItemProperty() {} // Dummy constructor
		public CCustomizedArrayItemProperty(uint parentId, string parentName) {}
	
		// Methods
		public override T GetValue(Agent self, int index) => default;
		public override void SetValue(Agent self, T value, int index) {}
		public IInstantiatedVariable Instantiate() => default;
	}
}
