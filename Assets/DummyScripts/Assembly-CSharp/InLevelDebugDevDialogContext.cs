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

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class InLevelDebugDevDialogContext : BaseDialogContext // TypeDefIndex: 28603
{
	// Fields
	private static float monsterCreateTime; // 0x00
	private static int monsterCreateNum; // 0x04
	private static float monsterCreateRange; // 0x08
	private static int monsterCreateLevel; // 0x0C
	private static float monsterCreateScale; // 0x10
	private static int testLightNum; // 0x14

	// Constructors
	public InLevelDebugDevDialogContext() {} // 0x00000001823199A0-0x0000000182319A40
	static InLevelDebugDevDialogContext() {} // 0x0000000182319900-0x00000001823199A0

	// Methods
	// [XID] // 0x00000001896B5F90-0x00000001896B5FB0
	public override void SetupView() {} // 0x0000000182319840-0x0000000182319900
	// [XID] // 0x00000001896BD150-0x00000001896BD170
	public override bool OnNotify(Notify ntf) => default; // 0x0000000182319620-0x0000000182319720
	// [XID] // 0x00000001896C4650-0x00000001896C4670
	private void SetupGadgetDrop() {} // 0x0000000182315980-0x0000000182315CC0
	// [XID] // 0x00000001896CBCB0-0x00000001896CBCD0
	private void SetupItemDrop() {} // 0x0000000182315F90-0x00000001823167E0
	// [XID] // 0x00000001896D2F50-0x00000001896D2F70
	public override void ClearView() {} // 0x0000000182315180-0x0000000182315980
	// [XID] // 0x00000001896DAB20-0x00000001896DAB40
	private void InitEvents() {} // 0x00000001823173F0-0x0000000182318120
	// [XID] // 0x00000001896E2250-0x00000001896E2270
	private void RefreshView() {} // 0x0000000182316B30-0x0000000182317390
	// [XID] // 0x00000001896E9790-0x00000001896E97B0
	private void OnReturn() {} // 0x0000000182315EE0-0x0000000182315F90
	// [XID] // 0x00000001896F09F0-0x00000001896F0A10
	private void OnApplyGadget() {} // 0x0000000182314F10-0x0000000182315180
	// [XID] // 0x00000001896F81E0-0x00000001896F8200
	private void OnApplyItem() {} // 0x0000000182319080-0x0000000182319590
	// [XID] // 0x00000001896FFB40-0x00000001896FFB60
	private void CreateGadget(int cID) {} // 0x0000000182314310-0x0000000182314620
	// [XID] // 0x0000000189707210-0x0000000189707230
	private void CreateItem(int cID) {} // 0x0000000182318120-0x0000000182318430
	[DebuggerHidden] // 0x000000018970EA90-0x000000018970EAD0
	// [XID] // 0x000000018970EA90-0x000000018970EAD0
	private IEnumerator CreateGadgets(int cID) => default; // 0x00000001823167E0-0x0000000182316900
	[DebuggerHidden] // 0x0000000189719270-0x00000001897192B0
	// [XID] // 0x0000000189719270-0x00000001897192B0
	private IEnumerator CreateItems(int cID) => default; // 0x0000000182318C60-0x0000000182318D80
	// [XID] // 0x00000001897236C0-0x00000001897236E0
	private void OnMonsterScaleChanged(float num) {} // 0x0000000182313CD0-0x0000000182313F10
	// [XID] // 0x000000018972AE20-0x000000018972AE40
	private void OnMonsterNumChanged(float num) {} // 0x0000000182316960-0x0000000182316B30
	// [XID] // 0x00000001897324F0-0x0000000189732510
	private void OnMonsterRangehanged(float range) {} // 0x0000000182315CC0-0x0000000182315EE0
	// [XID] // 0x0000000189739C20-0x0000000189739C40
	private void OnMonsterCreateTimeChaned(string range) {} // 0x0000000182318D80-0x0000000182318F20
	// [XID] // 0x00000001897417E0-0x0000000189741800
	private void OnMonsterlevelChaned(string level) {} // 0x0000000182318430-0x00000001823185D0
	// [XID] // 0x0000000189749100-0x0000000189749120
	private void OnEffectCache() {} // 0x00000001823185D0-0x00000001823187C0
	// [XID] // 0x00000001897505B0-0x00000001897505D0
	private void SwitchInfiniteStamina() {} // 0x0000000182313F10-0x00000001823140A0
	// [XID] // 0x0000000189757AD0-0x0000000189757AF0
	private void OnLoadDobuleLockingParam() {} // 0x0000000182318FE0-0x0000000182319080
	// [XID] // 0x000000018975F550-0x000000018975F570
	private void OnLoadMultiLockingParam() {} // 0x0000000182314270-0x0000000182314310
	// [XID] // 0x0000000189766A00-0x0000000189766A20
	private void OnChangeSkillNoCD() {} // 0x0000000182318F20-0x0000000182318FE0
	// [XID] // 0x000000018976DFB0-0x000000018976DFD0
	private void OnTestLighting() {} // 0x0000000182314620-0x0000000182314B40
	// [XID] // 0x0000000189775730-0x0000000189775750
	private void OnHitRetreat() {} // 0x0000000182318940-0x0000000182318C60
	// [XID] // 0x000000018977CF70-0x000000018977CF90
	private void OnHitAir() {} // 0x0000000182314B40-0x0000000182314F10
	// [XID] // 0x00000001897849F0-0x0000000189784A10
	private void OnKillSelf() {} // 0x0000000182319780-0x0000000182319840
	// [XID] // 0x000000018978BFA0-0x000000018978BFC0
	private void OnLogSwitch() {} // 0x00000001823140A0-0x0000000182314270
}

