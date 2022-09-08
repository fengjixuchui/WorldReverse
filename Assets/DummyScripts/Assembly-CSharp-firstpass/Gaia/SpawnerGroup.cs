/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;
using UnityEngine;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace Gaia
{
	[ExecuteInEditMode] // 0x00000001897B1BA0-0x00000001897B1BB0
	public class SpawnerGroup : MonoBehaviour // TypeDefIndex: 9314
	{
		// Fields
		public List<SpawnerInstance> m_spawners; // 0x18
		[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
		public List<SpawnerGroup> m_spawnerGroups; // 0x20
		public IEnumerator m_updateCoroutine; // 0x28
		private bool m_cancelSpawn; // 0x30
		[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
		public int m_progress; // 0x34
	
		// Nested types
		[Serializable]
		public class SpawnerInstance // TypeDefIndex: 9315
		{
			// Fields
			public string m_name; // 0x10
			public Spawner m_spawner; // 0x18
			public int m_interationsPerSpawn; // 0x20
	
			// Constructors
			public SpawnerInstance() {} // 0x0000000186450080-0x00000001864500F0
		}
	
		// Constructors
		public SpawnerGroup() {} // 0x000000018644FFC0-0x0000000186450080
	
		// Methods
		// [XID] // 0x000000018965FFB0-0x000000018965FFD0
		private void OnEnable() {} // 0x000000018644FA10-0x000000018644FAB0
		// [XID] // 0x0000000189667A90-0x0000000189667AB0
		private void OnDisable() {} // 0x000000018644F970-0x000000018644FA10
		// [XID] // 0x000000018966F280-0x000000018966F2A0
		public void StartEditorUpdates() {} // 0x000000018644FE80-0x000000018644FF20
		// [XID] // 0x0000000189676D70-0x0000000189676D90
		public void StopEditorUpdates() {} // 0x000000018644FF20-0x000000018644FFC0
		// [XID] // 0x0000000189645080-0x00000001896450A0
		private void EditorUpdate() {} // 0x000000018644F6F0-0x000000018644F7B0
		// [XID] // 0x0000000189685C90-0x0000000189685CB0
		public void RunSpawnerIteration() {} // 0x000000018644FDC0-0x000000018644FE80
		[DebuggerHidden] // 0x000000018968D5E0-0x000000018968D620
		// [XID] // 0x000000018968D5E0-0x000000018968D620
		public IEnumerator RunSpawnerIterationCoRoutine() => default; // 0x000000018644FCB0-0x000000018644FDC0
		// [XID] // 0x0000000189851FE0-0x0000000189852000
		public void CancelSpawn() {} // 0x000000018644F560-0x000000018644F6F0
		// [XID] // 0x000000018969F8C0-0x000000018969F8E0
		public bool FixNames() => default; // 0x000000018644F7B0-0x000000018644F970
		// [XID] // 0x00000001896A6B30-0x00000001896A6B50
		public void ResetSpawner() {} // 0x000000018644FAB0-0x000000018644FCB0
	}
}
