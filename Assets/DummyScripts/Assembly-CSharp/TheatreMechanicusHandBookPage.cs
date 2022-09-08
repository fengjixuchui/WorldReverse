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

public sealed class TheatreMechanicusHandBookPage : BasePageContext // TypeDefIndex: 29956
{
	// Fields
	private FocusNavType _focusRegion; // 0x190
	private MonoTheatreMechanicusHandBookPage _pageMono; // 0x198
	private List<MonoBtnTab> _pageTabList; // 0x1A0
	private SimpleSafeUInt32[] _openMapList; // 0x1A8
	private List<MechanicusWatcherExcelConfig> chanlleageList; // 0x1B0
	private int TAB_COUNT; // 0x1B8

	// Nested types
	private enum FocusNavType // TypeDefIndex: 29957
	{
		Left = 0,
		Right = 1
	}

	// Constructors
	public TheatreMechanicusHandBookPage() {} // 0x000000018243B230-0x000000018243B330

	// Methods
	// [XID] // 0x0000000189A4ADB0-0x0000000189A4ADD0
	public override void SetupView() {} // 0x000000018243B0C0-0x000000018243B230
	// [XID] // 0x0000000189A524D0-0x0000000189A524F0
	private void SetupTabList() {} // 0x000000018243AEC0-0x000000018243AFE0
	// [XID] // 0x0000000189A59E20-0x0000000189A59E40
	private void RefreshTabItems(Transform trans, int index) {} // 0x0000000182439940-0x0000000182439B50
	// [XID] // 0x0000000189A615D0-0x0000000189A615F0
	private void OnClickTabMap(int index) {} // 0x00000001824391C0-0x00000001824392F0
	// [XID] // 0x0000000189A694F0-0x0000000189A69510
	private void OnClickTabChallenge(int index) {} // 0x0000000182439810-0x0000000182439940
	// [XID] // 0x0000000189A70820-0x0000000189A70840
	private void SetImageTabState(int index) {} // 0x000000018243A090-0x000000018243A1E0
	// [XID] // 0x0000000189A780F0-0x0000000189A78110
	protected override void BindViewCallbacks() {} // 0x0000000182438F50-0x0000000182439060
	// [XID] // 0x0000000189A7F6E0-0x0000000189A7F700
	private void OnClickReturn() {} // 0x000000018243AFE0-0x000000018243B0C0
	// [XID] // 0x0000000189A87440-0x0000000189A87460
	private void RefreshMapScroller() {} // 0x0000000182439B50-0x0000000182439DB0
	// [XID] // 0x0000000189A8EC40-0x0000000189A8EC60
	private void RefreshScrollSelectState(RectTransform trans, bool selected) {} // 0x0000000182439060-0x00000001824391C0
	// [XID] // 0x0000000189A96230-0x0000000189A96250
	private void RefreshMapItems(Transform trans, int index) {} // 0x000000018243A620-0x000000018243A840
	// [XID] // 0x0000000189A9D780-0x0000000189A9D7A0
	private void OnClickMap(uint mapID, int index) {} // 0x000000018243A1E0-0x000000018243A5C0
	// [XID] // 0x0000000189AA5030-0x0000000189AA5050
	private void RefreshChanllengeScroller() {} // 0x00000001824394A0-0x0000000182439620
	// [XID] // 0x0000000189AAC810-0x0000000189AAC830
	private void RefreshChanlleageItems(Transform trans, int index) {} // 0x0000000182439DB0-0x000000018243A090
	// [XID] // 0x0000000189AB4090-0x0000000189AB40B0
	public override void OnJoypadUIModuleSelectIndex(MonoJoypadUIModule sourceModule, int index, Transform transform, JoypadSelectIndexResult selectResult = JoypadSelectIndexResult.Normal /* Metadata: 0x00B10351 */) {} // 0x000000018243ACD0-0x000000018243AEC0
	// [XID] // 0x0000000189ABBDD0-0x0000000189ABBDF0
	public override void OnJoypadUIModuleFocus(MonoJoypadUIModule focusModule) {} // 0x000000018243A840-0x000000018243ACD0
	// [XID] // 0x0000000189AC35A0-0x0000000189AC35C0
	public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x0000000182439680-0x0000000182439810
}

