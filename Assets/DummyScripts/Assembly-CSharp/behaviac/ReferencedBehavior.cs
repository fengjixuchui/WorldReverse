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
	public sealed class ReferencedBehavior : BehaviorNode // TypeDefIndex: 27480
	{
		// Fields
		private List<Transition> m_transitions; // 0x60
		private IInstanceMember m_referencedBehaviorPath; // 0x68
		private IMethod m_taskMethod; // 0x70
		private Task m_taskNode; // 0x78
	
		// Nested types
		public class ReferencedBehaviorTask : SingeChildTask // TypeDefIndex: 27481
		{
			// Fields
			private int m_nextStateId; // 0x40
			private BehaviorTreeTask m_subTree; // 0x48
	
			// Constructors
			public ReferencedBehaviorTask() {} // 0x0000000186DF11A0-0x0000000186DF1260
	
			// Methods
			protected override bool CheckPreconditions(Agent pAgent, bool bIsAlive) => default; // 0x0000000186DF10B0-0x0000000186DF1140
			public override int GetNextStateId() => default; // 0x0000000186DF1140-0x0000000186DF11A0
			public override bool onevent(Agent pAgent, string eventName, Dictionary<uint, IInstantiatedVariable> eventPrams) => default; // 0x0000000186DF1440-0x0000000186DF1520
			protected override bool onenter(Agent pAgent) => default; // 0x0000000186DF1260-0x0000000186DF1440
			protected override void onexit(Agent pAgent, EBTStatus s) {} // 0x0000000186DF1520-0x0000000186DF15B0
			protected override EBTStatus update(Agent pAgent, EBTStatus childStatus) => default; // 0x0000000186DF15B0-0x0000000186DF16D0
		}
	
		// Constructors
		public ReferencedBehavior() {} // 0x0000000186DF1B70-0x0000000186DF1BD0
	
		// Methods
		protected override void load(int version, string agentType, List<property_t> properties) {} // 0x0000000186DF1C40-0x0000000186DF1F30
		public override void Attach(BehaviorNode pAttachment, bool bIsPrecondition, bool bIsEffector, bool bIsTransition) {} // 0x0000000186DF16D0-0x0000000186DF1810
		public override bool IsValid(Agent pAgent, BehaviorTask pTask) => default; // 0x0000000186DF1900-0x0000000186DF19C0
		protected override BehaviorTask createTask() => default; // 0x0000000186DF1BD0-0x0000000186DF1C40
		public string GetReferencedTree(Agent pAgent) => default; // 0x0000000186DF1810-0x0000000186DF1900
		public void SetTaskParams(Agent agent, BehaviorTreeTask treeTask) {} // 0x0000000186DF1AD0-0x0000000186DF1B70
		public Task RootTaskNode(Agent pAgent) => default; // 0x0000000186DF19C0-0x0000000186DF1AD0
	}
}
