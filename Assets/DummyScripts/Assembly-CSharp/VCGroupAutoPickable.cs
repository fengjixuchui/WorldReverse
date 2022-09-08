/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class VCGroupAutoPickable : VCAutoPickable // TypeDefIndex: 11876
{
	// Fields
	private const int MAX_GAMEOBJECT_NUM = 50; // Metadata: 0x00AEAD98
	private static int _curGameObjCount; // 0x00
	private const float LIMIT_UNDER_HEIGHT = 3f; // Metadata: 0x00AEAD9C
	private List<GroupItemInfo> _groupItemInfos; // 0x1B8
	private int _realItemCount; // 0x1C0
	private GameObject _originalObj; // 0x1C8
	private Vector3 _bornPos; // 0x1D0
	private int _groupNum; // 0x1DC
	private int _attractCount; // 0x1E0
	private float _lifeSpan; // 0x1E4
	private Vector3 _targetPos; // 0x1E8

	// Properties
	public override int metaTypeID { /* [XID] */ /* 0x0000000189797690-0x00000001897976B0 */ get => default; } // 0x00000001850DED60-0x00000001850DEE00 

	// Constructors
	public VCGroupAutoPickable() {} // 0x00000001850DECC0-0x00000001850DED60
	static VCGroupAutoPickable() {} // 0x00000001850DEC60-0x00000001850DECC0

	// Methods
	// [XID] // 0x00000001896BC900-0x00000001896BC920
	public override void Init() {} // 0x00000001850DD110-0x00000001850DD1D0
	// [XID] // 0x00000001896C3E60-0x00000001896C3E80
	public override void Destroy() {} // 0x00000001850DC280-0x00000001850DC330
	// [XID] // 0x00000001897C5850-0x00000001897C5870
	protected override void InitGameObject() {} // 0x00000001850DBA00-0x00000001850DBDE0
	// [XID] // 0x00000001897E3730-0x00000001897E3750
	private void InitRigidbodyVelocity(int i) {} // 0x00000001850DC890-0x00000001850DCB80
	// [XID] // 0x00000001897EAEA0-0x00000001897EAEC0
	private void InitObjects() {} // 0x00000001850DDFF0-0x00000001850DE170
	// [XID] // 0x00000001896E19E0-0x00000001896E1A00
	private bool IsGhostValid() => default; // 0x00000001850DC7A0-0x00000001850DC890
	// [XID] // 0x00000001897F2BB0-0x00000001897F2BD0
	private void LoadFinishCB(ulong pathHash, bool loadSucceeded, uint handle, GameObject obj) {} // 0x00000001850DD970-0x00000001850DDFF0
	// [XID] // 0x000000018982E420-0x000000018982E440
	protected override Vector3 GetInitVelocity() => default; // 0x00000001850DADA0-0x00000001850DB770
	// [XID] // 0x00000001897B63D0-0x00000001897B63F0
	private bool CalcCurrentDropHeight(Vector3 pos, int index) => default; // 0x00000001850DC330-0x00000001850DC620
	// [XID] // 0x00000001896FF4F0-0x00000001896FF510
	private void CheckBarrierCollider(Vector3 pos, int index) {} // 0x00000001850DE4B0-0x00000001850DE770
	// [XID] // 0x000000018981F770-0x000000018981F790
	private void DebugCheck(float deltaTime) {} // 0x00000001850DCF00-0x00000001850DD110
	// [XID] // 0x000000018970E190-0x000000018970E1B0
	protected override void TickObject() {} // 0x00000001850DE770-0x00000001850DEC60
	// [XID] // 0x00000001897155B0-0x00000001897155D0
	protected override void UpdateHeight() {} // 0x00000001850DCB80-0x00000001850DCF00
	// [XID] // 0x00000001897A6B40-0x00000001897A6B60
	private void ClearAllObjs() {} // 0x00000001850DE170-0x00000001850DE3E0
	// [XID] // 0x0000000189826D70-0x0000000189826D90
	private float GetDistance(Vector3 targetPos) => default; // 0x00000001850DBFF0-0x00000001850DC280
	// [XID] // 0x000000018972BBC0-0x000000018972BBE0
	private bool IsAutoPickable() => default; // 0x00000001850DC6B0-0x00000001850DC7A0
	// [XID] // 0x0000000189BCE390-0x0000000189BCE3B0
	public override bool CheckShape(BaseShape3d shape) => default; // 0x00000001850DB770-0x00000001850DB9A0
	// [XID] // 0x000000018973ABD0-0x000000018973ABF0
	private void CheckStopGravity(Rigidbody rigidbody, Vector3 pos, Vector3 targetPos) {} // 0x00000001850DBE40-0x00000001850DBFF0
	// [XID] // 0x0000000189742380-0x00000001897423A0
	public override bool SetTarget(Vector3 targetPos) => default; // 0x00000001850DD320-0x00000001850DD970
}

