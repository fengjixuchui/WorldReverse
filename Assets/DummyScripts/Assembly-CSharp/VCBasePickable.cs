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

public class VCBasePickable : VCBase // TypeDefIndex: 11826
{
	// Fields
	public bool isLocalObj; // 0x108
	public GadgetBornType bornType; // 0x10C
	public bool isStatic; // 0x110
	protected Rigidbody _rigidbody; // 0x118
	private bool _hasRigidbody; // 0x120
	private bool _origGravity; // 0x121
	private CollisionDetectionMode _origCCDMode; // 0x124
	private bool _origKinematic; // 0x128
	protected Collider _collider; // 0x130
	private int _origColLayer; // 0x138
	private bool _origColEnable; // 0x13C
	private bool _hasCollider; // 0x13D
	protected PickableState _state; // 0x140
	protected bool _isControlled; // 0x144
	protected float selfRotateSpeed; // 0x148
	private float _selfRotation; // 0x14C
	protected bool isSuspend; // 0x150
	private Vector3 originalSuspendPos; // 0x154
	private float curSelfSuspendLen; // 0x160
	protected Transform parentTrans; // 0x168
	protected ConfigPickup _pickupConfig; // 0x170
	protected bool _isForbidGuest; // 0x178
	protected float _checkValidPosInterval; // 0x17C
	protected float MaxValidPosInterval; // 0x180
	protected bool _hasInitComponents; // 0x184
	private const float fixDynamicFriction = 0.45f; // Metadata: 0x00AEAC7C
	private const float fixStaticFriction = 0.45f; // Metadata: 0x00AEAC80
	private const float scaleColliderRatio = 0.7f; // Metadata: 0x00AEAC84
	private int _attachedBornEffect; // 0x188
	private int _attachedDropEffect; // 0x18C
	private const float LimitSpeed = 50f; // Metadata: 0x00AEAC88
	private const float LimitHeight = -1000f; // Metadata: 0x00AEAC8C

	// Properties
	public override int metaTypeID { /* [XID] */ /* 0x0000000189673A80-0x0000000189673AA0 */ get => default; } // 0x0000000184023C90-0x0000000184023D30 
	public bool isForbidGuest { /* [XID] */ /* 0x000000018967B180-0x000000018967B1A0 */ get => default; } // 0x0000000184020980-0x0000000184020A30 

	// Nested types
	protected enum PickableState // TypeDefIndex: 11827
	{
		None = 0,
		Static = 1,
		Dynamic = 2,
		ForceToStop = 3,
		PreDestroy = 4,
		Destroy = 5,
		Attract = 6
	}

	// Constructors
	public VCBasePickable() {} // 0x0000000184023B50-0x0000000184023C90

