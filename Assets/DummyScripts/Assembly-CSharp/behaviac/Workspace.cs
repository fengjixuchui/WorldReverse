/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace behaviac
{
	public class Workspace : IDisposable // TypeDefIndex: 27557
	{
		// Fields
		private static Workspace ms_instance; // 0x00
		private EFileFormat fileFormat_; // 0x10
		private string m_filePath; // 0x18
		private string m_metaFile; // 0x20
		private int m_frameSinceStartup; // 0x28
		private bool _useIntValue; // 0x2C
		private double m_doubleValueSinceStartup; // 0x30
		private long m_intValueSinceStartup; // 0x38
		private bool m_bRegistered; // 0x50
		private bool m_bInited; // 0x51
		private Dictionary<uint, BreakpointInfo_t> m_breakpoints; // 0x58
		private Dictionary<CStringID, int> m_actions_count; // 0x60
		private bool m_bExecAgents; // 0x68
		private Dictionary<string, BehaviorTree> m_behaviortrees; // 0x70
		private Dictionary<string, MethodInfo> m_btCreators; // 0x78
		private Dictionary<string, BTItem_t> m_allBehaviorTreeTasks; // 0x80
		private Dictionary<string, System.Type> m_behaviorNodeTypes; // 0x88
		private Assembly m_callingAssembly; // 0x90
	
		// Properties
		public static Workspace Instance { get => default; } // 0x0000000186E0BA20-0x0000000186E0BAF0 
		public EFileFormat FileFormat { get => default; set {} } // 0x0000000186E0B880-0x0000000186E0B8E0 0x0000000186E0BF90-0x0000000186E0BFF0
		public string FilePath { get => default; set {} } // 0x0000000186E0B8E0-0x0000000186E0B9B0 0x0000000186E0BFF0-0x0000000186E0C050
		public string MetaFile { get => default; set {} } // 0x0000000186E0BC30-0x0000000186E0BC90 0x0000000186E0C170-0x0000000186E0C1D0
		public virtual int FrameSinceStartup { get => default; set {} } // 0x0000000186E0B9B0-0x0000000186E0BA20 0x0000000186E0C050-0x0000000186E0C0B0
		public bool UseIntValue { get => default; set {} } // 0x0000000186E0BD20-0x0000000186E0BD80 0x0000000186E0C240-0x0000000186E0C310
		public virtual double TimeSinceStartup { get => default; set {} } // 0x0000000186E0BC90-0x0000000186E0BD20 0x0000000186E0C1D0-0x0000000186E0C240
		public virtual double DoubleValueSinceStartup { get => default; set {} } // 0x0000000186E0B7F0-0x0000000186E0B880 0x0000000186E0BF20-0x0000000186E0BF90
		public virtual long IntValueSinceStartup { get => default; set {} } // 0x0000000186E0BAF0-0x0000000186E0BB70 0x0000000186E0C0B0-0x0000000186E0C110
		internal bool IsInited { get => default; } // 0x0000000186E0BBD0-0x0000000186E0BC30 
		public bool IsExecAgents { get => default; set {} } // 0x0000000186E0BB70-0x0000000186E0BBD0 0x0000000186E0C110-0x0000000186E0C170
		private Dictionary<string, BehaviorTree> BehaviorTrees { get => default; } // 0x0000000186E0B6E0-0x0000000186E0B770 
		private Dictionary<string, MethodInfo> BTCreators { get => default; } // 0x0000000186E0B650-0x0000000186E0B6E0 
		private Assembly CallingAssembly { get => default; } // 0x0000000186E0B770-0x0000000186E0B7F0 
	
		// Events
		private event BehaviorNodeLoader BehaviorNodeLoaded;
		public event DRespondToBreakHandler RespondToBreakHandler;
	
		// Nested types
		[Flags] // 0x000000018990A800-0x000000018990A810
		public enum EFileFormat // TypeDefIndex: 27558
		{
			EFF_xml = 1,
			EFF_bson = 2,
			EFF_cs = 4,
			EFF_default = 7
		}
	
		public delegate void BehaviorNodeLoader(string nodeType, List<property_t> properties); // TypeDefIndex: 27559; 0x0000000182431690-0x0000000182431940
	
		public delegate void DRespondToBreakHandler(string msg, string title); // TypeDefIndex: 27560; 0x0000000182431B30-0x0000000182431DE0
	
		private class BreakpointInfo_t // TypeDefIndex: 27561
		{
			// Fields
			public string btname; // 0x10
			public ushort hit_config; // 0x18
			public EActionResult action_result; // 0x1C
	
			// Constructors
			public BreakpointInfo_t() {} // 0x00000001824319C0-0x0000000182431A30
		}
	
		private class BTItem_t // TypeDefIndex: 27562
		{
			// Fields
			public List<BehaviorTreeTask> bts; // 0x10
			public List<Agent> agents; // 0x18
	
			// Constructors
			public BTItem_t() {} // 0x00000001824314E0-0x0000000182431590
		}
	
		// Constructors
		public Workspace() {} // 0x0000000186E0B280-0x0000000186E0B400
		static Workspace() {} // 0x0000000186E0B220-0x0000000186E0B280
	
		// Methods
		public void Dispose() {} // 0x0000000186E08900-0x0000000186E08990
		private static string GetDefaultFilePath() => default; // 0x0000000186E08CB0-0x0000000186E08DA0
		public void OnBehaviorNodeLoaded(string nodeType, List<property_t> properties) {} // 0x0000000186E09F50-0x0000000186E09FE0
		private static extern int MessageBox(int hWnd, string text, string caption, int options); // 0x0000000186E09E20-0x0000000186E09F50
		public void RespondToBreak(string msg, string title) {} // 0x0000000186E0A9B0-0x0000000186E0AAA0
		public bool TryInit() => default; // 0x0000000186E0AAF0-0x0000000186E0AD10
		public void Cleanup() {} // 0x0000000186E08070-0x0000000186E08230
		internal void RegisterStuff() {} // 0x0000000186E0A920-0x0000000186E0A9B0
		private void UnRegisterStuff() {} // 0x0000000186E0AF10-0x0000000186E0AFA0
		public void LogWorkspaceInfo() {} // 0x0000000186E09B60-0x0000000186E09E20
		private bool LoadWorkspaceSetting(string file, string ext, ref string workspaceFile) => default; // 0x0000000186E09180-0x0000000186E09390
		public void SetAutoHotReload(bool enable) {} // 0x0000000186E0AAA0-0x0000000186E0AAF0
		public bool GetAutoHotReload() => default; // 0x0000000186E08C00-0x0000000186E08C50
		public void HotReload() {} // 0x0000000186E08F70-0x0000000186E08FC0
		private void ParseBreakpoint(string[] tokens) {} // 0x0000000186E0A030-0x0000000186E0A450
		private void ParseProfiling(string[] tokens) {} // 0x0000000186E0A450-0x0000000186E0A5B0
		private void ParseAppLogFilter(string[] tokens) {} // 0x0000000186E09FE0-0x0000000186E0A030
		private void ParseProperty(string[] tokens) {} // 0x0000000186E0A5B0-0x0000000186E0A600
		protected void LogFrames() {} // 0x0000000186E09B10-0x0000000186E09B60
		protected void WaitforContinue() {} // 0x0000000186E0B1D0-0x0000000186E0B220
		protected bool HandleRequests() => default; // 0x0000000186E08F20-0x0000000186E08F70
		public void DebugUpdate() {} // 0x0000000186E08650-0x0000000186E08780
		public void Update() {} // 0x0000000186E0B130-0x0000000186E0B1D0
		public void LogCurrentStates() {} // 0x0000000186E09A90-0x0000000186E09B10
		public bool CheckBreakpoint(Agent pAgent, BehaviorNode b, string action, EActionResult actionResult) => default; // 0x0000000186E08020-0x0000000186E08070
		public bool CheckAppLogFilter(string filter) => default; // 0x0000000186E07FD0-0x0000000186E08020
		public int UpdateActionCount(string actionString) => default; // 0x0000000186E0AFA0-0x0000000186E0B130
		public int GetActionCount(string actionString) => default; // 0x0000000186E08AB0-0x0000000186E08C00
		public void RecordBTAgentMapping(string relativePath, Agent agent) {} // 0x0000000186E0A790-0x0000000186E0A920
		public void UnLoad(string relativePath) {} // 0x0000000186E0ADD0-0x0000000186E0AE90
		public void UnLoadAll() {} // 0x0000000186E0AD10-0x0000000186E0ADD0
		public byte[] ReadFileToBuffer(string file, string ext) => default; // 0x0000000186E0A6D0-0x0000000186E0A790
		public void PopFileFromBuffer(string file, string ext, byte[] pBuffer) {} // 0x0000000186E0A600-0x0000000186E0A6D0
		private string getValidFilename(string filename) => default; // 0x0000000186E0B5A0-0x0000000186E0B650
		public bool Load(string relativePath, bool bForce) => default; // 0x0000000186E09410-0x0000000186E09A90
		public void HandleFileFormat(string fullPath, ref string ext, ref EFileFormat f) {} // 0x0000000186E08DA0-0x0000000186E08F20
		public bool Load(string relativePath) => default; // 0x0000000186E09390-0x0000000186E09410
		public BehaviorTree LoadBehaviorTree(string relativePath) => default; // 0x0000000186E09090-0x0000000186E09180
		public bool IsValidPath(string relativePath) => default; // 0x0000000186E08FC0-0x0000000186E09090
		public BehaviorTreeTask CreateBehaviorTreeTask(string relativePath) => default; // 0x0000000186E08450-0x0000000186E08650
		public void DestroyBehaviorTreeTask(BehaviorTreeTask behaviorTreeTask, Agent agent) {} // 0x0000000186E08780-0x0000000186E08900
		public Dictionary<string, BehaviorTree> GetBehaviorTrees() => default; // 0x0000000186E08C50-0x0000000186E08CB0
		private void UnRegisterBehaviorNode() {} // 0x0000000186E0AE90-0x0000000186E0AF10
		public BehaviorNode CreateBehaviorNode(string className) => default; // 0x0000000186E08230-0x0000000186E08450
		public bool ExportMetas(string xmlMetaFilePath, bool onlyExportPublicMembers) => default; // 0x0000000186E08990-0x0000000186E08A00
		public bool ExportMetas(string exportPathRelativeToWorkspace) => default; // 0x0000000186E08A00-0x0000000186E08AB0
	}
}
