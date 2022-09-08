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
	public sealed class DecoratorFrames : DecoratorNode // TypeDefIndex: 27520
	{
		// Fields
		private IInstanceMember m_frames; // 0x68
	
		// Nested types
		private class DecoratorFramesTask : DecoratorTask // TypeDefIndex: 27521
		{
			// Fields
			private int m_start; // 0x40
			private int m_frames; // 0x44
	
			// Constructors
			public DecoratorFramesTask() {} // 0x0000000186D85140-0x0000000186D851F0
	
			// Methods
			public override void copyto(BehaviorTask target) {} // 0x0000000186D851F0-0x0000000186D852D0
			public override void save(ISerializableNode node) {} // 0x0000000186D854F0-0x0000000186D85620
			public override void load(ISerializableNode node) {} // 0x0000000186D85390-0x0000000186D85410
			protected override bool onenter(Agent pAgent) => default; // 0x0000000186D85410-0x0000000186D854F0
			protected override EBTStatus decorate(EBTStatus status) => default; // 0x0000000186D852D0-0x0000000186D85390
			private int GetFrames(Agent pAgent) => default; // 0x0000000186D85090-0x0000000186D85140
		}
	
		// Constructors
		public DecoratorFrames() {} // 0x0000000186D856E0-0x0000000186D85780
	
		// Methods
		protected override void load(int version, string agentType, List<property_t> properties) {} // 0x0000000186D857F0-0x0000000186D859A0
		private int GetFrames(Agent pAgent) => default; // 0x0000000186D85620-0x0000000186D856E0
		protected override BehaviorTask createTask() => default; // 0x0000000186D85780-0x0000000186D857F0
	}
}
