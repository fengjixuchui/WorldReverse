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

public sealed class GalleryModule : BaseModule // TypeDefIndex: 21504
{
	// Fields
	private bool _isGalleryPlaying; // 0x10
	private uint _curGalleryID; // 0x14
	private uint TrackingGalleryMarkID; // 0x18
	private char[] _audioSplits; // 0x20
	private FleurFairFallSettleNotify _cachedFallSettleNotify; // 0x28
	private bool _cachedFallSettle; // 0x30
	private GalleryBalloonInfo _balloonInfo; // 0x38
	private GalleryFallInfo _fallInfo; // 0x40
	public MusicSettleInfo musicSettleInfo; // 0x48
	public FleurFairDungeonGalleryInfo dungeonGalleryInfo; // 0x50
	public HideAndSeekInfo hideAndSeekInfo; // 0x68

	// Properties
	public bool IsInGalleryPlaying { /* [XID] */ /* 0x000000018995BBE0-0x000000018995BC00 */ get => default; /* [XID] */ /* 0x0000000189963760-0x0000000189963780 */ set {} } // 0x00000001833252E0-0x0000000183325380 0x0000000183329D60-0x0000000183329E20
	public uint CurGalleryID { /* [XID] */ /* 0x000000018996AB60-0x000000018996AB80 */ get => default; } // 0x00000001833266C0-0x0000000183326760 

	// Nested types
	public class GalleryBalloonInfo // TypeDefIndex: 21505
	{
		// Fields
		public uint galleryID; // 0x10
		public uint curScore; // 0x14
		public uint combo; // 0x18
		public ulong comboDisableTime; // 0x20
		public uint endTime; // 0x28
		public Dictionary<uint, uint> uidScoreDict; // 0x30

		// Constructors
		public GalleryBalloonInfo() {} // 0x0000000183337D50-0x0000000183337DB0
	}

	public class GalleryFallInfo // TypeDefIndex: 21506
	{
		// Fields
		public uint galleryID; // 0x10
		public uint curScore; // 0x14
		public uint endTime; // 0x18
		public Dictionary<uint, uint> ballCatchCountDict; // 0x20
		public Dictionary<uint, FallPlayerBrief> uidBriefDict; // 0x28

		// Constructors
		public GalleryFallInfo() {} // 0x0000000183317EB0-0x0000000183317F10
	}

	public class MusicSettleInfo // TypeDefIndex: 21507
	{
		// Fields
		public uint musicBasicID; // 0x10
		public uint score; // 0x14
		public uint combo; // 0x18
		public uint correctHit; // 0x1C
		public bool isUnlockNextLevel; // 0x20
		public bool isNewRecord; // 0x21

		// Constructors
		public MusicSettleInfo() {} // 0x0000000183317F10-0x0000000183317F70
	}

	public struct FleurFairDungeonGalleryInfo // TypeDefIndex: 21508
	{
		// Fields
		public uint galleryID; // 0x00
		public uint energy; // 0x04
		public uint endTime; // 0x08
		public uint progress; // 0x0C
		public uint maxProgress; // 0x10
	}

	public struct HideAndSeekInfo // TypeDefIndex: 21509
	{
		// Fields
		public List<uint> caughtUidList; // 0x00
	}

	// Constructors
	public GalleryModule() {} // 0x0000000183329E20-0x0000000183329F40

