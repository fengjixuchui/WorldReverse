/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using IFix.Core;
using UnityEngine;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace Gaia
{
	[ExecuteInEditMode] // 0x00000001897B1BA0-0x00000001897B1BB0
	public class GaiaWorkManager : Singleton<Gaia.GaiaWorkManager> // TypeDefIndex: 9166
	{
		// Fields
		private object m_taskCompletionQueueLock; // 0x18
		private Queue<IGaiaWorkItem> m_taskCompletionQueue; // 0x20
		private static object m_threadDebugDumpLock; // 0x00
		private IEnumerator m_updateCoRoutine; // 0x28
		private ulong m_currentJobID; // 0x30
		private GaiaWorldManager m_worldManager; // 0x38
		private bool m_showDebug; // 0x40
		private int m_progress; // 0x44
	
		// Properties
		public bool ShowDebug { /* [XID] */ /* 0x0000000189763570-0x0000000189763590 */ get => default; /* [XID] */ /* 0x000000018976AD30-0x000000018976AD50 */ set {} } // 0x0000000185ED2850-0x0000000185ED28F0 0x0000000185ED28F0-0x0000000185ED29A0
	
		// Constructors
		protected GaiaWorkManager() {} // 0x0000000185ED2770-0x0000000185ED2850
		static GaiaWorkManager() {} // 0x0000000185ED26F0-0x0000000185ED2770
	
		// Methods
		// [XID] // 0x00000001899D0C60-0x00000001899D0C80
		public void ScheduleWorkItem(IGaiaWorkItem workItem) {} // 0x0000000185ED1AB0-0x0000000185ED25A0
		// [XID] // 0x0000000189A04C60-0x0000000189A04C80
		private static void ProcessWorkItemInThread(object workItemObject) {} // 0x0000000185ED0BA0-0x0000000185ED1720
		// [XID] // 0x00000001898E0EB0-0x00000001898E0ED0
		public void ScheduleCompletionTask(IGaiaWorkItem workItem) {} // 0x0000000185ED1970-0x0000000185ED1AB0
		// [XID] // 0x0000000189B69E90-0x0000000189B69EB0
		private int ProcessTaskCompetionQueue() => default; // 0x0000000185ED0130-0x0000000185ED0BA0
		// [XID] // 0x0000000189790050-0x0000000189790070
		public static string GetThreadInformation() => default; // 0x0000000185ECFC80-0x0000000185ECFEF0
		// [XID] // 0x0000000189797840-0x0000000189797860
		private void Reset() {} // 0x0000000185ED1820-0x0000000185ED18C0
		// [XID] // 0x000000018979F7B0-0x000000018979F7D0
		private new void OnEnable() {} // 0x0000000185ED0090-0x0000000185ED0130
		// [XID] // 0x00000001897A6C60-0x00000001897A6C80
		private void Update() {} // 0x0000000185ED2640-0x0000000185ED26F0
		// [XID] // 0x00000001897AE490-0x00000001897AE4B0
		private void EditorUpdate() {} // 0x0000000185ECFB30-0x0000000185ECFBE0
		// [XID] // 0x00000001897B6570-0x00000001897B6590
		public int GetProgress() => default; // 0x0000000185ECFBE0-0x0000000185ECFC80
		// [XID] // 0x000000018962A140-0x000000018962A160
		private void OnDisable() {} // 0x0000000185ECFFF0-0x0000000185ED0090
		// [XID] // 0x00000001897C59C0-0x00000001897C59E0
		public GaiaWorldManager GetWorldManager(bool initialise = false /* Metadata: 0x00AE548B */) => default; // 0x0000000185ECFEF0-0x0000000185ECFFF0
		// [XID] // 0x00000001897CD0F0-0x00000001897CD110
		public void ResetGaiaTargetTerrains(List<Terrain> targetT) {} // 0x0000000185ED1720-0x0000000185ED1820
		// [XID] // 0x00000001897D46D0-0x00000001897D46F0
		public void UpdateWorldFromTerrain() {} // 0x0000000185ED25A0-0x0000000185ED2640
		// [XID] // 0x0000000189640760-0x0000000189640780
		public void SaveWorldToTerrain() {} // 0x0000000185ED18C0-0x0000000185ED1970
	}
}
