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
	public sealed class SelectorStochastic : CompositeStochastic // TypeDefIndex: 27488
	{
		// Nested types
		private class SelectorStochasticTask : CompositeStochastic.CompositeStochasticTask // TypeDefIndex: 27489
		{
			// Constructors
			public SelectorStochasticTask() {} // 0x0000000186DF3440-0x0000000186DF34A0
	
			// Methods
			protected override void addChild(BehaviorTask pBehavior) {} // 0x0000000186DF34A0-0x0000000186DF3520
			public override void copyto(BehaviorTask target) {} // 0x0000000186DF3520-0x0000000186DF35A0
			public override void save(ISerializableNode node) {} // 0x0000000186DF3740-0x0000000186DF37C0
			public override void load(ISerializableNode node) {} // 0x0000000186DF35A0-0x0000000186DF3620
			protected override bool onenter(Agent pAgent) => default; // 0x0000000186DF3620-0x0000000186DF36A0
			protected override void onexit(Agent pAgent, EBTStatus s) {} // 0x0000000186DF36A0-0x0000000186DF3740
			protected override EBTStatus update(Agent pAgent, EBTStatus childStatus) => default; // 0x0000000186DF37C0-0x0000000186DF3910
		}
	
		// Constructors
		public SelectorStochastic() {} // 0x0000000186DF39D0-0x0000000186DF3A30
	
		// Methods
		protected override void load(int version, string agentType, List<property_t> properties) {} // 0x0000000186DF3AE0-0x0000000186DF3B70
		public override bool IsValid(Agent pAgent, BehaviorTask pTask) => default; // 0x0000000186DF3910-0x0000000186DF39D0
		protected override BehaviorTask createTask() => default; // 0x0000000186DF3A30-0x0000000186DF3AE0
	}
}
