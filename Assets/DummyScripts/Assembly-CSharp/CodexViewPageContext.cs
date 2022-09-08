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

public sealed class CodexViewPageContext : BasePageContext // TypeDefIndex: 28525
{
	// Fields
	private MonoCodexViewPage _pageMono; // 0x190
	private Dictionary<uint, List<CodexModule.CodexViewData>> _cityViewDict; // 0x198
	private uint _currentCity; // 0x1A0
	private List<CodexModule.CodexViewData> _currentCityViews; // 0x1A8
	private List<uint> _cityIds; // 0x1B0
	private CodexViewUISceneComponent _uiSceneComp; // 0x1B8

	// Constructors
	public CodexViewPageContext() {} // 0x0000000181945BB0-0x0000000181945C70

	// Methods
	// [XID] // 0x0000000189A37A40-0x0000000189A37A60
	protected override void BindViewCallbacks() {} // 0x0000000181943C50-0x0000000181943DC0
	// [XID] // 0x0000000189A3F130-0x0000000189A3F150
	private void OnBack() {} // 0x00000001819457D0-0x0000000181945880
	// [XID] // 0x0000000189A46810-0x0000000189A46830
	private void OnCityDropDown(int index) {} // 0x00000001819456F0-0x00000001819457D0
	// [XID] // 0x0000000189A4E060-0x0000000189A4E080
	public override void SetupView() {} // 0x0000000181945880-0x0000000181945BB0
	// [XID] // 0x0000000189A557D0-0x0000000189A557F0
	public override void ClearView() {} // 0x0000000181943DC0-0x0000000181943E70
	// [XID] // 0x0000000189A5D130-0x0000000189A5D150
	private void RefreshCityView() {} // 0x0000000181943E70-0x0000000181944250
	// [XID] // 0x0000000189A64990-0x0000000189A649B0
	private void RefreshItemSelectState(RectTransform trans, bool selected) {} // 0x00000001819439B0-0x0000000181943AB0
	// [XID] // 0x0000000189A6C1B0-0x0000000189A6C1D0
	private void RefreshViewItem(Transform trans, int index) {} // 0x0000000181945070-0x00000001819454B0
	// [XID] // 0x0000000189A73960-0x0000000189A73980
	private void SetCityDropdown() {} // 0x0000000181944A60-0x0000000181944CD0
	// [XID] // 0x0000000189A7B4A0-0x0000000189A7B4C0
	public int FindPrevView(int currentIndex) => default; // 0x00000001819444A0-0x00000001819445A0
	// [XID] // 0x0000000189A82B60-0x0000000189A82B80
	public int FindNextView(int currentIndex) => default; // 0x0000000181943B30-0x0000000181943C50
	// [XID] // 0x0000000189A8A570-0x0000000189A8A590
	public CodexModule.CodexViewData GetViewData(int index) => default; // 0x0000000181944990-0x0000000181944A60
	// [XID] // 0x0000000189A91D70-0x0000000189A91D90
	public void SetCurrentView(int index) {} // 0x00000001819446C0-0x00000001819447D0
	// [XID] // 0x0000000189A997E0-0x0000000189A99800
	public void CheckSetViewed(int index) {} // 0x0000000181944250-0x00000001819444A0
	// [XID] // 0x0000000189AA0850-0x0000000189AA0870
	public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x0000000181944830-0x0000000181944930
	// [XID] // 0x0000000189AA7E50-0x0000000189AA7E70
	private bool HandleInputActionEventMain(InputActionEvent actionEvent) => default; // 0x0000000181944CD0-0x0000000181945070
	// [XID] // 0x0000000189AAF920-0x0000000189AAF940
	private bool HandleInputActionEventScreen(InputActionEvent actionEvent) => default; // 0x00000001819454B0-0x0000000181945690
}

