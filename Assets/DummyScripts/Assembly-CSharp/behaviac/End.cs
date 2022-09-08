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
	public sealed class End : BehaviorNode // TypeDefIndex: 27460
	{
		// Fields
		private IInstanceMember m_endStatus; // 0x60
		private bool m_endOutside; // 0x68
	
		// Nested types
		private class EndTask : LeafTask // TypeDefIndex: 27461
		{
			// Constructors
			public EndTask() {} // 0x0000000186D8BEF0-0x0000000186D8BF50
	
			// Methods
			private EBTStatus GetStatus(Agent pAgent) => default; // 0x0000000186D8BE50-0x0000000186D8BEF0
			private bool GetEndOutside() => default; // 0x0000000186D8BD90-0x0000000186D8BE50
			protected override bool onenter(Agent pAgent) => default; // 0x0000000186D8BF50-0x0000000186D8BFA0
			protected override void onexit(Agent pAgent, EBTStatus s) {} // 0x0000000186D8BFA0-0x0000000186D8BFF0
			protected override EBTStatus update(Agent pAgent, EBTStatus childStatus) => default; // 0x0000000186D8BFF0-0x0000000186D8C0B0
		}
	
		// Constructors
		public End() {} // 0x0000000186D8C1D0-0x0000000186D8C230
	
		// Methods
		protected override void load(int version, string agentType, List<property_t> properties) {} // 0x0000000186D8C2E0-0x0000000186D8C500
		private EBTStatus GetStatus(Agent pAgent) => default; // 0x0000000186D8C110-0x0000000186D8C1D0
		private bool GetEndOutside() => default; // 0x0000000186D8C0B0-0x0000000186D8C110
		protected override BehaviorTask createTask() => default; // 0x0000000186D8C230-0x0000000186D8C2E0
	}
}
