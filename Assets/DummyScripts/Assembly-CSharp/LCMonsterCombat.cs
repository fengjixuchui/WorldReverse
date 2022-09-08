/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class LCMonsterCombat : LCCharacterCombat // TypeDefIndex: 11748
{
	// Fields
	public bool isElite; // 0x1B8
	public List<uint> affixList; // 0x1C0

	// Properties
	public override int metaTypeID { /* [XID] */ /* 0x00000001896FF530-0x00000001896FF550 */ get => default; } // 0x0000000182A815F0-0x0000000182A81690 
	public override bool isInCombat { /* [XID] */ /* 0x00000001897068E0-0x0000000189706900 */ get => default; } // 0x0000000182A80790-0x0000000182A80860 

	// Constructors
	public LCMonsterCombat() {} // 0x0000000182A81580-0x0000000182A815F0

	// Methods
	// [XID] // 0x000000018970E1B0-0x000000018970E1D0
	private float ComputeFinalValue(float src, FightPropType type, MonsterExcelConfig config, MonsterCurveExcelConfig curve) => default; // 0x0000000182A805E0-0x0000000182A80790
	// [XID] // 0x00000001896B6E70-0x00000001896B6E90
	private float ComputeCurveValue(float src, GrowCurveType type, MonsterCurveExcelConfig curve) => default; // 0x0000000182A803F0-0x0000000182A805E0
	// [XID] // 0x00000001896C5890-0x00000001896C58B0
	protected override void RefreshCombatProperty() {} // 0x0000000182A81220-0x0000000182A812C0
	// [XID] // 0x00000001896CCF40-0x00000001896CCF60
	private void RefreshCombatPropertyLocal() {} // 0x0000000182A7F710-0x0000000182A803F0
	// [XID] // 0x000000018972BBE0-0x000000018972BC00
	protected override void ChangeLevel(int level, DataPropOp state = DataPropOp.Change /* Metadata: 0x00AEA788 */) {} // 0x0000000182A7F1A0-0x0000000182A7F470
	// [XID] // 0x000000018982FB30-0x000000018982FB50
	protected override void ChangeMaxHP(float maxHP) {} // 0x0000000182A80B60-0x0000000182A80E20
	// [XID] // 0x000000018973ABF0-0x000000018973AC10
	protected override void ChangeHP(float newHP) {} // 0x0000000182A812C0-0x0000000182A81580
	// [XID] // 0x000000018983E890-0x000000018983E8B0
	public override void UpdateCombatProp(FightPropType type, float value, DataPropOp state = DataPropOp.Change /* Metadata: 0x00AEA78C */) {} // 0x0000000182A7F470-0x0000000182A7F710
	// [XID] // 0x0000000189749FB0-0x0000000189749FD0
	public override void DoKill(uint killerID, DieStateFlag dieType) {} // 0x0000000182A80E20-0x0000000182A81140
}

