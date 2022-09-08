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

public sealed class TheatreMechanicusCardSelectionPageContext : BasePageContext // TypeDefIndex: 29942
{
	// Fields
	private MonoTheatreMechanicusCardSelectionPage _pageMono; // 0x190
	private List<InBattleMechanicusCardInfo> _cardList; // 0x198
	private List<InBattleMechanicusMonsterInfo> _monsterList; // 0x1A0
	private int _selectedIndex; // 0x1A8
	private int _selectedIndexByOthers; // 0x1AC
	private int _confirmedIndex; // 0x1B0
	private int _confirmedIndexByOthers; // 0x1B4
	private bool _isSkipped; // 0x1B8
	private bool _isSkippedByOthers; // 0x1B9
	private ulong _prevTickTime; // 0x1C0
	private ulong _endTimeStamp; // 0x1C8
	private bool _finish; // 0x1D0
	private bool _showResult; // 0x1D1
	private GeneralDialogContext _skipDialog; // 0x1D8
	private bool _hasEnabledInput; // 0x1E0

	// Properties
	public int curSelectIndex { /* [XID] */ /* 0x00000001896DF160-0x00000001896DF180 */ get => default; } // 0x0000000181FDCCC0-0x0000000181FDCD60 

	// Constructors
	public TheatreMechanicusCardSelectionPageContext() {} // 0x0000000181FE0ED0-0x0000000181FE1080

	// Methods
	// [XID] // 0x00000001896E65B0-0x00000001896E65D0
	public override void SetupView() {} // 0x0000000181FE0CB0-0x0000000181FE0E30
	// [XID] // 0x00000001896EDB00-0x00000001896EDB20
	public override void ClearView() {} // 0x0000000181FDBB90-0x0000000181FDBC30
	// [XID] // 0x00000001896F5310-0x00000001896F5330
	public override void UpdateView() {} // 0x0000000181FE0E30-0x0000000181FE0ED0
	// [XID] // 0x00000001896FCB30-0x00000001896FCB50
	protected override void ClearOnDestroy() {} // 0x0000000181FDBA90-0x0000000181FDBB90
	// [XID] // 0x0000000189704010-0x0000000189704030
	protected override void BindViewCallbacks() {} // 0x0000000181FDB8E0-0x0000000181FDBA90
	// [XID] // 0x000000018970B900-0x000000018970B920
	public override bool OnNotify(Notify ntf) => default; // 0x0000000181FE0800-0x0000000181FE0B10
	// [XID] // 0x00000001897131D0-0x00000001897131F0
	public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x0000000181FDD300-0x0000000181FDD410
	// [XID] // 0x000000018971A9B0-0x000000018971A9D0
	private void RefreshView() {} // 0x0000000181FDD410-0x0000000181FDE690
	// [XID] // 0x0000000189721CF0-0x0000000189721D10
	private void RefreshCardRow(Transform trans, int index) {} // 0x0000000181FDE810-0x0000000181FDEED0
	// [XID] // 0x0000000189729380-0x00000001897293A0
	private string GetCardIconNameByType(MechanicusCardType type) => default; // 0x0000000181FDEED0-0x0000000181FDEFA0
	// [XID] // 0x0000000189730BA0-0x0000000189730BC0
	private void OnCardRowClick(int index) {} // 0x0000000181FE0B10-0x0000000181FE0CB0
	// [XID] // 0x00000001897384F0-0x0000000189738510
	private bool CardRowNavigationRules(int index) => default; // 0x0000000181FDE750-0x0000000181FDE810
	// [XID] // 0x0000000189740230-0x0000000189740250
	private void RefreshMonsterRow(Transform trans, int index) {} // 0x0000000181FDBC30-0x0000000181FDBF30
	// [XID] // 0x0000000189747600-0x0000000189747620
	private void OnConfirmBtnClick() {} // 0x0000000181FDB200-0x0000000181FDB3D0
	// [XID] // 0x000000018974ED50-0x000000018974ED70
	private void OnInfoBtnClick() {} // 0x0000000181FDF230-0x0000000181FDF330
	// [XID] // 0x0000000189756460-0x0000000189756480
	private void OnSkipBtnClick() {} // 0x0000000181FE03C0-0x0000000181FE0570
	// [XID] // 0x000000018975D880-0x000000018975D8A0
	private void OnInBattleMechanicusPickCardRsp(uint cardId) {} // 0x0000000181FDC070-0x0000000181FDC4A0
	// [XID] // 0x0000000189764E30-0x0000000189764E50
	private void OnInBattleMechanicusPickCardNotify(uint cardId) {} // 0x0000000181FDCF60-0x0000000181FDD2A0
	// [XID] // 0x000000018976C8D0-0x000000018976C8F0
	private void OnInBattleMechanicusConfirmCardRsp(uint cardId) {} // 0x0000000181FDC530-0x0000000181FDCCC0
	// [XID] // 0x0000000189773D70-0x0000000189773D90
	private void OnInBattleMechanicusConfirmCardNotify(uint cardId) {} // 0x0000000181FDB3D0-0x0000000181FDB8E0
	// [XID] // 0x000000018977B440-0x000000018977B460
	private void OnInBattleMechanicusCardResultNotify(InBattleMechanicusCardResultNotify ntf) {} // 0x0000000181FDF330-0x0000000181FE03C0
	// [XID] // 0x0000000189782F80-0x0000000189782FA0
	private void TickTime() {} // 0x0000000181FDBF30-0x0000000181FDC070
	// [XID] // 0x000000018978A410-0x000000018978A430
	private void UpdateTimeText() {} // 0x0000000181FE0610-0x0000000181FE0710
	// [XID] // 0x0000000189791C30-0x0000000189791C50
	private void SetTimeText(ulong time) {} // 0x0000000181FDEFA0-0x0000000181FDF230
	// [XID] // 0x0000000189799230-0x0000000189799250
	private int CompareCardSortOrder(InBattleMechanicusCardInfo x, InBattleMechanicusCardInfo y) => default; // 0x0000000181FDCD60-0x0000000181FDCF00
}

