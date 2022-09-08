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
	public sealed class DecoratorCountLimit : DecoratorCount // TypeDefIndex: 27516
	{
		// Nested types
		private class DecoratorCountLimitTask : DecoratorCount.DecoratorCountTask // TypeDefIndex: 27517
		{
			// Fields
			private bool m_bInited; // 0x48
	
			// Constructors
			public DecoratorCountLimitTask() {} // 0x0000000186D83CE0-0x0000000186D83D40
	
			// Methods
			public override void copyto(BehaviorTask target) {} // 0x0000000186D83D40-0x0000000186D83E20
			public override void save(ISerializableNode node) {} // 0x0000000186D84010-0x0000000186D840E0
			public override void load(ISerializableNode node) {} // 0x0000000186D83E80-0x0000000186D83F30
			protected override bool onenter(Agent pAgent) => default; // 0x0000000186D83F30-0x0000000186D84010
			protected override EBTStatus decorate(EBTStatus status) => default; // 0x0000000186D83E20-0x0000000186D83E80
		}
	
		// Constructors
		public DecoratorCountLimit() {} // 0x0000000186D84220-0x0000000186D84280
	
		// Methods
		protected override void load(int version, string agentType, List<property_t> properties) {} // 0x0000000186D84330-0x0000000186D843C0
		public override bool IsValid(Agent pAgent, BehaviorTask pTask) => default; // 0x0000000186D84160-0x0000000186D84220
		protected override BehaviorTask createTask() => default; // 0x0000000186D84280-0x0000000186D84330
		public bool CheckIfReInit(Agent pAgent) => default; // 0x0000000186D840E0-0x0000000186D84160
	}
}
