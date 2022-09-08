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
	public class State : BehaviorNode // TypeDefIndex: 27544
	{
		// Fields
		protected bool m_bIsEndState; // 0x60
		protected IMethod m_method; // 0x68
		protected List<Transition> m_transitions; // 0x70
	
		// Properties
		public bool IsEndState { get => default; } // 0x0000000186DF6D30-0x0000000186DF6D90 
	
		// Nested types
		public class StateTask : LeafTask // TypeDefIndex: 27545
		{
			// Fields
			protected int m_nextStateId; // 0x30
	
			// Properties
			public bool IsEndState { get => default; } // 0x0000000186DF63B0-0x0000000186DF64B0 
	
			// Constructors
			public StateTask() {} // 0x0000000186DF62C0-0x0000000186DF6330
	
			// Methods
			public override void copyto(BehaviorTask target) {} // 0x0000000186DF6330-0x0000000186DF63B0
			public override void save(ISerializableNode node) {} // 0x0000000186DF65E0-0x0000000186DF6660
			public override void load(ISerializableNode node) {} // 0x0000000186DF64B0-0x0000000186DF6530
			public override int GetNextStateId() => default; // 0x0000000186DF6260-0x0000000186DF62C0
			protected override bool onenter(Agent pAgent) => default; // 0x0000000186DF6530-0x0000000186DF6590
			protected override void onexit(Agent pAgent, EBTStatus s) {} // 0x0000000186DF6590-0x0000000186DF65E0
			protected override EBTStatus update(Agent pAgent, EBTStatus childStatus) => default; // 0x0000000186DF6660-0x0000000186DF6740
		}
	
		// Constructors
		public State() {} // 0x0000000186DF6C10-0x0000000186DF6C70
	
		// Methods
		protected override void load(int version, string agentType, List<property_t> properties) {} // 0x0000000186DF6D90-0x0000000186DF6F60
		public override void Attach(BehaviorNode pAttachment, bool bIsPrecondition, bool bIsEffector, bool bIsTransition) {} // 0x0000000186DF6740-0x0000000186DF6880
		public override bool IsValid(Agent pAgent, BehaviorTask pTask) => default; // 0x0000000186DF6930-0x0000000186DF6A20
		public EBTStatus Execute(Agent pAgent) => default; // 0x0000000186DF6880-0x0000000186DF6930
		protected override BehaviorTask createTask() => default; // 0x0000000186DF6C70-0x0000000186DF6D30
		public EBTStatus Update(Agent pAgent, out int nextStateId) {
			nextStateId = default;
			return default;
		} // 0x0000000186DF6B50-0x0000000186DF6C10
		public static bool UpdateTransitions(Agent pAgent, BehaviorNode node, List<Transition> transitions, ref int nextStateId, EBTStatus result) => default; // 0x0000000186DF6A20-0x0000000186DF6B50
	}
}
