/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace behaviac
{
	[TypeMetaInfo] // 0x000000018974C130-0x000000018974C140
	public class Agent // TypeDefIndex: 27193
	{
		// Fields
		private string name; // 0x10
		private List<BehaviorTreeTask> m_behaviorTreeTasks; // 0x18
		private List<BehaviorTreeStackItem_t> m_btStack; // 0x20
		private BehaviorTreeTask m_currentBT; // 0x28
		private BehaviorTreeTask m_excutingTreeTask; // 0x30
		private int m_id; // 0x38
		private bool m_bActive; // 0x3C
		private bool m_referencetree; // 0x3D
		public int m_priority; // 0x40
		public int m_contextId; // 0x44
		private static uint ms_idMask; // 0x00
		private uint m_idFlag; // 0x48
		private static int ms_agent_index; // 0x04
		private static Dictionary<string, int> ms_agent_type_index; // 0x08
		private static Dictionary<string, AgentName_t> ms_names; // 0x10
		private Variables m_variables; // 0x50
	
		// Properties
		private List<BehaviorTreeTask> BehaviorTreeTasks { get => default; } // 0x0000000185A616A0-0x0000000185A61730 
		private List<BehaviorTreeStackItem_t> BTStack { get => default; } // 0x0000000185A61610-0x0000000185A616A0 
		public BehaviorTreeTask CurrentTreeTask { get => default; private set {} } // 0x0000000185A61730-0x0000000185A61790 0x0000000185A619B0-0x0000000185A61A10
		public BehaviorTreeTask ExcutingTreeTask { get => default; set {} } // 0x0000000185A61790-0x0000000185A617F0 0x0000000185A61A10-0x0000000185A61A70
		internal static Dictionary<string, AgentName_t> Names { get => default; } // 0x0000000185A617F0-0x0000000185A61900 
		public Variables Variables { get => default; } // 0x0000000185A61900-0x0000000185A619B0 
	
		// Nested types
		public class State_t // TypeDefIndex: 27194
		{
			// Fields
			protected Variables m_vars; // 0x10
			protected BehaviorTreeTask m_bt; // 0x18
	
			// Properties
			public Variables Vars { get => default; } // 0x00000001860B9880-0x00000001860B98E0 
			public BehaviorTreeTask BT { get => default; set {} } // 0x00000001860B9820-0x00000001860B9880 0x00000001860B98E0-0x00000001860B9940
	
			// Constructors
			public State_t() {} // Dummy constructor
			public State_t(State_t c) {} // 0x00000001860B96D0-0x00000001860B9820
	
			// Methods
			public bool SaveToFile(string fileName) => default; // 0x00000001860B9680-0x00000001860B96D0
			public bool LoadFromFile(string fileName) => default; // 0x00000001860B9630-0x00000001860B9680
		}
	
		private class BehaviorTreeStackItem_t // TypeDefIndex: 27195
		{
			// Fields
			public BehaviorTreeTask bt; // 0x10
			public TriggerMode triggerMode; // 0x18
			public bool triggerByEvent; // 0x1C
	
			// Constructors
			public BehaviorTreeStackItem_t() {} // Dummy constructor
			public BehaviorTreeStackItem_t(BehaviorTreeTask bt_, TriggerMode tm, bool bByEvent) {} // 0x00000001860B3EE0-0x00000001860B3F70
		}
	
		internal struct AgentName_t // TypeDefIndex: 27196
		{
			// Fields
			public string instantceName_; // 0x00
			public string className_; // 0x08
			public string displayName_; // 0x10
			public string desc_; // 0x18
	
			// Properties
			public string ClassName { get => default; } // 0x00000001860A4260-0x00000001860A43B0 
	
			// Constructors
			public AgentName_t(string instanceName, string className, string displayName, string desc) : this() {
				instantceName_ = default;
				className_ = default;
				displayName_ = default;
				desc_ = default;
			} // 0x00000001860A41F0-0x00000001860A4260
		}
	
		[TypeConverter] // 0x000000018977FF00-0x000000018977FF10
		public class StructConverter : TypeConverter // TypeDefIndex: 27197
		{
			// Constructors
			public StructConverter() {} // 0x00000001860B9B80-0x00000001860B9BE0
	
			// Methods
			public override bool CanConvertFrom(ITypeDescriptorContext context, System.Type sourceType) => default; // 0x00000001860B9940-0x00000001860B9A10
			public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value) => default; // 0x00000001860B9A10-0x00000001860B9AA0
			public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, System.Type destinationType) => default; // 0x00000001860B9AA0-0x00000001860B9B80
		}
	
		// Constructors
		protected Agent() {} // 0x0000000185A5FE40-0x0000000185A5FF10
		static Agent() {} // 0x0000000185A5FDE0-0x0000000185A5FE40
	
		// Methods
		protected void Init() {} // 0x0000000185A5E690-0x0000000185A5E6F0
		private void Awake() {} // 0x0000000185A5D8B0-0x0000000185A5D960
		public void OnDestroy() {} // 0x0000000185A5EC50-0x0000000185A5EDC0
		public int GetId() => default; // 0x0000000185A5DEA0-0x0000000185A5DF00
		public int GetPriority() => default; // 0x0000000185A5E270-0x0000000185A5E2D0
		public string GetClassTypeName() => default; // 0x0000000185A5DCD0-0x0000000185A5DD60
		public bool IsMasked() => default; // 0x0000000185A5E870-0x0000000185A5E900
		public void SetIdFlag(uint idMask) {} // 0x0000000185A5EFE0-0x0000000185A5F040
		public static bool IsDerived(Agent pAgent, string agentType) => default; // 0x0000000185A5E750-0x0000000185A5E870
		public static void SetIdMask(uint idMask) {} // 0x0000000185A5F040-0x0000000185A5F0D0
		public static uint IdMask() => default; // 0x0000000185A5E500-0x0000000185A5E590
		public string GetName() => default; // 0x0000000185A5E210-0x0000000185A5E270
		public void SetName(string instanceName) {} // 0x0000000185A5F0D0-0x0000000185A5F400
		public int GetContextId() => default; // 0x0000000185A5DD60-0x0000000185A5DDC0
		public bool IsActive() => default; // 0x0000000185A5E6F0-0x0000000185A5E750
		public void SetActive(bool bActive) {} // 0x0000000185A5EF80-0x0000000185A5EFE0
		public static bool RegisterInstanceName<TAGENT>(string agentInstanceName, string displayName, string desc)
			where TAGENT : Agent => default;
		public static bool RegisterInstanceName<TAGENT>(string agentInstanceName)
			where TAGENT : Agent => default;
		public static bool RegisterInstanceName<TAGENT>()
			where TAGENT : Agent => default;
		public static bool RegisterStaticClass(System.Type type, string displayName, string desc) => default; // 0x0000000185A5EDC0-0x0000000185A5EF80
		public static void UnRegisterInstanceName<TAGENT>(string agentInstanceName)
			where TAGENT : Agent {}
		public static void UnRegisterInstanceName<TAGENT>()
			where TAGENT : Agent {}
		public static bool IsNameRegistered(string agentInstanceName) => default; // 0x0000000185A5E900-0x0000000185A5E9B0
		public static string GetRegisteredClassName(string agentInstanceName) => default; // 0x0000000185A5E3C0-0x0000000185A5E500
		public static bool BindInstance(Agent pAgentInstance, string agentInstanceName, int contextId) => default; // 0x0000000185A5DA00-0x0000000185A5DAC0
		public static bool BindInstance(Agent pAgentInstance, string agentInstanceName) => default; // 0x0000000185A5D960-0x0000000185A5DA00
		public static bool BindInstance(Agent pAgentInstance) => default; // 0x0000000185A5DAC0-0x0000000185A5DB60
		public static bool UnbindInstance(string agentInstanceName, int contextId) => default; // 0x0000000185A5F580-0x0000000185A5F630
		public static bool UnbindInstance(string agentInstanceName) => default; // 0x0000000185A5F4F0-0x0000000185A5F580
		public static bool UnbindInstance<T>() => default;
		public static Agent GetInstance(string agentInstanceName, int contextId) => default; // 0x0000000185A5DF90-0x0000000185A5E040
		public static Agent GetInstance(string agentInstanceName) => default; // 0x0000000185A5DF00-0x0000000185A5DF90
		public static TAGENT GetInstance<TAGENT>(string agentInstanceName, int contextId)
			where TAGENT : Agent, new() => default;
		public static TAGENT GetInstance<TAGENT>(string agentInstanceName)
			where TAGENT : Agent, new() => default;
		public static TAGENT GetInstance<TAGENT>()
			where TAGENT : Agent, new() => default;
		private Dictionary<uint, IInstantiatedVariable> GetCustomizedVariables() => default; // 0x0000000185A5DDC0-0x0000000185A5DEA0
		internal IInstantiatedVariable GetInstantiatedVariable(uint varId) => default; // 0x0000000185A5E040-0x0000000185A5E210
		private IProperty GetProperty(uint propId) => default; // 0x0000000185A5E2D0-0x0000000185A5E3C0
		internal bool GetVarValue<VariableType>(uint varId, out VariableType value) {
			value = default;
			return default;
		}
		private bool GetVarValue<VariableType>(uint varId, int index, out VariableType value) {
			value = default;
			return default;
		}
		internal bool SetVarValue<VariableType>(uint varId, VariableType value) => default;
		private bool SetVarValue<VariableType>(uint varId, int index, VariableType value) => default;
		public bool IsValidVariable(string variableName) => default; // 0x0000000185A5E9B0-0x0000000185A5EA70
		public VariableType GetVariable<VariableType>(string variableName) => default;
		internal VariableType GetVariable<VariableType>(uint variableId) => default;
		internal VariableType GetVariable<VariableType>(uint variableId, int index) => default;
		public void SetVariable<VariableType>(string variableName, VariableType value) {}
		public void SetVariable<VariableType>(string variableName, uint variableId, VariableType value) {}
		public void SetVariable<VariableType>(string variableName, uint variableId, VariableType value, int index) {}
		internal void SetVariableFromString(string variableName, string valueStr) {} // 0x0000000185A5F400-0x0000000185A5F4F0
		public void LogVariables(bool bForce) {} // 0x0000000185A5EC00-0x0000000185A5EC50
		public void LogRunningNodes() {} // 0x0000000185A5EBB0-0x0000000185A5EC00
		protected static void Init_(int contextId, Agent pAgent, int priority) {} // 0x0000000185A5E590-0x0000000185A5E690
		public void btresetcurrrent() {} // 0x0000000185A60BF0-0x0000000185A60C60
		public void btsetcurrent(string relativePath) {} // 0x0000000185A60E00-0x0000000185A60E80
		public void btreferencetree(string relativePath) {} // 0x0000000185A608F0-0x0000000185A60980
		public void bteventtree(Agent pAgent, string relativePath, TriggerMode triggerMode) {} // 0x0000000185A5FF10-0x0000000185A5FFA0
		private void _btsetcurrent(string relativePath, TriggerMode triggerMode, bool bByEvent) {} // 0x0000000185A5F8A0-0x0000000185A5FDE0
		private EBTStatus btexec_() => default; // 0x0000000185A5FFA0-0x0000000185A601A0
		public void LogJumpTree(string newTree) {} // 0x0000000185A5EA70-0x0000000185A5EAC0
		public void LogReturnTree(string returnFromTree) {} // 0x0000000185A5EB60-0x0000000185A5EBB0
		public bool ChangeBehaviaTree(string treeName) => default; // 0x0000000185A5DB60-0x0000000185A5DC50
		public virtual EBTStatus btexec() => default; // 0x0000000185A601A0-0x0000000185A60360
		public bool btload(string relativePath, bool bForce) => default; // 0x0000000185A60600-0x0000000185A60710
		public bool btload(string relativePath) => default; // 0x0000000185A60710-0x0000000185A60790
		public void btunload(string relativePath) {} // 0x0000000185A60E80-0x0000000185A61230
		public virtual void bthotreloaded(BehaviorTree bt) {} // 0x0000000185A60360-0x0000000185A603E0
		public void btunloadall() {} // 0x0000000185A612D0-0x0000000185A61610
		public void btreloadall() {} // 0x0000000185A60980-0x0000000185A60BF0
		public bool btsave(State_t state) => default; // 0x0000000185A60C60-0x0000000185A60E00
		public bool btload(State_t state) => default; // 0x0000000185A603E0-0x0000000185A60600
		private void btunload_pars(BehaviorTree bt) {} // 0x0000000185A61230-0x0000000185A612D0
		public void btonevent(string btEvent, Dictionary<uint, IInstantiatedVariable> eventParams) {} // 0x0000000185A60790-0x0000000185A608F0
		public void FireEvent(string eventName) {} // 0x0000000185A5DC50-0x0000000185A5DCD0
		public void FireEvent<ParamType>(string eventName, ParamType param) {}
		public void FireEvent<ParamType1, ParamType2>(string eventName, ParamType1 param1, ParamType2 param2) {}
		public void FireEvent<ParamType1, ParamType2, ParamType3>(string eventName, ParamType1 param1, ParamType2 param2, ParamType3 param3) {}
		[MethodMetaInfo] // 0x0000000189769AE0-0x0000000189769AF0
		public static void LogMessage(string message) {} // 0x0000000185A5EAC0-0x0000000185A5EB60
		[MethodMetaInfo] // 0x0000000189769AE0-0x0000000189769AF0
		public static int VectorLength(IList vector) => default; // 0x0000000185A5F7B0-0x0000000185A5F820
		[MethodMetaInfo] // 0x0000000189769AE0-0x0000000189769AF0
		public static void VectorAdd(IList vector, object element) {} // 0x0000000185A5F630-0x0000000185A5F6B0
		[MethodMetaInfo] // 0x0000000189769AE0-0x0000000189769AF0
		public static void VectorRemove(IList vector, object element) {} // 0x0000000185A5F820-0x0000000185A5F8A0
		[MethodMetaInfo] // 0x0000000189769AE0-0x0000000189769AF0
		public static bool VectorContains(IList vector, object element) => default; // 0x0000000185A5F720-0x0000000185A5F7B0
		[MethodMetaInfo] // 0x0000000189769AE0-0x0000000189769AF0
		public static void VectorClear(IList vector) {} // 0x0000000185A5F6B0-0x0000000185A5F720
	}
}
