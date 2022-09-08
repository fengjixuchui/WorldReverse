/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class QuickUseWaterSprite : QuickWidgetBase // TypeDefIndex: 31363
{
	// Fields
	private BagItemSlot _equippedBagItemSlot; // 0x28
	private DateTime _curTime; // 0x38
	private DateTime _targetTime; // 0x48

	// Properties
	private bool isWaterSpriteSkillTriggered { /* [XID] */ /* 0x00000001896AB5A0-0x00000001896AB5E0 */ get; /* [XID] */ /* 0x00000001896B5CB0-0x00000001896B5CF0 */ set; } // 0x000000018221E480-0x000000018221E4E0 0x000000018221E720-0x000000018221E780

	// Constructors
	public QuickUseWaterSprite() {} // 0x000000018221F040-0x000000018221F100

	// Methods
	// [XID] // 0x00000001896BFC30-0x00000001896BFC50
	public override LCWidgetBagActionPara DoBag(LCWidget lcWidget) => default; // 0x000000018221D5E0-0x000000018221D720
	// [XID] // 0x00000001896C74F0-0x00000001896C7510
	public override void InitOnAttach(WidgetSlotTag tag) {} // 0x000000018221ED60-0x000000018221EEA0
	// [XID] // 0x00000001896CEC50-0x00000001896CEC70
	public override void ClearOnUnAttach(WidgetSlotTag tag) {} // 0x000000018221E310-0x000000018221E400
	// [XID] // 0x00000001896D6050-0x00000001896D6070
	public override LCWidgetButtonActionPara DoActionPanel(LCWidget lcWidget) => default; // 0x000000018221DC50-0x000000018221DF80
	// [XID] // 0x00000001896DD600-0x00000001896DD620
	public override void DoActionPanelPostAction(LCWidget lcWidget, bool success, object additionalPara = null) {} // 0x000000018221E810-0x000000018221EB30
	// [XID] // 0x00000001896E4CC0-0x00000001896E4CE0
	public override string GetBagPageButtonText(LCWidget lcWidget) => default; // 0x000000018221E0A0-0x000000018221E1A0
	// [XID] // 0x00000001896EC200-0x00000001896EC220
	public override void Tick(float inDeltaTime) {} // 0x000000018221E1A0-0x000000018221E310
	// [XID] // 0x00000001896F39B0-0x00000001896F39D0
	public override bool OnNotify(Notify ntf) => default; // 0x000000018221DF80-0x000000018221E0A0
	// [XID] // 0x00000001896FB080-0x00000001896FB0A0
	public override BagItemSlot GetCurrentEquippedBagItemSlot() => default; // 0x000000018221E4E0-0x000000018221E580
	// [XID] // 0x00000001897027C0-0x00000001897027E0
	public override void TickActionPanel(MonoQuickUseButton monoButton) {} // 0x000000018221D720-0x000000018221D950
	// [XID] // 0x0000000189709FB0-0x0000000189709FD0
	private void WaterSpriteRegionSearchOut() {} // 0x000000018221D9C0-0x000000018221DBD0
	// [XID] // 0x0000000189711A30-0x0000000189711A50
	private void WaterSpriteSync() {} // 0x000000018221EEA0-0x000000018221F040
	// [XID] // 0x0000000189718E70-0x0000000189718E90
	private void WaterSpriteOnAvatarChange() {} // 0x000000018221EB30-0x000000018221ECD0
}

