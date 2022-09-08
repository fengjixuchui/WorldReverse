/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text.RegularExpressions;
using IFix.Core;
using MoleMole;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class SkillLevelUpDialogContext : BaseDialogContext // TypeDefIndex: 29300
{
	// Fields
	private Regex skillPropRegex; // 0x178
	private MonoSkillLevelUpDialog _dialogMono; // 0x180
	private uint _skillId; // 0x188
	private bool _isCombatSkill; // 0x18C
	private bool _isEnergySkill; // 0x18D
	private uint _oldLevel; // 0x190
	private uint _curLevel; // 0x194
	private bool _haveExtraLevel; // 0x198
	private List<SkillPropStruct> _propChangeList; // 0x1A0

	// Nested types
	public struct SkillPropStruct // TypeDefIndex: 29301
	{
		// Fields
		public string name; // 0x00
		public string desc; // 0x08
		public string oldDesc; // 0x10
		public bool isChanged; // 0x18
		public bool isUnlock; // 0x19
	}

	// Constructors
	public SkillLevelUpDialogContext() {} // Dummy constructor
	public SkillLevelUpDialogContext(uint proudSkillId, bool haveExtraLevel) {} // 0x0000000182AF3660-0x0000000182AF37A0
	public SkillLevelUpDialogContext(uint skillId, uint oldLevel, uint curLevel, bool isEnergySkill, bool haveExtraLevel) {} // 0x0000000182AF3500-0x0000000182AF3660

	// Methods
	// [XID] // 0x00000001896EF3B0-0x00000001896EF3D0
	public override void SetupView() {} // 0x0000000182AF3420-0x0000000182AF3500
	// [XID] // 0x00000001896F6D80-0x00000001896F6DA0
	protected override void BindViewCallbacks() {} // 0x0000000182AF2350-0x0000000182AF2470
	// [XID] // 0x00000001896FE690-0x00000001896FE6B0
	private void SetSkillLevelUpView() {} // 0x0000000182AF1E50-0x0000000182AF2350
	// [XID] // 0x00000001897057C0-0x00000001897057E0
	private void RefreshSkillProps(ProudSkillExcelConfig postSkillConfig) {} // 0x0000000182AF2470-0x0000000182AF27B0
	// [XID] // 0x000000018970D300-0x000000018970D320
	private void RefreshSkillPropItem(Transform trans, int index) {} // 0x0000000182AF3030-0x0000000182AF3420
	// [XID] // 0x00000001897147A0-0x00000001897147C0
	private SkillPropStruct GetSkillPropDescStruct(string desc, ProudSkillExcelConfig proudSkillConfig) => default; // 0x0000000182AF2810-0x0000000182AF2FD0
}

