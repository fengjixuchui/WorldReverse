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
	public sealed class WaitFramesState : State // TypeDefIndex: 27547
	{
		// Fields
		private IInstanceMember m_frames; // 0x78
	
		// Nested types
		private class WaitFramesStateTask : State.StateTask // TypeDefIndex: 27548
		{
			// Fields
			private int m_start; // 0x38
			private int m_frames; // 0x3C
	
			// Constructors
			public WaitFramesStateTask() {} // 0x0000000186DFDC80-0x0000000186DFDD30
	
			// Methods
			public override void copyto(BehaviorTask target) {} // 0x0000000186DFDD30-0x0000000186DFDE50
			public override void save(ISerializableNode node) {} // 0x0000000186DFE020-0x0000000186DFE140
			public override void load(ISerializableNode node) {} // 0x0000000186DFDE50-0x0000000186DFDF00
			protected override bool onenter(Agent pAgent) => default; // 0x0000000186DFDF00-0x0000000186DFDFD0
			protected override void onexit(Agent pAgent, EBTStatus s) {} // 0x0000000186DFDFD0-0x0000000186DFE020
			protected override EBTStatus update(Agent pAgent, EBTStatus childStatus) => default; // 0x0000000186DFE140-0x0000000186DFE260
			private int GetFrames(Agent pAgent) => default; // 0x0000000186DFDBD0-0x0000000186DFDC80
		}
	
		// Constructors
		public WaitFramesState() {} // 0x0000000186DFE320-0x0000000186DFE3C0
	
		// Methods
		protected override void load(int version, string agentType, List<property_t> properties) {} // 0x0000000186DFE430-0x0000000186DFE5E0
		private int GetFrames(Agent pAgent) => default; // 0x0000000186DFE260-0x0000000186DFE320
		protected override BehaviorTask createTask() => default; // 0x0000000186DFE3C0-0x0000000186DFE430
	}
}
