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

public struct PlatformInitInfo // TypeDefIndex: 32171
{
	// Fields
	public uint routeId; // 0x00
	public int startIndex; // 0x04
	public uint startRouteTime; // 0x08
	public uint startSceneTime; // 0x0C
	public uint tempRouteTime; // 0x10
	public uint tempStartRouteTime; // 0x14
	public Vector3 startPos; // 0x18
	public bool isStarted; // 0x24
	public Quaternion startRot; // 0x28
	public uint stopSceneTime; // 0x38
	public Vector3 posOffset; // 0x3C
	public Quaternion rotOffset; // 0x48
	public MovingPlatformType movingPlatformType; // 0x58
	public Route newRoute; // 0x60
	public uint pointId; // 0x68
	public bool IsActive; // 0x6C

	// Methods
	// [XID] // 0x00000001899CC710-0x00000001899CC730
	public bool IsVaild() => default; // 0x0000000181367CB0-0x0000000181367CE0
	// [XID] // 0x00000001899D3DB0-0x00000001899D3DD0
	public void Init(PlatformInfo info) {} // 0x0000000181367B30-0x0000000181367BE0
	// [XID] // 0x00000001899DB320-0x00000001899DB340
	public void Clear() {} // 0x0000000181367BE0-0x0000000181367CB0
}

