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

public abstract class LCForceFieldBase : LCBase // TypeDefIndex: 11729
{
	// Fields
	public ConfigForceField config; // 0x130
	protected Vector3 _vel; // 0x138
	protected VCHumanoidMove _vcMove; // 0x148
	protected LCTrigger _lcTirgger; // 0x150

	// Properties
	public override int metaTypeID { /* [XID] */ /* 0x00000001898A5AD0-0x00000001898A5AF0 */ get; } // 0x0000000184FCF5A0-0x0000000184FCF640 

	// Constructors
	protected LCForceFieldBase() {} // 0x0000000184FCF540-0x0000000184FCF5A0

	// Methods
	// [XID] // 0x00000001897A3A70-0x00000001897A3A90
	public override void Init() {} // 0x0000000184FCF190-0x0000000184FCF370
	// [XID] // 0x00000001897AAE60-0x00000001897AAE80
	protected static new EventID[] GetSelfOnEventIDsExcludingBase() => default; // 0x0000000184FCF0B0-0x0000000184FCF190
	// [XID] // 0x00000001897B2AB0-0x00000001897B2AD0
	protected override bool OnEvent(BaseEvent e) => default; // 0x0000000184FCF460-0x0000000184FCF540
	// [XID] // 0x00000001897BA580-0x00000001897BA5A0
	protected virtual void OnFieldEnter(BaseEntity other) {} // 0x0000000184FCEF10-0x0000000184FCEFC0
	// [XID] // 0x00000001897C2460-0x00000001897C2480
	protected virtual void OnFieldExit(BaseEntity other) {} // 0x0000000184FCEE60-0x0000000184FCEF10
	// [XID] // 0x00000001897C9C40-0x00000001897C9C60
	public static bool CheckEntity(BaseEntity other) => default; // 0x0000000184FCEFC0-0x0000000184FCF0B0
}

