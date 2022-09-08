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
	public class Wait : BehaviorNode // TypeDefIndex: 27464
	{
		// Fields
		protected IInstanceMember m_time; // 0x60
	
		// Nested types
		private class WaitTask : LeafTask // TypeDefIndex: 27465
		{
			// Fields
			private double m_start; // 0x30
			private double m_time; // 0x38
			private long m_intStart; // 0x40
			private int m_intTime; // 0x48
	
			// Constructors
			public WaitTask() {} // 0x0000000186E01560-0x0000000186E015E0
	
			// Methods
			public override void copyto(BehaviorTask target) {} // 0x0000000186E015E0-0x0000000186E016E0
			public override void save(ISerializableNode node) {} // 0x0000000186E01960-0x0000000186E01AB0
			public override void load(ISerializableNode node) {} // 0x0000000186E016E0-0x0000000186E01760
			private double GetTime(Agent pAgent) => default; // 0x0000000186E01470-0x0000000186E01560
			private int GetIntTime(Agent pAgent) => default; // 0x0000000186E013A0-0x0000000186E01470
			protected override bool onenter(Agent pAgent) => default; // 0x0000000186E01760-0x0000000186E01910
			protected override void onexit(Agent pAgent, EBTStatus s) {} // 0x0000000186E01910-0x0000000186E01960
			protected override EBTStatus update(Agent pAgent, EBTStatus childStatus) => default; // 0x0000000186E01AB0-0x0000000186E01C40
		}
	
		// Constructors
		public Wait() {} // 0x0000000186E021D0-0x0000000186E02230
	
		// Methods
		protected override void load(int version, string agentType, List<property_t> properties) {} // 0x0000000186E06EF0-0x0000000186E070A0
		protected virtual double GetTime(Agent pAgent) => default; // 0x0000000186E01FD0-0x0000000186E021D0
		protected virtual int GetIntTime(Agent pAgent) => default; // 0x0000000186E01ED0-0x0000000186E01FD0
		protected override BehaviorTask createTask() => default; // 0x0000000186E06E30-0x0000000186E06EF0
	}
}
