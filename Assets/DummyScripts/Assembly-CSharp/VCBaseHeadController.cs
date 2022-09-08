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

public abstract class VCBaseHeadController : VCBase // TypeDefIndex: 11813
{
	// Fields
	public bool openLog; // 0x108
	protected ConfigHeadControl _config; // 0x110
	public bool enableMaxDegree; // 0x118
	private float _maxYawDegree; // 0x11C
	private float _maxPitchDegree; // 0x120
	public float spring; // 0x124
	public float weightSpeed; // 0x128
	protected float _enableCtrlWeight; // 0x12C
	protected float _disableCtrlWeight; // 0x130
	protected TargetData _curTarget; // 0x138
	protected Transform _root; // 0x168
	protected Vector3 _targetDir; // 0x170
	protected bool _ctrlHead; // 0x17C
	protected Priority _ctrlPriority; // 0x180
	protected float _ctrlWeight; // 0x184
	protected float _ctrlSpeed; // 0x188
	protected Priority _priority; // 0x18C
	private bool _useWhiteAnimState; // 0x190
	private List<int> _useHeadControlAnimStateIDs; // 0x198
	private List<int> _dontUseHeadControlAnimStateIDs; // 0x1A0
	protected bool _isAnimStateValid; // 0x1A8

	// Properties
	public override int metaTypeID { /* [XID] */ /* 0x00000001899F5F20-0x00000001899F5F40 */ get; } // 0x000000018237B5E0-0x000000018237B680 
	public float maxYawDegree { /* [XID] */ /* 0x00000001899FD650-0x00000001899FD670 */ get; /* [XID] */ /* 0x0000000189968990-0x00000001899689B0 */ set; } // 0x0000000182379090-0x0000000182379150 0x0000000182378FE0-0x0000000182379090
	public float maxPitchDegree { /* [XID] */ /* 0x000000018996FF80-0x000000018996FFA0 */ get; /* [XID] */ /* 0x0000000189977DE0-0x0000000189977E00 */ set; } // 0x0000000182378D30-0x0000000182378DF0 0x000000018237AA90-0x000000018237AB40

	// Nested types
	public enum TargetType // TypeDefIndex: 11814
	{
		Action = 0,
		Attack = 1,
		Enemy = 2,
		Item = 3,
		Npc = 4,
		Max = 5
	}

	public enum Priority // TypeDefIndex: 11815
	{
		Default = 0,
		Target = 1,
		Force = 2
	}

	protected struct TargetData // TypeDefIndex: 11816
	{
		// Fields
		public TargetType type; // 0x00
		private EntityHandle<BaseEntity> _entityHandle; // 0x08
		public Transform lockPoint; // 0x18
		public float deleteTime; // 0x20
		public float lineCheckTime; // 0x24
		public bool lastlineCheck; // 0x28
		public bool enabled; // 0x29

		// Properties
		public BaseEntity entity { /* [XID] */ /* 0x0000000189A2B0A0-0x0000000189A2B0C0 */ get => default; /* [XID] */ /* 0x0000000189AB5130-0x0000000189AB5150 */ set {} } // 0x00000001823A2B10-0x00000001823A2BD0 0x00000001823A24C0-0x00000001823A2620

		// Constructors
		public TargetData(BaseEntity entity, TargetType type, Transform lockPoint) : this() {
			this.type = default;
			_entityHandle = default;
			this.lockPoint = default;
			deleteTime = default;
			lineCheckTime = default;
			lastlineCheck = default;
			enabled = default;
		} // 0x00000001823A2BD0-0x00000001823A2C00

		// Methods
		// [XID] // 0x0000000189913920-0x0000000189913940
		public Vector3 GetPosition() => default; // 0x00000001823A23C0-0x00000001823A24C0
		// [XID] // 0x0000000189A41940-0x0000000189A41960
		public static bool operator ==(TargetData lhs, TargetData rhs) => default; // 0x00000001823A2800-0x00000001823A2920
		// [XID] // 0x0000000189B116C0-0x0000000189B116E0
		public static bool operator !=(TargetData lhs, TargetData rhs) => default; // 0x00000001823A2920-0x00000001823A2B10
		// [XID] // 0x000000018985E760-0x000000018985E780
		public override bool Equals(object obj) => default; // 0x00000001823A2620-0x00000001823A2720
		// [XID] // 0x0000000189A55150-0x0000000189A55170
		public override int GetHashCode() => default; // 0x00000001823A2720-0x00000001823A27F0
	}

	// Constructors
	protected VCBaseHeadController() {} // Dummy constructor
	protected VCBaseHeadController(ConfigHeadControl config) {} // 0x000000018237B4A0-0x000000018237B5E0

