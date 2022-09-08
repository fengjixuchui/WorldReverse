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
	public sealed class SequenceStochastic : CompositeStochastic // TypeDefIndex: 27492
	{
		// Nested types
		private class SequenceStochasticTask : CompositeStochastic.CompositeStochasticTask // TypeDefIndex: 27493
		{
			// Constructors
			public SequenceStochasticTask() {} // 0x0000000186DF4400-0x0000000186DF4460
	
			// Methods
			protected override void addChild(BehaviorTask pBehavior) {} // 0x0000000186DF4460-0x0000000186DF44E0
			public override void copyto(BehaviorTask target) {} // 0x0000000186DF44E0-0x0000000186DF4560
			public override void save(ISerializableNode node) {} // 0x0000000186DF46F0-0x0000000186DF4770
			public override void load(ISerializableNode node) {} // 0x0000000186DF4560-0x0000000186DF45E0
			protected override bool onenter(Agent pAgent) => default; // 0x0000000186DF45E0-0x0000000186DF4660
			protected override void onexit(Agent pAgent, EBTStatus s) {} // 0x0000000186DF4660-0x0000000186DF46F0
			protected override EBTStatus update(Agent pAgent, EBTStatus childStatus) => default; // 0x0000000186DF4770-0x0000000186DF48C0
		}
	
		// Constructors
		public SequenceStochastic() {} // 0x0000000186DF4980-0x0000000186DF49E0
	
		// Methods
		protected override void load(int version, string agentType, List<property_t> properties) {} // 0x0000000186DF4A90-0x0000000186DF4B20
		public override bool IsValid(Agent pAgent, BehaviorTask pTask) => default; // 0x0000000186DF48C0-0x0000000186DF4980
		protected override BehaviorTask createTask() => default; // 0x0000000186DF49E0-0x0000000186DF4A90
	}
}
