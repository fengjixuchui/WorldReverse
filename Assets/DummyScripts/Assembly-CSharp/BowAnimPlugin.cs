/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class BowAnimPlugin : BaseEquipAnimPlugin // TypeDefIndex: 12039
{
	// Fields
	private string _bowRatioName; // 0x60
	private Vector3 _bowStringLoosePoint; // 0x68
	private float _bowStringMaxLen; // 0x74
	private Transform _hand; // 0x78
	private bool _isDrawing; // 0x80

	// Properties
	public override int metaTypeID { /* [XID] */ /* 0x0000000189B275A0-0x0000000189B275C0 */ get => default; } // 0x00000001831856F0-0x0000000183185790 

	// Constructors
	public BowAnimPlugin() {} // Dummy constructor
	public BowAnimPlugin(VCEquipModel equipModel) {} // 0x0000000183185500-0x00000001831856F0

	// Methods
	// [XID] // 0x0000000189B2E780-0x0000000189B2E7A0
	public override void LateTick(float deltaTime) {} // 0x00000001831850C0-0x00000001831853F0
	// [XID] // 0x0000000189B35E30-0x0000000189B35E50
	private bool CheckHand() => default; // 0x0000000183184E70-0x0000000183185040
	// [XID] // 0x0000000189B3D580-0x0000000189B3D5A0
	public void StartDraw() {} // 0x0000000183185460-0x0000000183185500
	// [XID] // 0x0000000189B453E0-0x0000000189B45400
	public void FinishDraw() {} // 0x0000000183184DD0-0x0000000183184E70
}

