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
using UniRx;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class LevelModule : BaseModule // TypeDefIndex: 21539
{
	// Fields
	private uint _worldLevel; // 0x18
	private ulong _cdOverTime; // 0x20
	private Action<MessageBase> entityFightPropNotifyHandler; // 0x30
	private Action<MessageBase> entityFightPropUpdateNotifyHandler; // 0x38
	private Action<MessageBase> entityPropNotifyHandler; // 0x40
	private Coroutine loadEntityCoroutine; // 0x48
	private Action<MessageBase, Tuple<int, VisionType, uint>> entityAppearInLevelBy2ParamHandler; // 0x50
	private static Dictionary<uint, EntityStatInfo> statEntityRuntimeIDStatInfoMap; // 0x00
	public static Action<uint, int> delOnEntityCreated; // 0x08
	public static Action<uint, int> delOnEntityReady; // 0x10
	private Action<MessageBase, Tuple<uint, VisionType>> onSceneEntityDisappearBy2ParamHandler; // 0x58
	private Action<MessageBase, uint> lifeStateChangeNotifyHandler; // 0x60
	private ulong _forceDragTime; // 0x68
	private ChallengeRecordNotify _challengeRecordNtf; // 0x70
	private Dictionary<uint, List<uint>> _challengeTargetParamsDic; // 0x78
	private Dictionary<uint, List<uint>> _challengeProgressParamsDic; // 0x80
	private Dictionary<uint, ChallengeData> _challengeDataDic; // 0x88
	private uint? _currChallengeIndex; // 0x90
	private Dictionary<uint, uint> _challengeIndex2Record; // 0x98
	private bool _isInFlightChallenge; // 0xA0
	private bool _inServerCutScene; // 0xA1
	public bool isDungeonSettled; // 0xA2
	private bool _canShowTopTimer; // 0xA3
	private int _timeParamIndex; // 0xA4
	private Dictionary<uint, uint> _timeParamDic; // 0xA8
	private uint _challengeDeadline; // 0xB0
	private ulong _challengeBeginTimeStamp; // 0xB8
	private List<EntityAppearWaitForOwner> _entitiesWaitForOwner; // 0xC0

	// Properties
	public BaseLevel curLevel { /* [XID] */ /* 0x00000001898EB6D0-0x00000001898EB710 */ get; /* [XID] */ /* 0x00000001898F6060-0x00000001898F60A0 */ set; } // 0x0000000181637750-0x00000001816377B0 0x0000000181642FB0-0x0000000181643010
	public bool isLevelReady { /* [XID] */ /* 0x00000001899009D0-0x00000001899009F0 */ get => default; } // 0x0000000181642CA0-0x0000000181642DF0 
	public uint worldLevel { /* [XID] */ /* 0x0000000189908210-0x0000000189908230 */ get => default; /* [XID] */ /* 0x000000018990F9F0-0x000000018990FA10 */ set {} } // 0x0000000181641080-0x0000000181641120 0x00000001816406C0-0x00000001816407E0
	public ulong cdOverTime { /* [XID] */ /* 0x0000000189917440-0x0000000189917460 */ get => default; /* [XID] */ /* 0x000000018991EAE0-0x000000018991EB00 */ set {} } // 0x0000000181643D50-0x0000000181643DF0 0x0000000181639F50-0x000000018163A000
	public bool mpLevel { /* [XID] */ /* 0x0000000189926360-0x00000001899263A0 */ get; /* [XID] */ /* 0x0000000189930A00-0x0000000189930A40 */ private set; } // 0x000000018163E970-0x000000018163E9D0 0x00000001816458F0-0x0000000181645950
	private Coroutine GetLoadEntityCoroutine { /* [XID] */ /* 0x00000001899A4570-0x00000001899A4590 */ get => default; } // 0x000000018163B580-0x000000018163B620 
	public Dictionary<uint, ChallengeData> challengeDataDic { /* [XID] */ /* 0x0000000189AB1640-0x0000000189AB1660 */ get => default; } // 0x00000001816420E0-0x0000000181642190 
	public int challengeTimeParamIndex { /* [XID] */ /* 0x0000000189AFCCB0-0x0000000189AFCCD0 */ get => default; } // 0x0000000181640FE0-0x0000000181641080 
	public bool challengeHaveDeadline { /* [XID] */ /* 0x0000000189B04420-0x0000000189B04440 */ get => default; } // 0x00000001816455E0-0x0000000181645690 
	public bool canShowTopTimer { /* [XID] */ /* 0x0000000189B0BC70-0x0000000189B0BC90 */ get => default; } // 0x000000018163E0F0-0x000000018163E1A0 
	public uint challengeDeadline { /* [XID] */ /* 0x0000000189B13260-0x0000000189B13280 */ get => default; } // 0x0000000181645540-0x00000001816455E0 
	public ulong challengeBeginTimeStamp { /* [XID] */ /* 0x0000000189B21FF0-0x0000000189B22010 */ get => default; } // 0x000000018163B7F0-0x000000018163B8A0 
	public bool isInChallenge { /* [XID] */ /* 0x0000000189B295E0-0x0000000189B29600 */ get => default; } // 0x0000000181639D80-0x0000000181639E40 
	public DungeonChallengeConfig currChallenge { /* [XID] */ /* 0x0000000189B30B30-0x0000000189B30B50 */ get => default; } // 0x000000018163DFB0-0x000000018163E0F0 
	public uint currChallengeIndex { /* [XID] */ /* 0x0000000189B38210-0x0000000189B38230 */ get => default; } // 0x000000018163A000-0x000000018163A0E0 
	public uint currChallengeId { /* [XID] */ /* 0x0000000189B3FC60-0x0000000189B3FC80 */ get => default; } // 0x0000000181645400-0x0000000181645540 
	public uint currChallengeGroupId { /* [XID] */ /* 0x0000000189B47410-0x0000000189B47430 */ get => default; } // 0x0000000181638540-0x0000000181638680 
	public Dictionary<uint, List<uint>> challengeTargetParamsDic { /* [XID] */ /* 0x0000000189B5DD40-0x0000000189B5DD60 */ get => default; } // 0x00000001816416D0-0x0000000181641770 
	public Dictionary<uint, List<uint>> challengeProgressParamsDic { /* [XID] */ /* 0x0000000189B652C0-0x0000000189B652E0 */ get => default; } // 0x000000018163F450-0x000000018163F500 
	public uint challengeRemainSeconds { /* [XID] */ /* 0x0000000189B6C8E0-0x0000000189B6C900 */ get => default; } // 0x00000001816377B0-0x00000001816378A0 
	public bool challengeRemainSecondsChanged { /* [XID] */ /* 0x0000000189B73FC0-0x0000000189B73FE0 */ get => default; } // 0x0000000181639A90-0x0000000181639D80 

	// Nested types
	public abstract class PacketNotifyHandler<T> : SliceFrameJobHandlerOfTBase<T> // TypeDefIndex: 21540
		where T : MessageBase
	{
		// Constructors
		protected PacketNotifyHandler() {}

		// Methods
		public override void Dispose() {}
	}

	public class SceneEntityAppearNotifyHandler : PacketNotifyHandler<SceneEntityAppearNotify> // TypeDefIndex: 21541
	{
		// Fields
		private Dictionary<uint, int> _entityIDNotifyStateMap; // 0x20
		private Action _onRequstForceSyncHandlePacket; // 0x28

		// Constructors
		public SceneEntityAppearNotifyHandler() {} // 0x00000001816562E0-0x0000000181656350

		// Methods
		// [XID] // 0x0000000189681D90-0x0000000189681DB0
		public static PacketNotifyHandler<SceneEntityAppearNotify> Alloc(SceneEntityAppearNotify inNotify, Dictionary<uint, int> inEntityIDNotifyStateMap, Action inOnRequestForceSync) => default; // 0x0000000181655DD0-0x0000000181655EE0
		// [XID] // 0x0000000189689800-0x0000000189689820
		public override void Handle(int i) {} // 0x0000000181655A40-0x0000000181655D70
		// [XID] // 0x0000000189691560-0x0000000189691580
		public override void OnAccept(SceneEntityAppearNotify inNotify) {} // 0x0000000181655EE0-0x00000001816562E0
		// [XID] // 0x0000000189698C10-0x0000000189698C30
		public override void Dispose() {} // 0x0000000181655960-0x0000000181655A40
		// [XID] // 0x00000001896A00D0-0x00000001896A00F0
		protected override void Dealloc() {} // 0x00000001816558B0-0x0000000181655960
	}

	public class SceneEntityDisappearNotifyHandler : PacketNotifyHandler<SceneEntityDisappearNotify> // TypeDefIndex: 21542
	{
		// Fields
		private Dictionary<uint, int> _entityIDNotifyStateMap; // 0x20

		// Constructors
		public SceneEntityDisappearNotifyHandler() {} // 0x0000000181655840-0x00000001816558B0

		// Methods
		// [XID] // 0x00000001896A7400-0x00000001896A7420
		public static PacketNotifyHandler<SceneEntityDisappearNotify> Alloc(SceneEntityDisappearNotify inNotify, Dictionary<uint, int> inEntityIDNotifyStateMap) => default; // 0x00000001816555D0-0x00000001816556C0
		// [XID] // 0x00000001896AE920-0x00000001896AE940
		public override void Handle(int i) {} // 0x0000000181655270-0x00000001816555D0
		// [XID] // 0x00000001896B60E0-0x00000001896B6100
		public override void OnAccept(SceneEntityDisappearNotify inNotify) {} // 0x00000001816556C0-0x0000000181655840
		// [XID] // 0x00000001896BD360-0x00000001896BD380
		protected override void Dealloc() {} // 0x00000001816551C0-0x0000000181655270
	}

	public class LevelModulePacketSliceFrameHandlerManager : BaseModule.ModulePacketSliceFrameHandlerManager // TypeDefIndex: 21543
	{
		// Fields
		public const int EntityNotifyState_Appear = 0; // Metadata: 0x00AFF90D
		public const int EntityNotifyState_Disappear = 1; // Metadata: 0x00AFF911
		private Dictionary<uint, int> _entityIDNotifyStateMap; // 0x20
		private bool hasForceSyncHandleRequest; // 0x28

		// Properties
		public override bool shouldSyncHandle { /* [XID] */ /* 0x00000001896D3180-0x00000001896D31A0 */ get => default; } // 0x00000001816371E0-0x00000001816372C0 

		// Constructors
		public LevelModulePacketSliceFrameHandlerManager() {} // 0x0000000181637380-0x0000000181637750

		// Methods
		// [XID] // 0x00000001896DAD60-0x00000001896DAD80
		private void OnRequestForceSyncHandleFromPacket() {} // 0x0000000181636E70-0x0000000181636F10
		// [XID] // 0x00000001896E24C0-0x00000001896E24E0
		private void ClearForceSyncRequestFromPacket() {} // 0x0000000181636AD0-0x0000000181636B70
		// [XID] // 0x00000001896E9960-0x00000001896E9980
		public override void AmortizedHandlePacket() {} // 0x0000000181636D90-0x0000000181636E70
		// [XID] // 0x00000001896F0B60-0x00000001896F0B80
		public override void ClearAllJobs() {} // 0x00000001816372C0-0x0000000181637380
	}

	public class EntityStatInfo // TypeDefIndex: 21544
	{
		// Fields
		public int frameAppear; // 0x10
		public int frameCreated; // 0x14
		public int frameReady; // 0x18

		// Properties
		public int appearToCreatedFrame { /* [XID] */ /* 0x0000000189724FC0-0x0000000189724FE0 */ get => default; } // 0x0000000181656400-0x00000001816564B0 
		public int createdToReadyFrame { /* [XID] */ /* 0x000000018972C700-0x000000018972C720 */ get => default; } // 0x0000000181656350-0x0000000181656400 

		// Constructors
		public EntityStatInfo() {} // 0x00000001816564B0-0x0000000181656510
	}

	public struct ChallengeData // TypeDefIndex: 21545
	{
		// Fields
		public uint id; // 0x00
		public uint groupId; // 0x04
		public uint index; // 0x08
		public uint fatherIndex; // 0x0C
		public DungeonChallengeConfig config; // 0x10
		public string title; // 0x18
		public string subTitle; // 0x20
	}

	public struct EntityAppearWaitForOwner // TypeDefIndex: 21546
	{
		// Fields
		public uint ownerRuntimeID; // 0x00
		public SceneEntityInfo entity; // 0x08
		public VisionType type; // 0x10
		public uint infoParam; // 0x14
	}

	// Constructors
	public LevelModule() {} // 0x0000000181646A00-0x0000000181646BB0
	static LevelModule() {} // 0x0000000181646970-0x0000000181646A00

	// Methods
	// [XID] // 0x000000018993B1F0-0x000000018993B210
	public override bool OnPacket(Packet pkt) => default; // 0x00000001816391F0-0x0000000181639A90
	// [XID] // 0x0000000189942300-0x0000000189942320
	private void OnEntityTagChangeNotify(EntityTagChangeNotify notify) {} // 0x0000000181642190-0x0000000181642370
	// [XID] // 0x0000000189949C20-0x0000000189949C40
	private void OnAvatarFollowRouteNotify(AvatarFollowRouteNotify notify) {} // 0x0000000181637A60-0x0000000181637B80
	// [XID] // 0x00000001899517E0-0x0000000189951800
	private void OnGroupSuiteNotify(GroupSuiteNotify data) {} // 0x0000000181640360-0x0000000181640570
	// [XID] // 0x0000000189958D70-0x0000000189958D90
	private void OnGroupUnload(GroupUnloadNotify data) {} // 0x0000000181644F00-0x00000001816450D0
	// [XID] // 0x0000000189960420-0x0000000189960440
	private void OnSetEntityClientData(SetEntityClientDataNotify data) {} // 0x00000001816388C0-0x0000000181638A20
	// [XID] // 0x0000000189967E20-0x0000000189967E40
	private void OnPathfindingEnterSceneRsp(PathfindingEnterSceneRsp data) {} // 0x000000018163DDD0-0x000000018163DFB0
	// [XID] // 0x000000018996F0A0-0x000000018996F0C0
	public void OnEntityFightPropNotifyProxy(EntityFightPropNotify notify) {} // 0x000000018163AA90-0x000000018163ABB0
	// [XID] // 0x0000000189976BF0-0x0000000189976C10
	public void OnEntityFightPropNotify(MessageBase imessage) {} // 0x00000001816447B0-0x0000000181644AB0
	// [XID] // 0x000000018997E020-0x000000018997E040
	public void OnEntityFightPropUpdateNotifyProxy(EntityFightPropUpdateNotify notify) {} // 0x0000000181643DF0-0x0000000181643F10
	// [XID] // 0x0000000189BD88D0-0x0000000189BD88F0
	public void OnEntityFightPropUpdateNotify(MessageBase imessage) {} // 0x0000000181643430-0x00000001816437B0
	// [XID] // 0x000000018998D7A0-0x000000018998D7C0
	public void OnSceneCreaturePropNotifyProxy(EntityPropNotify notify) {} // 0x00000001816407E0-0x0000000181640900
	// [XID] // 0x00000001899951F0-0x0000000189995210
	public void OnSceneCreaturePropNotify(MessageBase imessage) {} // 0x0000000181638AD0-0x0000000181638E20
	// [XID] // 0x000000018999CCD0-0x000000018999CCF0
	public override bool OnNotify(Notify ntf) => default; // 0x0000000181645C40-0x0000000181645E80
	// [XID] // 0x00000001899ABF70-0x00000001899ABF90
	private void OnSceneEntityAppearNotify(Packet pkt) {} // 0x000000018163EB90-0x000000018163EEB0
	// [XID] // 0x00000001899B3800-0x00000001899B3820
	private void OnSceneEntityAppear(SceneEntityAppearNotify notify) {} // 0x000000018163DBC0-0x000000018163DDD0
	// [XID] // 0x00000001899BABE0-0x00000001899BAC00
	public static bool ShouldOnNeedForceSyncHandleAllPacket() => default; // 0x00000001816442F0-0x00000001816444A0
	// [XID] // 0x00000001899C25F0-0x00000001899C2610
	public void AmortizedHandleAppearDisappearPacket() {} // 0x0000000181642370-0x00000001816424A0
	// [XID] // 0x00000001899C9C80-0x00000001899C9CA0
	private void OnSceneEntityAppearAsync(SceneEntityAppearNotify notify) {} // 0x000000018163F500-0x000000018163FAE0
	// [XID] // 0x00000001899D1500-0x00000001899D1520
	public void EntityAppearInLevelBy2Param(MessageBase imessage, Tuple<int, VisionType, uint> tuple) {} // 0x000000018163B320-0x000000018163B460
	// [XID] // 0x00000001899D8A10-0x00000001899D8A30
	private static uint GetConfigID(SceneEntityInfo entity) => default; // 0x000000018163D000-0x000000018163D160
	// [XID] // 0x00000001899E0120-0x00000001899E0140
	public static EntityStatInfo GetEntiyStateInfo(uint entityRuntimeID) => default; // 0x000000018163D800-0x000000018163D990
	// [XID] // 0x00000001899E7C40-0x00000001899E7C60
	private static void OnEntityReceiveAppearPacket(uint runtimeID) {} // 0x00000001816445B0-0x0000000181644690
	// [XID] // 0x00000001899EEFB0-0x00000001899EEFD0
	public static void OnEntityCreated(uint runtimeID, uint configID) {} // 0x0000000181640570-0x00000001816406C0
	// [XID] // 0x00000001899F69F0-0x00000001899F6A10
	public static void OnEntityReady(uint runtimeID, uint configID) {} // 0x0000000181642700-0x0000000181642850
	// [XID] // 0x00000001899FDFB0-0x00000001899FDFD0
	public static void FlushEntityStateInfo() {} // 0x000000018163D640-0x000000018163D720
	// [XID] // 0x0000000189A058B0-0x0000000189A058D0
	public static void EntityAppearInLevel(SceneEntityInfo entity, VisionType type, uint infoParam) {} // 0x0000000181643F10-0x00000001816442F0
	// [XID] // 0x0000000189A0CBA0-0x0000000189A0CBC0
	private void OnSceneEntityDisappearNotify(Packet pkt) {} // 0x0000000181638680-0x00000001816388C0
	// [XID] // 0x0000000189A144A0-0x0000000189A144C0
	private void OnSceneEntityDisappearAsync(SceneEntityDisappearNotify notify) {} // 0x0000000181641820-0x0000000181641D50
	// [XID] // 0x0000000189A1B6F0-0x0000000189A1B710
	public void OnSceneEntityDisappearBy2Param(MessageBase notify, Tuple<uint, VisionType> tuple) {} // 0x00000001816444A0-0x00000001816445B0
	// [XID] // 0x0000000189A23160-0x0000000189A23180
	private void OnSceneEntityDisappear(SceneEntityDisappearNotify notify) {} // 0x000000018163B620-0x000000018163B7F0
	// [XID] // 0x0000000189A2A320-0x0000000189A2A340
	public static void EntityDisappearInLevel(uint entityId, VisionType type) {} // 0x00000001816437B0-0x0000000181643D50
	// [XID] // 0x0000000189A31790-0x0000000189A317B0
	private void OnEntityFightPropChangeReasonNotify(EntityFightPropChangeReasonNotify notify) {} // 0x0000000181643010-0x0000000181643430
	// [XID] // 0x0000000189A392B0-0x0000000189A392D0
	private void OnLifeStateChangeNotifyProxy(LifeStateChangeNotify notify, uint clientSequenceId) {} // 0x000000018163AD00-0x000000018163AE40
	// [XID] // 0x0000000189A40A90-0x0000000189A40AB0
	private void OnLifeStateChangeNotify(MessageBase imessage, uint clientSequenceId) {} // 0x000000018163EF00-0x000000018163F450
	// [XID] // 0x0000000189A48110-0x0000000189A48130
	private void DoOnLifeStateDead(uint targetID, uint killerID, string attackTag, DieStateFlag dieType) {} // 0x0000000181645AD0-0x0000000181645C40
	// [XID] // 0x0000000189A4F9A0-0x0000000189A4F9C0
	private void OnAvatarLifeStateChangeNotify(AvatarLifeStateChangeNotify notify, uint clientSequenceId) {} // 0x0000000181644AB0-0x0000000181644CE0
	// [XID] // 0x0000000189A56FB0-0x0000000189A56FD0
	private void OnSceneEntityMoveNotify(SceneEntityMoveNotify notify, bool isReliable, uint clientSequenceId) {} // 0x000000018163E8A0-0x000000018163E970
	// [XID] // 0x0000000189A5EB90-0x0000000189A5EBB0
	private void OnSceneEntitiesMoveCombineNotify(SceneEntitiesMoveCombineNotify notify, bool isReliable, uint clientSequenceId) {} // 0x000000018163E1A0-0x000000018163E8A0
	// [XID] // 0x0000000189A66290-0x0000000189A662B0
	private void OnForceDragAvatarNotify(ForceDragAvatarNotify notify) {} // 0x0000000181640900-0x0000000181640FE0
	// [XID] // 0x0000000189A6DA00-0x0000000189A6DA20
	public void ClearForceDragCount() {} // 0x0000000181645360-0x0000000181645400
	// [XID] // 0x0000000189A75150-0x0000000189A75170
	private void OnSceneEntityMoveRsp(SceneEntityMoveRsp rsp) {} // 0x0000000181646100-0x00000001816461B0
	// [XID] // 0x0000000189A7CDB0-0x0000000189A7CDD0
	private void OnSceneEntitiesMovesRsp(SceneEntitiesMovesRsp rsp) {} // 0x000000018163A9E0-0x000000018163AA90
	// [XID] // 0x0000000189A84640-0x0000000189A84660
	public void OnShowMessageNotify(ShowMessageNotify notify) {} // 0x0000000181641D50-0x0000000181642060
	// [XID] // 0x0000000189A8BFA0-0x0000000189A8BFC0
	private void OnMarkEntityInMiniMapNotify(MarkEntityInMinMapNotify ntf) {} // 0x000000018163D990-0x000000018163DA80
	// [XID] // 0x0000000189A93490-0x0000000189A934B0
	private void OnUnmarkEntityInMiniMapNotify(UnmarkEntityInMinMapNotify ntf) {} // 0x000000018163B950-0x000000018163BA40
	// [XID] // 0x0000000189A9AF80-0x0000000189A9AFA0
	private void OnSeeMonsterRsp(SeeMonsterRsp rsp) {} // 0x000000018163D4E0-0x000000018163D640
	// [XID] // 0x0000000189AA2310-0x0000000189AA2330
	private void OnAddSeenMonsterNotify(AddSeenMonsterNotify notify) {} // 0x0000000181638A20-0x0000000181638AD0
	// [XID] // 0x0000000189AA9840-0x0000000189AA9860
	private void OnAllSeenMonsterNotify(AllSeenMonsterNotify notify) {} // 0x00000001816459E0-0x0000000181645AD0
	// [XID] // 0x0000000189AB89C0-0x0000000189AB89E0
	private void OnDungeonChallengeBeginNotify(DungeonChallengeBeginNotify ntf) {} // 0x000000018163BD50-0x000000018163C4E0
	// [XID] // 0x0000000189AC05B0-0x0000000189AC05D0
	private void OnDungeonChallengeDataNotify(ChallengeDataNotify ntf) {} // 0x000000018163A470-0x000000018163A9E0
	// [XID] // 0x0000000189AC7F90-0x0000000189AC7FB0
	private void OnDungeonChallengeFinishNotify(DungeonChallengeFinishNotify ntf) {} // 0x0000000181641410-0x00000001816416D0
	// [XID] // 0x0000000189ACF610-0x0000000189ACF630
	private void OnDungeonChallengeBeginCheck(ChallengeData challengeData) {} // 0x000000018163FAE0-0x000000018163FCA0
	// [XID] // 0x0000000189AD73E0-0x0000000189AD7400
	private void OnDungeonChallengeFinishCheck() {} // 0x000000018163ABB0-0x000000018163AD00
	// [XID] // 0x0000000189ADEED0-0x0000000189ADEEF0
	private void ClearChallengeData() {} // 0x0000000181642EF0-0x0000000181642FB0
	// [XID] // 0x0000000189AE67A0-0x0000000189AE67C0
	private void OnCutSceneBeginNotify(CutSceneBeginNotify ntf) {} // 0x000000018163D160-0x000000018163D4E0
	// [XID] // 0x0000000189AEE0C0-0x0000000189AEE0E0
	private void OnCutSceneEndNotify(CutSceneEndNotify ntf) {} // 0x0000000181644CE0-0x0000000181644F00
	// [XID] // 0x0000000189AF5810-0x0000000189AF5830
	private void OnDungeonInterruptChallengeRsp(DungeonInterruptChallengeRsp ntf) {} // 0x0000000181642850-0x0000000181642B20
	// [XID] // 0x0000000189B1AA00-0x0000000189B1AA20
	private void UpdateChallengeCountDown(List<uint> progressParams, uint paramIndex, uint timeLimit, bool canShowTopTimer = true /* Metadata: 0x00AFF90B */) {} // 0x00000001816461B0-0x00000001816462E0
	// [XID] // 0x0000000189B4EC90-0x0000000189B4ECB0
	public void GetChallengeTitle(uint challengeIndex, ref string title, ref string subTitle) {} // 0x000000018163AF80-0x000000018163B100
	// [XID] // 0x0000000189B565C0-0x0000000189B565E0
	public DungeonChallengeConfig GetChallengeConfig(uint challengeIndex) => default; // 0x0000000181642DF0-0x0000000181642EF0
	// [XID] // 0x0000000189B7B5D0-0x0000000189B7B5F0
	private ChallengeRecord GetChallengeRecordByIndex(uint challengeIndex) => default; // 0x00000001816424A0-0x00000001816426A0
	// [XID] // 0x0000000189B82FA0-0x0000000189B82FC0
	public string GetChallengeRecordValueByIndex(uint challengeIndex) => default; // 0x000000018163BBB0-0x000000018163BD50
	// [XID] // 0x0000000189B8A550-0x0000000189B8A570
	public uint GetChallengeBestValue(uint challengeIndex) => default; // 0x0000000181642BD0-0x0000000181642CA0
	// [XID] // 0x0000000189B91B20-0x0000000189B91B40
	public uint GetChallengeCurrValue(uint challengeIndex) => default; // 0x000000018163D720-0x000000018163D800
	// [XID] // 0x0000000189B98FC0-0x0000000189B98FE0
	public string GetChallengeRecordCurrValueString(uint challengeIndex) => default; // 0x00000001816401D0-0x0000000181640360
	// [XID] // 0x0000000189BA0330-0x0000000189BA0350
	public override void ClearOnLevelDestroy() {} // 0x0000000181639E40-0x0000000181639F50
	// [XID] // 0x0000000189BA7B70-0x0000000189BA7B90
	public override void ClearOnDisconnect() {} // 0x0000000181645770-0x00000001816458F0
	// [XID] // 0x0000000189BAEF80-0x0000000189BAEFA0
	public override void ClearOnBackHome() {} // 0x000000018163DA80-0x000000018163DB40
	// [XID] // 0x0000000189BB6630-0x0000000189BB6650
	private void OnWorldDataNotify(WorldDataNotify ntf) {} // 0x0000000181638EA0-0x00000001816391F0
	// [XID] // 0x0000000189BBDCA0-0x0000000189BBDCC0
	private void OnChallengeRecordNotify(ChallengeRecordNotify ntf) {} // 0x0000000181642B20-0x0000000181642BD0
	// [XID] // 0x0000000189BC5980-0x0000000189BC59A0
	private void OnSceneDataNotify(SceneDataNotify ntf) {} // 0x00000001816450D0-0x0000000181645360
	// [XID] // 0x0000000189BCD420-0x0000000189BCD440
	private void RequestEntityInRegion(uint regionId, List<BaseEntity> entities) {} // 0x00000001816411E0-0x0000000181641410
	// [XID] // 0x0000000189BD4930-0x0000000189BD4950
	public void ChangeHP(uint targetEntityId, uint sourceEntityId, float addHP, float HP, float maxHP, bool forceLocal = false /* Metadata: 0x00AFF90C */) {} // 0x00000001816462E0-0x00000001816467F0
	// [XID] // 0x0000000189BDC420-0x0000000189BDC440
	public void AvatarDie(uint runtimeID) {} // 0x000000018163FCA0-0x00000001816401D0
	// [XID] // 0x00000001897A0B70-0x00000001897A0B90
	public void Drown(uint targetEntityId) {} // 0x00000001816378A0-0x0000000181637A60
	// [XID] // 0x00000001895F0520-0x00000001895F0540
	public void ChangeTeam(uint teamId, List<ulong> lst, ulong curGuid) {} // 0x0000000181637D10-0x0000000181638540
	// [XID] // 0x00000001895F7FF0-0x00000001895F8010
	public void AddAvatarId(uint avatarId) {} // 0x000000018163C5D0-0x000000018163D000
	// [XID] // 0x00000001895FF350-0x00000001895FF370
	public void ClearAppearAllWaitForOwnerInfos() {} // 0x000000018163BAF0-0x000000018163BBB0
	// [XID] // 0x0000000189606C00-0x0000000189606C20
	public bool AppearWaitForOwnerExist() => default; // 0x0000000181641120-0x00000001816411E0
	// [XID] // 0x000000018960E500-0x000000018960E520
	public void AddWaitForAppearInfo(uint ownerRuntimeID, SceneEntityInfo entity, VisionType type, uint infoParam) {} // 0x000000018163AE40-0x000000018163AF80
	// [XID] // 0x0000000189615BC0-0x0000000189615BE0
	public void ForceAppearAllWaitForOwnerInfos() {} // 0x0000000181637B80-0x0000000181637D10
	// [XID] // 0x000000018961D410-0x000000018961D430
	public void OwnerIsAppeared(BaseEntity entity) {} // 0x000000018163E9D0-0x000000018163EB90
	// [XID] // 0x00000001896248D0-0x00000001896248F0
	public void NotifyEnityMoveRoom(uint entityId, uint roomId) {} // 0x000000018163B460-0x000000018163B580
	// [XID] // 0x000000018962C030-0x000000018962C050
	private void CloseCommonTips() {} // 0x000000018163C4E0-0x000000018163C5D0
	// [XID] // 0x0000000189633BD0-0x0000000189633BF0
	private void OnCloseCommonTipsNotify(CloseCommonTipsNotify closeCommonTipsNotify) {} // 0x0000000181641770-0x0000000181641820
	// [XID] // 0x000000018963B450-0x000000018963B470
	private void OnShowCommonTipsNotify(ShowCommonTipsNotify showCommonTipsNotify) {} // 0x000000018163B100-0x000000018163B320
	// [XID] // 0x0000000189642C00-0x0000000189642C20
	private void OnPlayerEyePointStateNotify(PlayerEyePointStateNotify notify) {} // 0x0000000181645E80-0x0000000181646100
	// [XID] // 0x000000018964A230-0x000000018964A250
	public void NotifyAdjustWorldLevel(uint curLv, uint nextLv) {} // 0x0000000181644690-0x00000001816447B0
	// [XID] // 0x00000001896519A0-0x00000001896519C0
	public void OnAdjustWorldLevelRsp(AdjustWorldLevelRsp rsp) {} // 0x00000001816467F0-0x0000000181646970
	// [XID] // 0x0000000189659230-0x0000000189659250
	protected override void RegisterModulesPkt(NotifyManager notifyMgr) {} // 0x000000018163A0E0-0x000000018163A470
	// [XID] // 0x00000001896608B0-0x00000001896608D0
	protected override void RegsiterModuleNotify(NotifyManager notifyMgr) {} // 0x0000000181645690-0x0000000181645770
	// [XID] // 0x00000001896682C0-0x00000001896682E0
	public void OnSceneEntityAppearAsyncDebug(SceneEntityAppearNotify notify) {} // 0x000000018163B8A0-0x000000018163B950
	// [XID] // 0x000000018966FD90-0x000000018966FDB0
	public void OnSceneEntityDisappearAsyncDebug(SceneEntityDisappearNotify notify) {} // 0x000000018163BA40-0x000000018163BAF0
}

