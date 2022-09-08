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
using UnityEngine.EventSystems;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class LCAvatarAI : LCAIBeta // TypeDefIndex: 11696
{
	// Fields
	private float interval; // 0x268
	private int t; // 0x26C
	private List<LCAvatarCombat.SkillInfo> _skill_list; // 0x270
	private GameObject InLevelMainPage; // 0x278
	private MonoBattleBtn _skillButton; // 0x280
	private PointerEventData _pointer; // 0x288
	private int[] _skill_button_index; // 0x290
	private float[] _skill_delay; // 0x298

	// Properties
	public override int metaTypeID { /* [XID] */ /* 0x00000001898F9D60-0x00000001898F9D80 */ get => default; } // 0x0000000181B11CF0-0x0000000181B11D90 

	// Constructors
	public LCAvatarAI() {} // 0x0000000181B11BA0-0x0000000181B11CF0

	// Methods
	// [XID] // 0x0000000189901780-0x00000001899017A0
	protected override void InitConfig() {} // 0x0000000181B10950-0x0000000181B109F0
	// [XID] // 0x0000000189908E90-0x0000000189908EB0
	protected override void InitLevelDesign() {} // 0x0000000181B11AA0-0x0000000181B11B40
	// [XID] // 0x0000000189910430-0x0000000189910450
	protected override void InitPoseFSM() {} // 0x0000000181B10280-0x0000000181B10320
	// [XID] // 0x0000000189917F80-0x0000000189917FA0
	protected override void InitGizmos() {} // 0x0000000181B10140-0x0000000181B101E0
	// [XID] // 0x0000000189AB0BA0-0x0000000189AB0BC0
	protected override void InitFinish() {} // 0x0000000181B10320-0x0000000181B103C0
	// [XID] // 0x0000000189927120-0x0000000189927140
	protected override void UpdateCustomizedBeforeDecision() {} // 0x0000000181B101E0-0x0000000181B10280
	// [XID] // 0x000000018992E8D0-0x000000018992E8F0
	protected override void UpdateAction(float inDeltaTime) {} // 0x0000000181B10090-0x0000000181B10140
	// [XID] // 0x0000000189935B60-0x0000000189935B80
	protected override void UpdateAudio() {} // 0x0000000181B107F0-0x0000000181B10890
	// [XID] // 0x000000018993D800-0x000000018993D820
	protected override void UpdateParamPose() {} // 0x0000000181B10750-0x0000000181B107F0
	// [XID] // 0x0000000189B33090-0x0000000189B330B0
	protected override void UpdateParamAnimator() {} // 0x0000000181B0FFF0-0x0000000181B10090
	// [XID] // 0x000000018994C280-0x000000018994C2A0
	private void InitAutoPlayer() {} // 0x0000000181B11640-0x0000000181B11A40
	// [XID] // 0x00000001899538B0-0x00000001899538D0
	private void FindCloseTarget() {} // 0x0000000181B10C00-0x0000000181B115E0
	// [XID] // 0x000000018995B150-0x000000018995B170
	private void Skill(int index) {} // 0x0000000181B0FDE0-0x0000000181B0FFF0
	// [XID] // 0x0000000189AE4700-0x0000000189AE4720
	private void SkillUp() {} // 0x0000000181B10A60-0x0000000181B10C00
	// [XID] // 0x0000000189ADCFD0-0x0000000189ADCFF0
	private void UpdateAutoPlayerSkill(float inDeltaTime) {} // 0x0000000181B10420-0x0000000181B10690
}

