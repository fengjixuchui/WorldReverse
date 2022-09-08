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

public sealed class ActivityChannellerSlabDungeonInfoPageContext : BasePageContext // TypeDefIndex: 30162
{
	// Fields
	private MonoActivityChannellerSlabDungeonInfoPage _pageMono; // 0x190
	private DungeonFactorOverviewComponent _dungeonFactor; // 0x198
	private MonsterPreviewComponent _monsterPreview; // 0x1A0
	private RestrictionOverviewComponent _restrictionOverview; // 0x1A8
	private TabDataProvider _tabDataProvider; // 0x1B0
	private DungeonDataProvider _dungeonDataProvider; // 0x1B8
	private List<uint> _buffList; // 0x1C0
	private bool _isLoopDungeon; // 0x1C8
	private uint _dungeonId; // 0x1CC
	private int _selectedTabIdx; // 0x1D0

	// Nested types
	private class DungeonDataProvider // TypeDefIndex: 30163
	{
		// Fields
		private uint _dungeonId; // 0x10
		private bool _isLoopDungeon; // 0x14
		private bool _showSubTitle; // 0x15
		private string _title; // 0x18
		private string _subTitle; // 0x20

		// Properties
		public bool isLoopDungeon { /* [XID] */ /* 0x0000000189647060-0x0000000189647080 */ get => default; } // 0x0000000180F0FCB0-0x0000000180F0FD50 
		public bool showSubTitle { /* [XID] */ /* 0x000000018964E770-0x000000018964E790 */ get => default; } // 0x0000000180F0F920-0x0000000180F0F9C0 
		public string title { /* [XID] */ /* 0x0000000189655F80-0x0000000189655FA0 */ get => default; } // 0x0000000180F0FD50-0x0000000180F0FDF0 
		public string subTitle { /* [XID] */ /* 0x000000018965D740-0x000000018965D760 */ get => default; } // 0x0000000180F0FDF0-0x0000000180F0FE90 
		public uint factorGroupId { /* [XID] */ /* 0x0000000189664E60-0x0000000189664E80 */ get => default; } // 0x0000000180F0FAB0-0x0000000180F0FCB0 
		public string difficultyName { /* [XID] */ /* 0x000000018966C4A0-0x000000018966C4C0 */ get => default; } // 0x0000000180F0FE90-0x0000000180F10010 
		public uint successScore { /* [XID] */ /* 0x0000000189674360-0x0000000189674380 */ get => default; } // 0x0000000180F0F9C0-0x0000000180F0FAB0 

		// Constructors
		public DungeonDataProvider() {} // Dummy constructor
		public DungeonDataProvider(uint dungeonId) {} // 0x0000000180F10010-0x0000000180F104A0
	}

	private class TabDataProvider // TypeDefIndex: 30164
	{
		// Fields
		private static TabType[] types; // 0x00
		private static string[] names; // 0x08
		private int _count; // 0x10

		// Properties
		public int count { /* [XID] */ /* 0x000000018967BAE0-0x000000018967BB00 */ get => default; } // 0x0000000180F10660-0x0000000180F10700 

		// Nested types
		public enum TabType // TypeDefIndex: 30165
		{
			Info = 0,
			Restriction = 1,
			Buff = 2
		}

		// Constructors
		public TabDataProvider() {} // Dummy constructor
		public TabDataProvider(bool isLoopDungeon) {} // 0x0000000180F10B00-0x0000000180F10B90
		static TabDataProvider() {} // 0x0000000180F108D0-0x0000000180F10B00

		// Methods
		// [XID] // 0x00000001896831F0-0x0000000189683210
		public string GetName(int idx) => default; // 0x0000000180F10700-0x0000000180F108D0
		// [XID] // 0x000000018968ACA0-0x000000018968ACC0
		public TabType GetTabType(int idx) => default; // 0x0000000180F104A0-0x0000000180F10660
	}

	private class MonsterPreviewDataProvider : MonsterPreviewComponent.DataProvider // TypeDefIndex: 30166
	{
		// Fields
		private List<uint> _monsterIds; // 0x10

		// Properties
		public override int count { /* [XID] */ /* 0x00000001896929A0-0x00000001896929C0 */ get => default; } // 0x0000000180F11000-0x0000000180F110C0 
		public override bool showLevel { /* [XID] */ /* 0x0000000189699D40-0x0000000189699D60 */ get => default; } // 0x0000000180F10C80-0x0000000180F10D20 

		// Constructors
		public MonsterPreviewDataProvider() {} // 0x0000000180F110C0-0x0000000180F11260

		// Methods
		// [XID] // 0x00000001896A1460-0x00000001896A1480
		public override uint GetMonsterId(int idx) => default; // 0x0000000180F10E10-0x0000000180F10EE0
		// [XID] // 0x00000001896A88F0-0x00000001896A8910
		public override uint GetMonsterLevel(int idx) => default; // 0x0000000180F10EE0-0x0000000180F11000
	}

	private class RestrictionOverviewDataProvider : RestrictionOverviewComponent.DataProvider // TypeDefIndex: 30167
	{
		// Fields
		private List<uint> _restrictionIds; // 0x10
		private string _timeRestrictionStr; // 0x18
		private string _monsterHpRestrictionStr; // 0x20

