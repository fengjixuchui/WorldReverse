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
	public interface IInstantiatedVariable // TypeDefIndex: 27233
	{
		// Properties
		string Name { get; }
	
		// Methods
		object GetValueObject(Agent self);
		object GetValueObject(Agent self, int index);
		void SetValueFromString(Agent self, string valueStr);
		void SetValue(Agent self, object value);
		void SetValue(Agent self, object value, int index);
		void Log(Agent self);
		IInstantiatedVariable clone();
		void CopyTo(Agent pAgent);
		void Save(ISerializableNode node);
	}
}
