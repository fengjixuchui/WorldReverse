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
	public sealed class DecoratorWeight : DecoratorNode // TypeDefIndex: 27537
	{
		// Fields
		private IInstanceMember m_weight; // 0x68
	
		// Nested types
		public class DecoratorWeightTask : DecoratorTask // TypeDefIndex: 27538
		{
			// Constructors
			public DecoratorWeightTask() {} // 0x0000000186D8B190-0x0000000186D8B230
	
			// Methods
			public int GetWeight(Agent pAgent) => default; // 0x0000000186D8B0E0-0x0000000186D8B190
			public override void copyto(BehaviorTask target) {} // 0x0000000186D8B230-0x0000000186D8B2B0
			public override void save(ISerializableNode node) {} // 0x0000000186D8B390-0x0000000186D8B410
			public override void load(ISerializableNode node) {} // 0x0000000186D8B310-0x0000000186D8B390
			protected override EBTStatus decorate(EBTStatus status) => default; // 0x0000000186D8B2B0-0x0000000186D8B310
		}
	
		// Constructors
		public DecoratorWeight() {} // 0x0000000186D8B520-0x0000000186D8B5C0
	
		// Methods
		protected override void load(int version, string agentType, List<property_t> properties) {} // 0x0000000186D8B630-0x0000000186D8B790
		private int GetWeight(Agent pAgent) => default; // 0x0000000186D8B410-0x0000000186D8B4D0
		public override bool IsManagingChildrenAsSubTrees() => default; // 0x0000000186D8B4D0-0x0000000186D8B520
		protected override BehaviorTask createTask() => default; // 0x0000000186D8B5C0-0x0000000186D8B630
	}
}