		// Properties
		public override int count { /* [XID] */ /* 0x00000001896AFAC0-0x00000001896AFAE0 */ get => default; } // 0x0000000180F11720-0x0000000180F117E0 

		// Constructors
		public RestrictionOverviewDataProvider() {} // 0x0000000180F118E0-0x0000000180F11C90

		// Methods
		// [XID] // 0x00000001896B7430-0x00000001896B7450
		public ChannellerSlabLoopDungeonConditionExcelConfig GetConfig(int idx) => default; // 0x0000000180F11260-0x0000000180F11340
		// [XID] // 0x00000001896BE560-0x00000001896BE580
		public override uint GetFactorGroupId(int idx) => default; // 0x0000000180F117E0-0x0000000180F118E0
		// [XID] // 0x00000001896C5D90-0x00000001896C5DB0
		public string GetTimeRestrictionStr() => default; // 0x0000000180F11560-0x0000000180F11600
		// [XID] // 0x00000001896CD4E0-0x00000001896CD500
		public string GetMonsterHpRestrictionStr() => default; // 0x0000000180F11680-0x0000000180F11720
		// [XID] // 0x00000001896D4910-0x00000001896D4930
		public override string GetOverrideDesc(int idx) => default; // 0x0000000180F113B0-0x0000000180F114E0
	}

	// Constructors
	public ActivityChannellerSlabDungeonInfoPageContext() {} // Dummy constructor
	public ActivityChannellerSlabDungeonInfoPageContext(uint dungeonId) {} // 0x0000000180F185C0-0x0000000180F186C0

	// Methods
	// [XID] // 0x0000000189BA1930-0x0000000189BA1950
	public override void SetupView() {} // 0x0000000180F181C0-0x0000000180F185C0
	// [XID] // 0x0000000189BA8D50-0x0000000189BA8D70
	public override void ClearView() {} // 0x0000000180F16AC0-0x0000000180F16B70
	// [XID] // 0x0000000189BB04E0-0x0000000189BB0500
	protected override void BindViewCallbacks() {} // 0x0000000180F16760-0x0000000180F16860
	// [XID] // 0x0000000189BB78E0-0x0000000189BB7900
	private void SetupTabs() {} // 0x0000000180F16E90-0x0000000180F16FF0
	// [XID] // 0x0000000189BBEF40-0x0000000189BBEF60
	private void RefreshTabItem(Transform trans, int idx) {} // 0x0000000180F16B70-0x0000000180F16D50
	// [XID] // 0x0000000189BC6BD0-0x0000000189BC6BF0
	private void SetTabItemState(int idx) {} // 0x0000000180F17860-0x0000000180F17A40
	// [XID] // 0x0000000189BCE8C0-0x0000000189BCE8E0
	private void OnTabClick(int idx) {} // 0x0000000180F17BB0-0x0000000180F17CB0
	// [XID] // 0x0000000189BD5B80-0x0000000189BD5BA0
	private void SetupInfoPanel() {} // 0x0000000180F180E0-0x0000000180F181C0
	// [XID] // 0x0000000189BDD830-0x0000000189BDD850
	private void OpenInfoPanel() {} // 0x0000000180F17CB0-0x0000000180F17E10
	// [XID] // 0x00000001895EA390-0x00000001895EA3B0
	private void RefreshInfoPanel() {} // 0x0000000180F17500-0x0000000180F17700
	// [XID] // 0x00000001895F1810-0x00000001895F1830
	private void SetupRestrictionPanel() {} // 0x0000000180F17440-0x0000000180F17500
	// [XID] // 0x00000001895F92B0-0x00000001895F92D0
	private void OpenRestrictionPanel() {} // 0x0000000180F17EA0-0x0000000180F18000
	// [XID] // 0x00000001896008E0-0x0000000189600900
	private void RefreshRestrictionPanel() {} // 0x0000000180F16860-0x0000000180F16AC0
	// [XID] // 0x0000000189608200-0x0000000189608220
	private void RefreshBuffItem(Transform trans, int index) {} // 0x0000000180F16FF0-0x0000000180F17250
	// [XID] // 0x000000018960FBA0-0x000000018960FBC0
	private void SetupBuffPanel() {} // 0x0000000180F17B10-0x0000000180F17BB0
	// [XID] // 0x0000000189616E40-0x0000000189616E60
	private void OpenBuffPanel() {} // 0x0000000180F17700-0x0000000180F17860
	// [XID] // 0x000000018961E9A0-0x000000018961E9C0
	private void RefreshBuffPanel() {} // 0x0000000180F16510-0x0000000180F16760
	// [XID] // 0x0000000189625DC0-0x0000000189625DE0
	public override bool OnNotify(Notify ntf) => default; // 0x0000000180F18000-0x0000000180F180E0
	// [XID] // 0x000000018962D6E0-0x000000018962D700
	public override bool BasePageHandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x0000000180F172B0-0x0000000180F173E0
	// [XID] // 0x00000001896352A0-0x00000001896352C0
	private void OnBtnReturnClick() {} // 0x0000000180F16DE0-0x0000000180F16E90
}

