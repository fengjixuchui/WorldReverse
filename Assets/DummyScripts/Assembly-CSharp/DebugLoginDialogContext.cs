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

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class DebugLoginDialogContext : BaseDialogContext // TypeDefIndex: 28563
{
	// Fields
	private static SceneScriptData[] sceneConfigs; // 0x00
	private static uint[] configHandles; // 0x08
	private SceneScriptData selectedData; // 0x178
	private List<ServerConfigPattern> serverPatterns; // 0x180
	private LoginMainPageContext _mainPage; // 0x188
	private GameObject _debugPanel; // 0x190
	private GameObject _switchDebugPanelBtn; // 0x198
	private GameObject _debugDialog; // 0x1A0
	private GameObject _GMButton; // 0x1A8
	private bool hasBundleLoaded; // 0x1B0

	// Constructors
	public DebugLoginDialogContext() {} // 0x00000001812036C0-0x00000001812037C0

	// Methods
	// [XID] // 0x0000000189A3BF10-0x0000000189A3BF30
	public override void SetupView() {} // 0x0000000181203330-0x00000001812036C0
	// [XID] // 0x0000000189A43B40-0x0000000189A43B60
	public override void ClearView() {} // 0x00000001811FF030-0x00000001811FF0F0
	// [XID] // 0x0000000189A4AFF0-0x0000000189A4B010
	private void OnToggleDebugMenuDialog() {} // 0x00000001812027F0-0x0000000181202970
	// [XID] // 0x0000000189A526B0-0x0000000189A526D0
	private void DebugSetupView() {} // 0x00000001811FF5A0-0x00000001812000F0
	// [XID] // 0x0000000189A59FE0-0x0000000189A5A000
	private void CheckShowServerList() {} // 0x00000001812006F0-0x00000001812008B0
	// [XID] // 0x0000000189A61810-0x0000000189A61830
	private void ClearViewDebug() {} // 0x00000001811FF240-0x00000001811FF4E0
	// [XID] // 0x0000000189A69750-0x0000000189A69770
	private void ClearSaveConfig() {} // 0x00000001812020F0-0x00000001812023F0
	// [XID] // 0x0000000189A70AA0-0x0000000189A70AC0
	private void InitLevelChose() {} // 0x0000000181200210-0x0000000181200690
	// [XID] // 0x0000000189A78390-0x0000000189A783B0
	private void InitServerChoose() {} // 0x0000000181202970-0x0000000181203330
	// [XID] // 0x0000000189A7F9A0-0x0000000189A7F9C0
	private void OnServerChange(int index) {} // 0x00000001811FECC0-0x00000001811FEF90
	// [XID] // 0x0000000189A87640-0x0000000189A87660
	private void RequestOnGoToLevel() {} // 0x00000001812008B0-0x0000000181200F00
	// [XID] // 0x0000000189A8EDE0-0x0000000189A8EE00
	private void UpdateConnectState() {} // 0x00000001812016D0-0x00000001812018C0
	// [XID] // 0x0000000189A96430-0x0000000189A96450
	private void CheckOfflineBundle(Action callback) {} // 0x00000001812012B0-0x0000000181201500
	// [XID] // 0x0000000189A9D980-0x0000000189A9D9A0
	private void OnConnect() {} // 0x00000001812018C0-0x0000000181201EE0
	// [XID] // 0x0000000189AA5290-0x0000000189AA52B0
	private void ShowVersions() {} // 0x0000000181201FB0-0x00000001812020F0
	// [XID] // 0x0000000189AACA50-0x0000000189AACA70
	public override bool OnNotify(Notify ntf) => default; // 0x00000001812025A0-0x0000000181202790
	// [XID] // 0x0000000189AB4350-0x0000000189AB4370
	private void ShowDebugServerPanel() {} // 0x0000000181200F00-0x0000000181201020
	// [XID] // 0x0000000189ABC010-0x0000000189ABC030
	private void OnClearPersistClick() {} // 0x0000000181201080-0x0000000181201200
}

