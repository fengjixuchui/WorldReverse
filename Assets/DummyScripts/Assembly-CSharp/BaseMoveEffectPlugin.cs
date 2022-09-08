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

public class BaseMoveEffectPlugin : BaseComponentPlugin // TypeDefIndex: 12036
{
	// Fields
	protected VCBaseMove _vcBaseMove; // 0x58
	protected VCMoveData _moveData; // 0x60
	protected Transform _transform; // 0x68
	protected Rigidbody _rigidBody; // 0x70
	protected bool _underWater; // 0x78
	protected bool _underWaterStateChanged; // 0x79
	protected float _underWaterMoveDistant; // 0x7C
	protected Vector3 _lastPosition; // 0x80
	protected Vector3 _waterPosition; // 0x8C
	protected const float WATER_EFFECT_DEPTH_THRESHOLD = 0.4f; // Metadata: 0x00AEB374
	protected const float WATER_EFFECT_PLAY_DISTANCE = 0.8f; // Metadata: 0x00AEB378
	protected const float WATER_EFFECT_RUN_VELOCITY_THRESHOLD = 2f; // Metadata: 0x00AEB37C
	protected Vector3 velocity; // 0x98

	// Properties
	public override int metaTypeID { /* [XID] */ /* 0x00000001899CF310-0x00000001899CF330 */ get => default; } // 0x0000000182865CC0-0x0000000182865D60 

	// Constructors
	public BaseMoveEffectPlugin() {} // Dummy constructor
	public BaseMoveEffectPlugin(VCBaseMove moveComponent) {} // 0x0000000182865C30-0x0000000182865CC0

	// Methods
	// [XID] // 0x00000001899D67B0-0x00000001899D67D0
	public override void Init() {} // 0x0000000182865970-0x0000000182865AB0
	// [XID] // 0x00000001899DDE70-0x00000001899DDE90
	public override void LateTick(float inDeltaTime) {} // 0x0000000182865AB0-0x0000000182865BC0
	// [XID] // 0x00000001899E5C10-0x00000001899E5C30
	protected virtual void UpdateWaterEffect(float inDeltaTime) {} // 0x0000000182865150-0x00000001828657D0
	// [XID] // 0x00000001899ECCA0-0x00000001899ECCC0
	protected void EstimateVelocity(float inDeltaTime) {} // 0x0000000182864E30-0x00000001828650D0
	// [XID] // 0x00000001899F4A00-0x00000001899F4A20
	protected void CheckUnderWater() {} // 0x00000001828657D0-0x0000000182865970
}

