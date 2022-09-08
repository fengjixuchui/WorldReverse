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

public class ThreatInfo // TypeDefIndex: 20445
{
	// Fields
	public const float TEMPERVAL_MIN = 0f; // Metadata: 0x00AFDA89
	public const float TEMPERVAL_MAX = 100f; // Metadata: 0x00AFDA8D
	public const float TEMPERVAL_CLEAR = 0f; // Metadata: 0x00AFDA91
	public const float TEMPERVAL_AWARE = 10f; // Metadata: 0x00AFDA95
	public const float TEMPERVAL_ALERT = 100f; // Metadata: 0x00AFDA99
	public const float THREATVAL_MIN = 0f; // Metadata: 0x00AFDA9D
	public const float THREATVAL_MAX = 99999f; // Metadata: 0x00AFDAA1
	public const float THREATVAL_HIT_ONCE = 20f; // Metadata: 0x00AFDAA5
	public const float THREATVAL_MAINTHREAT_DROP = 0.03f; // Metadata: 0x00AFDAA9
	public const float TIME_HOLDTHREAT_AVATARCHANGED = 2f; // Metadata: 0x00AFDAAD
	public const float TIME_THREATLOST = 1f; // Metadata: 0x00AFDAB1
	public uint id; // 0x10
	public ThreatAddReason addReason; // 0x14
	public Vector3 threatPos; // 0x18
	public float temperature; // 0x24
	public float threatValue; // 0x28
	public float threatAUXScore; // 0x2C
	public float lastSeenTime; // 0x30
	public float lastFeelTime; // 0x34
	public float lastFootstepTime; // 0x38
	public float caredGlobalValue; // 0x3C
	public float holdFinishTick; // 0x40
	public AITimer lctByFarDistance; // 0x48
	public AITimer lctByEntityDisappear; // 0x50
	public AITimer lctByOutOfZone; // 0x58

	// Constructors
	public ThreatInfo() {} // Dummy constructor
	public ThreatInfo(uint runtimeID, Vector3 position, ThreatAddReason reason) {} // 0x00000001827C70F0-0x00000001827C71F0

	// Methods
	// [XID] // 0x0000000189AAA740-0x0000000189AAA760
	public void CopyFrom(ThreatInfo other) {} // 0x00000001827C6B20-0x00000001827C6C80
	// [XID] // 0x000000018995D7E0-0x000000018995D800
	public void IncreaseTemper(float amount) {} // 0x00000001827C6F00-0x00000001827C6FF0
	// [XID] // 0x0000000189964ED0-0x0000000189964EF0
	public void DecreaseTemper(float amount) {} // 0x00000001827C6A30-0x00000001827C6B20
	// [XID] // 0x0000000189A44AA0-0x0000000189A44AC0
	public void IncreaseThreat(float amount) {} // 0x00000001827C6C80-0x00000001827C6D70
	// [XID] // 0x0000000189973F10-0x0000000189973F30
	public void DecreaseThreat(float amount) {} // 0x00000001827C6FF0-0x00000001827C70F0
	// [XID] // 0x000000018997B6D0-0x000000018997B6F0
	public bool CausingScare(float currentTime) => default; // 0x00000001827C6D70-0x00000001827C6E40
	// [XID] // 0x0000000189B31B70-0x0000000189B31B90
	public void Hold(float currentTime) {} // 0x00000001827C6E40-0x00000001827C6F00
}

