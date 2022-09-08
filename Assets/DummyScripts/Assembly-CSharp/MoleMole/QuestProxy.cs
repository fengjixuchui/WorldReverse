/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole.Config;
using UnityEngine;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	[LuaCallCSharp] // 0x0000000189BA67A0-0x0000000189BA67C0
	public class QuestProxy // TypeDefIndex: 21677
	{
		// Fields
		public QuestExcelConfigProxy Cfg; // 0x10
		private Quest _quest; // 0x28
		private bool _inited; // 0x30
		private bool _cfgValid; // 0x31
		public bool cachedRewind; // 0x32
		private bool _forceUpdate; // 0x33
		private uint _questMainId; // 0x34
		private uint _questId; // 0x38
		private QuestState _questState; // 0x3C
		private RepeatedField<uint> _finishProgressList; // 0x40
		private RepeatedField<uint> _failProgressList; // 0x48
	
		// Properties
		public bool inited { /* [XID] */ /* 0x0000000189A2A2E0-0x0000000189A2A300 */ get => default; } // 0x0000000183BBC220-0x0000000183BBC2C0 
		public bool forceUpdate { /* [XID] */ /* 0x0000000189A5EAF0-0x0000000189A5EB10 */ get => default; } // 0x0000000183BBC180-0x0000000183BBC220 
		public int QuestOrder { /* [XID] */ /* 0x0000000189A8BF20-0x0000000189A8BF40 */ get => default; } // 0x0000000183BBBED0-0x0000000183BBBF90 
		public uint QuestMainId { /* [XID] */ /* 0x0000000189A93430-0x0000000189A93450 */ get => default; /* [XID] */ /* 0x0000000189A9AF40-0x0000000189A9AF60 */ set {} } // 0x0000000183BBBDF0-0x0000000183BBBED0 0x0000000183BBC7A0-0x0000000183BBC850
		public uint QuestConfigMainId { /* [XID] */ /* 0x0000000189AA2290-0x0000000189AA22B0 */ get => default; } // 0x0000000183BBBC50-0x0000000183BBBD10 
		public uint QuestId { /* [XID] */ /* 0x0000000189AA9800-0x0000000189AA9820 */ get => default; /* [XID] */ /* 0x0000000189AB15C0-0x0000000189AB15E0 */ set {} } // 0x0000000183BBBD10-0x0000000183BBBDF0 0x0000000183BBC6F0-0x0000000183BBC7A0
		public uint QuestConfigId { /* [XID] */ /* 0x000000018990A7C0-0x000000018990A7E0 */ get => default; } // 0x0000000183BBBB50-0x0000000183BBBC50 
		public uint State { /* [XID] */ /* 0x00000001899466C0-0x00000001899466E0 */ get => default; } // 0x0000000183BBBF90-0x0000000183BBC040 
		public QuestState questState { /* [XID] */ /* 0x0000000189AC7F50-0x0000000189AC7F70 */ get => default; } // 0x0000000183BBC2C0-0x0000000183BBC370 
		public RepeatedField<uint> LackedNPC { /* [XID] */ /* 0x0000000189ACF5D0-0x0000000189ACF5F0 */ get => default; } // 0x0000000183BBB9F0-0x0000000183BBBAA0 
		public RepeatedField<uint> LackedScene { /* [XID] */ /* 0x0000000189AD73A0-0x0000000189AD73C0 */ get => default; } // 0x0000000183BBBAA0-0x0000000183BBBB50 
		public QState state { /* [XID] */ /* 0x0000000189AEE080-0x0000000189AEE0A0 */ get => default; } // 0x0000000183BBC370-0x0000000183BBC470 
		public RepeatedField<uint> finishProgressList { /* [XID] */ /* 0x0000000189AFCC70-0x0000000189AFCC90 */ get => default; /* [XID] */ /* 0x0000000189AF5790-0x0000000189AF57B0 */ set {} } // 0x0000000183BBC0E0-0x0000000183BBC180 0x0000000183BBC900-0x0000000183BBCAF0
		public RepeatedField<uint> failProgressList { /* [XID] */ /* 0x0000000189B0BC30-0x0000000189B0BC50 */ get => default; /* [XID] */ /* 0x0000000189B043E0-0x0000000189B04400 */ set {} } // 0x0000000183BBC040-0x0000000183BBC0E0 0x0000000183BBC850-0x0000000183BBC900
	
		// Nested types
		public enum CallEventType // TypeDefIndex: 21678
		{
			START_MAIN = 0,
			FINISH_MAIN = 1,
			START_SUB = 2,
			FINISH_SUB = 3,
			FAIL_SUB = 4,
			REWIND = 5,
			FAIL_MAIN = 6,
			CANCEL_MAIN = 7
		}
	
		// Constructors
		public QuestProxy() {} // 0x0000000183BBB7A0-0x0000000183BBB810
	
		// Methods
		[BlackList] // 0x00000001899FDF40-0x00000001899FDF90
		// [IDTag] // 0x00000001899FDF40-0x00000001899FDF90
		// [XID] // 0x00000001899FDF40-0x00000001899FDF90
		public static QuestProxy CreateQuestProxy(Quest quest) => default; // 0x0000000183BB8F90-0x0000000183BB9070
		[BlackList] // 0x0000000189A0B480-0x0000000189A0B4D0
		// [IDTag] // 0x0000000189A0B480-0x0000000189A0B4D0
		// [XID] // 0x0000000189A0B480-0x0000000189A0B4D0
		public static QuestProxy CreateQuestProxy(uint questID, uint questConfigId, QuestState questState, uint questMainID, bool force = false /* Metadata: 0x00AFFBB5 */) => default; // 0x0000000183BB8E00-0x0000000183BB8F90
		[BlackList] // 0x0000000189A188D0-0x0000000189A18910
		// [XID] // 0x0000000189A188D0-0x0000000189A18910
		public void InitOnCreate(Quest quest) {} // 0x0000000183BBA370-0x0000000183BBA430
		// [XID] // 0x0000000189A23120-0x0000000189A23140
		private QuestActor GetActor() => default; // 0x0000000183BB9070-0x0000000183BB91B0
		// [XID] // 0x0000000189A31730-0x0000000189A31750
		public void Init() {} // 0x0000000183BBA430-0x0000000183BBA760
		// [XID] // 0x0000000189A39250-0x0000000189A39270
		public string GetLuaDataPathExternal() => default; // 0x0000000183BB91B0-0x0000000183BB9260
		// [XID] // 0x0000000189A40A50-0x0000000189A40A70
		private string GetLuaDataPath() => default; // 0x0000000183BB9260-0x0000000183BB9370
		// [XID] // 0x0000000189A48090-0x0000000189A480B0
		public void SoftRewindUnfinishedQuest() {} // 0x0000000183BBB2B0-0x0000000183BBB490
		// [XID] // 0x0000000189A4F920-0x0000000189A4F940
		public void RewindUnfinishedQuest() {} // 0x0000000183BBAB80-0x0000000183BBB2B0
		// [XID] // 0x0000000189A56F50-0x0000000189A56F70
		public void OnDestroy(bool force = false /* Metadata: 0x00AFFBB6 */) {} // 0x0000000183BBA9C0-0x0000000183BBAAE0
		// [XID] // 0x0000000189A66230-0x0000000189A66250
		public void ResetForceUpdate() {} // 0x0000000183BBAAE0-0x0000000183BBAB80
		// [XID] // 0x0000000189A6D9A0-0x0000000189A6D9C0
		public void UpdatePreQuest(Quest quest, bool init = false /* Metadata: 0x00AFFBB7 */) {} // 0x0000000183BBB490-0x0000000183BBB5C0
		// [XID] // 0x0000000189A750F0-0x0000000189A75110
		public void UpdateQuest(Quest quest) {} // 0x0000000183BBB6A0-0x0000000183BBB7A0
		// [XID] // 0x0000000189A7CD50-0x0000000189A7CD70
		public void UpdateQuestActor(Quest quest) {} // 0x0000000183BBB5C0-0x0000000183BBB6A0
		// [XID] // 0x0000000189A845E0-0x0000000189A84600
		public void CallQuestEvent(CallEventType type) {} // 0x0000000183BB88A0-0x0000000183BB8E00
		// [XID] // 0x0000000189ADEE90-0x0000000189ADEEB0
		public uint LackedSceneQuestId(uint sceneId) => default; // 0x0000000183BBA890-0x0000000183BBA9C0
		// [XID] // 0x0000000189AE6720-0x0000000189AE6740
		public uint LackedNPCQuestId(uint NPCId) => default; // 0x0000000183BBA760-0x0000000183BBA890
		// [XID] // 0x0000000189B13220-0x0000000189B13240
		public uint finishProgress(int i) => default; // 0x0000000183BBB900-0x0000000183BBB9F0
		// [XID] // 0x0000000189B1A9A0-0x0000000189B1A9C0
		public uint failProgress(int i) => default; // 0x0000000183BBB810-0x0000000183BBB900
		// [XID] // 0x0000000189B21F90-0x0000000189B21FB0
		public uint initFinishProgress(int i) => default; // 0x0000000183BBC5B0-0x0000000183BBC6F0
		// [XID] // 0x0000000189B29560-0x0000000189B29580
		public uint initFailProgress(int i) => default; // 0x0000000183BBC470-0x0000000183BBC5B0
		// [XID] // 0x0000000189B30AB0-0x0000000189B30AD0
		public string GetQuestLocationName() => default; // 0x0000000183BB9AC0-0x0000000183BB9C50
		// [IDTag] // 0x0000000189B38170-0x0000000189B381B0
		// [XID] // 0x0000000189B38170-0x0000000189B381B0
		public Vector3? GetQuestWorldPosition(out uint worldSceneId) {
			worldSceneId = default;
			return default;
		} // 0x0000000183BB9C50-0x0000000183BB9D60
		// [IDTag] // 0x0000000189B42AF0-0x0000000189B42B30
		// [XID] // 0x0000000189B42AF0-0x0000000189B42B30
		public Vector3? GetQuestWorldPosition(out uint worldSceneId, out uint guideScene) {
			worldSceneId = default;
			guideScene = default;
			return default;
		} // 0x0000000183BB9D60-0x0000000183BBA370
		// [XID] // 0x0000000189B4D2D0-0x0000000189B4D2F0
		public Vector3? GetQuestLocalPosition() => default; // 0x0000000183BB9370-0x0000000183BB9AC0
	}
}
