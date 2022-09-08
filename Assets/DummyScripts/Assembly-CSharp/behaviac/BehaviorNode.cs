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
	public abstract class BehaviorNode // TypeDefIndex: 27440
	{
		// Fields
		private string m_className; // 0x10
		private int m_id; // 0x18
		protected List<BehaviorNode> m_events; // 0x20
		private List<Precondition> m_preconditions; // 0x28
		private List<Effector> m_effectors; // 0x30
		protected bool m_loadAttachment; // 0x38
		private byte m_enter_precond; // 0x39
		private byte m_update_precond; // 0x3A
		private byte m_both_precond; // 0x3B
		private byte m_success_effectors; // 0x3C
		private byte m_failure_effectors; // 0x3D
		private byte m_both_effectors; // 0x3E
		protected BehaviorNode m_parent; // 0x40
		protected List<BehaviorNode> m_children; // 0x48
		protected BehaviorNode m_customCondition; // 0x50
		protected bool m_bHasEvents; // 0x58
	
		// Properties
		public BehaviorNode Parent { get; } // 0x00000001860AFE60-0x00000001860AFEC0 
		public int PreconditionsCount { get; } // 0x00000001860AFEC0-0x00000001860AFF40 
	
		// Constructors
		protected BehaviorNode() {} // 0x00000001860AFD50-0x00000001860AFDC0
	
		// Methods
		public BehaviorTask CreateAndInitTask() => default; // 0x00000001860AF560-0x00000001860AF600
		public bool HasEvents() => default; // 0x00000001860AFAD0-0x00000001860AFB30
		public void SetHasEvents(bool hasEvents) {} // 0x00000001860AFC90-0x00000001860AFCF0
		public int GetChildrenCount() => default; // 0x00000001860AF930-0x00000001860AF9B0
		public BehaviorNode GetChild(int index) => default; // 0x00000001860AF880-0x00000001860AF930
		public BehaviorNode GetChildById(int nodeId) => default; // 0x00000001860AF780-0x00000001860AF880
		public void Clear() {} // 0x00000001860AF3E0-0x00000001860AF4B0
		public virtual bool IsValid(Agent pAgent, BehaviorTask pTask) => default; // 0x00000001860AFB80-0x00000001860AFBD0
		public virtual bool IsManagingChildrenAsSubTrees() => default; // 0x00000001860AFB30-0x00000001860AFB80
		protected static BehaviorNode Create(string className) => default; // 0x00000001860AF600-0x00000001860AF6A0
		protected virtual void load(int version, string agentType, List<property_t> properties) {} // 0x00000001860B0C70-0x00000001860B0D80
		protected virtual void load_local(int version, string agentType, SecurityElement node) {} // 0x00000001860B08B0-0x00000001860B0900
		protected void load_properties_pars_attachments_children(bool bNode, int version, string agentType, SecurityElement node) {} // 0x00000001860B14B0-0x00000001860B1990
		private void load_attachment_transition_effectors(int version, string agentType, bool bHasEvents, SecurityElement c) {} // 0x00000001860B01F0-0x00000001860B0290
		private bool load_attachment(int version, string agentType, bool bHasEvents, SecurityElement c) => default; // 0x00000001860AFF40-0x00000001860B01F0
		private bool load_property_pars(ref List<property_t> properties, SecurityElement c, int version, string agentType) => default; // 0x00000001860B1990-0x00000001860B1DF0
		protected static BehaviorNode load(string agentType, SecurityElement node, int version) => default; // 0x00000001860B0D80-0x00000001860B0F20
		protected void load_properties(int version, string agentType, BsonDeserizer d) {} // 0x00000001860B1090-0x00000001860B12D0
		protected void load_locals(int version, string agentType, BsonDeserizer d) {} // 0x00000001860B0950-0x00000001860B0AE0
		protected void load_children(int version, string agentType, BsonDeserizer d) {} // 0x00000001860B0610-0x00000001860B0740
		protected void load_custom(int version, string agentType, BsonDeserizer d) {} // 0x00000001860B0740-0x00000001860B08B0
		protected void load_properties_pars_attachments_children(int version, string agentType, BsonDeserizer d, bool bIsTransition) {} // 0x00000001860B12D0-0x00000001860B14B0
		protected BehaviorNode load(string agentType, BsonDeserizer d, int version) => default; // 0x00000001860B0AE0-0x00000001860B0C70
		protected virtual void load_local(int version, string agentType, BsonDeserizer d) {} // 0x00000001860B0900-0x00000001860B0950
		protected void load_attachments(int version, string agentType, BsonDeserizer d, bool bIsTransition) {} // 0x00000001860B0290-0x00000001860B0610
		protected BehaviorNode load_node(int version, string agentType, BsonDeserizer d) => default; // 0x00000001860B0F20-0x00000001860B1090
		public void Attach(BehaviorNode pAttachment, bool bIsPrecondition, bool bIsEffector) {} // 0x00000001860AEF60-0x00000001860AF000
		public virtual void Attach(BehaviorNode pAttachment, bool bIsPrecondition, bool bIsEffector, bool bIsTransition) {} // 0x00000001860AED30-0x00000001860AEF60
		public virtual void AddChild(BehaviorNode pChild) {} // 0x00000001860AEB10-0x00000001860AEBE0
		protected virtual EBTStatus update_impl(Agent pAgent, EBTStatus childStatus) => default; // 0x00000001860B1DF0-0x00000001860B1E40
		public void SetClassNameString(string className) {} // 0x00000001860AFBD0-0x00000001860AFC30
		public string GetClassNameString() => default; // 0x00000001860AF9B0-0x00000001860AFA10
		public int GetId() => default; // 0x00000001860AFA10-0x00000001860AFA70
		public void SetId(int id) {} // 0x00000001860AFCF0-0x00000001860AFD50
		public string GetPath() => default; // 0x00000001860AFA70-0x00000001860AFAD0
		public bool CheckPreconditions(Agent pAgent, bool bIsAlive) => default; // 0x00000001860AF1E0-0x00000001860AF3E0
		private static void CombineResults(ref bool firstValidPrecond, ref bool lastCombineValue, Precondition pPrecond, bool taskBoolean) {} // 0x00000001860AF4B0-0x00000001860AF560
		public virtual void ApplyEffects(Agent pAgent, Effector.EPhase phase) {} // 0x00000001860AEBE0-0x00000001860AED30
		public bool CheckEvents(string eventName, Agent pAgent, Dictionary<uint, IInstantiatedVariable> eventParams) => default; // 0x00000001860AF000-0x00000001860AF1E0
		public virtual bool Evaluate(Agent pAgent) => default; // 0x00000001860AF6A0-0x00000001860AF6F0
		protected bool EvaluteCustomCondition(Agent pAgent) => default; // 0x00000001860AF6F0-0x00000001860AF780
		public void SetCustomCondition(BehaviorNode node) {} // 0x00000001860AFC30-0x00000001860AFC90
		protected abstract BehaviorTask createTask();
		public virtual bool enteraction_impl(Agent pAgent) => default; // 0x00000001860AFDC0-0x00000001860AFE10
		public virtual bool exitaction_impl(Agent pAgent) => default; // 0x00000001860AFE10-0x00000001860AFE60
	}
}
