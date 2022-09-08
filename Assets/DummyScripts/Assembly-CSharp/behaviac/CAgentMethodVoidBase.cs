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
	public class CAgentMethodVoidBase : IMethod // TypeDefIndex: 27302
	{
		// Fields
		protected string _instance; // 0x10
	
		// Constructors
		public CAgentMethodVoidBase() {} // 0x0000000186D6CD90-0x0000000186D6CE00
		public CAgentMethodVoidBase(CAgentMethodVoidBase rhs) {} // 0x0000000186D6CD00-0x0000000186D6CD90
	
		// Methods
		public virtual IMethod Clone() => default; // 0x0000000186D6C800-0x0000000186D6C850
		public virtual void Load(string instance, string[] paramStrs) {} // 0x0000000186D6CA70-0x0000000186D6CAD0
		public int GetCount(Agent self) => default; // 0x0000000186D6C8F0-0x0000000186D6C940
		public void SetValue(Agent self, IInstanceMember right, int index) {} // 0x0000000186D6CC60-0x0000000186D6CCB0
		public virtual void Run(Agent self) {} // 0x0000000186D6CAD0-0x0000000186D6CB20
		public IValue GetIValue(Agent self) => default; // 0x0000000186D6C940-0x0000000186D6C990
		public object GetValueObject(Agent self) => default; // 0x0000000186D6CA20-0x0000000186D6CA70
		public IValue GetIValue(Agent self, IInstanceMember firstParam) => default; // 0x0000000186D6C990-0x0000000186D6CA20
		public void SetValue(Agent self, IValue value) {} // 0x0000000186D6CC10-0x0000000186D6CC60
		public void SetValue(Agent self, object value) {} // 0x0000000186D6CBC0-0x0000000186D6CC10
		public void SetValueAs(Agent self, IInstanceMember right) {} // 0x0000000186D6CB70-0x0000000186D6CBC0
		public void SetValue(Agent self, IInstanceMember right) {} // 0x0000000186D6CCB0-0x0000000186D6CD00
		public bool Compare(Agent self, IInstanceMember right, EOperatorType comparisonType) => default; // 0x0000000186D6C850-0x0000000186D6C8A0
		public void Compute(Agent self, IInstanceMember right1, IInstanceMember right2, EOperatorType computeType) {} // 0x0000000186D6C8A0-0x0000000186D6C8F0
		public virtual void SetTaskParams(Agent self, BehaviorTreeTask treeTask) {} // 0x0000000186D6CB20-0x0000000186D6CB70
	}
}
