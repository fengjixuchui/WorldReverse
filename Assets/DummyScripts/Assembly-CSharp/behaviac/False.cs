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
	public sealed class False : ConditionBase // TypeDefIndex: 27502
	{
		// Nested types
		private class FalseTask : ConditionBaseTask // TypeDefIndex: 27503
		{
			// Constructors
			public FalseTask() {} // 0x0000000186DEA190-0x0000000186DEA1F0
	
			// Methods
			public override void copyto(BehaviorTask target) {} // 0x0000000186DEA1F0-0x0000000186DEA270
			public override void save(ISerializableNode node) {} // 0x0000000186DEA2F0-0x0000000186DEA370
			public override void load(ISerializableNode node) {} // 0x0000000186DEA270-0x0000000186DEA2F0
			protected override EBTStatus update(Agent pAgent, EBTStatus childStatus) => default; // 0x0000000186DEA370-0x0000000186DEA3C0
		}
	
		// Constructors
		public False() {} // 0x0000000186DEA480-0x0000000186DEA4E0
	
		// Methods
		protected override void load(int version, string agentType, List<property_t> properties) {} // 0x0000000186DEA590-0x0000000186DEA620
		public override bool IsValid(Agent pAgent, BehaviorTask pTask) => default; // 0x0000000186DEA3C0-0x0000000186DEA480
		protected override BehaviorTask createTask() => default; // 0x0000000186DEA4E0-0x0000000186DEA590
	}
}
