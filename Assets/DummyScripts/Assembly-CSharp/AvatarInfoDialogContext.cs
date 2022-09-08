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

public sealed class AvatarInfoDialogContext : BaseDialogContext // TypeDefIndex: 28799
{
	// Fields
	private MonoAvatarInfoDialog _dialogMono; // 0x178
	private AvatarDataItem _avatarData; // 0x180
	private const string AVATAR_PROPERTY_ROW_PATH = "ART/UI/Menus/Widget/AvatarPropertyRow"; // Metadata: 0x00B0E6D1
	private GameObject _propRowPrefab; // 0x188
	private List<Transform> _itemTrans; // 0x190
	private int _currIndex; // 0x198
	private bool _isRelic; // 0x19C
	private bool _isLocalPlayer; // 0x19D
	private LCAvatarCombat _combat; // 0x1A0
	private Dictionary<FightPropType, float> _relicProp; // 0x1A8

	// Constructors
	public AvatarInfoDialogContext() {} // Dummy constructor
	public AvatarInfoDialogContext(AvatarDataItem avatarData, bool isRelic = false /* Metadata: 0x00B0E6CE */, bool isLocalPlayer = true /* Metadata: 0x00B0E6CF */) {} // 0x000000018351EAE0-0x000000018351EC20

	// Methods
	// [XID] // 0x00000001897EB980-0x00000001897EB9A0
	private void RefreshCurrent() {} // 0x000000018351D4D0-0x000000018351D760
	// [XID] // 0x00000001897F3280-0x00000001897F32A0
	private void ClearCurrent() {} // 0x000000018351D360-0x000000018351D4D0
	// [XID] // 0x00000001897FAAF0-0x00000001897FAB10
	private void ChangeIndex(bool increase = true /* Metadata: 0x00B0E6D0 */) {} // 0x000000018351D9B0-0x000000018351DAD0
	// [XID] // 0x00000001898020A0-0x00000001898020C0
	public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x000000018351DCE0-0x000000018351DE60
	// [XID] // 0x0000000189809530-0x0000000189809550
	public override void SetupView() {} // 0x000000018351EA00-0x000000018351EAE0
	// [XID] // 0x0000000189810D40-0x0000000189810D60
	public override void ClearView() {} // 0x000000018351D240-0x000000018351D360
	// [XID] // 0x00000001898187D0-0x00000001898187F0
	protected override void BindViewCallbacks() {} // 0x000000018351D140-0x000000018351D240
	// [XID] // 0x00000001898200E0-0x0000000189820100
	private void RefreshAvatarProp() {} // 0x000000018351C470-0x000000018351CFB0
	// [XID] // 0x00000001898276A0-0x00000001898276C0
	private Transform GetAvatarPropItem(int index) => default; // 0x000000018351D7F0-0x000000018351D9B0
	// [XID] // 0x000000018982E8C0-0x000000018982E8E0
	private void SetAvatarPropRow(MonoAvatarPropertyItem item, PropertyFormatStyle.PropShowStruct propInfo, int index) {} // 0x000000018351E390-0x000000018351E7D0
	// [XID] // 0x0000000189836260-0x0000000189836280
	private void SetBgImageColor() {} // 0x000000018351E830-0x000000018351EA00
	// [XID] // 0x000000018983D6D0-0x000000018983D6F0
	private void OnDetailRowClick(FightPropType type) {} // 0x000000018351CFB0-0x000000018351D140
	// [XID] // 0x0000000189844EB0-0x0000000189844ED0
	private void SetElementMasteryRowDetail(MonoAvatarPropertyItem item, float value) {} // 0x000000018351DEC0-0x000000018351E390
	// [XID] // 0x000000018984C380-0x000000018984C3A0
	private void OnItemClick() {} // 0x000000018351DAD0-0x000000018351DC80
}

