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
	public sealed class WaitState : State // TypeDefIndex: 27549
	{
		// Fields
		private IInstanceMember m_time; // 0x78
	
		// Nested types
		private class WaitStateTask : State.StateTask // TypeDefIndex: 27550
		{
			// Fields
			private double m_start; // 0x38
			private double m_time; // 0x40
			private long m_intStart; // 0x48
			private int m_intTime; // 0x50
	
			// Constructors
			public WaitStateTask() {} // 0x0000000186E005B0-0x0000000186E00670
	
			// Methods
			public override void copyto(BehaviorTask target) {} // 0x0000000186E00670-0x0000000186E007A0
			public override void save(ISerializableNode node) {} // 0x0000000186E00A60-0x0000000186E00BF0
			public override void load(ISerializableNode node) {} // 0x0000000186E007A0-0x0000000186E00850
			private double GetTime(Agent pAgent) => default; // 0x0000000186E00500-0x0000000186E005B0
			private int GetIntTime(Agent pAgent) => default; // 0x0000000186E00460-0x0000000186E00500
			protected override bool onenter(Agent pAgent) => default; // 0x0000000186E00850-0x0000000186E00A10
			protected override void onexit(Agent pAgent, EBTStatus s) {} // 0x0000000186E00A10-0x0000000186E00A60
			protected override EBTStatus update(Agent pAgent, EBTStatus childStatus) => default; // 0x0000000186E00BF0-0x0000000186E00DE0
		}
	
		// Constructors
		public WaitState() {} // 0x0000000186E010E0-0x0000000186E01180
	
		// Methods
		protected override void load(int version, string agentType, List<property_t> properties) {} // 0x0000000186E011F0-0x0000000186E013A0
		private double GetTime(Agent pAgent) => default; // 0x0000000186E00EE0-0x0000000186E010E0
		private int GetIntTime(Agent pAgent) => default; // 0x0000000186E00DE0-0x0000000186E00EE0
		protected override BehaviorTask createTask() => default; // 0x0000000186E01180-0x0000000186E011F0
	}
}
