/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using MoleMole;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole.UAuto
{
	public class TestCaseNetworkBase : TestCaseBase // TypeDefIndex: 28223
	{
		// Fields
		public AvatarEntity remotePlayer; // 0x198
		public AvatarEntity localPlayer; // 0x1A0
		public List<AutoTestDriver.SyncData> localSyncDataList; // 0x1A8
		public List<AutoTestDriver.SyncData> localRemoteSyncDataList; // 0x1B0
		public List<AutoTestDriver.SyncData> remoteSyncDataList; // 0x1B8
		public List<AutoTestDriver.SyncData> remoteRemoteSyncDataList; // 0x1C0
		public List<BaseEntity> recordMonsterList; // 0x1C8
		public List<AutoTestDriver.SyncData> initEffectList; // 0x1D0
		private Dictionary<string, List<AutoTestDriver.SyncData>> initEntityDict; // 0x1D8
		public Coroutine recordCoroutine; // 0x1E0
		public List<Coroutine> entityRecordCoroutineList; // 0x1E8
		public bool initialized; // 0x1F0
		public bool skipCompare; // 0x1F1
		private List<MonoEffect> effectsList; // 0x1F8
		private AnimatorClipInfo[] animList; // 0x200
		private List<ActorModifier> modifierList; // 0x208
		private List<BaseEntity> waterList; // 0x210
		private List<BaseEntity> grassList; // 0x218
		private AutoTestDriver.SyncData data; // 0x220
		private List<AutoTestDriver.SyncData> gagetList; // 0x258
		private List<MonoEffectProxy> _ProxyCacheForGetEffect; // 0x260
		private List<MonoEffectProxy> _effectProxyListForWater; // 0x268
		private List<MonoEffectProxy> _effectProxyListForGrass; // 0x270
		private string[] gadgetFilter; // 0x278
		private string timeFormat; // 0x280
		public string lastCSV; // 0x288
	
		// Constructors
		public TestCaseNetworkBase() {} // 0x0000000184FA2740-0x0000000184FA2B50
	
		// Methods
		[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
		public IEnumerator EnterHostWorld(string worldName, string userid, bool clearAll = false /* Metadata: 0x00B0D4C1 */) => default; // 0x0000000184F9C780-0x0000000184F9C870
		[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
		public IEnumerator SetUpUserID(string userid) => default; // 0x0000000184FA1960-0x0000000184FA1A40
		~TestCaseNetworkBase() {} // 0x0000000184F9C870-0x0000000184F9C970
		[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
		public IEnumerator AddOneClient() => default; // 0x0000000184F93760-0x0000000184F93830
		[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
		public IEnumerator FlyToHost() => default; // 0x0000000184F9C970-0x0000000184F9CA40
		[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
		public IEnumerator ReenterHost() => default; // 0x0000000184FA1160-0x0000000184FA1230
		[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
		public override IEnumerator RunGM(string cmd, bool addAvatarAfterClear = true /* Metadata: 0x00B0D4C2 */, bool local = false /* Metadata: 0x00B0D4C3 */, bool skipWait = false /* Metadata: 0x00B0D4C4 */, bool isBoy = true /* Metadata: 0x00B0D4C5 */, bool skipSDK = false /* Metadata: 0x00B0D4C6 */) => default; // 0x0000000184FA1230-0x0000000184FA1350
		public void AddModifierToList(BaseEntity avatar, ActorModifier modifier, List<AutoTestDriver.SyncData> inList) {} // 0x0000000184F93440-0x0000000184F93760
		public void ModifierAddedHandler(BaseEntity entity, ActorModifier modifier) {} // 0x0000000184F9FDB0-0x0000000184FA0070
		[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
		public IEnumerator SnapshotPosition() => default; // 0x0000000184FA1A40-0x0000000184FA1B10
		[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
		public IEnumerator StartSyncRecord(uint runtimeID = 0 /* Metadata: 0x00B0D4C7 */, bool isMonster = false /* Metadata: 0x00B0D4CB */) => default; // 0x0000000184FA1BF0-0x0000000184FA1CE0
		[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
		public IEnumerator StartSyncRecord2(string entityList) => default; // 0x0000000184FA1B10-0x0000000184FA1BF0
		[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
		public IEnumerator TriggerRemoteFunction(string methodName, List<string> paras) => default; // 0x0000000184FA1DC0-0x0000000184FA1EB0
		[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
		public IEnumerator StopSyncRecord(bool skipWait = false /* Metadata: 0x00B0D4CC */) => default; // 0x0000000184FA1CE0-0x0000000184FA1DC0
		public AvatarEntity GetRemoteAvatar() => default; // 0x0000000184F9E650-0x0000000184F9E850
		private void AddEffect(MonoEffect effect, List<AutoTestDriver.SyncData> inList, string gadgetName = "" /* Metadata: 0x00B0D4CD */) {} // 0x0000000184F93070-0x0000000184F93440
		private void GetEffect(BaseEntity avatar, List<AutoTestDriver.SyncData> inList, bool initRecord) {} // 0x0000000184F9CEF0-0x0000000184F9D5A0
		private void GetAnimate(BaseEntity avatar, List<AutoTestDriver.SyncData> inList) {} // 0x0000000184F9CA40-0x0000000184F9CEF0
		private void GetWaterEntity(List<AutoTestDriver.SyncData> inList) {} // 0x0000000184F9E850-0x0000000184F9FCE0
		private void GetGrassEntity(List<AutoTestDriver.SyncData> inList) {} // 0x0000000184F9DA70-0x0000000184F9E650
		private bool InFilter(string[] filterList, string value) => default; // 0x0000000184F9FCE0-0x0000000184F9FDB0
		private void GetGadget(BaseEntity avatar, List<AutoTestDriver.SyncData> inList) {} // 0x0000000184F9D5A0-0x0000000184F9DA70
		[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
		private IEnumerator Record(BaseEntity recordEntity) => default; // 0x0000000184FA0FB0-0x0000000184FA1090
		[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
		private IEnumerator Record() => default; // 0x0000000184FA1090-0x0000000184FA1160
		[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
		private IEnumerator RecordEnv() => default; // 0x0000000184FA0EE0-0x0000000184FA0FB0
		[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
		private IEnumerator Record2(string monsterListString) => default; // 0x0000000184FA0E00-0x0000000184FA0EE0
		public void SendSyncData() {} // 0x0000000184FA1350-0x0000000184FA1960
		public void OnSync(List<AutoTestDriver.SyncData> syncList, List<AutoTestDriver.SyncData> remoteList, bool skip) {} // 0x0000000184FA0070-0x0000000184FA0210
		private string PrintListDebugInfo(List<AutoTestDriver.SyncData> localList, List<AutoTestDriver.SyncData> remoteList) => default; // 0x0000000184FA0210-0x0000000184FA0E00
		private bool CheckEffect(List<AutoTestDriver.SyncData> localList, List<AutoTestDriver.SyncData> remoteList, int timeout = 5000 /* Metadata: 0x00B0D4D1 */, int maxDistance = 10 /* Metadata: 0x00B0D4D5 */) => default; // 0x0000000184F94DD0-0x0000000184F96390
		private bool CheckAnim(List<AutoTestDriver.SyncData> localList, List<AutoTestDriver.SyncData> remoteList, int timeout = 5000 /* Metadata: 0x00B0D4D9 */, int maxDistance = 10 /* Metadata: 0x00B0D4DD */) => default; // 0x0000000184F93F80-0x0000000184F94DD0
		private bool CheckModifier(List<AutoTestDriver.SyncData> localList, List<AutoTestDriver.SyncData> remoteList, int timeout = 5000 /* Metadata: 0x00B0D4E1 */) => default; // 0x0000000184F97F10-0x0000000184F98A50
		private bool CheckEnv(List<AutoTestDriver.SyncData> localList, List<AutoTestDriver.SyncData> remoteList, int timeout = 5000 /* Metadata: 0x00B0D4E5 */) => default; // 0x0000000184F96390-0x0000000184F96FC0
		private bool CheckGadget(List<AutoTestDriver.SyncData> localList, List<AutoTestDriver.SyncData> remoteList, int timeout = 5000 /* Metadata: 0x00B0D4E9 */, int maxDistance = 10 /* Metadata: 0x00B0D4ED */) => default; // 0x0000000184F96FC0-0x0000000184F97F10
		private bool CheckPosition(List<AutoTestDriver.SyncData> localList, List<AutoTestDriver.SyncData> remoteList, int maxDistance = 1 /* Metadata: 0x00B0D4F1 */) => default; // 0x0000000184F98A50-0x0000000184F99530
		public void AppendToCSV(List<AutoTestDriver.SyncData> syncDataList, string title) {} // 0x0000000184F93830-0x0000000184F93F80
		public string UploadFile(string fileName = "" /* Metadata: 0x00B0D4F5 */, string dirName = "" /* Metadata: 0x00B0D4F9 */) => default; // 0x0000000184FA2010-0x0000000184FA2740
		public bool CheckRemote(int timeout = 5000 /* Metadata: 0x00B0D4FD */, int maxDistance = 10 /* Metadata: 0x00B0D501 */) => default; // 0x0000000184F99530-0x0000000184F9C780
	}
}
