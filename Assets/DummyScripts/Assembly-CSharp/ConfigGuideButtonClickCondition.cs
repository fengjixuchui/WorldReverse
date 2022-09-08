/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MihoyoOptimization;
using MoleMole;
using SimpleJSON;
using UnityEngine;
using UnityEngine.UI;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[RecycleType] // 0x00000001898C45A0-0x00000001898C45C0
public sealed class ConfigGuideButtonClickCondition : ConfigGuideCondition, IAutoAllocRecycle // TypeDefIndex: 18220
{
	// Fields
	private string _buttonPath; // 0x20
	private string _contextName; // 0x28
	private GuidePageType _pageType; // 0x30
	private GuideButtonClick _type; // 0x34
	private SimpleSafeFloat valueRawNum; // 0x38
	private MonoActionBtn _actionButton; // 0x40
	private Button _button; // 0x48
	private BaseContext _baseContext; // 0x50
	private bool _widgetClick; // 0x58
	private float _pressTime; // 0x5C
	private GuideManager _manager; // 0x60
	private Toggle _toggle; // 0x68
	private NewbieDialogContext _newBieDialog; // 0x70
	private NotifyTypes[] _curNotifyList; // 0x78

	// Properties
	public string buttonPath { /* [XID] */ /* 0x0000000189915D00-0x0000000189915D20 */ get => default; /* [XID] */ /* 0x000000018991D770-0x000000018991D790 */ private set {} } // 0x00000001823C53A0-0x00000001823C5440 0x00000001823C6220-0x00000001823C62D0
	public string contextName { /* [XID] */ /* 0x0000000189924F60-0x0000000189924F80 */ get => default; /* [XID] */ /* 0x000000018992C560-0x000000018992C580 */ private set {} } // 0x00000001823C3980-0x00000001823C3A20 0x00000001823C4510-0x00000001823C45C0
	public GuidePageType pageType { /* [XID] */ /* 0x0000000189933B20-0x0000000189933B40 */ get => default; /* [XID] */ /* 0x000000018993B6F0-0x000000018993B710 */ private set {} } // 0x00000001823C55A0-0x00000001823C5640 0x00000001823C2F80-0x00000001823C3030
	public GuideButtonClick type { /* [XID] */ /* 0x00000001899427B0-0x00000001899427D0 */ get => default; /* [XID] */ /* 0x000000018994A0C0-0x000000018994A0E0 */ private set {} } // 0x00000001823C62D0-0x00000001823C6370 0x00000001823C56C0-0x00000001823C5770
	public float value { /* [XID] */ /* 0x0000000189951BB0-0x0000000189951BD0 */ get => default; /* [XID] */ /* 0x0000000189959030-0x0000000189959050 */ private set {} } // 0x00000001823C3300-0x00000001823C33E0 0x00000001823C3030-0x00000001823C3110
	private bool _isUsing { /* [XID] */ /* 0x00000001899D5FD0-0x00000001899D5FF0 */ get => default; } // 0x00000001823C4DD0-0x00000001823C4F10 

	// Constructors
	public ConfigGuideButtonClickCondition() {} // 0x00000001823C6650-0x00000001823C6700

