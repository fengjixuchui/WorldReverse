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
using UniRx;
using UnityEngine;
using UnityEngine.UI;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class AvatarLevelUpDialogContext : BaseDialogContext // TypeDefIndex: 28802
{
	// Fields
	private uint _prevLevel; // 0x178
	private uint _currLevel; // 0x17C
	private const string PROPERTY_ITEM_PATH = "ART/UI/Menus/Widget/AvatarLevelUpPropertyItem"; // Metadata: 0x00B0E6FA
	private MonoAvatarPropertyItem _propertyItemPrefab; // 0x180
	private List<Tuple<FightPropType, float, float>> _propertyList; // 0x188
	private ScrollRect _scroller; // 0x190

	// Constructors
	public AvatarLevelUpDialogContext() {} // Dummy constructor
	public AvatarLevelUpDialogContext(AvatarUpgradeRsp rsp) {} // 0x0000000181736FE0-0x0000000181737410

	// Methods
	// [XID] // 0x00000001898698D0-0x00000001898698F0
	public override void SetupView() {} // 0x0000000181736C50-0x0000000181736FE0
	// [XID] // 0x0000000189870A70-0x0000000189870A90
	protected override void BindViewCallbacks() {} // 0x0000000181736360-0x0000000181736530
	// [XID] // 0x0000000189878560-0x0000000189878580
	public override void ClearView() {} // 0x0000000181736530-0x0000000181736650
	// [XID] // 0x000000018987FA90-0x000000018987FAB0
	private void RefreshPropertyItem(Transform trans, int index) {} // 0x0000000181736650-0x0000000181736880
	// [XID] // 0x00000001898870C0-0x00000001898870E0
	public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x0000000181736970-0x0000000181736B90
}

