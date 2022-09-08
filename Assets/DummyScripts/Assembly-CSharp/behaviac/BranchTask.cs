/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace behaviac
{
	public abstract class BranchTask : BehaviorTask // TypeDefIndex: 27449
	{
		// Fields
		private BehaviorTask m_currentTask; // 0x30
	
		// Constructors
		protected BranchTask() {} // 0x00000001860B6170-0x00000001860B6240
	
		// Methods
		public override void Clear() {} // 0x00000001860B5FA0-0x00000001860B6050
		protected override bool onenter(Agent pAgent) => default; // 0x00000001860B63A0-0x00000001860B63F0
		protected override void onexit(Agent pAgent, EBTStatus status) {} // 0x00000001860B6690-0x00000001860B66E0
		public override void onreset(Agent pAgent) {} // 0x00000001860B66E0-0x00000001860B6730
		private bool oneventCurrentNode(Agent pAgent, string eventName, Dictionary<uint, IInstantiatedVariable> eventParams) => default; // 0x00000001860B63F0-0x00000001860B6570
		public override bool onevent(Agent pAgent, string eventName, Dictionary<uint, IInstantiatedVariable> eventParams) => default; // 0x00000001860B6570-0x00000001860B6690
		private EBTStatus execCurrentTask(Agent pAgent, EBTStatus childStatus) => default; // 0x00000001860B6240-0x00000001860B63A0
		protected override EBTStatus update_current(Agent pAgent, EBTStatus childStatus) => default; // 0x00000001860B68A0-0x00000001860B6940
		protected EBTStatus resume_branch(Agent pAgent, EBTStatus status) => default; // 0x00000001860B6730-0x00000001860B68A0
		protected abstract void addChild(BehaviorTask pBehavior);
		public override BehaviorTask GetCurrentTask() => default; // 0x00000001860B6050-0x00000001860B60B0
		public override void SetCurrentTask(BehaviorTask task) {} // 0x00000001860B60B0-0x00000001860B6170
	}
}
