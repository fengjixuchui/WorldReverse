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

public class AirRigidbody // TypeDefIndex: 32184
{
	// Fields
	private const float TOWARD_DUMMY_MAX_VELOCITY = 3f; // Metadata: 0x00B1423D
	private const float MAX_ALLOWED_AIR_SPEED_DOWN = 30f; // Metadata: 0x00B14241
	private const float MAX_ALLOWED_AIR_SPEED_XZ = 30f; // Metadata: 0x00B14245
	public const float MIN_VALID_TIME_SCALE = 0.2f; // Metadata: 0x00B14249
	private const float NO_STANDY_HORIZONTAL_GROUND_MIN_XZ_VELCITY = 1f; // Metadata: 0x00B1424D
	private Rigidbody _rigidbody; // 0x10
	private Rigidbody _dummyRigidbody; // 0x18
	private VCHumanoidMove _vcHumanoidMove; // 0x20
	private VCHumanoidMoveData _moveData; // 0x28
	private Transform _transform; // 0x30
	private Transform _dummyRigidbodyTrans; // 0x38
	private float _lastEntityTimeScale; // 0x40
	private Vector3 _lastUnscaledVelocity; // 0x44
	private VCMoveCollider _moveCollider; // 0x50
	private bool _ignoreDummy; // 0x58
	private bool _groundNoStandAndHorizontal; // 0x59
	public bool dummyRigidbodyFirstSet; // 0x5A
	private const int MAX_DOWN_SPEED_FRAME = 3; // Metadata: 0x00B14251
	private int _maxDownSpeedIndex; // 0x5C
	private float[] _maxDownSpeedQueue; // 0x60
	public float _maxDownSpeed; // 0x68

	// Properties
	public float maxDownSpeed { /* [XID] */ /* 0x0000000189A9BF20-0x0000000189A9BF40 */ get => default; /* [XID] */ /* 0x0000000189AA35C0-0x0000000189AA35E0 */ set {} } // 0x000000018305A270-0x000000018305A320 0x0000000183059E70-0x0000000183059FD0
	public float reachMaxDownSpeedTime { /* [XID] */ /* 0x0000000189AAABF0-0x0000000189AAAC30 */ get; /* [XID] */ /* 0x0000000189AB5570-0x0000000189AB55B0 */ private set; } // 0x000000018305BAC0-0x000000018305BB30 0x000000018305BB30-0x000000018305BBA0
	public bool Enabled { /* [XID] */ /* 0x0000000189AC0120-0x0000000189AC0140 */ get => default; } // 0x000000018305BDB0-0x000000018305BED0 

	// Constructors
	public AirRigidbody() {} // Dummy constructor
	public AirRigidbody(Rigidbody rigidbody, VCHumanoidMove vcHumanoidMove, Transform transform) {} // 0x000000018305BED0-0x000000018305BFD0

	// Methods
	// [XID] // 0x0000000189AC7B80-0x0000000189AC7BA0
	public void Enable(bool clearMaxDownSpeed) {} // 0x0000000183059FD0-0x000000018305A270
	// [XID] // 0x0000000189ACF0E0-0x0000000189ACF100
	private void ClearMaxDownSpeed() {} // 0x000000018305BBA0-0x000000018305BC80
	// [XID] // 0x000000018975BA50-0x000000018975BA70
	public void Disable() {} // 0x000000018305BC80-0x000000018305BDB0
	// [XID] // 0x0000000189ADE950-0x0000000189ADE970
	public void ModifyVelocityUseDummy() {} // 0x000000018305B5B0-0x000000018305BAC0
	// [XID] // 0x0000000189AE62D0-0x0000000189AE62F0
	public Vector3 GetDummyPos() => default; // 0x000000018305A410-0x000000018305A510
	// [XID] // 0x0000000189AEDA60-0x0000000189AEDA80
	public void SetDummyPos(Vector3 pos) {} // 0x000000018305A320-0x000000018305A410
	// [XID] // 0x0000000189AF5200-0x0000000189AF5220
	public Vector3 GetVelocity() => default; // 0x000000018305B440-0x000000018305B5B0
	// [XID] // 0x0000000189AFC7A0-0x0000000189AFC7C0
	public Vector3 GetUnscaledVelocity() => default; // 0x000000018305A510-0x000000018305A830
	// [XID] // 0x0000000189B03EB0-0x0000000189B03ED0
	public void SetIgnoreDummy(bool ignoreDummy, bool groundNoStandAndHorizontal = false /* Metadata: 0x00B1423C */) {} // 0x000000018305B250-0x000000018305B440
	// [XID] // 0x0000000189B0B790-0x0000000189B0B7B0
	public void SetUnscaledVelocity(Vector3 velocity) {} // 0x000000018305A830-0x000000018305B250
}

