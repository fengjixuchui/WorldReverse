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

public sealed class SynthesisPageContext : BasePageContext // TypeDefIndex: 29311
{
	// Fields
	private MonoSynthesisPage _pageMono; // 0x190
	private Dictionary<uint, List<uint>> _combineDic; // 0x198
	private Dictionary<uint, List<uint>> _convertDic; // 0x1A0
	private Dictionary<uint, List<uint>> _convertTargetIdToRecipesDic; // 0x1A8
	private uint _combineType; // 0x1B0
	private int _selectedIndex; // 0x1B4
	private uint _selectedItemId; // 0x1B8
	private uint _minCount; // 0x1BC
	private uint _maxCount; // 0x1C0
	private uint _selectedCount; // 0x1C4
	private List<uint> _avatarList; // 0x1C8
	private uint _selectedAvatarId; // 0x1D0
	private uint _toSelectAvatarId; // 0x1D4
	private int _toSelectAvatarIndex; // 0x1D8
	private Dictionary<uint, uint> _bonusAvatarDic; // 0x1E0
	private List<SimpleItemStruct> _itemGotList; // 0x1E8
	private bool _isAsce; // 0x1F0
	private bool _screenOpen; // 0x1F1
	private List<uint> _screenTypeList; // 0x1F8
	private uint[] _screenTypes; // 0x200
	private uint _curSelectedCombineId; // 0x208
	private List<uint> _canConvertList; // 0x210
	private List<uint> _cantConvertList; // 0x218
	private static readonly uint _switchBagAudio; // 0x00
	private static readonly uint _selectItemAudio; // 0x04
	private uint _currentPageIndex; // 0x220
	private const uint SYNTHESIS_PAGE_INDEX = 0; // Metadata: 0x00B0F5C0
	private const uint MELTING_PAGE_INDEX = 1; // Metadata: 0x00B0F5C4
	private int _curSelectColumn; // 0x224

	// Properties
	private bool screenOpen { /* [XID] */ /* 0x000000018994B290-0x000000018994B2B0 */ get => default; /* [XID] */ /* 0x0000000189952C20-0x0000000189952C40 */ set {} } // 0x0000000182D34050-0x0000000182D34100 0x0000000182D2A100-0x0000000182D2A290

	// Constructors
	public SynthesisPageContext() {} // 0x0000000182D379F0-0x0000000182D37C10
	static SynthesisPageContext() {} // 0x0000000182D37940-0x0000000182D379F0

