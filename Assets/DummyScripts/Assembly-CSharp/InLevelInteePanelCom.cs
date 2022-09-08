/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class InLevelInteePanelCom : BaseContextComponent // TypeDefIndex: 29672
{
	// Fields
	private InLevelMainPageContext _mainPageContext; // 0x30
	private MonoInLevelMainPage _monoPage; // 0x38
	private MonoInteePanel _inteePanel; // 0x40
	private static readonly uint _triggerInterAudio; // 0x00
	private List<uint> _currentPickupEntities; // 0x48
	private List<uint> _currentDialogEntities; // 0x50
	private HashSet<uint> _lowPriortyEntities; // 0x58
	private Dictionary<uint, GeneralInteeType> _currentGeneralIntees; // 0x60
	private int _prevTriggerInteeIndex; // 0x68
	private float _prevTriggerInteeTime; // 0x6C
	private const float MINUS_TRIGGER_GAP = 0.4f; // Metadata: 0x00B0FBB5
	private static string DEFAULT_PICKUP_ITEM_SPRITE_PATH; // 0x08
	private static string DEFAULT_TALK_ITEM_SPRITE_PATH; // 0x10
	private Sprite _defaultPickupItemSprite; // 0x70
	private Sprite _defaultTalkItemSprite; // 0x78
	private int _selectedInteeIndex; // 0x80

	// Properties
	public bool anyInteractionButton { /* [XID] */ /* 0x0000000189843640-0x0000000189843660 */ get => default; } // 0x0000000181838480-0x0000000181838570 
	public int totalInteeCount { /* [XID] */ /* 0x000000018984AB40-0x000000018984AB60 */ get => default; } // 0x00000001818377A0-0x0000000181837850 

	// Constructors
	public InLevelInteePanelCom() {} // 0x0000000181839200-0x0000000181839310
	static InLevelInteePanelCom() {} // 0x0000000181839140-0x0000000181839200

	// Methods
	// [XID] // 0x00000001897B93D0-0x00000001897B93F0
	public override void Init(GameObject view) {} // 0x0000000181838160-0x00000001818382F0
	// [XID] // 0x00000001897C1460-0x00000001897C1480
	public override void Destroy() {} // 0x0000000181836FC0-0x0000000181837070
	// [XID] // 0x00000001897C8EC0-0x00000001897C8EE0
	public override bool OnNotify(Notify ntf) => default; // 0x0000000181838C60-0x0000000181838D70
	// [XID] // 0x00000001897D0520-0x00000001897D0540
	public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x0000000181837850-0x0000000181837A50
	// [XID] // 0x00000001897D8240-0x00000001897D8260
	public override void BindViewCallbacks() {} // 0x0000000181836410-0x0000000181836550
	// [XID] // 0x00000001897DF300-0x00000001897DF320
	public override void OnEnable() {} // 0x0000000181838BB0-0x0000000181838C60
	// [XID] // 0x00000001897E6BC0-0x00000001897E6BE0
	private void InitInteePanel() {} // 0x0000000181838D70-0x0000000181838F30
	// [XID] // 0x00000001897EE730-0x00000001897EE750
	private void ClearInteePanel() {} // 0x00000001818388B0-0x00000001818389D0
	// [XID] // 0x00000001897F5FA0-0x00000001897F5FC0
	private void SetupPickupButton() {} // 0x0000000181836550-0x0000000181836720
	// [XID] // 0x00000001897FD6C0-0x00000001897FD6E0
	private void AddGeneralInteeButton(IGeneralIntee intee) {} // 0x0000000181837F50-0x0000000181838160
	// [XID] // 0x0000000189804D20-0x0000000189804D40
	private void AddPickupInteeButton(IGeneralIntee intee) {} // 0x00000001818357A0-0x0000000181835BA0
	// [XID] // 0x000000018980C2D0-0x000000018980C2F0
	private void AddDialogInteeButton(IGeneralIntee intee) {} // 0x00000001818368F0-0x0000000181836E00
	// [XID] // 0x0000000189813A80-0x0000000189813AA0
	private void HandleGeneralInteeCommand(IGeneralInteeCommand command) {} // 0x0000000181837BA0-0x0000000181837CE0
	// [XID] // 0x000000018981B5B0-0x000000018981B5D0
	private bool RetargetGeneralInteeButton(IGeneralInteeCommandOfT<IGeneralIntee> command) => default; // 0x0000000181838350-0x0000000181838480
	// [XID] // 0x0000000189822C20-0x0000000189822C40
	private bool RemoveGeneralInteeButton(uint instanceID) => default; // 0x0000000181837310-0x0000000181837430
	// [XID] // 0x000000018982A550-0x000000018982A570
	private void RemovePickupInteeButton(uint instanceID) {} // 0x00000001818385D0-0x0000000181838740
	// [XID] // 0x00000001898318A0-0x00000001898318C0
	private void RemoveDialogInteeButton(uint instanceID) {} // 0x0000000181837430-0x00000001818376B0
	[DebuggerHidden] // 0x0000000189838F80-0x0000000189838FC0
	// [XID] // 0x0000000189838F80-0x0000000189838FC0
	private IEnumerator PickupAll() => default; // 0x0000000181837070-0x0000000181837180
	// [XID] // 0x0000000189851EE0-0x0000000189851F00
	private bool ToNextIntee(bool iterateBack = false /* Metadata: 0x00B0FBB4 */) => default; // 0x00000001818387A0-0x00000001818388B0
	// [XID] // 0x00000001898597A0-0x00000001898597C0
	private bool ToPrevIntee() => default; // 0x0000000181837210-0x0000000181837310
	// [XID] // 0x0000000189860920-0x0000000189860940
	private void UpdateSelectOnInteeAdd(int index) {} // 0x0000000181836230-0x0000000181836410
	// [XID] // 0x0000000189868050-0x0000000189868070
	private void UpdateSelectOnInteeRemoved(int index) {} // 0x0000000181837CE0-0x0000000181837F50
	// [XID] // 0x000000018986F5F0-0x000000018986F610
	private void ValidateInteeSelect() {} // 0x0000000181838F30-0x0000000181839140
	// [XID] // 0x0000000189876BC0-0x0000000189876BE0
	private void OnFreeClick() {} // 0x0000000181836720-0x00000001818368F0
	// [XID] // 0x000000018987E6C0-0x000000018987E6E0
	public void RemoveAllPickupButton() {} // 0x00000001818389D0-0x0000000181838B20
	// [XID] // 0x0000000189885AB0-0x0000000189885AD0
	public void RemoveAllDialogButton() {} // 0x0000000181836E00-0x0000000181836F60
	// [XID] // 0x000000018988CDA0-0x000000018988CDC0
	private void RemoveGeneralIntee(uint instanceID) {} // 0x0000000181837AB0-0x0000000181837BA0
	// [XID] // 0x0000000189894490-0x00000001898944B0
	public void RefreshCurrOptionKeyIcon() {} // 0x00000001818376B0-0x00000001818377A0
	// [XID] // 0x000000018989BA40-0x000000018989BA60
	public bool TryTalkPick() => default; // 0x0000000181835BA0-0x00000001818361B0
}

