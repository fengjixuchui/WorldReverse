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
	public sealed class True : ConditionBase // TypeDefIndex: 27506
	{
		// Nested types
		private class TrueTask : ConditionBaseTask // TypeDefIndex: 27507
		{
			// Constructors
			public TrueTask() {} // 0x0000000186DF9910-0x0000000186DF9970
	
			// Methods
			public override void copyto(BehaviorTask target) {} // 0x0000000186DF9970-0x0000000186DF99F0
			public override void save(ISerializableNode node) {} // 0x0000000186DF9A70-0x0000000186DF9AF0
			public override void load(ISerializableNode node) {} // 0x0000000186DF99F0-0x0000000186DF9A70
			protected override EBTStatus update(Agent pAgent, EBTStatus childStatus) => default; // 0x0000000186DF9AF0-0x0000000186DF9B40
		}
	
		// Constructors
		public True() {} // 0x0000000186DF9C00-0x0000000186DF9C60
	
		// Methods
		protected override void load(int version, string agentType, List<property_t> properties) {} // 0x0000000186DF9D10-0x0000000186DF9DA0
		public override bool IsValid(Agent pAgent, BehaviorTask pTask) => default; // 0x0000000186DF9B40-0x0000000186DF9C00
		protected override BehaviorTask createTask() => default; // 0x0000000186DF9C60-0x0000000186DF9D10
	}
}