	// Methods
	// [XID] // 0x000000018995A1D0-0x000000018995A1F0
	public override void SetupView() {} // 0x0000000182D375A0-0x0000000182D37890
	// [XID] // 0x0000000189961C00-0x0000000189961C20
	public override void UpdateView() {} // 0x0000000182D37890-0x0000000182D37940
	// [XID] // 0x0000000189969290-0x00000001899692B0
	public override void ClearView() {} // 0x0000000182D2B640-0x0000000182D2B6F0
	// [XID] // 0x0000000189970D30-0x0000000189970D50
	protected override void BindViewCallbacks() {} // 0x0000000182D29A00-0x0000000182D2A100
	// [XID] // 0x0000000189978670-0x0000000189978690
	public override bool OnNotify(Notify ntf) => default; // 0x0000000182D364F0-0x0000000182D365E0
	// [XID] // 0x000000018997F790-0x000000018997F7B0
	private void ShowPageByTabIndex(int index) {} // 0x0000000182D2F030-0x0000000182D2F230
	// [XID] // 0x00000001899870E0-0x0000000189987100
	private void InitSynthesisPage() {} // 0x0000000182D36990-0x0000000182D36E00
	// [XID] // 0x000000018998EBB0-0x000000018998EBD0
	private void InitMeltingPage() {} // 0x0000000182D35560-0x0000000182D35AC0
	// [XID] // 0x0000000189996790-0x00000001899967B0
	public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x0000000182D307B0-0x0000000182D30D20
	// [XID] // 0x000000018999E2B0-0x000000018999E2D0
	private bool SelectMoveLeft() => default; // 0x0000000182D32910-0x0000000182D32D00
	// [XID] // 0x00000001899A5C70-0x00000001899A5C90
	private bool SelectMoveRight() => default; // 0x0000000182D28CA0-0x0000000182D28EC0
	// [XID] // 0x00000001899AD330-0x00000001899AD350
	private void ResetSelect() {} // 0x0000000182D293E0-0x0000000182D294F0
	// [XID] // 0x00000001899B4B90-0x00000001899B4BB0
	private bool IsInSelect() => default; // 0x0000000182D30510-0x0000000182D305C0
	// [XID] // 0x00000001899BC250-0x00000001899BC270
	private MonoBagProxySlot GetCurSelectObj() => default; // 0x0000000182D2B6F0-0x0000000182D2B9B0
	// [XID] // 0x00000001899C3C90-0x00000001899C3CB0
	private void RefreshSelectState() {} // 0x0000000182D35D10-0x0000000182D35F50
	// [XID] // 0x00000001899CB390-0x00000001899CB3B0
	private void RefreshNormalState() {} // 0x0000000182D2E7B0-0x0000000182D2E9C0
	// [XID] // 0x00000001899D28C0-0x00000001899D28E0
	private bool HandleNormalInputActionEvent(InputActionEvent actionEvent) => default; // 0x0000000182D2D500-0x0000000182D2E7B0
	// [XID] // 0x00000001899D9FD0-0x00000001899D9FF0
	private void RefreshSelectedAvatarState() {} // 0x0000000182D31E00-0x0000000182D32160
	// [XID] // 0x00000001899E18B0-0x00000001899E18D0
	private bool HandleCharacterSelectInputActionEvent(InputActionEvent actionEvent) => default; // 0x0000000182D2A290-0x0000000182D2A9B0
	// [XID] // 0x00000001899E8E60-0x00000001899E8E80
	private bool HandleFilterInputActionEvent(InputActionEvent actionEvent) => default; // 0x0000000182D2B9B0-0x0000000182D2BF70
	// [XID] // 0x00000001899F07E0-0x00000001899F0800
	private void OnRecipeSelectBtnClick(uint resultId) {} // 0x0000000182D34F60-0x0000000182D35170
	// [XID] // 0x00000001899F7E20-0x00000001899F7E40
	private void SynMeltingSelectCallback(uint id) {} // 0x0000000182D31CC0-0x0000000182D31E00
	// [XID] // 0x00000001899FF4D0-0x00000001899FF4F0
	private void RefreshCombineList() {} // 0x0000000182D2C190-0x0000000182D2CBC0
	// [XID] // 0x0000000189A06D10-0x0000000189A06D30
	private void RefreshConvertPageView(bool resort = true /* Metadata: 0x00B0F5B6 */, bool playScrollerAnim = true /* Metadata: 0x00B0F5B7 */) {} // 0x0000000182D29170-0x0000000182D293E0
	// [XID] // 0x0000000189A0E400-0x0000000189A0E420
	private void RefreshCombinePageView(bool resort = true /* Metadata: 0x00B0F5B8 */, bool playScrollerAnim = true /* Metadata: 0x00B0F5B9 */) {} // 0x0000000182D34CF0-0x0000000182D34F60
	// [XID] // 0x0000000189A15980-0x0000000189A159A0
	private void RefreshConvertItem(Transform trans, int index) {} // 0x0000000182D294F0-0x0000000182D297B0
	// [XID] // 0x0000000189A1CE40-0x0000000189A1CE60
	private void RefreshCombineItem(Transform trans, int index) {} // 0x0000000182D2F500-0x0000000182D2F710
	// [XID] // 0x0000000189A24380-0x0000000189A243A0
	private void OnConvertRowClick(int index, bool force = false /* Metadata: 0x00B0F5BA */, bool useCombineId = false /* Metadata: 0x00B0F5BB */) {} // 0x0000000182D2F710-0x0000000182D2FAB0
	// [XID] // 0x0000000189A2B840-0x0000000189A2B860
	private void OnSynthesisRowClick(int index, bool force = false /* Metadata: 0x00B0F5BC */) {} // 0x0000000182D330B0-0x0000000182D33520
	// [XID] // 0x0000000189A32EC0-0x0000000189A32EE0
	private void SetConvertItem(MonoSimpleReusableList itemList, uint id, uint count) {} // 0x0000000182D34460-0x0000000182D34770
	// [XID] // 0x0000000189A3A730-0x0000000189A3A750
	private void RefreshConvertDetail(uint paramId, bool isResultId = true /* Metadata: 0x00B0F5BD */) {} // 0x0000000182D31670-0x0000000182D31CC0
	// [XID] // 0x0000000189A42080-0x0000000189A420A0
	private void RefreshCombineDetail(uint combineId) {} // 0x0000000182D2CF70-0x0000000182D2D500
	// [XID] // 0x0000000189A49630-0x0000000189A49650
	private void RefreshCombineCount(CombineExcelConfig combineConfig) {} // 0x0000000182D338D0-0x0000000182D33EE0
	// [XID] // 0x0000000189A50FC0-0x0000000189A50FE0
	private void SetNumBtnActive(bool showTip) {} // 0x0000000182D2A9B0-0x0000000182D2AB70
	// [XID] // 0x0000000189A58520-0x0000000189A58540
	private void OnNumPlusBtnClick() {} // 0x0000000182D35440-0x0000000182D35500
	// [XID] // 0x0000000189A5FFE0-0x0000000189A60000
	private void OnNumMinusBtnClick() {} // 0x0000000182D34100-0x0000000182D341C0
	// [XID] // 0x0000000189A67C40-0x0000000189A67C60
	private void OnNumSliderValueChange(float value) {} // 0x0000000182D32D00-0x0000000182D32DD0
	// [XID] // 0x0000000189A6F050-0x0000000189A6F070
	private void OnSelectedCountChange() {} // 0x0000000182D2E9C0-0x0000000182D2EE10
	// [XID] // 0x0000000189A76890-0x0000000189A768B0
	private void OnSynthesisBtnClick() {} // 0x0000000182D2AC30-0x0000000182D2B530
	// [XID] // 0x0000000189A7E160-0x0000000189A7E180
	private void realSynthesis() {} // 0x0000000182D365E0-0x0000000182D36990
	// [XID] // 0x0000000189A85B00-0x0000000189A85B20
	private void EnableSynthesisBtn() {} // 0x0000000182D342E0-0x0000000182D34460
	// [XID] // 0x0000000189A8D3A0-0x0000000189A8D3C0
	private void SetAvatarIconView() {} // 0x0000000182D34770-0x0000000182D34B50
	// [XID] // 0x0000000189A948E0-0x0000000189A94900
	private void RefreshSelectAvatar(uint avatarId) {} // 0x0000000182D32230-0x0000000182D32600
	// [XID] // 0x0000000189A9C200-0x0000000189A9C220
	private void OpenAvatarSelectPanel() {} // 0x0000000182D2FB40-0x0000000182D2FD30
	// [XID] // 0x0000000189AA38B0-0x0000000189AA38D0
	private void CloseAvatarSelectPanel() {} // 0x0000000182D2F230-0x0000000182D2F500
	// [XID] // 0x0000000189AAAF70-0x0000000189AAAF90
	private void SetAvatarSelectView() {} // 0x0000000182D32DD0-0x0000000182D330B0
	// [XID] // 0x0000000189AB2900-0x0000000189AB2920
	private void InitToSelectAvatarIndex() {} // 0x0000000182D341C0-0x0000000182D342E0
	// [XID] // 0x0000000189ABA430-0x0000000189ABA450
	private void RefreshAvatarList() {} // 0x0000000182D31040-0x0000000182D313E0
	// [XID] // 0x0000000189AC1D80-0x0000000189AC1DA0
	private void RefreshAvatarRow(Transform trans, int index) {} // 0x0000000182D313E0-0x0000000182D31670
	// [XID] // 0x0000000189AC9330-0x0000000189AC9350
	private void OnAvatarRowClick(int index) {} // 0x0000000182D2FDF0-0x0000000182D30060
	// [XID] // 0x0000000189AD0E00-0x0000000189AD0E20
	private uint CheckIsBonusAvatar(uint combineType, AvatarDataItem avatarData) => default; // 0x0000000182D32600-0x0000000182D32910
	// [XID] // 0x0000000189AD8A30-0x0000000189AD8A50
	private bool CheckHaveBonusAvatar(uint combineType) => default; // 0x0000000182D2BFE0-0x0000000182D2C190
	// [XID] // 0x0000000189AE0600-0x0000000189AE0620
	private void OnSelectAvatar() {} // 0x0000000182D2AB70-0x0000000182D2AC30
	// [XID] // 0x0000000189AE7B90-0x0000000189AE7BB0
	private void OnGetCombineOutputNotify(List<SimpleItemStruct> itemList) {} // 0x0000000182D37380-0x0000000182D375A0
	// [XID] // 0x0000000189AEF8F0-0x0000000189AEF910
	private void RefreshLastSelectedIndex() {} // 0x0000000182D30620-0x0000000182D307B0
	// [XID] // 0x0000000189AF6E10-0x0000000189AF6E30
	private void SetupCombineGotPanel() {} // 0x0000000182D2EE10-0x0000000182D2F030
	// [XID] // 0x0000000189AFE340-0x0000000189AFE360
	private void OnSelectRewardStateChange(Transform trans, bool isSelect) {} // 0x0000000182D34B50-0x0000000182D34C80
	// [XID] // 0x0000000189B05B30-0x0000000189B05B50
	private void RefreshItemGotSlot(Transform trans, int index) {} // 0x0000000182D2CCC0-0x0000000182D2CF70
	// [XID] // 0x0000000189B0D2C0-0x0000000189B0D2E0
	private void OpenItemGotPanel() {} // 0x0000000182D2B530-0x0000000182D2B640
	// [XID] // 0x0000000189B14820-0x0000000189B14840
	private void CloseItemGotPanel() {} // 0x0000000182D2CBC0-0x0000000182D2CCC0
	// [XID] // 0x0000000189B1C140-0x0000000189B1C160
	private void SortResultList(List<uint> resultList) {} // 0x0000000182D28EC0-0x0000000182D29170
	// [XID] // 0x0000000189B237D0-0x0000000189B237F0
	private void SortConvertList() {} // 0x0000000182D30E00-0x0000000182D30FD0
	// [XID] // 0x0000000189B2AA70-0x0000000189B2AA90
	private void SortCombineList() {} // 0x0000000182D35AC0-0x0000000182D35D10
	// [XID] // 0x0000000189B31FA0-0x0000000189B31FC0
	private bool FilterCombileList(ref List<uint> combineList, bool needFilter = true /* Metadata: 0x00B0F5BE */, bool moreThanOne = true /* Metadata: 0x00B0F5BF */) => default; // 0x0000000182D30060-0x0000000182D30510
	// [XID] // 0x0000000189B39760-0x0000000189B39780
	private int CompareCombineItem(uint x, uint y) => default; // 0x0000000182D35FC0-0x0000000182D36170
	// [XID] // 0x0000000189B41110-0x0000000189B41130
	private void ChangeSortOrder() {} // 0x0000000182D33520-0x0000000182D338D0
	// [XID] // 0x0000000189B48A00-0x0000000189B48A20
	private void OnScreenBtnClick() {} // 0x0000000182D297B0-0x0000000182D29990
	// [XID] // 0x0000000189B50190-0x0000000189B501B0
	private void OnScreenBackClick() {} // 0x0000000182D33EE0-0x0000000182D34050
	// [XID] // 0x0000000189B579C0-0x0000000189B579E0
	private void SetScreeningView() {} // 0x0000000182D36E00-0x0000000182D371C0
	// [XID] // 0x0000000189B5F330-0x0000000189B5F350
	private void RefreshScreeninRow(Transform trans, int index) {} // 0x0000000182D36170-0x0000000182D36460
	// [XID] // 0x0000000189B66920-0x0000000189B66940
	private void OnScreeningRowClick(int index) {} // 0x0000000182D351E0-0x0000000182D35440
	// [XID] // 0x0000000189B6DE80-0x0000000189B6DEA0
	private string GetCombineTypeName(uint combineType) => default; // 0x0000000182D371C0-0x0000000182D37380
}

