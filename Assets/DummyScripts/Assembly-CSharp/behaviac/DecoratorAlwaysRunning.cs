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
	public sealed class DecoratorAlwaysRunning : DecoratorNode // TypeDefIndex: 27510
	{
		// Nested types
		private class DecoratorAlwaysRunningTask : DecoratorTask // TypeDefIndex: 27511
		{
			// Constructors
			public DecoratorAlwaysRunningTask() {} // 0x0000000186D832C0-0x0000000186D83360
	
			// Methods
			protected override void addChild(BehaviorTask pBehavior) {} // 0x0000000186D83360-0x0000000186D833E0
			public override void copyto(BehaviorTask target) {} // 0x0000000186D833E0-0x0000000186D83460
			public override void save(ISerializableNode node) {} // 0x0000000186D83530-0x0000000186D835B0
			public override void load(ISerializableNode node) {} // 0x0000000186D834B0-0x0000000186D83530
			protected override EBTStatus decorate(EBTStatus status) => default; // 0x0000000186D83460-0x0000000186D834B0
		}
	
		// Constructors
		public DecoratorAlwaysRunning() {} // 0x0000000186D83670-0x0000000186D83710
	
		// Methods
		protected override void load(int version, string agentType, List<property_t> properties) {} // 0x0000000186D83780-0x0000000186D83810
		public override bool IsValid(Agent pAgent, BehaviorTask pTask) => default; // 0x0000000186D835B0-0x0000000186D83670
		protected override BehaviorTask createTask() => default; // 0x0000000186D83710-0x0000000186D83780
	}
}
