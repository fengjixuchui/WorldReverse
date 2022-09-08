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
	public interface IProperty // TypeDefIndex: 27216
	{
		// Properties
		string Name { get; }
	
		// Methods
		void SetValue(Agent self, IInstanceMember right);
		void SetValueFromString(Agent self, string valueStr);
		object GetValueObject(Agent self);
		object GetValueObject(Agent self, int index);
		IInstanceMember CreateInstance(string instance, IInstanceMember indexMember);
		IValue CreateIValue();
	}
}
