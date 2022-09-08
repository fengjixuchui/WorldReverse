/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using FullInspector;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class LCGadgetCombat : LCBaseCombat // TypeDefIndex: 11732
{
	// Fields
	protected LCTimer _lcTimer; // 0x1B8

	// Properties
	public override int metaTypeID { /* [XID] */ /* 0x000000018982E2E0-0x000000018982E300 */ get => default; } // 0x000000018507BE60-0x000000018507BF00 
	[NotSerialized] // 0x0000000189845E90-0x0000000189845EA0
	public ConfigGadgetPattern configPattern { /* [XID] */ /* 0x0000000189835A30-0x0000000189835A70 */ get; /* [XID] */ /* 0x000000018983FEA0-0x000000018983FEE0 */ set; } // 0x0000000185078D00-0x0000000185078D60 0x000000018507B000-0x000000018507B070

	// Constructors
	public LCGadgetCombat() {} // 0x000000018507BDE0-0x000000018507BE60

	// Methods
	// [XID] // 0x000000018984A370-0x000000018984A390
	public override void Init() {} // 0x000000018507B070-0x000000018507B1C0
	// [XID] // 0x00000001897A8270-0x00000001897A8290
	public override void ReInit(BaseEntity.ReInitReason reason) {} // 0x000000018507BC80-0x000000018507BDE0
	// [XID] // 0x0000000189859030-0x0000000189859050
	public override void Clear(BaseEntity.ClearReason clearReason) {} // 0x0000000185078710-0x0000000185078850
	// [XID] // 0x0000000189860210-0x0000000189860230
	public override void InitCombatProperty() {} // 0x00000001850785C0-0x0000000185078710
	// [XID] // 0x00000001898678F0-0x0000000189867910
	protected override void DoAttackLanded(EvtAttackLanded evtAttackLanded) {} // 0x000000018507AF40-0x000000018507B000
	// [XID] // 0x000000018986F000-0x000000018986F020
	protected override void RefreshCombatProperty() {} // 0x000000018507B430-0x000000018507BC80
	// [XID] // 0x0000000189876510-0x0000000189876530
	private float ComputeCurveValue(float src, GrowCurveType type, GadgetCurveExcelConfig curve) => default; // 0x0000000185078B10-0x0000000185078D00
	// [XID] // 0x0000000189711600-0x0000000189711620
	public void CopyOwnerPropertyToGadget(CombatProperty combatProperty, CombatPropertyIndex[] propertyList, bool useCreatorBuffedProperty) {} // 0x0000000185078DC0-0x000000018507AEE0
	// [XID] // 0x0000000189885140-0x0000000189885160
	protected void TriggerGadgetAction(ConfigBaseGadgetTriggerAction[] triggerActions, uint collideEntityID) {} // 0x0000000185078850-0x0000000185078990
	// [XID] // 0x000000018988C700-0x000000018988C720
	public virtual ConfigBaseGadgetTriggerAction GetGadgetTriggerAction(int actionIdx) => default; // 0x000000018507B220-0x000000018507B2D0
	// [XID] // 0x0000000189893C70-0x0000000189893C90
	public override void Destroy() {} // 0x0000000185078990-0x0000000185078B10
}

