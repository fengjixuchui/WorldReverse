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

public sealed class VCWindmillMove : VCScenePropAccurateMoveBase // TypeDefIndex: 11976
{
	// Fields
	private ulong _lastSyncTime; // 0x228
	private float _lastSyncAngle; // 0x230
	private Quaternion _originalRotation; // 0x234
	private int _lastFrameWindLevel; // 0x244
	private float _lastFrameAngle; // 0x248
	private float testDelay; // 0x24C
	private WindmillPack entityClientData; // 0x250
	private const float forcePullAngleMax = 30f; // Metadata: 0x00AEB004
	private const float forcePullAngleMin = 5f; // Metadata: 0x00AEB008
	private uint predictTime; // 0x25C
	private uint _simulateTime; // 0x260
	private bool _useSimulatedTime; // 0x264
	private int _lastUpdateTime; // 0x268

	// Properties
	public override int metaTypeID { /* [XID] */ /* 0x0000000189B32EB0-0x0000000189B32ED0 */ get => default; } // 0x00000001841AF7F0-0x00000001841AF890 

	// Constructors
	public VCWindmillMove() {} // 0x00000001841AF750-0x00000001841AF7F0

	// Methods
	// [XID] // 0x0000000189B3A940-0x0000000189B3A960
	public override void Init() {} // 0x00000001841AEE50-0x00000001841AF050
	// [XID] // 0x0000000189B42210-0x0000000189B42230
	public override void CalcMoveState(float inDeltaTime) {} // 0x00000001841AF6A0-0x00000001841AF750
	// [XID] // 0x0000000189B49C50-0x0000000189B49C70
	private uint GetTime(float deltaTime) => default; // 0x00000001841AE820-0x00000001841AE970
	// [XID] // 0x0000000189B51350-0x0000000189B51370
	protected override void LateTick(float inDeltaTime) {} // 0x00000001841AF140-0x00000001841AF630
	// [XID] // 0x0000000189B58CC0-0x0000000189B58CE0
	private float GetSmoothAngle(float current, float target, float rotateSpeed, float deltaTime) => default; // 0x00000001841AEC30-0x00000001841AEE50
	// [XID] // 0x0000000189B60370-0x0000000189B60390
	public void SendPack() {} // 0x00000001841AE970-0x00000001841AEAA0
	// [XID] // 0x0000000189B67B90-0x0000000189B67BB0
	public void InitWindmillFromServer(EntityClientData data = null) {} // 0x00000001841AEAA0-0x00000001841AEBB0
	// [XID] // 0x00000001898B7770-0x00000001898B7790
	public void SetWindmillFromServer(EntityClientData data = null) {} // 0x00000001841AF050-0x00000001841AF140
}

