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

public sealed class LCAvatarAutoPickup : LCBase // TypeDefIndex: 11698
{
	// Fields
	private EntityTimer _timer; // 0x130
	public float checkCD; // 0x138
	private float _nextCheckTime; // 0x13C
	private SimpleSphere _inShape; // 0x140
	private Transform _attractTrans; // 0x148
	private SliceFrameWatch _addPickWatcher; // 0x150
	private int curEntityIndex; // 0x158
	private bool isChecking; // 0x15C
	private int curCheckEntityIndex; // 0x160
	private float _pickRadiusDelta; // 0x164

	// Properties
	public override int metaTypeID { /* [XID] */ /* 0x000000018963C2E0-0x000000018963C300 */ get => default; } // 0x00000001822388A0-0x0000000182238940 
	public EntityTimer Timer { /* [XID] */ /* 0x0000000189643A20-0x0000000189643A40 */ get => default; /* [XID] */ /* 0x0000000189BB1A80-0x0000000189BB1AA0 */ set {} } // 0x00000001822381D0-0x0000000182238280 0x0000000182237CE0-0x0000000182237D90

	// Constructors
	public LCAvatarAutoPickup() {} // 0x00000001822387E0-0x00000001822388A0

	// Methods
	// [XID] // 0x00000001899D3A40-0x00000001899D3A60
	public override void Init() {} // 0x0000000182237E10-0x0000000182238170
	// [XID] // 0x00000001899DB000-0x00000001899DB020
	public override void Destroy() {} // 0x0000000182237BF0-0x0000000182237CE0
	// [XID] // 0x00000001895F13A0-0x00000001895F13C0
	protected override void Tick(float inDeltaTime) {} // 0x0000000182238600-0x00000001822387E0
	// [XID] // 0x0000000189607980-0x00000001896079A0
	private void UpdateShape() {} // 0x00000001822376D0-0x0000000182237830
	// [XID] // 0x00000001899F1550-0x00000001899F1570
	private bool CheckInShape() => default; // 0x0000000182237830-0x0000000182237BF0
	// [XID] // 0x00000001899F8DD0-0x00000001899F8DF0
	private void UpdateAutoAttractItem() {} // 0x0000000182238280-0x0000000182238590
	// [XID] // 0x0000000189A003D0-0x0000000189A003F0
	private void OnPickRadiusChanged() {} // 0x0000000182237590-0x00000001822376D0
}

