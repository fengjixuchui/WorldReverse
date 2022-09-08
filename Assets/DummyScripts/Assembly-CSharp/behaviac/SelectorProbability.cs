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
	public sealed class SelectorProbability : BehaviorNode // TypeDefIndex: 27486
	{
		// Fields
		private IMethod m_method; // 0x60
	
		// Nested types
		private class SelectorProbabilityTask : CompositeTask // TypeDefIndex: 27487
		{
			// Fields
			private List<int> m_weightingMap; // 0x50
			private int m_totalSum; // 0x58
	
			// Constructors
			public SelectorProbabilityTask() {} // 0x0000000186DF2A80-0x0000000186DF2B10
	
			// Methods
			public override void copyto(BehaviorTask target) {} // 0x0000000186DF2B10-0x0000000186DF2B90
			public override void save(ISerializableNode node) {} // 0x0000000186DF2E30-0x0000000186DF2EB0
			public override void load(ISerializableNode node) {} // 0x0000000186DF2B90-0x0000000186DF2C10
			protected override bool onenter(Agent pAgent) => default; // 0x0000000186DF2C10-0x0000000186DF2DA0
			protected override void onexit(Agent pAgent, EBTStatus s) {} // 0x0000000186DF2DA0-0x0000000186DF2E30
			protected override EBTStatus update(Agent pAgent, EBTStatus childStatus) => default; // 0x0000000186DF2EB0-0x0000000186DF30B0
		}
	
		// Constructors
		public SelectorProbability() {} // 0x0000000186DF3210-0x0000000186DF3270
	
		// Methods
		protected override void load(int version, string agentType, List<property_t> properties) {} // 0x0000000186DF32E0-0x0000000186DF3440
		public override void AddChild(BehaviorNode pBehavior) {} // 0x0000000186DF30B0-0x0000000186DF3150
		public override bool IsValid(Agent pAgent, BehaviorTask pTask) => default; // 0x0000000186DF3150-0x0000000186DF3210
		protected override BehaviorTask createTask() => default; // 0x0000000186DF3270-0x0000000186DF32E0
	}
}
