/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;
using UnityEngine;
using UnityEngine.UI;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class InLevelDebugStreamDialogContext : BaseDialogContext // TypeDefIndex: 28630
{
	// Fields
	private GameObject _basicPanel; // 0x178
	private UnityEngine.UI.Text _basicPanelText; // 0x180
	private SliceFrameWatch lodLoader; // 0x188
	private GameObject _layerPanel; // 0x190
	private UnityEngine.UI.Text _layerPanelText; // 0x198
	private GameObject _settingPanel; // 0x1A0

	// Constructors
	public InLevelDebugStreamDialogContext() {} // 0x0000000183FD5180-0x0000000183FD5240

	// Methods
	// [XID] // 0x00000001896F81C0-0x00000001896F81E0
	public override void SetupView() {} // 0x0000000183FD4DF0-0x0000000183FD50C0
	// [XID] // 0x00000001896FFB20-0x00000001896FFB40
	public override void ClearView() {} // 0x0000000183FD2060-0x0000000183FD22D0
	// [XID] // 0x00000001897071F0-0x0000000189707210
	private void InitEvents() {} // 0x0000000183FD2C30-0x0000000183FD2EB0
	// [XID] // 0x000000018970EA70-0x000000018970EA90
	public override void UpdateView() {} // 0x0000000183FD50C0-0x0000000183FD5180
	// [XID] // 0x0000000189715E90-0x0000000189715EB0
	private void OnCloseBasicPanel() {} // 0x0000000183FD4CF0-0x0000000183FD4DF0
	// [XID] // 0x000000018971D8F0-0x000000018971D910
	private void OnCloseLayerPanel() {} // 0x0000000183FD2B30-0x0000000183FD2C30
	// [XID] // 0x0000000189724D10-0x0000000189724D30
	private void OnCloseSettingPanel() {} // 0x0000000183FD2610-0x0000000183FD2710
	// [XID] // 0x000000018972C4C0-0x000000018972C4E0
	private void CheckDestroyEntireDialog() {} // 0x0000000183FD1C50-0x0000000183FD1E20
	// [XID] // 0x0000000189733C20-0x0000000189733C40
	private void UpdateBasicPanel() {} // 0x0000000183FD33A0-0x0000000183FD4B80
	// [XID] // 0x000000018973B300-0x000000018973B320
	private void UpdateLayerPanel() {} // 0x0000000183FD2710-0x0000000183FD2A70
	// [XID] // 0x0000000189742CB0-0x0000000189742CD0
	private string GetLayerInfos(bool showLayers) => default; // 0x0000000183FD1E20-0x0000000183FD2060
	// [XID] // 0x000000018974A9D0-0x000000018974A9F0
	private void UpdateSettingPanel() {} // 0x0000000183FD23C0-0x0000000183FD2550
	// [XID] // 0x0000000189751AB0-0x0000000189751AD0
	private void UpdateSlider(string name) {} // 0x0000000183FD3170-0x0000000183FD33A0
	// [XID] // 0x00000001897590A0-0x00000001897590C0
	private void RegisteSlider(string name, Action<float> func, float value) {} // 0x0000000183FD2F10-0x0000000183FD3170
	// [XID] // 0x0000000189760CF0-0x0000000189760D10
	private void UnregisteSlider(string name) {} // 0x0000000183FD4B80-0x0000000183FD4CF0
	// [XID] // 0x0000000189768050-0x0000000189768070
	public void SetLodSlider(float value) {} // 0x0000000183FD22D0-0x0000000183FD23C0
	// [XID] // 0x000000018976F5E0-0x000000018976F600
	public void SetLimitLOD(float value) {} // 0x0000000183FD2550-0x0000000183FD2610
}

