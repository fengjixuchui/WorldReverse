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
	public abstract class DecoratorNode : BehaviorNode // TypeDefIndex: 27441
	{
		// Fields
		public bool m_bDecorateWhenChildEnds; // 0x60
	
		// Constructors
		public DecoratorNode() {} // 0x0000000186D88CA0-0x0000000186D88D10
	
		// Methods
		protected override void load(int version, string agentType, List<property_t> properties) {} // 0x0000000186D88D10-0x0000000186D88E80
		public override bool IsManagingChildrenAsSubTrees() => default; // 0x0000000186D88B60-0x0000000186D88BB0
		public override bool IsValid(Agent pAgent, BehaviorTask pTask) => default; // 0x0000000186D88BB0-0x0000000186D88CA0
	}
}
