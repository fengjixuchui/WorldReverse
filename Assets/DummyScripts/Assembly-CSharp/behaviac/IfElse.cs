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
	public sealed class IfElse : BehaviorNode // TypeDefIndex: 27472
	{
		// Nested types
		private class IfElseTask : CompositeTask // TypeDefIndex: 27473
		{
			// Constructors
			public IfElseTask() {} // 0x0000000186DEB0B0-0x0000000186DEB110
	
			// Methods
			public override void copyto(BehaviorTask target) {} // 0x0000000186DEB110-0x0000000186DEB190
			public override void save(ISerializableNode node) {} // 0x0000000186DEB330-0x0000000186DEB3B0
			public override void load(ISerializableNode node) {} // 0x0000000186DEB190-0x0000000186DEB210
			protected override bool onenter(Agent pAgent) => default; // 0x0000000186DEB210-0x0000000186DEB2A0
			protected override void onexit(Agent pAgent, EBTStatus s) {} // 0x0000000186DEB2A0-0x0000000186DEB330
			protected override EBTStatus update(Agent pAgent, EBTStatus childStatus) => default; // 0x0000000186DEB3B0-0x0000000186DEB4E0
		}
	
		// Constructors
		public IfElse() {} // 0x0000000186DEB5A0-0x0000000186DEB600
	
		// Methods
		protected override void load(int version, string agentType, List<property_t> properties) {} // 0x0000000186DEB6B0-0x0000000186DEB740
		public override bool IsValid(Agent pAgent, BehaviorTask pTask) => default; // 0x0000000186DEB4E0-0x0000000186DEB5A0
		protected override BehaviorTask createTask() => default; // 0x0000000186DEB600-0x0000000186DEB6B0
	}
}
