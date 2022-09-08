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
	public class CProperty<T> : IProperty // TypeDefIndex: 27218
	{
		// Fields
		private string _name;
	
		// Properties
		public string Name { get => default; }
	
		// Constructors
		public CProperty() {} // Dummy constructor
		public CProperty(string name) {}
	
		// Methods
		public IInstanceMember CreateInstance(string instance, IInstanceMember indexMember) => default;
		public IValue CreateIValue() => default;
		public object GetValueObject(Agent self) => default;
		public object GetValueObject(Agent self, int index) => default;
		public void SetValueFromString(Agent self, string valueStr) {}
		public void SetValue(Agent self, IInstanceMember right) {}
		public virtual void SetValue(Agent self, T value) {}
		public virtual void SetValue(Agent self, T value, int index) {}
		public virtual T GetValue(Agent self) => default;
		public virtual T GetValue(Agent self, int index) => default;
	}
}