	// Methods
	// [XID] // 0x00000001899608C0-0x00000001899608E0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001823C60C0-0x00000001823C6220
	// [XID] // 0x00000001899680E0-0x0000000189968100
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x00000001823C54A0-0x00000001823C55A0
	// [XID] // 0x000000018996F500-0x000000018996F520
	public override ConfigBaseGuide Clone(bool useObjectPool = false /* Metadata: 0x00AF90AF */) => default; // 0x00000001823C49B0-0x00000001823C4AA0
	// [XID] // 0x0000000189977120-0x0000000189977140
	public override int GetHashNum() => default; // 0x00000001823C20E0-0x00000001823C21B0
	// [XID] // 0x000000018997E440-0x000000018997E460
	public override void InitEmpty() {} // 0x00000001823C4310-0x00000001823C4430
	[BlackList] // 0x0000000189985EF0-0x0000000189985F30
	// [XID] // 0x0000000189985EF0-0x0000000189985F30
	public override bool FromJson(JSONNode node) => default; // 0x00000001823C3600-0x00000001823C3980
	// [XID] // 0x0000000189990BD0-0x0000000189990BF0
	private new bool InternalFromJson(JSONNode node) => default; // 0x00000001823C1560-0x00000001823C1B40
	[BlackList] // 0x00000001899986B0-0x00000001899986F0
	// [XID] // 0x00000001899986B0-0x00000001899986F0
	public static new ConfigGuideButtonClickCondition ParseFromJson(JSONNode node) => default; // 0x00000001823C5180-0x00000001823C53A0
	// [XID] // 0x00000001899A2F70-0x00000001899A2F90
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF90B0 */, bool useObjectPool = false /* Metadata: 0x00AF90B4 */) => default; // 0x00000001823C46B0-0x00000001823C49B0
	// [XID] // 0x00000001899AAA60-0x00000001899AAA80
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF90B5 */, bool useObjectPool = false /* Metadata: 0x00AF90B9 */) => default; // 0x00000001823C2A60-0x00000001823C2F00
	// [XID] // 0x00000001899B2450-0x00000001899B2470
	public static new ConfigGuideButtonClickCondition ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF90BA */, bool useObjectPool = false /* Metadata: 0x00AF90BE */) => default; // 0x00000001823C3A20-0x00000001823C3C10
	[BlackList] // 0x00000001899B9790-0x00000001899B97D0
	// [XID] // 0x00000001899B9790-0x00000001899B97D0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x00000001823C1B40-0x00000001823C1E10
	// [XID] // 0x00000001899C4380-0x00000001899C43A0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001823C5B20-0x00000001823C5F30
	[BlackList] // 0x00000001899CBB20-0x00000001899CBB60
	// [XID] // 0x00000001899CBB20-0x00000001899CBB60
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x00000001823C45C0-0x00000001823C46B0
	// [XID] // 0x00000001899DD440-0x00000001899DD460
	private void ButtonClick() {} // 0x00000001823C2860-0x00000001823C2A60
	// [XID] // 0x00000001899E5160-0x00000001899E5180
	private void ButtonPressDown() {} // 0x00000001823C3C10-0x00000001823C3E70
	// [XID] // 0x00000001899EC4D0-0x00000001899EC4F0
	private void ButtonChargePressDown() {} // 0x00000001823C2250-0x00000001823C2370
	// [XID] // 0x00000001899F4150-0x00000001899F4170
	private void ButtonChargePressUp() {} // 0x00000001823C21B0-0x00000001823C2250
	// [XID] // 0x00000001899FB790-0x00000001899FB7B0
	private void CheckChargeCondition() {} // 0x00000001823C4AA0-0x00000001823C4DD0
	// [XID] // 0x0000000189A02AB0-0x0000000189A02AD0
	private bool RegisterClickAction(Transform widget) => default; // 0x00000001823C5770-0x00000001823C5980
	// [XID] // 0x0000000189A0A1E0-0x0000000189A0A200
	private bool RegisterPressDownAction(Transform widget) => default; // 0x00000001823C6370-0x00000001823C65B0
	// [XID] // 0x0000000189A11B00-0x0000000189A11B20
	private bool RegisterChargeAction(Transform widget) => default; // 0x00000001823C23D0-0x00000001823C27E0
	// [XID] // 0x0000000189A18D50-0x0000000189A18D70
	protected override bool Prepare(GuideManager manager) => default; // 0x00000001823C3190-0x00000001823C3250
	// [XID] // 0x0000000189A20430-0x0000000189A20450
	protected override void Finish(GuideManager manager) {} // 0x00000001823C5980-0x00000001823C5AA0
	// [XID] // 0x0000000189A27820-0x0000000189A27840
	private void ShowProgressTime() {} // 0x00000001823C5F30-0x00000001823C60C0
	// [XID] // 0x0000000189A2EF50-0x0000000189A2EF70
	private bool RegisterToggleAction(Transform widget) => default; // 0x00000001823C4F70-0x00000001823C5180
	// [XID] // 0x0000000189A36950-0x0000000189A36970
	private void ToggleClick(bool enable) {} // 0x00000001823C33E0-0x00000001823C3600
	// [XID] // 0x0000000189A3DF50-0x0000000189A3DF70
	private void Tick() {} // 0x00000001823C3250-0x00000001823C3300
	// [XID] // 0x0000000189A45700-0x0000000189A45720
	public override bool Ready(object body = null) => default; // 0x00000001823C3EE0-0x00000001823C4290
	[BlackList] // 0x0000000189A4CC60-0x0000000189A4CCA0
	// [XID] // 0x0000000189A4CC60-0x0000000189A4CCA0
	public override void AutoAllocTypeFields() {} // 0x00000001823C1E10-0x00000001823C1EB0
	[BlackList] // 0x0000000189A573D0-0x0000000189A57410
	// [XID] // 0x0000000189A573D0-0x0000000189A57410
	public override void AutoRecycleTypeFields() {} // 0x00000001823C1EB0-0x00000001823C1FC0
	[BlackList] // 0x0000000189A61C70-0x0000000189A61CB0
	// [XID] // 0x0000000189A61C70-0x0000000189A61CB0
	public override void ReturnToObjectPool() {} // 0x00000001823C65B0-0x00000001823C6650
}

