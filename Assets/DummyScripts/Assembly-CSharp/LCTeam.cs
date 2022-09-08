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

public sealed class LCTeam : LCBase // TypeDefIndex: 11772
{
	// Fields
	private const float BATTLE_TIME = 1f; // Metadata: 0x00AEA7E8
	private EntityTimer _battleTimer; // 0x130
	private bool _tmpInBattle; // 0x138
	public bool playerInBattle; // 0x139
	private bool teamAlive; // 0x13A
	[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
	private MoleMole.SceneSurfaceMaterial curSurfaceMaterial; // 0x13C

	// Properties
	public override int metaTypeID { /* [XID] */ /* 0x0000000189A036E0-0x0000000189A03700 */ get => default; } // 0x00000001838B4DA0-0x00000001838B4E40 

	// Constructors
	public LCTeam() {} // 0x00000001838B4D30-0x00000001838B4DA0

	// Methods
	// [XID] // 0x00000001899CDB20-0x00000001899CDB40
	public MoleMole.SceneSurfaceMaterial GetCurSurfaceMaterial() => default; // 0x00000001838B46C0-0x00000001838B4760
	// [XID] // 0x0000000189A124C0-0x0000000189A124E0
	public override void PreInit() {} // 0x00000001838B49D0-0x00000001838B4C10
	// [XID] // 0x0000000189A198D0-0x0000000189A198F0
	public override void Destroy() {} // 0x00000001838B3D30-0x00000001838B3F60
	// [XID] // 0x0000000189A20F20-0x0000000189A20F40
	protected override void Tick(float inDeltaTime) {} // 0x00000001838B4C10-0x00000001838B4D30
	// [XID] // 0x0000000189A37440-0x0000000189A37460
	private static new EventID[] GetSelfListenEventIDsExcludingBase() => default; // 0x00000001838B4060-0x00000001838B4130
	// [XID] // 0x0000000189A3EB50-0x0000000189A3EB70
	protected override bool ListenEvent(BaseEvent evt) => default; // 0x00000001838B4340-0x00000001838B4650
	// [XID] // 0x0000000189A4D970-0x0000000189A4D990
	private void AvatarInBattle(bool inBattle) {} // 0x00000001838B3C00-0x00000001838B3D30
	// [XID] // 0x0000000189A01980-0x0000000189A019A0
	private void CheckBattleState() {} // 0x00000001838B3B00-0x00000001838B3C00
	// [XID] // 0x0000000189A55230-0x0000000189A55250
	private void CheckTeamAlive() {} // 0x00000001838B4850-0x00000001838B49D0
	// [XID] // 0x0000000189A10940-0x0000000189A10960
	private void CheckTeamTransmit() {} // 0x00000001838B4760-0x00000001838B4850
	// [XID] // 0x0000000189A17F90-0x0000000189A17FB0
	public void EnterSurface(MoleMole.SceneSurfaceMaterial surfaceMaterial) {} // 0x00000001838B3A30-0x00000001838B3B00
	// [XID] // 0x0000000189A1F590-0x0000000189A1F5B0
	private void OnCurSurfaceChanged(MoleMole.SceneSurfaceMaterial surfaceMaterial) {} // 0x00000001838B4130-0x00000001838B4280
}

