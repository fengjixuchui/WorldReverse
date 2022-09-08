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
	public class CInstanceMember<T> : IInstanceMember // TypeDefIndex: 27217
	{
		// Fields
		protected string _instance;
		protected IInstanceMember _indexMember;
	
		// Constructors
		public CInstanceMember() {}
		public CInstanceMember(string instance, IInstanceMember indexMember) {}
		public CInstanceMember(CInstanceMember<T> rhs) {}
	
		// Methods
		public int GetCount(Agent self) => default;
		public void SetValue(Agent self, IInstanceMember right, int index) {}
		public virtual T GetValue(Agent self) => default;
		public object GetValueObject(Agent self) => default;
		public virtual void SetValue(Agent self, T value) {}
		public void SetValue(Agent self, object value) {}
		public void SetValueAs(Agent self, IInstanceMember right) {}
		public void SetValue(Agent self, IInstanceMember right) {}
		public void SetValue(Agent self, CInstanceMember<T> right) {}
		public bool Compare(Agent self, IInstanceMember right, EOperatorType comparisonType) => default;
		public void Compute(Agent self, IInstanceMember right1, IInstanceMember right2, EOperatorType computeType) {}
		public virtual void Run(Agent self) {}
	}
}
