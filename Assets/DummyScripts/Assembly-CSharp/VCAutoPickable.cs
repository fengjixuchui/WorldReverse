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

public class VCAutoPickable : VCBasePickable, IAutoAttract // TypeDefIndex: 11787
{
	// Fields
	public const float DEFAULT_HEIGHT = 0.5f; // Metadata: 0x00AEAB70
	protected const float MIN_DISTANCE = 0.3f; // Metadata: 0x00AEAB74
	protected const float DIRECT_DISTANCE = 10f; // Metadata: 0x00AEAB78
	protected const int CLICK_TIMES = 2; // Metadata: 0x00AEAB7C
	protected const float ATTRACK_SPEED = 10f; // Metadata: 0x00AEAB80
	protected EntityTimer _timer; // 0x190
	protected int _nStageLayerMask; // 0x198
	public float speed; // 0x19C
	public float acceleration; // 0x1A0
	private int _reboundTimes; // 0x1A4
	private float _currentDropHeight; // 0x1A8
	private float _lastDropHeight; // 0x1AC
	private bool _collisionChecked; // 0x1B0
	[NonSerialized]
	public bool actDropAnim; // 0x1B1
	protected float _delaySelectTime; // 0x1B4

	// Properties
	public override int metaTypeID { /* [XID] */ /* 0x00000001896121F0-0x0000000189612210 */ get => default; } // 0x000000018497F320-0x000000018497F3C0 

	// Constructors
	public VCAutoPickable() {} // 0x000000018497F260-0x000000018497F320

	// Methods
	// [XID] // 0x0000000189619B70-0x0000000189619B90
	public override void Init() {} // 0x000000018497E140-0x000000018497E200
	// [XID] // 0x0000000189620FB0-0x0000000189620FD0
	public override void ReInit(BaseEntity.ReInitReason reason) {} // 0x000000018497F0B0-0x000000018497F180
	// [XID] // 0x00000001899E5D60-0x00000001899E5D80
	public override void Clear(BaseEntity.ClearReason clearReason) {} // 0x000000018497D9C0-0x000000018497DA90
	// [XID] // 0x0000000189630070-0x0000000189630090
	public override void Destroy() {} // 0x000000018497DBD0-0x000000018497DC90
	// [XID] // 0x0000000189637D40-0x0000000189637D60
	private void ReleaseAutoPickable() {} // 0x000000018497DA90-0x000000018497DBD0
	// [XID] // 0x000000018963EFB0-0x000000018963EFD0
	private void DestroyTimer() {} // 0x000000018497E470-0x000000018497E550
	// [XID] // 0x000000018985E7D0-0x000000018985E7F0
	private void ResetAutoPickable() {} // 0x000000018497E200-0x000000018497E470
	// [XID] // 0x0000000189B940E0-0x0000000189B94100
	protected virtual void InitGameObject() {} // 0x000000018497D4D0-0x000000018497D730
	// [XID] // 0x00000001899DDFF0-0x00000001899DE010
	private Vector3 FilterDropPos(Vector3 pos) => default; // 0x000000018497D7A0-0x000000018497D9C0
	// [XID] // 0x000000018965D0E0-0x000000018965D100
	protected override Vector3 GetInitVelocity() => default; // 0x000000018497CBF0-0x000000018497D2D0
	// [XID] // 0x0000000189664690-0x00000001896646B0
	private bool CalcCurrentDropHeight(Vector3 pos) => default; // 0x000000018497DC90-0x000000018497DF40
	// [XID] // 0x0000000189AE2A40-0x0000000189AE2A60
	private void TickTimer(float inDeltaTime) {} // 0x000000018497E050-0x000000018497E140
	// [XID] // 0x0000000189673AA0-0x0000000189673AC0
	protected override void Tick(float inDeltaTime) {} // 0x000000018497F180-0x000000018497F260
	// [XID] // 0x0000000189AEA520-0x0000000189AEA540
	protected virtual void TickObject() {} // 0x000000018497ED90-0x000000018497F0B0
	// [XID] // 0x0000000189682AE0-0x0000000189682B00
	private void CheckBarrierCollider(Vector3 pos) {} // 0x000000018497EA60-0x000000018497ED20
	// [XID] // 0x000000018968A6A0-0x000000018968A6C0
	public override void ResetPickComponents(bool forceReset = false /* Metadata: 0x00AEAB6F */) {} // 0x000000018497E8A0-0x000000018497E970
	// [XID] // 0x0000000189669330-0x0000000189669350
	public virtual bool CheckShape(BaseShape3d shape) => default; // 0x000000018497D2D0-0x000000018497D470
	// [XID] // 0x0000000189B16DE0-0x0000000189B16E00
	public virtual bool SetTarget(Vector3 targetPos) => default; // 0x000000018497E5B0-0x000000018497E8A0
	// [XID] // 0x00000001896A0C60-0x00000001896A0C80
	public void Pickup() {} // 0x000000018497C940-0x000000018497CBF0
}

