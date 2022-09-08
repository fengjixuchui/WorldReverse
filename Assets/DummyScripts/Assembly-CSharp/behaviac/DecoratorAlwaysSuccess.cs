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
	public sealed class DecoratorAlwaysSuccess : DecoratorNode // TypeDefIndex: 27512
	{
		// Nested types
		private class DecoratorAlwaysSuccessTask : DecoratorTask // TypeDefIndex: 27513
		{
			// Constructors
			public DecoratorAlwaysSuccessTask() {} // 0x0000000186D83810-0x0000000186D838B0
	
			// Methods
			public override void copyto(BehaviorTask target) {} // 0x0000000186D838B0-0x0000000186D83930
			public override void save(ISerializableNode node) {} // 0x0000000186D83A00-0x0000000186D83A80
			public override void load(ISerializableNode node) {} // 0x0000000186D83980-0x0000000186D83A00
			protected override EBTStatus decorate(EBTStatus status) => default; // 0x0000000186D83930-0x0000000186D83980
		}
	
		// Constructors
		public DecoratorAlwaysSuccess() {} // 0x0000000186D83B40-0x0000000186D83BE0
	
		// Methods
		protected override void load(int version, string agentType, List<property_t> properties) {} // 0x0000000186D83C50-0x0000000186D83CE0
		public override bool IsValid(Agent pAgent, BehaviorTask pTask) => default; // 0x0000000186D83A80-0x0000000186D83B40
		protected override BehaviorTask createTask() => default; // 0x0000000186D83BE0-0x0000000186D83C50
	}
}
