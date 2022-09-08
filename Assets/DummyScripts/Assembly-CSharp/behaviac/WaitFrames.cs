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
	public class WaitFrames : BehaviorNode // TypeDefIndex: 27468
	{
		// Fields
		private IInstanceMember m_frames; // 0x60
	
		// Nested types
		private class WaitFramesTask : LeafTask // TypeDefIndex: 27469
		{
			// Fields
			private int m_start; // 0x30
			private int m_frames; // 0x34
	
			// Constructors
			public WaitFramesTask() {} // 0x0000000186DFE6C0-0x0000000186DFE720
	
			// Methods
			public override void copyto(BehaviorTask target) {} // 0x0000000186DFE720-0x0000000186DFE800
			public override void save(ISerializableNode node) {} // 0x0000000186DFE9A0-0x0000000186DFEA90
			public override void load(ISerializableNode node) {} // 0x0000000186DFE800-0x0000000186DFE880
			protected override bool onenter(Agent pAgent) => default; // 0x0000000186DFE880-0x0000000186DFE950
			protected override void onexit(Agent pAgent, EBTStatus s) {} // 0x0000000186DFE950-0x0000000186DFE9A0
			protected override EBTStatus update(Agent pAgent, EBTStatus childStatus) => default; // 0x0000000186DFEA90-0x0000000186DFEB50
			private int GetFrames(Agent pAgent) => default; // 0x0000000186DFE5E0-0x0000000186DFE6C0
		}
	
		// Constructors
		public WaitFrames() {} // 0x0000000186DFEC10-0x0000000186DFEC70
	
		// Methods
		protected override void load(int version, string agentType, List<property_t> properties) {} // 0x0000000186E002B0-0x0000000186E00460
		protected virtual int GetFrames(Agent pAgent) => default; // 0x0000000186DFEB50-0x0000000186DFEC10
		protected override BehaviorTask createTask() => default; // 0x0000000186E00200-0x0000000186E002B0
	}
}
