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
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class EvtCameraSceneLook : BaseEvent, IAutoAllocRecycle // TypeDefIndex: 20079
{
	// Fields
	private OP _op; // 0x30
	private Vector3 _targetPos; // 0x34
	private Transform _targetTrans; // 0x40
	private float _offsetY; // 0x48
	private float _duration; // 0x4C
	private bool _forceLook; // 0x50
	private bool _recoverKeepCurrent; // 0x51
	private bool _setFollowPos; // 0x52
	private Vector3 _followPos; // 0x54
	private bool _isForceWalk; // 0x60
	private bool _isChangePlayMode; // 0x61
	private bool _isSetScreenXY; // 0x62
	private float _screenX; // 0x64
	private float _screenY; // 0x68

	// Properties
	public OP op { /* [XID] */ /* 0x0000000189BC3C10-0x0000000189BC3C30 */ get => default; } // 0x00000001827C20D0-0x00000001827C2170 
	public Vector3 targetPos { /* [XID] */ /* 0x0000000189BCB3C0-0x0000000189BCB3E0 */ get => default; } // 0x00000001827C2210-0x00000001827C22F0 
	public Transform targetTrans { /* [XID] */ /* 0x0000000189A217B0-0x0000000189A217D0 */ get => default; } // 0x00000001827C1940-0x00000001827C19E0 
	public float offsetY { /* [XID] */ /* 0x0000000189BD9F30-0x0000000189BD9F50 */ get => default; } // 0x00000001827C2550-0x00000001827C2600 
	public float duration { /* [XID] */ /* 0x0000000189A303B0-0x0000000189A303D0 */ get => default; } // 0x00000001827C16B0-0x00000001827C1760 
	public bool forceLook { /* [XID] */ /* 0x0000000189A37E30-0x0000000189A37E50 */ get => default; } // 0x00000001827C1F30-0x00000001827C1FD0 
	public bool recoverKeepCurrent { /* [XID] */ /* 0x0000000189661620-0x0000000189661640 */ get => default; } // 0x00000001827C18A0-0x00000001827C1940 
	public bool setFollowPos { /* [XID] */ /* 0x0000000189A46B90-0x0000000189A46BB0 */ get => default; } // 0x00000001827C1470-0x00000001827C1510 
	public Vector3 followPos { /* [XID] */ /* 0x0000000189670BE0-0x0000000189670C00 */ get => default; } // 0x00000001827C1760-0x00000001827C1840 
	public bool isForceWalk { /* [XID] */ /* 0x0000000189678430-0x0000000189678450 */ get => default; } // 0x00000001827C24B0-0x00000001827C2550 
	public bool isChangePlayMode { /* [XID] */ /* 0x0000000189A5D3E0-0x0000000189A5D400 */ get => default; } // 0x00000001827C2170-0x00000001827C2210 
	public bool isSetScreenXY { /* [XID] */ /* 0x0000000189A64D40-0x0000000189A64D60 */ get => default; } // 0x00000001827C1FD0-0x00000001827C2070 
	public float screenX { /* [XID] */ /* 0x00000001896AF640-0x00000001896AF660 */ get => default; } // 0x00000001827C2350-0x00000001827C2400 
	public float screenY { /* [XID] */ /* 0x0000000189A73C70-0x0000000189A73C90 */ get => default; } // 0x00000001827C2400-0x00000001827C24B0 

	// Nested types
	public enum OP // TypeDefIndex: 20080
	{
		INVALID = -1,
		ENTER = 0,
		EXIT = 1,
		INTERRUT = 2
	}

	// Constructors
	public EvtCameraSceneLook() {} // 0x00000001827C26A0-0x00000001827C2740

	// Methods
	[BlackList] // 0x00000001899F3D50-0x00000001899F3D90
	// [XID] // 0x00000001899F3D50-0x00000001899F3D90
	public override void AutoAllocTypeFields() {} // 0x00000001827C1510-0x00000001827C15B0
	[BlackList] // 0x00000001899FE1B0-0x00000001899FE1F0
	// [XID] // 0x00000001899FE1B0-0x00000001899FE1F0
	public override void AutoRecycleTypeFields() {} // 0x00000001827C15B0-0x00000001827C16B0
	[BlackList] // 0x0000000189A086B0-0x0000000189A086F0
	// [XID] // 0x0000000189A086B0-0x0000000189A086F0
	public override void ReturnToObjectPool() {} // 0x00000001827C2600-0x00000001827C26A0
	// [IDTag] // 0x0000000189A7B760-0x0000000189A7B7A0
	// [XID] // 0x0000000189A7B760-0x0000000189A7B7A0
	public void Init(uint targetID, OP op, Vector3 targetPos, float offsetY, float duration, bool forceLook, bool recoverKeepCurrent, bool setFollow, Vector3 followPos, bool forceWalk, bool changePlayMode, bool setScreenXY, float screenX, float screenY) {} // 0x00000001827C1B60-0x00000001827C1DE0
	// [IDTag] // 0x0000000189A85F70-0x0000000189A85FB0
	// [XID] // 0x0000000189A85F70-0x0000000189A85FB0
	public void Init(uint targetID, OP op, Vector3 targetPos, float offsetY, float duration, bool forceLook, bool recoverKeepCurrent = false /* Metadata: 0x00AFD220 */) {} // 0x00000001827C19E0-0x00000001827C1B60
	// [IDTag] // 0x0000000189A90A30-0x0000000189A90A70
	// [XID] // 0x0000000189A90A30-0x0000000189A90A70
	public void Init(uint targetID, OP op, Transform targetTrans, float offsetY, float duration, bool forceLook, bool recoverKeepCurrent = false /* Metadata: 0x00AFD221 */) {} // 0x00000001827C1DE0-0x00000001827C1F30
}

