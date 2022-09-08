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
	public sealed class Event : ConditionBase // TypeDefIndex: 27433
	{
		// Fields
		private string m_eventName; // 0x60
		private string m_referencedBehaviorPath; // 0x68
		private TriggerMode m_triggerMode; // 0x70
		private bool m_bTriggeredOnce; // 0x74
	
		// Constructors
		public Event() {} // 0x0000000186D8C6E0-0x0000000186D8C7A0
	
		// Methods
		protected override void load(int version, string agentType, List<property_t> properties) {} // 0x0000000186D8C7F0-0x0000000186D8CB40
		public string GetEventName() => default; // 0x0000000186D8C500-0x0000000186D8C560
		public bool TriggeredOnce() => default; // 0x0000000186D8C680-0x0000000186D8C6E0
		public TriggerMode GetTriggerMode() => default; // 0x0000000186D8C560-0x0000000186D8C5C0
		public void switchTo(Agent pAgent, Dictionary<uint, IInstantiatedVariable> eventParams) {} // 0x0000000186D8CB40-0x0000000186D8CCA0
		public override bool IsValid(Agent pAgent, BehaviorTask pTask) => default; // 0x0000000186D8C5C0-0x0000000186D8C680
		protected override BehaviorTask createTask() => default; // 0x0000000186D8C7A0-0x0000000186D8C7F0
	}
}
