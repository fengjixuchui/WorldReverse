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
using UnityEngine.UI;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class SynthesisExchangeDialogContext : BaseDialogContext // TypeDefIndex: 30313
{
	// Fields
	public string title; // 0x178
	public Action<bool> buttonCallBack; // 0x180
	private MonoSynthesisExchangeDialog _dialogMono; // 0x188
	private string _confirmText; // 0x190
	private List<SimpleItemStruct> _simpleItemList; // 0x198
	private SimpleItemStruct _resultSimpleItem; // 0x1A0
	private ShopMaterial _shopMaterial; // 0x1C0
	private List<MonoSimpleReusableList> _validReusableLists; // 0x1C8
	private List<MonoSimpleReusableList> _sourceReusableLists; // 0x1D0
	private int _selectedIndex; // 0x1D8
	private static readonly uint _selectAudio; // 0x00

	// Constructors
	public SynthesisExchangeDialogContext() {} // Dummy constructor
	public SynthesisExchangeDialogContext(string confirmText, List<SimpleItemStruct> simpleItemList, SimpleItemStruct resultSimpleItem, ShopMaterial shopMaterial) {} // 0x0000000183370760-0x0000000183370880
	static SynthesisExchangeDialogContext() {} // 0x00000001833706D0-0x0000000183370760

	// Methods
	// [XID] // 0x00000001896AE530-0x00000001896AE550
	public override void SetupView() {} // 0x0000000183370360-0x00000001833706D0
	// [XID] // 0x00000001896B5DB0-0x00000001896B5DD0
	public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x000000018336F8B0-0x000000018336FA40
	// [XID] // 0x00000001896BCF70-0x00000001896BCF90
	protected override void BindViewCallbacks() {} // 0x000000018336E770-0x000000018336E900
	// [XID] // 0x00000001896C4450-0x00000001896C4470
	private void OnButtonClick(bool isOk) {} // 0x000000018336FAB0-0x000000018336FB90
	// [XID] // 0x00000001896CBAB0-0x00000001896CBAD0
	private void UpdateReusableLists() {} // 0x000000018336E900-0x000000018336ED20
	// [XID] // 0x00000001896D2DB0-0x00000001896D2DD0
	private void UpdateTitleText() {} // 0x000000018336E600-0x000000018336E770
	// [XID] // 0x00000001896DA960-0x00000001896DA980
	private void UpdateDescText() {} // 0x000000018336FB90-0x000000018336FD00
	// [XID] // 0x00000001896E2070-0x00000001896E2090
	private void UpdateItemConfig() {} // 0x0000000183370090-0x0000000183370360
	// [XID] // 0x00000001896E9570-0x00000001896E9590
	private void RefreshItemConfig(MonoSimpleReusableList item, SimpleItemStruct simpleItemStruct) {} // 0x000000018336F4F0-0x000000018336F850
	// [XID] // 0x00000001896F07E0-0x00000001896F0800
	private void SetSelectIndexWithRefresh(int newIndex, bool isForce = false /* Metadata: 0x00B109AE */) {} // 0x000000018336FD00-0x000000018336FFC0
	// [IDTag] // 0x00000001896F7FA0-0x00000001896F7FE0
	// [XID] // 0x00000001896F7FA0-0x00000001896F7FE0
	private void RefreshItemJoyStickState(MonoSimpleReusableList reusableList, bool isSelect) {} // 0x000000018336F0A0-0x000000018336F200
	// [IDTag] // 0x0000000189702980-0x00000001897029C0
	// [XID] // 0x0000000189702980-0x00000001897029C0
	private void RefreshItemJoyStickState(Transform itemTrans, bool isSelect) {} // 0x000000018336EDB0-0x000000018336F0A0
	private T GetButtonByItem<T>(Transform item)
		where T : Button => default;
	// [XID] // 0x000000018970D1A0-0x000000018970D1C0
	private void ShowItemDetail() {} // 0x000000018336F200-0x000000018336F4F0
}

