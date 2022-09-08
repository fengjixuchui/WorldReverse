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

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class ActivitySubPage_Bonus : BaseSubPageContext // TypeDefIndex: 29382
{
	// Fields
	private MonoGiveCharacterContext _monoGiveCharacter; // 0x178
	private readonly uint _towerDungeonID; // 0x180
	private readonly uint _characterConfigID; // 0x184
	private uint _bonusId; // 0x188
	private BonusActivityInfo _bonusInfo; // 0x190
	private BonusActivityClientExcelConfig _bonusConfig; // 0x198
	private bool isLocked; // 0x1A0
	private float CLICK_INTERVAL; // 0x1A4
	private float _lastClickTime; // 0x1A8

	// Constructors
	public ActivitySubPage_Bonus() {} // Dummy constructor
	public ActivitySubPage_Bonus(uint bonusId, BasePageContext _parent, Transform _mountTrans) {} // 0x0000000183977B20-0x0000000183977D60

	// Methods
	// [XID] // 0x00000001896A58D0-0x00000001896A58F0
	protected override void BindViewCallbacks() {} // 0x0000000183976570-0x0000000183976740
	// [XID] // 0x00000001896AD150-0x00000001896AD170
	public override void SetupView() {} // 0x0000000183977990-0x0000000183977B20
	// [XID] // 0x00000001896B4780-0x00000001896B47A0
	private void Refresh() {} // 0x0000000183975EA0-0x00000001839764F0
	// [XID] // 0x00000001896BB9F0-0x00000001896BBA10
	private void OnClickCharacter() {} // 0x0000000183977660-0x0000000183977710
	// [XID] // 0x00000001896C2EB0-0x00000001896C2ED0
	private void OnClickGotoBtn() {} // 0x00000001839767D0-0x0000000183976C00
	// [XID] // 0x00000001896CA340-0x00000001896CA360
	public void RefreshGiveCharacterState(uint activity_id) {} // 0x0000000183977290-0x0000000183977660
	// [XID] // 0x00000001896D19F0-0x00000001896D1A10
	public override bool OnNotify(Notify ntf) => default; // 0x0000000183977800-0x0000000183977990
	// [XID] // 0x00000001896D9200-0x00000001896D9220
	public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x0000000183976C60-0x0000000183977080
	// [XID] // 0x00000001896E09D0-0x00000001896E09F0
	public override void OnParentFocusChangeed(bool focusOnParent) {} // 0x0000000183977080-0x0000000183977290
}

