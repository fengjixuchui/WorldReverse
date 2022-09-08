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
	public sealed class FSM : BehaviorNode // TypeDefIndex: 27541
	{
		// Fields
		private int m_initialid; // 0x60
	
		// Properties
		public int InitialId { get => default; set {} } // 0x0000000186DE9F70-0x0000000186DE9FD0 0x0000000186DEA130-0x0000000186DEA190
	
		// Nested types
		public class FSMTask : CompositeTask // TypeDefIndex: 27542
		{
			// Fields
			private int m_currentNodeId; // 0x50
	
			// Constructors
			public FSMTask() {} // 0x0000000186DE9900-0x0000000186DE9970
	
			// Methods
			public override void copyto(BehaviorTask target) {} // 0x0000000186DE9970-0x0000000186DE99F0
			public override void save(ISerializableNode node) {} // 0x0000000186DE9BE0-0x0000000186DE9C60
			public override void load(ISerializableNode node) {} // 0x0000000186DE99F0-0x0000000186DE9A70
			protected override bool onenter(Agent pAgent) => default; // 0x0000000186DE9A70-0x0000000186DE9B50
			protected override void onexit(Agent pAgent, EBTStatus s) {} // 0x0000000186DE9B50-0x0000000186DE9BE0
			private EBTStatus UpdateFSM(Agent pAgent, EBTStatus childStatus) => default; // 0x0000000186DE97F0-0x0000000186DE9900
			protected override EBTStatus update_current(Agent pAgent, EBTStatus childStatus) => default; // 0x0000000186DE9C60-0x0000000186DE9CF0
			protected override EBTStatus update(Agent pAgent, EBTStatus childStatus) => default; // 0x0000000186DE9CF0-0x0000000186DE9D80
		}
	
		// Constructors
		public FSM() {} // 0x0000000186DE9E40-0x0000000186DE9EB0
	
		// Methods
		protected override void load(int version, string agentType, List<property_t> properties) {} // 0x0000000186DE9FD0-0x0000000186DEA130
		public override bool IsValid(Agent pAgent, BehaviorTask pTask) => default; // 0x0000000186DE9D80-0x0000000186DE9E40
		protected override BehaviorTask createTask() => default; // 0x0000000186DE9EB0-0x0000000186DE9F70
	}
}
