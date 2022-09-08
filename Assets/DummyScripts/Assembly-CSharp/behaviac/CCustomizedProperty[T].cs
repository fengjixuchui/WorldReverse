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
	public class CCustomizedProperty<T> : CProperty<T>, ICustomizedProperty // TypeDefIndex: 27234
	{
		// Fields
		private uint _id;
		private T _defaultValue;
	
		// Constructors
		public CCustomizedProperty() {} // Dummy constructor
		public CCustomizedProperty(uint id, string name, string valueStr) {}
	
		// Methods
		public override T GetValue(Agent self) => default;
		public override void SetValue(Agent self, T value) {}
		public IInstantiatedVariable Instantiate() => default;
	}
}
