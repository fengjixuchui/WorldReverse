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
	public sealed class SelectorLoop : BehaviorNode // TypeDefIndex: 27484
	{
		// Fields
		private bool m_bResetChildren; // 0x60
	
		// Nested types
		public class SelectorLoopTask : CompositeTask // TypeDefIndex: 27485
		{
			// Constructors
			public SelectorLoopTask() {} // 0x0000000186DF1F30-0x0000000186DF1F90
	
			// Methods
			protected override void addChild(BehaviorTask pBehavior) {} // 0x0000000186DF1F90-0x0000000186DF2010
			public override void copyto(BehaviorTask target) {} // 0x0000000186DF2010-0x0000000186DF20F0
			public override void save(ISerializableNode node) {} // 0x0000000186DF2280-0x0000000186DF2340
			public override void load(ISerializableNode node) {} // 0x0000000186DF20F0-0x0000000186DF2170
			protected override bool onenter(Agent pAgent) => default; // 0x0000000186DF2170-0x0000000186DF21F0
			protected override void onexit(Agent pAgent, EBTStatus s) {} // 0x0000000186DF21F0-0x0000000186DF2280
			protected override EBTStatus update_current(Agent pAgent, EBTStatus childStatus) => default; // 0x0000000186DF2340-0x0000000186DF23D0
			protected override EBTStatus update(Agent pAgent, EBTStatus childStatus) => default; // 0x0000000186DF23D0-0x0000000186DF26F0
		}
	
		// Constructors
		public SelectorLoop() {} // 0x0000000186DF2800-0x0000000186DF2870
	
		// Methods
		protected override void load(int version, string agentType, List<property_t> properties) {} // 0x0000000186DF2920-0x0000000186DF2A80
		public override bool IsValid(Agent pAgent, BehaviorTask pTask) => default; // 0x0000000186DF2740-0x0000000186DF2800
		public override bool IsManagingChildrenAsSubTrees() => default; // 0x0000000186DF26F0-0x0000000186DF2740
		protected override BehaviorTask createTask() => default; // 0x0000000186DF2870-0x0000000186DF2920
	}
}
