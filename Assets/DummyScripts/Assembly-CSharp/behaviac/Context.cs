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
	public class Context // TypeDefIndex: 27198
	{
		// Fields
		private static Dictionary<int, Context> ms_contexts; // 0x00
		private Dictionary<string, Agent> m_namedAgents; // 0x10
		private List<HeapItem_t> m_agents; // 0x18
		private int m_context_id; // 0x20
		private bool m_IsExecuting; // 0x24
		private List<Agent> delayAddedAgents; // 0x28
		private List<Agent> delayRemovedAgents; // 0x30
	
		// Properties
		public List<HeapItem_t> Agents { get => default; set {} } // 0x0000000186D82640-0x0000000186D826D0 0x0000000186D828F0-0x0000000186D82950
	
		// Nested types
		public struct HeapItem_t : IComparable<HeapItem_t> // TypeDefIndex: 27199
		{
			// Fields
			public int priority; // 0x00
			public Dictionary<int, Agent> agents; // 0x08
	
			// Methods
			public int CompareTo(HeapItem_t other) => default; // 0x0000000186D8D3F0-0x0000000186D8D480
		}
	
		// Constructors
		public Context() {} // Dummy constructor
		private Context(int contextId) {} // 0x0000000186D81EB0-0x0000000186D81FA0
		static Context() {} // 0x0000000186D81E20-0x0000000186D81EB0
	
		// Methods
		private int GetContextId() => default; // 0x0000000186D814D0-0x0000000186D81530
		public static Context GetContext(int contextId) => default; // 0x0000000186D81530-0x0000000186D816A0
		public static void Cleanup(int contextId) {} // 0x0000000186D81110-0x0000000186D81280
		public static void AddAgent(Agent pAgent) {} // 0x0000000186D80DB0-0x0000000186D80EA0
		public static void RemoveAgent(Agent pAgent) {} // 0x0000000186D81C50-0x0000000186D81D40
		private void DelayProcessingAgents() {} // 0x0000000186D81280-0x0000000186D81430
		private void addAgent_(Agent pAgent) {} // 0x0000000186D81FA0-0x0000000186D82200
		private void removeAgent_(Agent pAgent) {} // 0x0000000186D826D0-0x0000000186D828F0
		public static void execAgents(int contextId) {} // 0x0000000186D824A0-0x0000000186D82640
		private void execAgents_() {} // 0x0000000186D82200-0x0000000186D824A0
		private void LogCurrentState() {} // 0x0000000186D81820-0x0000000186D81AC0
		public static void LogCurrentStates(int contextId) {} // 0x0000000186D81AC0-0x0000000186D81C50
		private void CleanupInstances() {} // 0x0000000186D81090-0x0000000186D81110
		private static bool GetClassNameString(string variableName, ref string className) => default; // 0x0000000186D81430-0x0000000186D814D0
		public bool BindInstance(Agent pAgentInstance, string agentInstanceName) => default; // 0x0000000186D80EA0-0x0000000186D81010
		public bool BindInstance(Agent pAgentInstance) => default; // 0x0000000186D81010-0x0000000186D81090
		public bool UnbindInstance(string agentInstanceName) => default; // 0x0000000186D81D40-0x0000000186D81E20
		public bool UnbindInstance<T>() => default;
		public Agent GetInstance(string agentInstanceName) => default; // 0x0000000186D816A0-0x0000000186D81820
	}
}
