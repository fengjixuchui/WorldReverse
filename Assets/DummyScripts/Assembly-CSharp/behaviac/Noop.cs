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
	public sealed class Noop : BehaviorNode // TypeDefIndex: 27462
	{
		// Nested types
		private class NoopTask : LeafTask // TypeDefIndex: 27463
		{
			// Constructors
			public NoopTask() {} // 0x0000000186DED130-0x0000000186DED190
	
			// Methods
			public override void copyto(BehaviorTask target) {} // 0x0000000186DED190-0x0000000186DED210
			public override void save(ISerializableNode node) {} // 0x0000000186DED330-0x0000000186DED3B0
			public override void load(ISerializableNode node) {} // 0x0000000186DED210-0x0000000186DED290
			protected override bool onenter(Agent pAgent) => default; // 0x0000000186DED290-0x0000000186DED2E0
			protected override void onexit(Agent pAgent, EBTStatus s) {} // 0x0000000186DED2E0-0x0000000186DED330
			protected override EBTStatus update(Agent pAgent, EBTStatus childStatus) => default; // 0x0000000186DED3B0-0x0000000186DED400
		}
	
		// Constructors
		public Noop() {} // 0x0000000186DED490-0x0000000186DED4F0
	
		// Methods
		protected override void load(int version, string agentType, List<property_t> properties) {} // 0x0000000186DED5A0-0x0000000186DED630
		public override bool IsValid(Agent pAgent, BehaviorTask pTask) => default; // 0x0000000186DED400-0x0000000186DED490
		protected override BehaviorTask createTask() => default; // 0x0000000186DED4F0-0x0000000186DED5A0
	}
}
