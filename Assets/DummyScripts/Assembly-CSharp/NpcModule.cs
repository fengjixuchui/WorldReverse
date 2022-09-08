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
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class NpcModule : CharacterModule // TypeDefIndex: 21595
{
	// Fields
	private Dictionary<uint, Dictionary<uint, BaseEntity>> _cfgId2RealNpcDic; // 0x18
	private Dictionary<uint, Dictionary<uint, BaseEntity>> _cfgId2SeriesDic; // 0x20
	private Dictionary<uint, bool> _cfgId2ReturningDic; // 0x28
	private Dictionary<uint, Dictionary<uint, NPCAnimeOverrideInfo>> _seriesIdNpcOverrideAnimes; // 0x30
	private Dictionary<uint, Dictionary<uint, NPCAnimeOverrideInfo>> _questIdNpcOverrideAnimes; // 0x38
	private Dictionary<uint, BaseEntity> _appearedNpcDic; // 0x40
	private List<BaseEntity> _appearedNpcList; // 0x48
	private HashSet<uint> _firstMetID; // 0x50
	private uint INVALID_FIRST_MEET_ID; // 0x58

	// Properties
	public List<BaseEntity> appearedNpcList { /* [XID] */ /* 0x0000000189618050-0x0000000189618070 */ get => default; } // 0x0000000184959600-0x00000001849596A0 

	// Nested types
	public class NPCAnimeOverrideInfo // TypeDefIndex: 21596
	{
		// Fields
		public Dictionary<string, HashSet<IAnimeOverrideReason>> stateLoadReasonDic; // 0x10
		public Dictionary<int, HashSet<IAnimeOverrideReason>> freeStyleLoadReasonDic; // 0x18

		// Properties
		public bool isEmpty { /* [XID] */ /* 0x0000000189A4C900-0x0000000189A4C920 */ get => default; } // 0x00000001849645E0-0x00000001849646C0 

		// Constructors
		public NPCAnimeOverrideInfo() {} // 0x0000000184964B90-0x0000000184964C40

		// Methods
		// [IDTag] // 0x0000000189A54110-0x0000000189A54150
		// [XID] // 0x0000000189A54110-0x0000000189A54150
		public void AddLoadReason(string stateId, IAnimeOverrideReason reason) {} // 0x0000000184964320-0x0000000184964480
		// [IDTag] // 0x0000000189A5EB10-0x0000000189A5EB50
		// [XID] // 0x0000000189A5EB10-0x0000000189A5EB50
		public bool RemoveLoadReason(string stateId, IAnimeOverrideReason reason) => default; // 0x00000001849646C0-0x0000000184964830
		// [IDTag] // 0x0000000189A69910-0x0000000189A69950
		// [XID] // 0x0000000189A69910-0x0000000189A69950
		public void AddLoadReason(int freeStyleId, IAnimeOverrideReason reason) {} // 0x0000000184964480-0x00000001849645E0
		// [IDTag] // 0x0000000189A73B50-0x0000000189A73B90
		// [XID] // 0x0000000189A73B50-0x0000000189A73B90
		public bool RemoveLoadReason(int freeStyleId, IAnimeOverrideReason reason) => default; // 0x0000000184964830-0x0000000184964990
		// [IDTag] // 0x0000000189A7E440-0x0000000189A7E480
		// [XID] // 0x0000000189A7E440-0x0000000189A7E480
		public void AddLoadReason(int[] freeStyleIdList, IAnimeOverrideReason reason) {} // 0x0000000184964170-0x0000000184964320
		// [IDTag] // 0x0000000189A88FB0-0x0000000189A88FF0
		// [XID] // 0x0000000189A88FB0-0x0000000189A88FF0
		public bool RemoveLoadReason(int[] freeStyleIdList, IAnimeOverrideReason reason) => default; // 0x0000000184964990-0x0000000184964AB0
		// [XID] // 0x0000000189A93450-0x0000000189A93470
		public void Release() {} // 0x0000000184964AB0-0x0000000184964B90
	}

	public enum SpeechBubblePriority // TypeDefIndex: 21597
	{
		None = 0,
		Daily = 1,
		Conv = 2,
		Quest = 3,
		Given = 4,
		All = 5
	}

	// Constructors
	public NpcModule() {} // 0x000000018495D800-0x000000018495D990

	// Methods
	// [XID] // 0x00000001898A7810-0x00000001898A7830
	protected override void RegsiterModuleNotify(NotifyManager notifyMgr) {} // 0x000000018495B490-0x000000018495B560
	// [XID] // 0x00000001898AF270-0x00000001898AF290
	protected override void RegisterModulesPkt(NotifyManager notifyMgr) {} // 0x00000001849585C0-0x00000001849586A0
	// [XID] // 0x00000001898B66F0-0x00000001898B6710
	public void AddReturning(uint npcId, uint mainQuestId) {} // 0x00000001849594B0-0x0000000184959600
	// [XID] // 0x00000001898BDF00-0x00000001898BDF20
	public void ClearReturning(uint npcId) {} // 0x0000000184959C40-0x0000000184959D30
	// [XID] // 0x00000001898C5790-0x00000001898C57B0
	public bool IsReturning(uint npcId) => default; // 0x000000018495BBF0-0x000000018495BCC0
	// [XID] // 0x00000001898CCE70-0x00000001898CCE90
	private void ClearRealNpcDic() {} // 0x0000000184957420-0x0000000184957750
	// [XID] // 0x00000001898D47D0-0x00000001898D47F0
	public uint GetSeriesId(uint mainQuestId) => default; // 0x0000000184958780-0x0000000184958870
	// [IDTag] // 0x00000001898DC1B0-0x00000001898DC1F0
	// [XID] // 0x00000001898DC1B0-0x00000001898DC1F0
	public BaseEntity GetRealNpcOnCreate(uint configId, uint mainQuestId, bool createNow = true /* Metadata: 0x00AFF9B4 */) => default; // 0x000000018495C110-0x000000018495C210
	// [IDTag] // 0x00000001898E7110-0x00000001898E7150
	// [XID] // 0x00000001898E7110-0x00000001898E7150
	public BaseEntity GetRealNpcOnCreate(uint configId, uint mainQuestId, out uint localMainQuestId, bool createNow = true /* Metadata: 0x00AFF9B5 */) {
		localMainQuestId = default;
		return default;
	} // 0x000000018495BCC0-0x000000018495C110
	// [XID] // 0x00000001898F1990-0x00000001898F19B0
	public BaseEntity GetRealNpc(uint configId, uint mainQuestId) => default; // 0x00000001849570E0-0x0000000184957420
	// [XID] // 0x00000001898F90D0-0x00000001898F90F0
	public BaseEntity GetRealNpcAny(uint configId, uint mainQuestId) => default; // 0x0000000184959820-0x0000000184959AD0
	// [XID] // 0x00000001899009B0-0x00000001899009D0
	public void AddRealNpc(uint configId, uint mainQuestId, BaseEntity entity) {} // 0x0000000184957A60-0x0000000184957D20
	// [XID] // 0x00000001899081F0-0x0000000189908210
	public void RemoveRealNpc(uint configId, uint mainQuestId) {} // 0x0000000184956B30-0x0000000184956D40
	// [XID] // 0x000000018990F990-0x000000018990F9B0
	public EntityMetaData CreateDefaultNpcMetaData(uint configId, uint sceneId, uint roomId, uint questMainId, Vector3 pos, Vector3 euler, string alias = null, string metaPath = null) => default; // 0x000000018495C780-0x000000018495CA60
	// [XID] // 0x0000000189A2E230-0x0000000189A2E250
	public EntityMetaData UpdateNpcMetaData(uint configId, uint sceneId, uint roomId, uint questMainId, Vector3 pos, Vector3 euler, string alias, string metaPath) => default; // 0x0000000184959030-0x0000000184959430
	// [IDTag] // 0x000000018991EAA0-0x000000018991EAE0
	// [XID] // 0x000000018991EAA0-0x000000018991EAE0
	public BaseEntity CreateRealNpc(EntityMetaData data, bool async = false /* Metadata: 0x00AFF9B6 */, uint targetRuntimeId = 0 /* Metadata: 0x00AFF9B7 */) => default; // 0x000000018495B0E0-0x000000018495B1F0
	// [IDTag] // 0x0000000189929300-0x0000000189929340
	// [XID] // 0x0000000189929300-0x0000000189929340
	public BaseEntity CreateRealNpc(EntityMetaData data, out uint localMainQuestId, bool async = false /* Metadata: 0x00AFF9BB */, bool checkLocal = false /* Metadata: 0x00AFF9BC */, uint targetRuntimeId = 0 /* Metadata: 0x00AFF9BD */) {
		localMainQuestId = default;
		return default;
	} // 0x000000018495AAC0-0x000000018495B0E0
	// [XID] // 0x0000000189933500-0x0000000189933520
	private static void ResetNPCModelVisible(VCBaseModel model) {} // 0x0000000184959B50-0x0000000184959C40
	// [XID] // 0x000000018993B190-0x000000018993B1B0
	public BaseEntity TryCreateRealNpc(uint configId, uint sceneId, uint roomId, uint questMainID, Vector3 pos, Vector3 euler, string alias = null, string metaPath = null, bool async = false /* Metadata: 0x00AFF9C1 */, bool force = false /* Metadata: 0x00AFF9C2 */) => default; // 0x0000000184957D20-0x0000000184958110
	// [XID] // 0x00000001896DBBC0-0x00000001896DBBE0
	public void ReturnRealDailyLocalNpc(uint configId, uint questMainID) {} // 0x0000000184958AB0-0x0000000184958E80
	// [XID] // 0x0000000189949BA0-0x0000000189949BC0
	public Vector3 GetNpcPosition(uint configId, uint questMainID, out BaseEntity npcEntity) {
		npcEntity = default;
		return default;
	} // 0x0000000184958870-0x0000000184958AB0
	// [IDTag] // 0x0000000189951780-0x00000001899517C0
	// [XID] // 0x0000000189951780-0x00000001899517C0
	public BaseEntity EntityAppear(uint configId, uint roomId, uint mainQuestId, Vector3 pos, Vector3 rot, uint runtimeID = 0 /* Metadata: 0x00AFF9C3 */) => default; // 0x000000018495CF00-0x000000018495D800
	// [IDTag] // 0x000000018995BB60-0x000000018995BBA0
	// [XID] // 0x000000018995BB60-0x000000018995BBA0
	public override void EntityAppear(SceneEntityInfo entityInfo, VisionType type, uint infoParam) {} // 0x000000018495CE30-0x000000018495CF00
	// [IDTag] // 0x0000000189966530-0x0000000189966570
	// [XID] // 0x0000000189966530-0x0000000189966570
	public override void EntityDisappear(uint entityId, VisionType type) {} // 0x000000018495CA60-0x000000018495CB20
	// [IDTag] // 0x0000000189971080-0x00000001899710C0
	// [XID] // 0x0000000189971080-0x00000001899710C0
	public void EntityDisappear(uint entityId, VisionType type, bool fromManager) {} // 0x000000018495CB20-0x000000018495CE30
	// [XID] // 0x000000018997B530-0x000000018997B550
	private void ClearNpcCache() {} // 0x000000018495B3F0-0x000000018495B490
	// [XID] // 0x0000000189982F90-0x0000000189982FB0
	public void LoadNpcOverrideAnimeSync(uint configId, uint mainQuestId, string stateId, IAnimeOverrideReason reason) {} // 0x00000001849567F0-0x0000000184956A20
	// [XID] // 0x000000018998A740-0x000000018998A760
	public void LoadNpcOverrideAnimeAsync(uint configId, uint mainQuestId, string stateId, IAnimeOverrideReason reason, Action<bool> callBack) {} // 0x000000018495A1A0-0x000000018495A400
	// [XID] // 0x0000000189991FE0-0x0000000189992000
	public void LoadNpcOverrideAnimeByFreeStyleSync(uint configId, uint mainQuestId, int freeStyle, IAnimeOverrideReason reason) {} // 0x000000018495A660-0x000000018495A890
	// [XID] // 0x0000000189999D70-0x0000000189999D90
	public void LoadNpcOverrideAnimeByFreeStyleListSync(uint configId, uint mainQuestId, int[] freeStyleList, IAnimeOverrideReason reason) {} // 0x000000018495A890-0x000000018495AAC0
	// [XID] // 0x00000001899A1450-0x00000001899A1470
	public void LoadNpcOverrideAnimeByFreeStyleAsync(uint configId, uint mainQuestId, int freeStyle, IAnimeOverrideReason reason, Action<bool> callBack) {} // 0x000000018495B8C0-0x000000018495BB20
	// [XID] // 0x0000000189A28260-0x0000000189A28280
	public void LoadNpcOverrideAnimeByFreeStyleListAsync(uint configId, uint mainQuestId, int[] freeStyleList, IAnimeOverrideReason reason, Action<bool> callBack) {} // 0x000000018495A400-0x000000018495A660
	// [XID] // 0x00000001899B0810-0x00000001899B0830
	public NPCAnimeOverrideInfo GetNpcOverrideAnimes(uint configId, uint mainQuestId) => default; // 0x0000000184959D30-0x0000000184959E80
	// [XID] // 0x00000001899B7BB0-0x00000001899B7BD0
	public void ResetNpcOverrideAnime(uint configId, uint mainQuestId, string stateId, IAnimeOverrideReason reason) {} // 0x000000018495B600-0x000000018495B830
	// [XID] // 0x00000001899BF5D0-0x00000001899BF5F0
	public void ResetNpcOverrideAnimeByFreeStyle(uint configId, uint mainQuestId, int freeStyle, IAnimeOverrideReason reason) {} // 0x0000000184958210-0x0000000184958440
	// [XID] // 0x00000001899C6F70-0x00000001899C6F90
	public void ResetNpcOverrideAnimeByFreeStyleList(uint configId, uint mainQuestId, int[] freeStyleList, IAnimeOverrideReason reason) {} // 0x0000000184959E80-0x000000018495A0B0
	// [XID] // 0x00000001899CE410-0x00000001899CE430
	private void ClearNpcOverrideAnimeCache() {} // 0x000000018495C210-0x000000018495C780
	// [XID] // 0x0000000189814C30-0x0000000189814C50
	private void AddAppeared(BaseEntity entity, uint preRuntimeId) {} // 0x0000000184958E80-0x0000000184959030
	// [XID] // 0x00000001899E4B40-0x00000001899E4B60
	public void RemoveOnDestroy(uint runtimeId) {} // 0x000000018495B340-0x000000018495B3F0
	// [XID] // 0x00000001899EC070-0x00000001899EC090
	private void RemoveDisappeared(uint runtimeId) {} // 0x0000000184958440-0x00000001849585C0
	// [XID] // 0x00000001899F3A50-0x00000001899F3A70
	public static bool IsNpc(BaseEntity entity) => default; // 0x000000018495A0B0-0x000000018495A1A0
	// [XID] // 0x00000001899FB330-0x00000001899FB350
	public override bool OnNotify(Notify ntf) => default; // 0x000000018495BB20-0x000000018495BBF0
	// [XID] // 0x0000000189A02550-0x0000000189A02570
	public override bool OnPacket(Packet pkt) => default; // 0x0000000184957940-0x0000000184957A60
	// [XID] // 0x0000000189A09CE0-0x0000000189A09D00
	public override void ClearOnLevelDestroy() {} // 0x0000000184958110-0x0000000184958210
	// [XID] // 0x0000000189A11520-0x0000000189A11540
	public override void ClearOnDisconnect() {} // 0x000000018495B560-0x000000018495B600
	// [XID] // 0x0000000189A18910-0x0000000189A18930
	public bool TriggerNpcSpeechBubble(uint npcID, uint dialogID, uint mainQuestId, uint priority, float time = 0f /* Metadata: 0x00AFF9C7 */) => default; // 0x0000000184956F80-0x00000001849570E0
	// [XID] // 0x0000000189A1FFB0-0x0000000189A1FFD0
	public void ClearNpcSpeechBubble(uint npcID, uint mainQuestId, uint priority) {} // 0x0000000184956A20-0x0000000184956B30
	// [XID] // 0x0000000189A27340-0x0000000189A27360
	public bool IsFirstMeet(uint npcID) => default; // 0x00000001849586A0-0x0000000184958780
	// [XID] // 0x0000000189A2EB80-0x0000000189A2EBA0
	public void RecordMeet(uint npcID) {} // 0x00000001849577D0-0x0000000184957940
	// [XID] // 0x0000000189A364B0-0x0000000189A364D0
	private void OnMeetNpcRsp(MeetNpcRsp meetNpcRsp) {} // 0x000000018495B1F0-0x000000018495B340
	// [XID] // 0x0000000189A3DA90-0x0000000189A3DAB0
	private void OnMetNpcIdListNotify(MetNpcIdListNotify metNpcIdListNotify) {} // 0x0000000184956D40-0x0000000184956F80
	// [XID] // 0x0000000189A451F0-0x0000000189A45210
	private uint GetFirstMeetIDFromNPCID(uint npcID) => default; // 0x0000000184959740-0x0000000184959820
}

