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
using UnityEngine.Events;
using UnityEngine.UI;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class ActivityChannellerSlabDungeonEntryPageContext : BasePageContext // TypeDefIndex: 30158
{
	// Fields
	private uint _pointId; // 0x190
	private MonoActivityChannellerSlabDungeonEntryPage _pageMono; // 0x198
	private OneOffDungeonDataProvider _dungeonDataProvider; // 0x1A0
	private DungeonFactorOverviewComponent _factorOverview; // 0x1A8
	private RewardPreviewComponent _rewardPreview; // 0x1B0
	private ChannellerSlabPlateComponent _plate; // 0x1B8
	private List<ElementType> _lackElementTypes; // 0x1C0

	// Nested types
	private class OneOffDungeonDataProvider // TypeDefIndex: 30159
	{
		// Fields
		private uint _stageId; // 0x10

		// Properties
		public uint dungeonId { /* [XID] */ /* 0x0000000189A41FA0-0x0000000189A41FC0 */ get => default; } // 0x0000000181F4A9A0-0x0000000181F4AA60 
		public uint factorGroupId { /* [XID] */ /* 0x0000000189A49550-0x0000000189A49570 */ get => default; } // 0x0000000181F4A540-0x0000000181F4A750 
		public uint rewardId { /* [XID] */ /* 0x0000000189A50E60-0x0000000189A50E80 */ get => default; } // 0x0000000181F4A820-0x0000000181F4A8E0 
		public ElementType[] recommendElementTypes { /* [XID] */ /* 0x0000000189A58420-0x0000000189A58440 */ get => default; } // 0x0000000181F4A750-0x0000000181F4A820 
		public string title { /* [XID] */ /* 0x0000000189A5FEA0-0x0000000189A5FEC0 */ get => default; } // 0x0000000181F4A8E0-0x0000000181F4A9A0 

		// Constructors
		public OneOffDungeonDataProvider() {} // Dummy constructor
		public OneOffDungeonDataProvider(uint stageId) {} // 0x0000000181F4AA60-0x0000000181F4AAD0
	}

	// Constructors
	public ActivityChannellerSlabDungeonEntryPageContext() {} // Dummy constructor
	public ActivityChannellerSlabDungeonEntryPageContext(uint pointId) {} // 0x0000000181F26960-0x0000000181F26A70

	// Methods
	// [XID] // 0x00000001899C53A0-0x00000001899C53C0
	public override void SetupView() {} // 0x0000000181F267C0-0x0000000181F26960
	// [XID] // 0x00000001899CCA30-0x00000001899CCA50
	private uint GetStageId(uint pointId) => default; // 0x0000000181F24FC0-0x0000000181F25370
	// [XID] // 0x00000001899D40B0-0x00000001899D40D0
	private void SetupFactorOverview() {} // 0x0000000181F26580-0x0000000181F266A0
	// [XID] // 0x00000001899DB640-0x00000001899DB660
	private void SetupRecommendElements() {} // 0x0000000181F25500-0x0000000181F260D0
	// [XID] // 0x00000001899E2D60-0x00000001899E2D80
	private void SetupRewardOverview() {} // 0x0000000181F24950-0x0000000181F24A60
	// [XID] // 0x00000001899EA4B0-0x00000001899EA4D0
	private void SetupPlate() {} // 0x0000000181F261B0-0x0000000181F263C0
	// [XID] // 0x00000001899F1E40-0x00000001899F1E60
	public override void ClearView() {} // 0x0000000181F24DB0-0x0000000181F24EB0
	// [XID] // 0x00000001899F9640-0x00000001899F9660
	protected override void BindViewCallbacks() {} // 0x0000000181F24A60-0x0000000181F24CC0
	// [XID] // 0x0000000189A00960-0x0000000189A00980
	protected override void OnEnable() {} // 0x0000000181F266A0-0x0000000181F267C0
	// [XID] // 0x0000000189A08280-0x0000000189A082A0
	private void OnBtnStartClick() {} // 0x0000000181F260D0-0x0000000181F261B0
	// [XID] // 0x0000000189A0F700-0x0000000189A0F720
	private void OnBtnReturnClick() {} // 0x0000000181F24F10-0x0000000181F24FC0
	// [XID] // 0x0000000189A16D40-0x0000000189A16D60
	private void OnBtnItemDetailClick() {} // 0x0000000181F248A0-0x0000000181F24950
	// [XID] // 0x0000000189A1E3A0-0x0000000189A1E3C0
	private void OnBtnPlateClick() {} // 0x0000000181F24790-0x0000000181F248A0
	// [XID] // 0x0000000189A25AA0-0x0000000189A25AC0
	private void OnBtnDetailClick() {} // 0x0000000181F263C0-0x0000000181F26520
}

