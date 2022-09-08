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
	public abstract class BehaviorTask // TypeDefIndex: 27446
	{
		// Fields
		private const int kMaxParentsCount = 512; // Metadata: 0x00B0C9D5
		private static BehaviorTask[] ms_parents; // 0x00
		protected static NodeHandler_t getRunningNodes_handler_; // 0x08
		protected static NodeHandler_t end_handler_; // 0x10
		protected static NodeHandler_t abort_handler_; // 0x18
		protected static NodeHandler_t reset_handler_; // 0x20
		public EBTStatus m_status; // 0x10
		protected BehaviorNode m_node; // 0x18
		protected BranchTask m_parent; // 0x20
		protected int m_id; // 0x28
		protected bool m_bHasManagingParent; // 0x2C
	
		// Properties
		public BehaviorTreeTask RootTask { get; } // 0x00000001860B37B0-0x00000001860B3870 
	
		// Constructors
		protected BehaviorTask() {} // 0x00000001860B31D0-0x00000001860B3240
		static BehaviorTask() {} // 0x00000001860B2FB0-0x00000001860B31D0
	
		// Methods
		public static void DestroyTask(BehaviorTask task) {} // 0x00000001860B2310-0x00000001860B2360
		public virtual void Init(BehaviorNode node) {} // 0x00000001860B2D40-0x00000001860B2DF0
		public virtual void Clear() {} // 0x00000001860B22B0-0x00000001860B2310
		public virtual void copyto(BehaviorTask target) {} // 0x00000001860B33B0-0x00000001860B3430
		public virtual void save(ISerializableNode node) {} // 0x00000001860B3DB0-0x00000001860B3E00
		public virtual void load(ISerializableNode node) {} // 0x00000001860B3870-0x00000001860B38C0
		public string GetClassNameString() => default; // 0x00000001860B23F0-0x00000001860B24A0
		public int GetId() => default; // 0x00000001860B24F0-0x00000001860B2550
		public virtual int GetNextStateId() => default; // 0x00000001860B2550-0x00000001860B25A0
		public virtual BehaviorTask GetCurrentTask() => default; // 0x00000001860B24A0-0x00000001860B24F0
		public EBTStatus exec(Agent pAgent) => default; // 0x00000001860B3520-0x00000001860B35A0
		public EBTStatus exec(Agent pAgent, EBTStatus childStatus) => default; // 0x00000001860B35A0-0x00000001860B36F0
		private bool CheckParentUpdatePreconditions(Agent pAgent) => default; // 0x00000001860B1F30-0x00000001860B21F0
		private BranchTask GetTopManageBranchTask() => default; // 0x00000001860B2C20-0x00000001860B2D40
		private static bool getRunningNodes_handler(BehaviorTask node, Agent pAgent, object user_data) => default; // 0x00000001860B36F0-0x00000001860B37B0
		private static bool end_handler(BehaviorTask node, Agent pAgent, object user_data) => default; // 0x00000001860B3430-0x00000001860B3520
		private static bool abort_handler(BehaviorTask node, Agent pAgent, object user_data) => default; // 0x00000001860B3240-0x00000001860B32F0
		private static bool reset_handler(BehaviorTask node, Agent pAgent, object user_data) => default; // 0x00000001860B3C40-0x00000001860B3CF0
		public List<BehaviorTask> GetRunningNodes(bool onlyLeaves = true /* Metadata: 0x00B0C9D4 */) => default; // 0x00000001860B2840-0x00000001860B2A30
		public void abort(Agent pAgent) {} // 0x00000001860B32F0-0x00000001860B33B0
		public void reset(Agent pAgent) {} // 0x00000001860B3CF0-0x00000001860B3DB0
		public EBTStatus GetStatus() => default; // 0x00000001860B2A30-0x00000001860B2A90
		public void SetStatus(EBTStatus s) {} // 0x00000001860B2F00-0x00000001860B2F60
		public BehaviorNode GetNode() => default; // 0x00000001860B25A0-0x00000001860B2600
		public void SetParent(BranchTask parent) {} // 0x00000001860B2EA0-0x00000001860B2F00
		public BranchTask GetParent() => default; // 0x00000001860B27E0-0x00000001860B2840
		public abstract void traverse(bool childFirst, NodeHandler_t handler, Agent pAgent, object user_data);
		public bool CheckEvents(string eventName, Agent pAgent, Dictionary<uint, IInstantiatedVariable> eventParams) => default; // 0x00000001860B1E90-0x00000001860B1F30
		public virtual void onreset(Agent pAgent) {} // 0x00000001860B3BF0-0x00000001860B3C40
		public virtual bool onevent(Agent pAgent, string eventName, Dictionary<uint, IInstantiatedVariable> eventParams) => default; // 0x00000001860B39E0-0x00000001860B3AE0
		protected virtual EBTStatus update_current(Agent pAgent, EBTStatus childStatus) => default; // 0x00000001860B3E00-0x00000001860B3E90
		protected virtual EBTStatus update(Agent pAgent, EBTStatus childStatus) => default; // 0x00000001860B3E90-0x00000001860B3EE0
		protected virtual bool onenter(Agent pAgent) => default; // 0x00000001860B3990-0x00000001860B39E0
		protected virtual void onexit(Agent pAgent, EBTStatus status) {} // 0x00000001860B3BA0-0x00000001860B3BF0
		public static string GetTickInfo(Agent pAgent, BehaviorTask bt, string action) => default; // 0x00000001860B2B20-0x00000001860B2C20
		public static string GetTickInfo(Agent pAgent, BehaviorNode n, string action) => default; // 0x00000001860B2A90-0x00000001860B2B20
		public static string GetParentTreeName(Agent pAgent, BehaviorNode n) => default; // 0x00000001860B2600-0x00000001860B27E0
		private static string GetActionResultStr(EActionResult actionResult) => default; // 0x00000001860B2360-0x00000001860B23F0
		private static void _MY_BREAKPOINT_BREAK_(Agent pAgent, string btMsg, EActionResult actionResult) {} // 0x00000001860B2F60-0x00000001860B2FB0
		public static void CHECK_BREAKPOINT(Agent pAgent, BehaviorNode b, string action, EActionResult actionResult) {} // 0x00000001860B1E40-0x00000001860B1E90
		protected virtual bool CheckPreconditions(Agent pAgent, bool bIsAlive) => default; // 0x00000001860B21F0-0x00000001860B22B0
		public bool onenter_action(Agent pAgent) => default; // 0x00000001860B38C0-0x00000001860B3990
		public void onexit_action(Agent pAgent, EBTStatus status) {} // 0x00000001860B3AE0-0x00000001860B3BA0
		public void SetHasManagingParent(bool bHasManagingParent) {} // 0x00000001860B2E40-0x00000001860B2EA0
		public virtual void SetCurrentTask(BehaviorTask task) {} // 0x00000001860B2DF0-0x00000001860B2E40
	}
}
