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

public class EquipContent // TypeDefIndex: 32133
{
	// Fields
	public string name; // 0x10
	public string equipPart; // 0x18
	public Transform equipTrans; // 0x20
	public bool useHipOffsetFromIK; // 0x28
	public Quaternion offsetRotation; // 0x2C
	public Vector3 uniformScale; // 0x3C
	public Vector3 putAwayScale; // 0x48
	public Vector3 takeOutScale; // 0x54
	public uint runtimeID; // 0x60
	public ulong guid; // 0x68
	public Vector3 currentVel; // 0x70
	public EquipContent subEquipContent; // 0x80
	public bool place; // 0x88
	public float breathAnimTime; // 0x8C
	public Vector3 fixedTargetPositionForStandby; // 0x90
	public bool lastIsStandby; // 0x9C
	public float angleDampVelocity; // 0xA0
	public Vector3 lastFilteredPos; // 0xA4
	public Vector3 lastPos; // 0xB0
	public Vector3 posOffset; // 0xBC
	public Vector3 lastTransformPos; // 0xC8
	public Quaternion lastRelatedRotation; // 0xD4
	public Quaternion lastRotation; // 0xE4
	public bool isFilterInitialized; // 0xF4
	public SimpleKalmanFilter skfilter; // 0xF8
	public Vector3 posDampVelocity; // 0x100
	public const float NOISE_Q = 20f; // Metadata: 0x00B140E0
	public const float NOISE_R = 200f; // Metadata: 0x00B140E4
	public const float Init_ERROR = 20f; // Metadata: 0x00B140E8
	public const float POS_DAMP_TIME = 0.05f; // Metadata: 0x00B140EC
	public const float ANGLE_DAMP_TIME = 0.5f; // Metadata: 0x00B140F0
	public const float MAX_DIST = 0.3f; // Metadata: 0x00B140F4
	public bool useAuxTrans; // 0x10C
	public string ausTransName; // 0x110
	public Transform auxTrans; // 0x118
	public bool forceFollow; // 0x120
	public int stopFollowAfterTimeZeroTimeScaleCount; // 0x124

	// Properties
	public BaseEntity equipEntity { /* [XID] */ /* 0x000000018993AD80-0x000000018993ADA0 */ get => default; } // 0x0000000182482770-0x0000000182482850 
	public bool needFollow { /* [XID] */ /* 0x0000000189941D70-0x0000000189941D90 */ get => default; } // 0x0000000182482850-0x0000000182482910 

	// Constructors
	public EquipContent() {} // 0x0000000182482E50-0x0000000182482F40

	// Methods
	// [XID] // 0x0000000189933230-0x0000000189933250
	public void CheckEquipTransUseHipOffsetFromIK() {} // 0x0000000182482CB0-0x0000000182482E50
	// [XID] // 0x0000000189949830-0x0000000189949850
	public Vector3 FilterEquipAttachBone(float deltaTime, Vector3 Origin, Vector3 Velocity) => default; // 0x0000000182482910-0x0000000182482CB0
}

