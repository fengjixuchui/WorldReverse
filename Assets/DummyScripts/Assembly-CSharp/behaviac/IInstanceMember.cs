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
	public interface IInstanceMember // TypeDefIndex: 27215
	{
		// Methods
		int GetCount(Agent self);
		void SetValue(Agent self, IInstanceMember right, int index);
		object GetValueObject(Agent self);
		void SetValue(Agent self, object value);
		void SetValue(Agent self, IInstanceMember right);
		void SetValueAs(Agent self, IInstanceMember right);
		bool Compare(Agent self, IInstanceMember right, EOperatorType comparisonType);
		void Compute(Agent self, IInstanceMember right1, IInstanceMember right2, EOperatorType computeType);
		void Run(Agent self);
	}
}
