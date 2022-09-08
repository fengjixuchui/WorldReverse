/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class NpcTalkContainer : ITickableObject<uint>, ISimplePoolObject // TypeDefIndex: 21670
{
	// Fields
	private static SimpleObjectPool<NpcTalkContainer> _pool; // 0x00
	private uint _npcConfigId; // 0x10
	private uint _curDirtyFlag; // 0x14
	private uint _lastRefreshMainQuestId; // 0x18
	private bool _lastIsDiscard; // 0x1C
	private List<uint> _relatedMainQuests; // 0x20
	private List<ConfigTalkScheme> _validTalkList; // 0x28
	private ConfigTalkScheme _validPrePerformTalk; // 0x30
	private ConfigTalkScheme _validMarkTalk; // 0x38
	private Dictionary<uint, List<ConfigTalkScheme>> _candidateTalkListDic; // 0x40
	private Dictionary<uint, ConfigTalkScheme> _autonomyTalkDic; // 0x48
	private HashSet<uint> _checkedTempTalkIds; // 0x50

	// Properties
	public uint key { /* [XID] */ /* 0x00000001897073E0-0x0000000189707400 */ get => default; } // 0x00000001849AE430-0x00000001849AE4D0 
	public bool isDirty { /* [XID] */ /* 0x0000000189AC4770-0x0000000189AC4790 */ get => default; } // 0x00000001849B01F0-0x00000001849B02C0 
	public uint lastRefreshMainQuestId { /* [XID] */ /* 0x0000000189724F20-0x0000000189724F40 */ get => default; } // 0x00000001849AF380-0x00000001849AF420 
	public bool lastIsDiscard { /* [XID] */ /* 0x000000018972C6A0-0x000000018972C6C0 */ get => default; } // 0x00000001849AFBE0-0x00000001849AFC80 
	public List<ConfigTalkScheme> validTalkList { /* [XID] */ /* 0x0000000189733DF0-0x0000000189733E10 */ get => default; } // 0x00000001849B0910-0x00000001849B09B0 
	public uint validTalkId { /* [XID] */ /* 0x0000000189655B00-0x0000000189655B20 */ get => default; } // 0x00000001849AEC40-0x00000001849AEDB0 
	public ConfigTalkScheme validPrePerformTalk { /* [XID] */ /* 0x0000000189742FA0-0x0000000189742FC0 */ get => default; } // 0x00000001849AF180-0x00000001849AF220 
	public ConfigTalkScheme validMarkTalk { /* [XID] */ /* 0x000000018974AB60-0x000000018974AB80 */ get => default; } // 0x00000001849B0010-0x00000001849B00B0 
	public int index { get; set; } // 0x00000001849AFD80-0x00000001849AFDE0 0x00000001849AFDE0-0x00000001849AFE40

	// Nested types
	private enum PriorityGroup // TypeDefIndex: 21671
	{
		None = 0,
		Daily = 1,
		IgnoreNormal = 2,
		LowPriority = 3,
		IgnoreLowPriority = 4,
		Quest = 5
	}

	private struct PriorityConfig // TypeDefIndex: 21672
	{
		// Fields
		public uint priority; // 0x00
		public PriorityGroup priorityGroup; // 0x04

		// Methods
		// [XID] // 0x0000000189ADB370-0x0000000189ADB390
		public static PriorityConfig GetDefault() => default; // 0x00000001849A9AC0-0x00000001849A9B60
		// [XID] // 0x00000001897FF050-0x00000001897FF070
		private int CompareTo(PriorityConfig tar) => default; // 0x00000001849A9380-0x00000001849A93A0
		// [XID] // 0x00000001896CE840-0x00000001896CE860
		public void CopyFrom(ConfigTalkScheme config) {} // 0x00000001849A9550-0x00000001849A9560
		// [XID] // 0x000000018980DF90-0x000000018980DFB0
		public override bool Equals(object obj) => default; // 0x00000001849A97C0-0x00000001849A9880
		// [XID] // 0x0000000189815630-0x0000000189815650
		public override int GetHashCode() => default; // 0x00000001849A9880-0x00000001849A9930
		// [XID] // 0x000000018981D080-0x000000018981D0A0
		public static bool operator ==(PriorityConfig self, PriorityConfig tar) => default; // 0x00000001849A9940-0x00000001849A9A00
		// [XID] // 0x00000001898244A0-0x00000001898244C0
		public static bool operator !=(PriorityConfig self, PriorityConfig tar) => default; // 0x00000001849A9A00-0x00000001849A9AC0
		// [XID] // 0x000000018982BF70-0x000000018982BF90
		public static bool operator >(PriorityConfig self, PriorityConfig tar) => default; // 0x00000001849A93A0-0x00000001849A9550
		// [XID] // 0x00000001897B7AA0-0x00000001897B7AC0
		public static bool operator <(PriorityConfig self, PriorityConfig tar) => default; // 0x00000001849A9560-0x00000001849A96B0
	}

	// Constructors
	public NpcTalkContainer() {} // 0x00000001849B0D70-0x00000001849B0EB0
	static NpcTalkContainer() {} // 0x00000001849B0D00-0x00000001849B0D70

	// Methods
	// [XID] // 0x0000000189ABCE50-0x0000000189ABCE70
	public static NpcTalkContainer Get(uint npcConfigId) => default; // 0x00000001849AF420-0x00000001849AF530
	// [XID] // 0x00000001896FFCE0-0x00000001896FFD00
	public static void Release(NpcTalkContainer container) {} // 0x00000001849AFF20-0x00000001849B0010
	// [XID] // 0x00000001897424E0-0x0000000189742500
	public void SetDirty() {} // 0x00000001849AEEA0-0x00000001849AEF40
	// [XID] // 0x000000018971DAC0-0x000000018971DAE0
	public void ResetDirty() {} // 0x00000001849B09B0-0x00000001849B0A70
	// [XID] // 0x0000000189751BD0-0x0000000189751BF0
	private bool GetCandidateTalkList(uint mainQuestId, out List<ConfigTalkScheme> talkList) {
		talkList = default;
		return default;
	} // 0x00000001849B00B0-0x00000001849B01F0
	// [XID] // 0x0000000189759300-0x0000000189759320
	private bool TryGetCandidateTalkList(uint mainQuestId, out List<ConfigTalkScheme> talkList) {
		talkList = default;
		return default;
	} // 0x00000001849AF0A0-0x00000001849AF180
	// [XID] // 0x0000000189760E50-0x0000000189760E70
	public void AddCandidateTalk(uint mainQuestId, ConfigTalkScheme talkConfig) {} // 0x00000001849ADF20-0x00000001849AE200
	// [XID] // 0x0000000189768200-0x0000000189768220
	public ConfigTalkScheme GetCandidateTalk(uint talkId, uint mainQuestId) => default; // 0x00000001849B06E0-0x00000001849B0910
	// [XID] // 0x000000018976F7D0-0x000000018976F7F0
	public void RemoveCandidateTalk(uint mainQuestId) {} // 0x00000001849B02C0-0x00000001849B06E0
	// [XID] // 0x00000001896F7C10-0x00000001896F7C30
	public void FlushToBeRemoveCandidateTalk(uint mainQuestId) {} // 0x00000001849AF770-0x00000001849AFAE0
	// [XID] // 0x000000018977E860-0x000000018977E880
	public void AddAutonomyTalk(ConfigTalkScheme talkConfig) {} // 0x00000001849AE200-0x00000001849AE430
	// [XID] // 0x0000000189786020-0x0000000189786040
	public ConfigTalkScheme GetAutonomyTalk(uint talkId) => default; // 0x00000001849AE4D0-0x00000001849AE5B0
	// [XID] // 0x000000018978D6D0-0x000000018978D6F0
	public void RemoveAutonomyTalk(uint talkId) {} // 0x00000001849AFC80-0x00000001849AFD80
	// [XID] // 0x0000000189794B20-0x0000000189794B40
	public void RefreshMainQuestId(uint mainQuestId) {} // 0x00000001849AEDB0-0x00000001849AEEA0
	// [XID] // 0x0000000189B5A4C0-0x0000000189B5A4E0
	public bool IsNeedRefreshValidTalkId(uint mainQuestId, bool isDiscard) => default; // 0x00000001849AFE40-0x00000001849AFF20
	// [XID] // 0x0000000189637F90-0x0000000189637FB0
	public void RefreshValidTalkId(uint mainQuestId, bool isDiscard) {} // 0x00000001849AF530-0x00000001849AF770
	// [XID] // 0x00000001897AB920-0x00000001897AB940
	private PriorityConfig GetTalkPriority(ConfigTalkScheme talkConfig, uint mainQuestId, bool isNextTalk) => default; // 0x00000001849AF220-0x00000001849AF380
	// [XID] // 0x000000018973C8E0-0x000000018973C900
	private void GetMaxPriorityInNextTalk(uint[] nextTalkIds, uint mainQuestId, ref PriorityConfig curPriority, HashSet<uint> checkedTalks) {} // 0x00000001849AEA00-0x00000001849AEC40
	// [XID] // 0x0000000189AE2B60-0x0000000189AE2B80
	private void RefreshValidTalkIdInternal(uint mainQuestId, ref PriorityConfig currentPriority) {} // 0x00000001849AE5B0-0x00000001849AEA00
	// [XID] // 0x00000001897C2EB0-0x00000001897C2ED0
	private bool IsTalkValid(ConfigTalkScheme talkConfig, uint mainQuestId, PriorityConfig currentPriority, out PriorityConfig tarPriority) {
		tarPriority = default;
		return default;
	} // 0x00000001849B0A70-0x00000001849B0C00
	// [XID] // 0x00000001897260C0-0x00000001897260E0
	private bool IsNextTalkValid(ConfigTalkScheme nextTalkConfig, uint mainQuestId) => default; // 0x00000001849AFAE0-0x00000001849AFBE0
	// [XID] // 0x00000001897E0EA0-0x00000001897E0EC0
	public void Tick(float deltaTime) {} // 0x00000001849AEFF0-0x00000001849AF0A0
	// [XID] // 0x00000001897E8570-0x00000001897E8590
	public void ResetObject() {} // 0x00000001849B0C00-0x00000001849B0D00
	// [XID] // 0x0000000189ACBE80-0x0000000189ACBEA0
	public void Init(uint configId) {} // 0x00000001849AEF40-0x00000001849AEFF0
}

