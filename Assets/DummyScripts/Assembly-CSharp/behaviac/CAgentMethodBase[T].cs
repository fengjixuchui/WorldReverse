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
	public class CAgentMethodBase<T> : CInstanceMember<T>, IMethod // TypeDefIndex: 27241
	{
		// Fields
		protected TValue<T> _returnValue;
	
		// Constructors
		protected CAgentMethodBase() {}
		protected CAgentMethodBase(CAgentMethodBase<T> rhs) {}
	
		// Methods
		public virtual IMethod Clone() => default;
		public virtual void Load(string instance, string[] paramStrs) {}
		public override void Run(Agent self) {}
		public override T GetValue(Agent self) => default;
		public virtual IValue GetIValue(Agent self) => default;
		public virtual IValue GetIValue(Agent self, IInstanceMember firstParam) => default;
		public virtual void SetTaskParams(Agent self, BehaviorTreeTask treeTask) {}
	}
}
