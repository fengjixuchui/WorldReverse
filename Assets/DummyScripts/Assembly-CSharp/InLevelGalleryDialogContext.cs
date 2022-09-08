/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class InLevelGalleryDialogContext : BaseDialogContext // TypeDefIndex: 29555
{
	// Fields
	private MonoPrefabPlugin _prefabPlugin; // 0x178
	private MonoInLevelGalleryDialog _dialogMono; // 0x180
	private bool _excludeQuestHintDialog; // 0x18C
	private bool _toHideQuestHintDialog; // 0x18D
	private bool _resumeQuestHintDialog; // 0x18E
	private bool _checkQuestHintDialogOnEnable; // 0x18F
	private bool _bInWaitOther; // 0x190
	private bool _bCanInterrupt; // 0x191
	private const string DUNGEON_COUNT_DOWN = "DungeonCountDown"; // Metadata: 0x00B0F89D
	private const string BALLOON_COMBO = "BalloonCombo"; // Metadata: 0x00B0F8B1
	private const string GALLERY_TOP_HINT = "TopHint_Gallery"; // Metadata: 0x00B0F8C1
	private const string GALLERY_SIDE = "LevelChallenge_Gallery"; // Metadata: 0x00B0F8D4
	private const string BANNER = "Challenge"; // Metadata: 0x00B0F8EE
	private BannerData _challengeData; // 0x1B8
	private MonoDungeonChallenge _challengeIns; // 0x1D0

	// Properties
	public uint GalleryID { /* [XID] */ /* 0x000000018981CDB0-0x000000018981CDF0 */ get; /* [XID] */ /* 0x0000000189827540-0x0000000189827580 */ private set; } // 0x0000000181B03CA0-0x0000000181B03D00 0x0000000181B082F0-0x0000000181B08360
	public MonoDungeonCountDown dungeonCountDown { /* [XID] */ /* 0x00000001898318C0-0x0000000189831900 */ get; /* [XID] */ /* 0x000000018983C010-0x000000018983C050 */ private set; } // 0x0000000181B03C40-0x0000000181B03CA0 0x0000000181B03D00-0x0000000181B03D70
	public MonoInLevelGalleryTopHint galleryTopHint { /* [XID] */ /* 0x0000000189846570-0x00000001898465B0 */ get; /* [XID] */ /* 0x0000000189850970-0x00000001898509B0 */ private set; } // 0x0000000181B06290-0x0000000181B062F0 0x0000000181B061C0-0x0000000181B06230
	public MonoInLevelGalleySide gallerySide { /* [XID] */ /* 0x000000018985AEA0-0x000000018985AEE0 */ get; /* [XID] */ /* 0x00000001898651B0-0x00000001898651F0 */ private set; } // 0x0000000181B07070-0x0000000181B070D0 0x0000000181B070D0-0x0000000181B07140
	public MonoInLevelSimpleCombo balloonCombo { /* [XID] */ /* 0x000000018986F610-0x000000018986F650 */ get; /* [XID] */ /* 0x000000018987A0B0-0x000000018987A0F0 */ private set; } // 0x0000000181B069C0-0x0000000181B06A20 0x0000000181B063E0-0x0000000181B06450
	public FleurFairMiniGameType curMiniGameType { /* [XID] */ /* 0x000000018990AB80-0x000000018990ABA0 */ get => default; } // 0x0000000181B03FE0-0x0000000181B040E0 

	// Nested types
	private enum BannerStateType // TypeDefIndex: 29556
	{
		InActive = 0,
		Show = 1
	}

	private struct BannerData // TypeDefIndex: 29557
	{
		// Fields
		public bool valid; // 0x00
		public BannerStateType state; // 0x04
		public string title; // 0x08
		public string subTitle; // 0x10
	}

	// Constructors
	public InLevelGalleryDialogContext() {} // 0x0000000181B095B0-0x0000000181B096F0

	// Methods
	// [XID] // 0x0000000189883E30-0x0000000189883E50
	public override void SetupView() {} // 0x0000000181B093C0-0x0000000181B094D0
	// [XID] // 0x000000018988B4D0-0x000000018988B4F0
	protected override void BindViewCallbacks() {} // 0x0000000181B043B0-0x0000000181B04450
	// [XID] // 0x0000000189892C90-0x0000000189892CB0
	public override void ClearView() {} // 0x0000000181B04CC0-0x0000000181B04D60
	// [XID] // 0x000000018989A2F0-0x000000018989A310
	protected override void OnEnable() {} // 0x0000000181B08CC0-0x0000000181B08E20
	// [XID] // 0x00000001898A1550-0x00000001898A1570
	protected override void OnDisable() {} // 0x0000000181B08C20-0x0000000181B08CC0
	// [XID] // 0x00000001898A8DA0-0x00000001898A8DC0
	public override bool OnNotify(Notify ntf) => default; // 0x0000000181B08ED0-0x0000000181B091E0
	// [XID] // 0x00000001898B0740-0x00000001898B0760
	private void CreateDungeonCountDown() {} // 0x0000000181B05E90-0x0000000181B06030
	// [XID] // 0x00000001898B7D50-0x00000001898B7D70
	private void ClearDungeonCountDown() {} // 0x0000000181B040E0-0x0000000181B041E0
	// [XID] // 0x00000001898BF3C0-0x00000001898BF3E0
	private void CreateBalloonCombo() {} // 0x0000000181B04E70-0x0000000181B050A0
	// [XID] // 0x00000001898C6CE0-0x00000001898C6D00
	private void ClearBalloonCombo() {} // 0x0000000181B05D90-0x0000000181B05E90
	// [XID] // 0x00000001898CE2E0-0x00000001898CE300
	private void CreateGalleryTopHint() {} // 0x0000000181B03E40-0x0000000181B03FE0
	// [XID] // 0x00000001898D5CF0-0x00000001898D5D10
	private void ClearGalleryTopHint() {} // 0x0000000181B072C0-0x0000000181B073C0
	// [XID] // 0x00000001898DD9A0-0x00000001898DD9C0
	private void CreateGallerySide() {} // 0x0000000181B06A20-0x0000000181B06BC0
	// [XID] // 0x00000001898E52F0-0x00000001898E5310
	private void ClearGallerySide() {} // 0x0000000181B056B0-0x0000000181B057B0
	// [XID] // 0x00000001898ECA60-0x00000001898ECA80
	private void OnGalleryBannerStart(string title, string subTitle) {} // 0x0000000181B04450-0x0000000181B04690
	// [XID] // 0x00000001898F4470-0x00000001898F4490
	private bool TickBannerHint() => default; // 0x0000000181B06560-0x0000000181B06690
	// [XID] // 0x00000001898FBC00-0x00000001898FBC20
	private void AddBannerBegin(string title, string subTitle) {} // 0x0000000181B08AB0-0x0000000181B08C20
	// [XID] // 0x0000000189903670-0x0000000189903690
	private void ClearBanner() {} // 0x0000000181B05530-0x0000000181B05650
	// [XID] // 0x0000000189912890-0x00000001899128B0
	public override void UpdateView() {} // 0x0000000181B094D0-0x0000000181B095B0
	// [XID] // 0x000000018991A160-0x000000018991A180
	public override void LateUpdateView() {} // 0x0000000181B077F0-0x0000000181B078B0
	// [XID] // 0x0000000189921960-0x0000000189921980
	private void OnGalleryStart(uint galleryID, uint endTime) {} // 0x0000000181B07DA0-0x0000000181B07F80
	// [XID] // 0x0000000189929080-0x00000001899290A0
	private void OnGalleryStop(uint galleryID) {} // 0x0000000181B05810-0x0000000181B059A0
	// [XID] // 0x00000001899305D0-0x00000001899305F0
	private void OnGalleryUpdateAll(uint galleryID) {} // 0x0000000181B04A80-0x0000000181B04BF0
	// [XID] // 0x0000000189937B20-0x0000000189937B40
	private void IniCountDown(uint newEndTime) {} // 0x0000000181B041E0-0x0000000181B043B0
	// [XID] // 0x000000018993F5F0-0x000000018993F610
	private void TickCountDown() {} // 0x0000000181B06030-0x0000000181B061C0
	// [XID] // 0x0000000189946BE0-0x0000000189946C00
	private void HideQuestHintDialog() {} // 0x0000000181B08150-0x0000000181B08290
	// [XID] // 0x000000018994E260-0x000000018994E280
	private void ResumeQuestHintDialog() {} // 0x0000000181B068A0-0x0000000181B069C0
	// [XID] // 0x0000000189955840-0x0000000189955860
	private void OnRefresh() {} // 0x0000000181B05390-0x0000000181B05530
	// [XID] // 0x000000018995D360-0x000000018995D380
	private void InitSideReset() {} // 0x0000000181B07AF0-0x0000000181B07DA0
	// [XID] // 0x0000000189964A10-0x0000000189964A30
	private void OnGalleryBalloonStart(uint endTime) {} // 0x0000000181B06690-0x0000000181B068A0
	// [XID] // 0x000000018996C0F0-0x000000018996C110
	private void OnGalleryBalloonEnd() {} // 0x0000000181B092D0-0x0000000181B093C0
	// [XID] // 0x0000000189973B80-0x0000000189973BA0
	private void OnGalleryBalloonRefresh() {} // 0x0000000181B07140-0x0000000181B072C0
	// [XID] // 0x000000018997B1F0-0x000000018997B210
	private void OnGalleryBalloonUpdateAll() {} // 0x0000000181B05CF0-0x0000000181B05D90
	// [XID] // 0x0000000189982CC0-0x0000000189982CE0
	private void OnGalleryBalloonShootNotify(GalleryBalloonShootNotify notify) {} // 0x0000000181B064B0-0x0000000181B06560
	// [XID] // 0x000000018998A490-0x000000018998A4B0
	private void SetBalloonInfo() {} // 0x0000000181B05B20-0x0000000181B05CF0
	// [XID] // 0x0000000189991D80-0x0000000189991DA0
	private void TickBalloonCombo() {} // 0x0000000181B08680-0x0000000181B087F0
	// [XID] // 0x0000000189999AB0-0x0000000189999AD0
	private void SetBalloonCombo(uint combo, ulong comboRemainTime) {} // 0x0000000181B073C0-0x0000000181B07560
	// [XID] // 0x00000001899A1140-0x00000001899A1160
	private void OnGalleryFallStart(uint endTime) {} // 0x0000000181B03D70-0x0000000181B03E40
	// [XID] // 0x00000001899A8C70-0x00000001899A8C90
	private void OnGalleryFallEnd() {} // 0x0000000181B05A30-0x0000000181B05B20
	// [XID] // 0x00000001899B0590-0x00000001899B05B0
	private void OnGalleryFallRefresh() {} // 0x0000000181B04D60-0x0000000181B04E70
	// [XID] // 0x00000001899B78C0-0x00000001899B78E0
	private void SetFallUI() {} // 0x0000000181B04690-0x0000000181B04830
	// [XID] // 0x00000001899BF260-0x00000001899BF280
	private string GetGalleryFallProgress(uint score1, uint score2, uint score3) => default; // 0x0000000181B08360-0x0000000181B08680
	// [XID] // 0x00000001899C6C90-0x00000001899C6CB0
	private void OnGalleryFallCatchNotify(GalleryFallCatchNotify notify) {} // 0x0000000181B07FE0-0x0000000181B08150
	// [XID] // 0x00000001899CE1A0-0x00000001899CE1C0
	private void SetFallCatchBallInfo() {} // 0x0000000181B06C20-0x0000000181B06FB0
	// [XID] // 0x00000001899D5980-0x00000001899D59A0
	private void SetFallScoreInfo() {} // 0x0000000181B07560-0x0000000181B077F0
	// [XID] // 0x00000001899DCCD0-0x00000001899DCCF0
	private void OnGalleryFallScoreNotify() {} // 0x0000000181B06FB0-0x0000000181B07070
	// [XID] // 0x00000001899E48D0-0x00000001899E48F0
	private bool IsSelfFallGround() => default; // 0x0000000181B03A50-0x0000000181B03BE0
	// [XID] // 0x00000001899EBCC0-0x00000001899EBCE0
	private void OnPlayerGround() {} // 0x0000000181B087F0-0x0000000181B08A20
	// [XID] // 0x00000001899F3790-0x00000001899F37B0
	private void TickWaitCountDown() {} // 0x0000000181B078B0-0x0000000181B07970
	// [XID] // 0x00000001899FB0B0-0x00000001899FB0D0
	private void OnGalleryFallUpdateAll() {} // 0x0000000181B04BF0-0x0000000181B04CC0
	// [XID] // 0x0000000189A02300-0x0000000189A02320
	public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x0000000181B062F0-0x0000000181B063E0
	// [XID] // 0x0000000189A09AF0-0x0000000189A09B10
	private void OnChallengeResetConfirm() {} // 0x0000000181B04830-0x0000000181B04A80
	// [XID] // 0x0000000189A11290-0x0000000189A112B0
	private void OnChallengeReset(bool confirm) {} // 0x0000000181B091E0-0x0000000181B092D0
	// [XID] // 0x0000000189A18660-0x0000000189A18680
	public override void OnInputDeviceChanged() {} // 0x0000000181B08E20-0x0000000181B08ED0
	// [XID] // 0x0000000189A1FD20-0x0000000189A1FD40
	private void TrySetChallengeInterruptIcon() {} // 0x0000000181B07970-0x0000000181B07AF0
	// [XID] // 0x0000000189A270B0-0x0000000189A270D0
	private void SetChallengeInterruptIcon(MonoControlElement keyElement) {} // 0x0000000181B050A0-0x0000000181B05390
}