	// Methods
	// [XID] // 0x000000018997EF90-0x000000018997EFB0
	public virtual void SetCurTarget(BaseEntity entity) {} // 0x000000018237AFF0-0x000000018237B0A0
	// [XID] // 0x00000001899868D0-0x00000001899868F0
	public override void Init() {} // 0x0000000182379DA0-0x000000018237A170
	// [XID] // 0x0000000189A3D090-0x0000000189A3D0B0
	protected Transform FindTransform(Transform root, string name, ref List<Transform> tfArray) => default; // 0x000000018237A410-0x000000018237A6F0
	// [XID] // 0x0000000189995FE0-0x0000000189996000
	public override void Destroy() {} // 0x00000001823794D0-0x00000001823795E0
	// [XID] // 0x0000000189AAD860-0x0000000189AAD880
	protected virtual void ClearTargets() {} // 0x000000018237A220-0x000000018237A2D0
	// [XID] // 0x0000000189A0C370-0x0000000189A0C390
	public override void OnDisable() {} // 0x000000018237B3E0-0x000000018237B4A0
	// [XID] // 0x00000001899ACD70-0x00000001899ACD90
	public virtual void AddTarget(BaseEntity targetEntity, Transform lockPoint, TargetType type, bool target) {} // 0x0000000182378F00-0x0000000182378FE0
	// [XID] // 0x00000001899B45B0-0x00000001899B45D0
	protected virtual void UpdateTarget() {} // 0x0000000182379640-0x00000001823796E0
	// [XID] // 0x00000001899BBA50-0x00000001899BBA70
	protected virtual bool CheckTarget(ref TargetData target) => default; // 0x000000018237A750-0x000000018237A800
	// [XID] // 0x00000001899C3670-0x00000001899C3690
	protected virtual void UpdateTargetDir(float deltaTime) {} // 0x000000018237A170-0x000000018237A220
	// [XID] // 0x0000000189A2FA50-0x0000000189A2FA70
	protected float AngleAroundAxis(Vector3 dirA, Vector3 dirB, Vector3 axis) => default; // 0x000000018237ABB0-0x000000018237AEB0
	// [XID] // 0x0000000189A37420-0x0000000189A37440
	protected Quaternion QuatWeight(Quaternion q, float w) => default; // 0x000000018237AEB0-0x000000018237AFF0
	// [XID] // 0x00000001899D9880-0x00000001899D98A0
	public virtual void SetLookAt(Vector3 dir, Priority priority = Priority.Default /* Metadata: 0x00AEAC11 */, bool pitch = false /* Metadata: 0x00AEAC15 */) {} // 0x0000000182378DF0-0x0000000182378F00
	// [XID] // 0x00000001899E0E70-0x00000001899E0E90
	protected virtual Vector3 GetLookAtPoint(ref TargetData target) => default; // 0x00000001823796E0-0x0000000182379AF0
	// [XID] // 0x0000000189AE2A20-0x0000000189AE2A40
	private float GetHightOffset(BaseEntity entity) => default; // 0x000000018237B0A0-0x000000018237B180
	// [XID] // 0x00000001899F0160-0x00000001899F0180
	protected Vector3 LerpVector3(float deltaTime, Vector3 v1, Vector3 v2, float angleSpeed) => default; // 0x000000018237B180-0x000000018237B3E0
	// [XID] // 0x00000001899F7760-0x00000001899F7780
	protected Quaternion LerpRotation(float deltaTime, Quaternion r1, Quaternion r2, float speed) => default; // 0x0000000182379AF0-0x0000000182379D00
	// [XID] // 0x0000000189A4D930-0x0000000189A4D950
	protected float LerpParam(float deltaTime, float p1, float p2, float speed) => default; // 0x0000000182379150-0x0000000182379280
	// [XID] // 0x0000000189A066C0-0x0000000189A066E0
	protected bool IsAnimStateValid(int shortNameHash) => default; // 0x0000000182378BD0-0x0000000182378CD0
	// [XID] // 0x0000000189A0DBC0-0x0000000189A0DBE0
	protected virtual void OnAnimatorStateChanged(EvtAnimatorStateChanged evt) {} // 0x000000018237A2D0-0x000000018237A410
	// [XID] // 0x0000000189A2E1A0-0x0000000189A2E1C0
	public void EnableHeadControl(bool enabled, Priority priority = Priority.Default /* Metadata: 0x00AEAC16 */, bool blend = true /* Metadata: 0x00AEAC1A */) {} // 0x0000000182379280-0x00000001823794D0
	// [XID] // 0x0000000189A1C410-0x0000000189A1C430
	protected virtual void ForceLookForward() {} // 0x0000000182379D00-0x0000000182379DA0
	// [XID] // 0x00000001898E6450-0x00000001898E6470
	protected bool CheckTargetForward(ref TargetData target) => default; // 0x000000018237A800-0x000000018237AA90
}