	// Methods
	// [XID] // 0x0000000189B77EA0-0x0000000189B77EC0
	public override void PreInit() {} // 0x0000000184023840-0x0000000184023990
	// [XID] // 0x0000000189B87090-0x0000000189B870B0
	public void InitRigidbody(BaseEntity e) {} // 0x0000000184023770-0x0000000184023840
	// [XID] // 0x0000000189692390-0x00000001896923B0
	public override void Init() {} // 0x0000000184022290-0x0000000184022470
	// [XID] // 0x00000001896997F0-0x0000000189699810
	public override void ReInit(BaseEntity.ReInitReason reason) {} // 0x0000000184023990-0x0000000184023B50
	// [XID] // 0x00000001896A0C20-0x00000001896A0C40
	public override void Clear(BaseEntity.ClearReason clearReason) {} // 0x0000000184020750-0x00000001840208C0
	// [XID] // 0x000000018962A1A0-0x000000018962A1C0
	public override void Destroy() {} // 0x0000000184020A30-0x0000000184020B90
	// [XID] // 0x00000001896A3DD0-0x00000001896A3DF0
	private void DestroyComponent() {} // 0x0000000184022730-0x0000000184022890
	// [XID] // 0x0000000189B7F440-0x0000000189B7F460
	private void InitConfig() {} // 0x0000000184022DF0-0x0000000184022F20
	// [XID] // 0x00000001896BDE20-0x00000001896BDE40
	public override void OnEntityReady() {} // 0x00000001840234A0-0x0000000184023560
	// [XID] // 0x00000001896C5730-0x00000001896C5750
	protected virtual Vector3 GetInitVelocity() => default; // 0x000000018401F9E0-0x000000018401FAF0
	// [XID] // 0x00000001896CCD80-0x00000001896CCDA0
	protected virtual Vector3 GetInitAngularVelocity() => default; // 0x0000000184021AC0-0x0000000184021BD0
	// [XID] // 0x0000000189789E90-0x0000000189789EB0
	protected virtual Transform GetDropTransform() => default; // 0x0000000184020400-0x0000000184020610
	// [XID] // 0x00000001896DB920-0x00000001896DB940
	protected bool IsLocalObj() => default; // 0x0000000184020340-0x0000000184020400
	// [XID] // 0x00000001897D4610-0x00000001897D4630
	protected void CreateRigidbody() {} // 0x000000018401FAF0-0x000000018401FE30
	// [XID] // 0x00000001896EA680-0x00000001896EA6A0
	public Rigidbody GetRigidbody() => default; // 0x00000001840213E0-0x0000000184021490
	// [XID] // 0x00000001896F1670-0x00000001896F1690
	protected void RemoveRigidbody() {} // 0x0000000184023170-0x0000000184023300
	// [XID] // 0x00000001896F9040-0x00000001896F9060
	protected void RemoveCollider() {} // 0x0000000184021540-0x00000001840216E0
	// [XID] // 0x0000000189700A50-0x0000000189700A70
	protected void InitCollider() {} // 0x0000000184020B90-0x00000001840213E0
	// [XID] // 0x00000001897080C0-0x00000001897080E0
	protected virtual void InitPickComponents() {} // 0x0000000184021490-0x0000000184021540
	// [XID] // 0x00000001897CCF60-0x00000001897CCF80
	public virtual void ResetPickComponents(bool forceReset = false /* Metadata: 0x00AEAC7B */) {} // 0x0000000184022D10-0x0000000184022DF0
	// [XID] // 0x0000000189716D30-0x0000000189716D50
	public virtual void ControlPickComponents() {} // 0x00000001840219F0-0x0000000184021AC0
	// [XID] // 0x000000018969C830-0x000000018969C850
	protected virtual void RemovePickableComponents() {} // 0x00000001840230C0-0x0000000184023170
	// [XID] // 0x00000001896725F0-0x0000000189672610
	public virtual void OnSceneLoad() {} // 0x00000001840217C0-0x00000001840219F0
	// [XID] // 0x000000018972D470-0x000000018972D490
	protected void PlayBornEffect() {} // 0x0000000184022950-0x0000000184022D10
	// [XID] // 0x00000001896679E0-0x0000000189667A00
	protected void DetachBornEffect() {} // 0x0000000184020680-0x0000000184020750
	// [XID] // 0x0000000189BAE520-0x0000000189BAE540
	protected void PlayDropEffect() {} // 0x000000018401FE90-0x0000000184020340
	// [XID] // 0x0000000189743C60-0x0000000189743C80
	protected void DetachDropEffect() {} // 0x00000001840233D0-0x00000001840234A0
	// [XID] // 0x000000018974B7F0-0x000000018974B810
	protected void PlayScanEffect() {} // 0x00000001840208C0-0x0000000184020980
	// [XID] // 0x0000000189752BF0-0x0000000189752C10
	private void EnableScanEffect(bool enable) {} // 0x0000000184023660-0x0000000184023770
	// [XID] // 0x0000000189AF1F30-0x0000000189AF1F50
	protected virtual void UpdateHeight() {} // 0x0000000184021EE0-0x0000000184022290
	// [XID] // 0x0000000189696C10-0x0000000189696C30
	protected virtual void UpdateRotation() {} // 0x0000000184021BD0-0x0000000184021EE0
	// [XID] // 0x0000000189769070-0x0000000189769090
	protected float GetDeltaTime() => default; // 0x0000000184022F20-0x0000000184022FD0
	// [XID] // 0x0000000189770790-0x00000001897707B0
	protected virtual void CheckValidPos(float inDeltaTime) {} // 0x0000000184022470-0x0000000184022730
	// [XID] // 0x0000000189777F30-0x0000000189777F50
	protected static new EventID[] GetSelfOnEventIDsExcludingBase() => default; // 0x00000001840216E0-0x00000001840217C0
	// [XID] // 0x000000018977F4A0-0x000000018977F4C0
	protected override bool OnEvent(BaseEvent e) => default; // 0x0000000184023560-0x0000000184023660
}