	// Methods
	// [XID] // 0x00000001899727D0-0x00000001899727F0
	public override void ClearOnDisconnect() {} // 0x0000000183329B40-0x0000000183329BE0
	// [XID] // 0x0000000189979F90-0x0000000189979FB0
	public override void ClearOnLevelDestroy() {} // 0x0000000183323A80-0x0000000183323B20
	// [XID] // 0x0000000189981720-0x0000000189981740
	public override void ClearOnBackHome() {} // 0x00000001833257A0-0x0000000183325880
	// [XID] // 0x0000000189988FD0-0x0000000189988FF0
	public override bool OnPacket(Packet packet) => default; // 0x0000000183323180-0x0000000183323630
	// [XID] // 0x00000001899907F0-0x0000000189990810
	private void SetLimitRegion() {} // 0x0000000183324250-0x0000000183324590
	// [XID] // 0x0000000189998310-0x0000000189998330
	private void AddRegionMark() {} // 0x0000000183322380-0x00000001833226D0
	// [XID] // 0x000000018999FA70-0x000000018999FA90
	private void RemoveRegionMark() {} // 0x0000000183324590-0x00000001833246C0
	// [XID] // 0x00000001899A7780-0x00000001899A77A0
	private void OnStartAudio() {} // 0x00000001833286F0-0x00000001833287C0
	// [XID] // 0x00000001899AEF90-0x00000001899AEFB0
	private void OnEndAudio() {} // 0x0000000183326210-0x00000001833262E0
	// [IDTag] // 0x00000001899B6310-0x00000001899B6350
	// [XID] // 0x00000001899B6310-0x00000001899B6350
	private void SetAudioState(string audioValues) {} // 0x00000001833290F0-0x0000000183329200
	// [IDTag] // 0x00000001899C0D90-0x00000001899C0DD0
	// [XID] // 0x00000001899C0D90-0x00000001899C0DD0
	private void SetAudioState(int pairCount, string[] strParams) {} // 0x0000000183329200-0x00000001833293E0
	// [XID] // 0x00000001899CB730-0x00000001899CB750
	private int CheckAudioParams(string str, out string[] strParams) {
		strParams = default;
		return default;
	} // 0x0000000183328590-0x00000001833286F0
	// [XID] // 0x00000001899D2B30-0x00000001899D2B50
	public override bool OnNotify(Notify ntf) => default; // 0x0000000183329C70-0x0000000183329D60
	// [XID] // 0x00000001899DA180-0x00000001899DA1A0
	public void OnGalleryPreStartNotify(GalleryPreStartNotify preStartNotify) {} // 0x00000001833287C0-0x00000001833288E0
	// [XID] // 0x00000001899E1C70-0x00000001899E1C90
	private void PreStartNotify(uint preStartEndTime, Action callback = null) {} // 0x0000000183328370-0x0000000183328590
	// [XID] // 0x00000001899E9030-0x00000001899E9050
	public void OnGalleryStartNotify(GalleryStartNotify notify) {} // 0x00000001833262E0-0x00000001833264E0
	// [XID] // 0x00000001899F0950-0x00000001899F0970
	private void OnGalleryStart(uint galleryId, uint endTime, bool clearCacheData, GalleryStartNotify notify = null) {} // 0x0000000183328980-0x0000000183328D10
	// [XID] // 0x00000001899F8030-0x00000001899F8050
	public void OnGalleryStopNotify(GalleryStopNotify notify) {} // 0x0000000183325550-0x00000001833257A0
	// [XID] // 0x00000001899FF6C0-0x00000001899FF6E0
	private void RequestSceneGalleryInfo() {} // 0x0000000183323B20-0x0000000183323C00
	// [XID] // 0x0000000189A06EE0-0x0000000189A06F00
	private void OnGetAllSceneGalleryInfoRsp(GetAllSceneGalleryInfoRsp rsp) {} // 0x0000000183325A10-0x0000000183325F80
	// [XID] // 0x0000000189A0E5F0-0x0000000189A0E610
	private void OnSceneGalleryInfoNotify(SceneGalleryInfoNotify ntf) {} // 0x0000000183329910-0x0000000183329A70
	// [XID] // 0x0000000189A15C00-0x0000000189A15C20
	private void OnFleurFairReplayMiniGameRsp(FleurFairReplayMiniGameRsp rsp) {} // 0x0000000183323F00-0x0000000183324060
	// [XID] // 0x0000000189A1D030-0x0000000189A1D050
	public void RequestInterrupt() {} // 0x0000000183325880-0x0000000183325990
	// [XID] // 0x0000000189A24670-0x0000000189A24690
	private void OnGalleryInterruptRsp(InterruptGalleryRsp rsp) {} // 0x0000000183325180-0x00000001833252E0
	// [XID] // 0x0000000189A2BB10-0x0000000189A2BB30
	private void OnFleurFairBalloonSettleNotify(FleurFairBalloonSettleNotify notify) {} // 0x00000001833280F0-0x0000000183328310
	// [XID] // 0x0000000189A330D0-0x0000000189A330F0
	private void OnFleurFairFallSettleNotify(FleurFairFallSettleNotify notify) {} // 0x0000000183324D50-0x0000000183324EF0
	// [XID] // 0x0000000189A3A9C0-0x0000000189A3A9E0
	private void RealFleurFairFallSettleNotify(FleurFairFallSettleNotify notify) {} // 0x0000000183323630-0x0000000183323850
	// [XID] // 0x0000000189A422F0-0x0000000189A42310
	private void CheckCacheFallSettle() {} // 0x0000000183326D40-0x0000000183326E00
	// [XID] // 0x0000000189A49900-0x0000000189A49920
	public GalleryBalloonInfo GetCurrentBallonInfo() => default; // 0x0000000183325F80-0x0000000183326020
	// [XID] // 0x0000000189A51250-0x0000000189A51270
	private void ClearBalloonCacheData(uint galleryID, uint endTime) {} // 0x0000000183327F40-0x00000001833280F0
	// [XID] // 0x0000000189A588A0-0x0000000189A588C0
	private void OnGalleryBalloonShootNotify(GalleryBalloonShootNotify notify) {} // 0x00000001833264E0-0x00000001833266C0
	// [XID] // 0x0000000189A60380-0x0000000189A603A0
	private void OnGalleryBalloonScoreNotify(GalleryBalloonScoreNotify notify) {} // 0x0000000183327C70-0x0000000183327F40
	// [XID] // 0x0000000189A67F10-0x0000000189A67F30
	private void OnGalleryBalloonRecover(uint galleryId, SceneGalleryBalloonInfo info) {} // 0x0000000183326950-0x0000000183326D40
	// [XID] // 0x0000000189A6F2C0-0x0000000189A6F2E0
	public GalleryFallInfo GetCurrentFallInfo() => default; // 0x00000001833288E0-0x0000000183328980
	// [XID] // 0x0000000189A76B20-0x0000000189A76B40
	private void ClearFallCacheData(uint galleryID, uint endTime) {} // 0x00000001833293E0-0x00000001833295B0
	// [XID] // 0x0000000189A7E480-0x0000000189A7E4A0
	public void OnGalleryFallRecover(uint galleryID, SceneGalleryFallInfo sceneFallInfo) {} // 0x00000001833228C0-0x0000000183322E50
	// [XID] // 0x0000000189A85DB0-0x0000000189A85DD0
	private void DeAllocatePlayerBrief() {} // 0x0000000183323850-0x0000000183323A80
	// [XID] // 0x0000000189A8D670-0x0000000189A8D690
	public void OnGalleryFallCatchNotify(GalleryFallCatchNotify notify) {} // 0x0000000183328D10-0x0000000183329030
	// [XID] // 0x0000000189A94C30-0x0000000189A94C50
	public void OnGalleryFallScoreNotify(GalleryFallScoreNotify notify) {} // 0x0000000183327020-0x00000001833274D0
	// [XID] // 0x0000000189A9C4B0-0x0000000189A9C4D0
	public void FleurFairMusicGameSettleReq(uint musicBasicID, uint score, uint combo = 0 /* Metadata: 0x00AFF8B4 */, uint correctHit = 0 /* Metadata: 0x00AFF8B8 */) {} // 0x0000000183326E00-0x0000000183327020
	// [XID] // 0x0000000189AA3C00-0x0000000189AA3C20
	private void OnFleurFairMusicGameSettleRsp(FleurFairMusicGameSettleRsp rsp) {} // 0x0000000183322ED0-0x0000000183323180
	// [XID] // 0x0000000189AAB1D0-0x0000000189AAB1F0
	public MusicSettleInfo GetSettleInfo(uint musicBasicID) => default; // 0x0000000183329030-0x00000001833290F0
	// [XID] // 0x0000000189AB2BC0-0x0000000189AB2BE0
	public void FleurFairMusicGameStartReq(uint musicBasicID) {} // 0x0000000183326760-0x0000000183326860
	// [XID] // 0x0000000189ABA700-0x0000000189ABA720
	private void OnFleurFairMusicGameStartRsp(FleurFairMusicGameStartRsp rsp) {} // 0x0000000183324EF0-0x0000000183325180
	// [XID] // 0x0000000189AC2010-0x0000000189AC2030
	private void OnGalleryFleurFairDungeonStart(uint galleryID, uint endTime, GalleryStartNotify notify) {} // 0x0000000183325380-0x0000000183325550
	// [XID] // 0x0000000189AC9660-0x0000000189AC9680
	private void OnGalleryFleurFairDungeonRecover(SceneGalleryInfo galleryInfo) {} // 0x00000001833295B0-0x0000000183329910
	// [XID] // 0x0000000189AD0FF0-0x0000000189AD1010
	private void OnGalleryBrokenFloorFallNotify(GalleryBrokenFloorFallNotify ntf) {} // 0x0000000183327550-0x0000000183327740
	// [XID] // 0x0000000189AD8DD0-0x0000000189AD8DF0
	private void OnGalleryBulletHitNotify(GalleryBulletHitNotify ntf) {} // 0x0000000183324060-0x0000000183324250
	// [XID] // 0x0000000189AE08A0-0x0000000189AE08C0
	private void OnGalleryFlowerCatchNotify(GalleryFlowerCatchNotify ntf) {} // 0x00000001833226D0-0x00000001833228C0
	// [XID] // 0x0000000189AE7D90-0x0000000189AE7DB0
	private void OnFleurFairBuffEnergyNotify(FleurFairBuffEnergyNotify ntf) {} // 0x0000000183326020-0x0000000183326210
	// [XID] // 0x0000000189AEFAC0-0x0000000189AEFAE0
	private void OnFleurFairFinishGalleryStageNotify(FleurFairFinishGalleryStageNotify ntf) {} // 0x0000000183326860-0x0000000183326950
	// [XID] // 0x0000000189AF6FA0-0x0000000189AF6FC0
	private void OnFleurFairStageSettleNotify(FleurFairStageSettleNotify ntf) {} // 0x00000001833246C0-0x0000000183324CB0
	// [XID] // 0x0000000189AFE5B0-0x0000000189AFE5D0
	private void OnGalleryHideAndSeekStart() {} // 0x0000000183324CB0-0x0000000183324D50
	// [XID] // 0x0000000189B05E20-0x0000000189B05E40
	private void OnGalleryHideAndSeekRecover(SceneGalleryHideAndSeekInfo info) {} // 0x0000000183323E50-0x0000000183323F00
	// [XID] // 0x0000000189B0D5B0-0x0000000189B0D5D0
	private void OnSceneGalleryHideAndSeekInfoNotify(SceneGalleryHideAndSeekInfo info) {} // 0x0000000183327740-0x0000000183327C70
	// [XID] // 0x0000000189B149F0-0x0000000189B14A10
	protected override void RegisterModulesPkt(NotifyManager notifyMgr) {} // 0x0000000183323C00-0x0000000183323E50
	// [XID] // 0x0000000189B1C3F0-0x0000000189B1C410
	protected override void RegsiterModuleNotify(NotifyManager notifyMgr) {} // 0x0000000183329A70-0x0000000183329B40
}

