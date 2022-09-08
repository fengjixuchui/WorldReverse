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

public abstract class VCHeadController : VCBaseHeadController // TypeDefIndex: 11877
{
	// Fields
	public const float NECK_YAW_THRESHOLD = 170f; // Metadata: 0x00AEADA5
	public string defaultHeadName; // 0x1B0
	public string defaultNeckName; // 0x1B8
	public string defaultBodyName; // 0x1C0
	protected Quaternion _targetNeckRot; // 0x1C8
	protected Quaternion _curNeckRot; // 0x1D8
	protected Quaternion _targetHeadRot; // 0x1E8
	protected Quaternion _curHeadRot; // 0x1F8
	protected Transform _neckBoneTrans; // 0x208
	protected Transform _bodyTrans; // 0x210
	protected Transform _headBoneTrans; // 0x218
	protected bool _rotPitch; // 0x220
	protected float _lastDeltaYaw; // 0x224
	protected float _lastYawCheckTime; // 0x228

	// Properties
	public override int metaTypeID { /* [XID] */ /* 0x0000000189873670-0x0000000189873690 */ get; } // 0x00000001830D95B0-0x00000001830D9650 

	// Constructors
	protected VCHeadController() {} // Dummy constructor
	public VCHeadController(ConfigHeadControl config) {} // 0x00000001830D94B0-0x00000001830D95B0

	// Methods
	// [XID] // 0x00000001897512F0-0x0000000189751310
	public override void Init() {} // 0x00000001830D8B30-0x00000001830D8EB0
	// [XID] // 0x000000018987B0C0-0x000000018987B0E0
	public Transform GetHeadTrans() => default; // 0x00000001830D8760-0x00000001830D8810
	// [XID] // 0x00000001897603B0-0x00000001897603D0
	protected override void ClearTargets() {} // 0x00000001830D9130-0x00000001830D9230
	// [XID] // 0x00000001897676E0-0x0000000189767700
	protected override void UpdateTargetDir(float deltaTime) {} // 0x00000001830D8EB0-0x00000001830D9130
	// [XID] // 0x000000018976EDF0-0x000000018976EE10
	protected bool CheckDegree(Vector3 referenceLookDir, Vector3 referenceUpDir, Vector3 bodyLookDir, float weight, float maxWeight, bool lookUp, bool checkLastYaw, ref Quaternion ret) => default; // 0x00000001830D77A0-0x00000001830D7FF0
	// [XID] // 0x00000001897769E0-0x0000000189776A00
	public Vector3 GetDir(Vector3 target) => default; // 0x00000001830D84E0-0x00000001830D8760
	// [XID] // 0x000000018977DE50-0x000000018977DE70
	public Vector3 GetViewPoint(Vector3 dir) => default; // 0x00000001830D8210-0x00000001830D84E0
	// [XID] // 0x00000001898897F0-0x0000000189889810
	public override void SetLookAt(Vector3 dir, Priority priority = Priority.Default /* Metadata: 0x00AEADA0 */, bool pitch = false /* Metadata: 0x00AEADA4 */) {} // 0x00000001830D7FF0-0x00000001830D8210
	// [XID] // 0x0000000189B0FC30-0x0000000189B0FC50
	protected void ForceSetLookAt(Vector3 dir) {} // 0x00000001830D8810-0x00000001830D8960
	// [XID] // 0x0000000189794160-0x0000000189794180
	protected override void ForceLookForward() {} // 0x00000001830D8960-0x00000001830D8A80
	// [XID] // 0x0000000189A91700-0x0000000189A91720
	public bool ControlHeadEnabled() => default; // 0x00000001830D93E0-0x00000001830D94B0
}

