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
	public class Parallel : BehaviorNode // TypeDefIndex: 27478
	{
		// Fields
		protected FAILURE_POLICY m_failPolicy; // 0x60
		protected SUCCESS_POLICY m_succeedPolicy; // 0x64
		protected EXIT_POLICY m_exitPolicy; // 0x68
		protected CHILDFINISH_POLICY m_childFinishPolicy; // 0x6C
	
		// Nested types
		private class ParallelTask : CompositeTask // TypeDefIndex: 27479
		{
			// Constructors
			public ParallelTask() {} // 0x0000000186DEE000-0x0000000186DEE060
	
			// Methods
			protected override bool onenter(Agent pAgent) => default; // 0x0000000186DEE060-0x0000000186DEE0B0
			protected override void onexit(Agent pAgent, EBTStatus s) {} // 0x0000000186DEE0B0-0x0000000186DEE140
			protected override EBTStatus update_current(Agent pAgent, EBTStatus childStatus) => default; // 0x0000000186DEE140-0x0000000186DEE1D0
			protected override EBTStatus update(Agent pAgent, EBTStatus childStatus) => default; // 0x0000000186DEE1D0-0x0000000186DEE2C0
		}
	
		// Constructors
		public Parallel() {} // 0x0000000186DEE690-0x0000000186DEE710
	
		// Methods
		protected override void load(int version, string agentType, List<property_t> properties) {} // 0x0000000186DEF250-0x0000000186DEF630
		public override bool IsValid(Agent pAgent, BehaviorTask pTask) => default; // 0x0000000186DEE310-0x0000000186DEE400
		public override bool IsManagingChildrenAsSubTrees() => default; // 0x0000000186DEE2C0-0x0000000186DEE310
		private void SetPolicy(FAILURE_POLICY failPolicy, SUCCESS_POLICY successPolicy, EXIT_POLICY exitPolicty) {} // 0x0000000186DEE610-0x0000000186DEE690
		protected override BehaviorTask createTask() => default; // 0x0000000186DEF1A0-0x0000000186DEF250
		public EBTStatus ParallelUpdate(Agent pAgent, List<BehaviorTask> children) => default; // 0x0000000186DEE400-0x0000000186DEE610
	}
}
