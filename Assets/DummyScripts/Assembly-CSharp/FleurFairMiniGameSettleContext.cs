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

public sealed class FleurFairMiniGameSettleContext : BasePageContext // TypeDefIndex: 29085
{
	// Fields
	private MonoFleurFairMiniGameSettlePage _pageMono; // 0x190
	private ActivityInfo _activityInfo; // 0x198
	private FleurFairBalloonSettleInfo _balloonSettleInfo; // 0x1A8
	private FleurFairFallSettleInfo _fallSettleInfo; // 0x1B0
	private GalleryModule.MusicSettleInfo _musicSettleInfo; // 0x1B8
	private uint _curGameId; // 0x1C0
	private List<uint> _watcherList; // 0x1C8

	// Properties
	public EFleurFairMiniGame MiniGame { /* [XID] */ /* 0x00000001897504F0-0x0000000189750530 */ get; private set; } // 0x000000018252A710-0x000000018252A770 0x000000018252A5A0-0x000000018252A610

	// Constructors
	public FleurFairMiniGameSettleContext() {} // Dummy constructor
	public FleurFairMiniGameSettleContext(FleurFairBalloonSettleNotify notify) {} // 0x000000018252B100-0x000000018252B2C0
	public FleurFairMiniGameSettleContext(FleurFairFallSettleNotify notify) {} // 0x000000018252B470-0x000000018252B630
	public FleurFairMiniGameSettleContext(uint musicBasicID) {} // 0x000000018252B2C0-0x000000018252B470

	// Methods
	// [XID] // 0x00000001897623C0-0x00000001897623E0
	private void SetupConfig() {} // 0x0000000182529E00-0x0000000182529ED0
	// [XID] // 0x00000001897699E0-0x0000000189769A00
	public override void SetupView() {} // 0x000000018252AFC0-0x000000018252B100
	// [XID] // 0x0000000189771010-0x0000000189771030
	protected override void BindViewCallbacks() {} // 0x0000000182528070-0x0000000182528270
	// [XID] // 0x00000001897788A0-0x00000001897788C0
	private void OnCloseMusicSettle() {} // 0x00000001825291C0-0x0000000182529300
	// [XID] // 0x000000018977FE20-0x000000018977FE40
	public override bool OnNotify(Notify ntf) => default; // 0x000000018252A980-0x000000018252AB00
	// [XID] // 0x0000000189787700-0x0000000189787720
	private void OnItemAdded(List<SimpleItemStruct> items) {} // 0x000000018252A610-0x000000018252A710
	// [XID] // 0x000000018978ED30-0x000000018978ED50
	private void UpdateActivity(uint activityId) {} // 0x000000018252A7D0-0x000000018252A8F0
	// [XID] // 0x0000000189796480-0x00000001897964A0
	private void Refresh() {} // 0x0000000182527E90-0x0000000182528010
	// [XID] // 0x000000018979E5D0-0x000000018979E5F0
	private void RefreshBalloon() {} // 0x0000000182528D40-0x00000001825291C0
	// [XID] // 0x00000001897A5D90-0x00000001897A5DB0
	private void RefreshFall() {} // 0x0000000182529ED0-0x000000018252A5A0
	// [XID] // 0x00000001897AD300-0x00000001897AD320
	private void RefreshMusic() {} // 0x0000000182529940-0x0000000182529E00
	// [XID] // 0x00000001897B5350-0x00000001897B5370
	private string GetLevelTextMap(uint musicLevel) => default; // 0x000000018252ACE0-0x000000018252ADD0
	// [XID] // 0x00000001897BCFE0-0x00000001897BD000
	private string GetMusicRank(MusicGameBasicConfig musicConfig, uint score) => default; // 0x000000018252AB00-0x000000018252ACE0
	// [XID] // 0x00000001897C4360-0x00000001897C4380
	private void OnClickAgain() {} // 0x0000000182529390-0x0000000182529580
	// [XID] // 0x00000001897CBB80-0x00000001897CBBA0
	private void SetRewardInfo(uint score) {} // 0x0000000182528270-0x0000000182528AB0
	// [XID] // 0x00000001897D34B0-0x00000001897D34D0
	private ActivityWatcherInfo GetWatcherInfo(uint watcherID) => default; // 0x000000018252ADD0-0x000000018252AFC0
	// [XID] // 0x00000001897DAF30-0x00000001897DAF50
	private void OnClickReceiveAll() {} // 0x0000000182528AB0-0x0000000182528D40
	// [XID] // 0x00000001897E26A0-0x00000001897E26C0
	public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x0000000182529720-0x0000000182529940
	// [XID] // 0x00000001897E9E10-0x00000001897E9E30
	private void ResolveReward(bool show) {} // 0x0000000182529580-0x00000001825296C0
}

