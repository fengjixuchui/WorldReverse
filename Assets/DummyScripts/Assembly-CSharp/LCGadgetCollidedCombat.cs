/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using FullInspector;
using IFix.Core;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class LCGadgetCollidedCombat : LCGadgetCombat // TypeDefIndex: 11731
{
	// Fields
	private VCCollision _collisionComponent; // 0x1C0
	private Collider _thisCollider; // 0x1C8

	// Properties
	public override int metaTypeID { /* [XID] */ /* 0x00000001897E05C0-0x00000001897E05E0 */ get => default; } // 0x0000000182EDDF80-0x0000000182EDE020 
	[NotSerialized] // 0x0000000189845E90-0x0000000189845EA0
	public ConfigGadgetCollidedPattern gadgetPatternConfig { /* [XID] */ /* 0x00000001897E7CB0-0x00000001897E7CD0 */ get => default; } // 0x0000000182EDD680-0x0000000182EDD740 

	// Constructors
	public LCGadgetCollidedCombat() {} // 0x0000000182EDDF10-0x0000000182EDDF80

	// Methods
	// [XID] // 0x0000000189928A70-0x0000000189928A90
	public override void Init() {} // 0x0000000182EDD740-0x0000000182EDD980
	// [XID] // 0x000000018968A7E0-0x000000018968A800
	public override void ReInit(BaseEntity.ReInitReason reason) {} // 0x0000000182EDDDF0-0x0000000182EDDF10
	// [XID] // 0x00000001897FE560-0x00000001897FE580
	public override void Clear(BaseEntity.ClearReason clearReason) {} // 0x0000000182EDCFE0-0x0000000182EDD100
	// [XID] // 0x0000000189805C90-0x0000000189805CB0
	public override void Destroy() {} // 0x0000000182EDD100-0x0000000182EDD230
	// [XID] // 0x000000018980D500-0x000000018980D520
	private void OnTriggerEnter(Collider collider) {} // 0x0000000182EDD230-0x0000000182EDD600
	// [XID] // 0x0000000189814B70-0x0000000189814B90
	public override ConfigBaseGadgetTriggerAction GetGadgetTriggerAction(int actionIdx) => default; // 0x0000000182EDD9E0-0x0000000182EDDD10
}

