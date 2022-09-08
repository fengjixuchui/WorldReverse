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
	public class Condition : ConditionBase // TypeDefIndex: 27498
	{
		// Fields
		protected IInstanceMember m_opl; // 0x60
		protected IInstanceMember m_opr; // 0x68
		protected EOperatorType m_operator; // 0x70
	
		// Nested types
		private class ConditionTask : ConditionBaseTask // TypeDefIndex: 27499
		{
			// Constructors
			public ConditionTask() {} // 0x0000000186D77730-0x0000000186D777D0
	
			// Methods
			public override void copyto(BehaviorTask target) {} // 0x0000000186D777D0-0x0000000186D77850
			public override void save(ISerializableNode node) {} // 0x0000000186D77970-0x0000000186D779F0
			public override void load(ISerializableNode node) {} // 0x0000000186D77850-0x0000000186D778D0
			protected override bool onenter(Agent pAgent) => default; // 0x0000000186D778D0-0x0000000186D77920
			protected override void onexit(Agent pAgent, EBTStatus s) {} // 0x0000000186D77920-0x0000000186D77970
			protected override EBTStatus update(Agent pAgent, EBTStatus childStatus) => default; // 0x0000000186D779F0-0x0000000186D77AE0
		}
	
		// Constructors
		public Condition() {} // 0x0000000186D77CA0-0x0000000186D77D50
	
		// Methods
		protected override void load(int version, string agentType, List<property_t> properties) {} // 0x0000000186D7FE90-0x0000000186D80160
		public override bool IsValid(Agent pAgent, BehaviorTask pTask) => default; // 0x0000000186D77BB0-0x0000000186D77CA0
		public override bool Evaluate(Agent pAgent) => default; // 0x0000000186D77AE0-0x0000000186D77BB0
		protected override BehaviorTask createTask() => default; // 0x0000000186D7FE20-0x0000000186D7FE90
	}
}
