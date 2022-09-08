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
	public class CVariable<T> : IInstantiatedVariable // TypeDefIndex: 27236
	{
		// Fields
		private T _value;
		private string _name;
	
		// Properties
		public string Name { get => default; }
	
		// Constructors
		public CVariable() {} // Dummy constructor
		public CVariable(string name, T value) {}
		public CVariable(string name, string valueStr) {}
	
		// Methods
		public T GetValue(Agent self) => default;
		public object GetValueObject(Agent self) => default;
		public object GetValueObject(Agent self, int index) => default;
		public void SetValueFromString(Agent self, string valueStr) {}
		public void SetValue(Agent self, T value) {}
		public void SetValue(Agent self, object value) {}
		public void SetValue(Agent self, object value, int index) {}
		public void Log(Agent self) {}
		public void CopyTo(Agent pAgent) {}
		public void Save(ISerializableNode node) {}
		public IInstantiatedVariable clone() => default;
	}
}
