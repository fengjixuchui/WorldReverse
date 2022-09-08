/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class BlossomModule : BaseModule // TypeDefIndex: 21409
{
	// Fields
	private static uint BlossomMarkStartID; // 0x00
	private SimpleObjectPool<BlossomData> _blossomDataPool; // 0x10
	private Dictionary<uint, List<BlossomData>> _blossomDataListDic; // 0x18
	private Dictionary<uint, Dictionary<uint, BlossomData>> _blossomDatas; // 0x20
	private uint _curMarkId; // 0x28
	private Dictionary<uint, BlossomData> _blossomMarkIdDic; // 0x30
	private BlossomScheduleInfo _currentBlossomScheduleInfo; // 0x38
	private BlossomGroupsExcelConfig _curBlossomGroupConfig; // 0x40
	private float _nextCheckTime; // 0x48
	private const float CHECK_GAP = 1f; // Metadata: 0x00AFF7B6
	private uint _outSideRange; // 0x4C
	private bool _outSideFlag; // 0x50
	private bool _lastOutSideFlag; // 0x51
	private SimpleObjectPool<NpcTalkInfo> _npcTalkInfoPool; // 0x58
	private Dictionary<uint, SortedList<NpcTalkInfo, NpcTalkInfo>> _npcCurTalkListDic; // 0x60
	private Dictionary<BlossomKey, BlossomTalkExcelConfig> _talkIdListDic; // 0x68
	private Dictionary<uint, BlossomTalkExcelConfig> _refreshIdListDic; // 0x70
	private Dictionary<uint, NpcTalkInfo> _talkIdLoadStateDic; // 0x78
	private int _curLoadTalkCount; // 0x80
	private bool _curLoadFinished; // 0x84
	private bool _talkDataInited; // 0x85
	private List<uint> _needSendGroupIdList; // 0x88

	// Properties
	public Dictionary<uint, List<BlossomData>> blossomDataListDic { /* [XID] */ /* 0x00000001896BBC40-0x00000001896BBC60 */ get => default; } // 0x000000018483B920-0x000000018483B9C0 
	public BlossomScheduleInfo currentBlossomScheduleInfo { /* [XID] */ /* 0x000000018971C3C0-0x000000018971C3E0 */ get => default; } // 0x000000018483DD20-0x000000018483DDC0 

	// Nested types
	private struct BlossomKey // TypeDefIndex: 21410
	{
		// Fields
		public uint refreshId; // 0x00
		public uint groupId; // 0x04

		// Constructors
		public BlossomKey(uint refreshId, uint groupId) {
			this.refreshId = default;
			this.groupId = default;
		} // 0x000000018485C660-0x000000018485C6D0

		// Methods
		// [XID] // 0x0000000189812640-0x0000000189812660
		public override int GetHashCode() => default; // 0x000000018485C4C0-0x000000018485C570
		// [IDTag] // 0x000000018981A280-0x000000018981A2C0
		// [XID] // 0x000000018981A280-0x000000018981A2C0
		public override bool Equals(object obj) => default; // 0x000000018485C3E0-0x000000018485C4C0
		// [IDTag] // 0x0000000189824520-0x0000000189824560
		// [XID] // 0x0000000189824520-0x0000000189824560
		public bool Equals(BlossomKey other) => default; // 0x000000018485C640-0x000000018485C660
		// [XID] // 0x000000018982EB70-0x000000018982EB90
		private static int CombineHashCodes(int h1, int h2) => default; // 0x000000018485C0E0-0x000000018485C230
		// [XID] // 0x0000000189836510-0x0000000189836530
		public void Reset() {} // 0x000000018485C230-0x000000018485C2D0
	}

	private class NpcTalkInfo : ISimplePoolObject, IComparable<NpcTalkInfo> // TypeDefIndex: 21411
	{
		// Fields
		public uint talkId; // 0x10
		public uint order; // 0x14
		public bool loaded; // 0x18
		public BlossomKey key; // 0x1C

		// Constructors
		public NpcTalkInfo() {} // 0x000000018485CD20-0x000000018485CD80

		// Methods
		// [IDTag] // 0x000000018983D920-0x000000018983D960
		// [XID] // 0x000000018983D920-0x000000018983D960
		public void Init(uint talkId, uint order, BlossomKey key) {} // 0x000000018485CA50-0x000000018485CB30
		// [IDTag] // 0x0000000189847DA0-0x0000000189847DE0
		// [XID] // 0x0000000189847DA0-0x0000000189847DE0
		public void Init(uint talkId, uint order, uint refreshId, uint groupId) {} // 0x000000018485CB30-0x000000018485CC70
		// [XID] // 0x00000001898520F0-0x0000000189852110
		public void ResetObject() {} // 0x000000018485CC70-0x000000018485CD20
		// [XID] // 0x0000000189859B50-0x0000000189859B70
		public int CompareTo(NpcTalkInfo tar) => default; // 0x000000018485C980-0x000000018485CA50
	}

	// Constructors
	public BlossomModule() {} // 0x0000000184841910-0x0000000184841B00
	static BlossomModule() {} // 0x00000001848418B0-0x0000000184841910

	// Methods
	// [XID] // 0x00000001896C3100-0x00000001896C3120
	private bool TryGetBlossomData(uint refreshID, uint groupId, out BlossomData data) {
		data = default;
		return default;
	} // 0x000000018483D390-0x000000018483D4D0
	// [XID] // 0x00000001896CA590-0x00000001896CA5B0
	private void AddBlossomData(BlossomData data) {} // 0x0000000184840130-0x0000000184840290
	// [XID] // 0x00000001896D1C60-0x00000001896D1C80
	private void ClearBlossomData() {} // 0x000000018483D0A0-0x000000018483D390
	// [XID] // 0x00000001896D94F0-0x00000001896D9510
	public bool TryGetBlossomDataByMarkId(uint markID, out BlossomData data) {
		data = default;
		return default;
	} // 0x000000018483CEB0-0x000000018483CF90
	// [XID] // 0x00000001896E0CB0-0x00000001896E0CD0
	public bool IsBlossomMark(uint markID) => default; // 0x000000018483F730-0x000000018483F800
	// [XID] // 0x00000001896E7EE0-0x00000001896E7F00
	public override void ClearOnBackHome() {} // 0x000000018483D960-0x000000018483DA30
	// [XID] // 0x00000001896EF640-0x00000001896EF660
	private uint GetNextMarkId() => default; // 0x000000018483D4D0-0x000000018483D5C0
	// [XID] // 0x00000001896F6F70-0x00000001896F6F90
	private void BlossomAddMark(BlossomData blossomData) {} // 0x000000018483AFF0-0x000000018483B1D0
	// [XID] // 0x00000001896FE8C0-0x00000001896FE8E0
	private void BlossomRemoveMark(BlossomData blossomData) {} // 0x000000018483C7E0-0x000000018483C9A0
	// [XID] // 0x0000000189705AE0-0x0000000189705B00
	private void ClearAllBlossomMark() {} // 0x0000000184840640-0x00000001848408A0
	// [XID] // 0x000000018970D570-0x000000018970D590
	public override bool OnPacket(Packet packet) => default; // 0x000000018483B1D0-0x000000018483B380
	// [XID] // 0x0000000189714950-0x0000000189714970
	private void OnBlossomChestCreateNotify(BlossomChestCreateNotify ntf) {} // 0x000000018483CD50-0x000000018483CEB0
	// [XID] // 0x00000001897237D0-0x00000001897237F0
	private void OnWorldOwnerBlossomScheduleInfoNotify(WorldOwnerBlossomScheduleInfoNotify ntf) {} // 0x000000018483DDC0-0x000000018483E010
	// [XID] // 0x000000018972AF50-0x000000018972AF70
	private void OnBlossomChestInfoNotify(BlossomChestInfoNotify ntf) {} // 0x000000018483FA70-0x000000018483FE50
	// [XID] // 0x00000001897326C0-0x00000001897326E0
	private void OnBlossomBriefInfoNotify(BlossomBriefInfoNotify ntf) {} // 0x0000000184840DC0-0x0000000184840F20
	// [XID] // 0x0000000189739E00-0x0000000189739E20
	private void OnWorldOwnerBlossomBriefInfoNotify(WorldOwnerBlossomBriefInfoNotify ntf) {} // 0x000000018483E630-0x000000018483E770
	// [XID] // 0x0000000189741980-0x00000001897419A0
	private void InitBlossomData(RepeatedMessageField<BlossomBriefInfo> blossomList) {} // 0x0000000184840290-0x0000000184840640
	// [XID] // 0x00000001897492A0-0x00000001897492C0
	public void RefreshBlossomMark() {} // 0x000000018483D5C0-0x000000018483D960
	// [XID] // 0x0000000189750780-0x00000001897507A0
	public void GMShowAllBlossomMark() {} // 0x000000018483FE50-0x0000000184840130
	// [XID] // 0x0000000189757C70-0x0000000189757C90
	public override bool OnNotify(Notify ntf) => default; // 0x00000001848415F0-0x00000001848416E0
	// [XID] // 0x000000018975F6D0-0x000000018975F6F0
	public override void ClearOnDisconnect() {} // 0x0000000184840CB0-0x0000000184840DC0
	// [XID] // 0x0000000189766B60-0x0000000189766B80
	public override void ClearOnLevelDestroy() {} // 0x000000018483B880-0x000000018483B920
	// [XID] // 0x000000018976E0E0-0x000000018976E100
	private void BlossomStart() {} // 0x000000018483DAB0-0x000000018483DD20
	// [XID] // 0x0000000189775920-0x0000000189775940
	private void UpdateBlossomProcess() {} // 0x000000018483F800-0x000000018483FA70
	// [XID] // 0x000000018977D1A0-0x000000018977D1C0
	private void HandleBlossomExitRegion() {} // 0x000000018483E7D0-0x000000018483E870
	// [XID] // 0x0000000189784B60-0x0000000189784B80
	private void RemoveCurrentBlossom() {} // 0x000000018483E410-0x000000018483E630
	// [XID] // 0x000000018978C0D0-0x000000018978C0F0
	private void FinishCurrentBlossom() {} // 0x000000018483E1D0-0x000000018483E410
	// [XID] // 0x0000000189793600-0x0000000189793620
	public void CheckBlossom(bool force = false /* Metadata: 0x00AFF7B5 */) {} // 0x000000018483BD20-0x000000018483C040
	// [XID] // 0x000000018979B830-0x000000018979B850
	private void InitTalkData() {} // 0x00000001848408A0-0x0000000184840BE0
	// [XID] // 0x00000001897A2C20-0x00000001897A2C40
	private void ClearTalkData() {} // 0x000000018483E090-0x000000018483E1D0
	// [XID] // 0x00000001897AA2A0-0x00000001897AA2C0
	private void InitBlossomTalks() {} // 0x000000018483E870-0x000000018483F730
	// [XID] // 0x00000001897B1C90-0x00000001897B1CB0
	private void CheckTalkLoadFinish() {} // 0x000000018483B380-0x000000018483B880
	// [XID] // 0x00000001897B9710-0x00000001897B9730
	private void TryRemoveBlossomTalk(BlossomData data) {} // 0x000000018483C4B0-0x000000018483C7E0
	// [XID] // 0x00000001897C1740-0x00000001897C1760
	private void RemoveBlossomTalk(BlossomTalkExcelConfig talkConfig) {} // 0x000000018483C9A0-0x000000018483CD50
	// [XID] // 0x000000018970FD90-0x000000018970FDB0
	public bool CheckTalkIsValid(uint npcId, uint talkId) => default; // 0x00000001848416E0-0x00000001848418B0
	// [XID] // 0x00000001897D07B0-0x00000001897D07D0
	public bool CheckNpcHaveBlossomTalk(uint npcId) => default; // 0x000000018483CF90-0x000000018483D0A0
	// [XID] // 0x00000001897D8500-0x00000001897D8520
	public void OnTalkLoaded(ConfigTalkScheme talkConfig) {} // 0x000000018483BAD0-0x000000018483BD20
	// [XID] // 0x00000001897DF5D0-0x00000001897DF5F0
	private void AddTalk2NpcImpl(NpcTalkInfo info, ConfigTalkScheme talkConfig) {} // 0x000000018483C040-0x000000018483C210
	// [XID] // 0x00000001897E6DF0-0x00000001897E6E10
	public void OpenMarkByTalk(uint npcId, uint talkId) {} // 0x0000000184840F20-0x0000000184841560
	// [IDTag] // 0x00000001897EEAA0-0x00000001897EEAE0
	// [XID] // 0x00000001897EEAA0-0x00000001897EEAE0
	private void C2S_OpenMark(uint refreshId, uint groupId) {} // 0x000000018483C360-0x000000018483C4B0
	// [IDTag] // 0x00000001897F94B0-0x00000001897F94F0
	// [XID] // 0x00000001897F94B0-0x00000001897F94F0
	private void C2S_OpenMark(uint refreshId, List<uint> groupIdList) {} // 0x000000018483C210-0x000000018483C360
	// [XID] // 0x0000000189803AF0-0x0000000189803B10
	protected override void RegisterModulesPkt(NotifyManager notifyMgr) {} // 0x000000018483B9C0-0x000000018483BAD0
	// [XID] // 0x000000018980AFB0-0x000000018980AFD0
	protected override void RegsiterModuleNotify(NotifyManager notifyMgr) {} // 0x0000000184840BE0-0x0000000184840CB0
}

