/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole.Config;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class PlatformRoutePoint // TypeDefIndex: 32167
{
	// Fields
	public Vector3 pos; // 0x10
	public float targetVelocity; // 0x1C
	public uint waitTime; // 0x20
	public uint timeToNextPoint; // 0x24
	public bool rotAngleSameStop; // 0x28
	public Vector3 dirReachThePoint; // 0x2C
	public Vector3 dirLeaveThePoint; // 0x38
	public float rotAngleMoveSpeed; // 0x44
	public float rotAngleWaitSpeed; // 0x48
	public int rotRoundReachRounds; // 0x4C
	public int rotRoundWaitRounds; // 0x50
	public RouteAxisAngle axisAngleToNextPoint; // 0x58
	public RouteAxisAngle axisAngleWaitThePoint; // 0x60

	// Constructors
	public PlatformRoutePoint() {} // 0x0000000183137D40-0x0000000183137DA0

	// Methods
	// [IDTag] // 0x0000000189806150-0x0000000189806190
	// [XID] // 0x0000000189806150-0x0000000189806190
	public void FromOtherPoint(PlatformRoutePoint point) {} // 0x0000000183137230-0x00000001831373E0
	// [IDTag] // 0x0000000189810A80-0x0000000189810AC0
	// [XID] // 0x0000000189810A80-0x0000000189810AC0
	public void FromOtherPoint(ConfigWaypoint point) {} // 0x00000001831373E0-0x0000000183137610
	// [XID] // 0x0000000189678570-0x0000000189678590
	public static Vector3 GetAxisByRotAngleType(RotAngleType type) => default; // 0x0000000183136F60-0x0000000183137090
	// [XID] // 0x00000001898228A0-0x00000001898228C0
	public static RouteAxisAngle CalcAxisAngleWait(PlatformRoutePoint point, RotType rotType, RotAngleType rotAngleType) => default; // 0x0000000183137BC0-0x0000000183137D40
	// [XID] // 0x000000018982A210-0x000000018982A230
	public static RouteAxisAngle CalcAxisAngleMove(PlatformRoutePoint fromPoint, PlatformRoutePoint toPoint, RotType rotType, RotAngleType rotAngleType) => default; // 0x0000000183137090-0x0000000183137230
	// [IDTag] // 0x0000000189831570-0x00000001898315B0
	// [XID] // 0x0000000189831570-0x00000001898315B0
	public static RouteAxisAngle CalcAxisAngle(Vector3 fromDir, Vector3 toDir, int roundN) => default; // 0x0000000183137610-0x0000000183137950
	// [IDTag] // 0x000000018983BCF0-0x000000018983BD30
	// [XID] // 0x000000018983BCF0-0x000000018983BD30
	public static RouteAxisAngle CalcAxisAngle(RotAngleType rotAngleType, float angle, uint timeN) => default; // 0x0000000183137950-0x0000000183137BC0
	// [IDTag] // 0x0000000189846220-0x0000000189846260
	// [XID] // 0x0000000189846220-0x0000000189846260
	public static Quaternion CalcQuaternion(Quaternion fromRot, Quaternion toRot, float pro) => default; // 0x0000000183136C40-0x0000000183136F60
	// [IDTag] // 0x0000000189850560-0x00000001898505A0
	// [XID] // 0x0000000189850560-0x00000001898505A0
	public static Quaternion CalcQuaternion(Quaternion rot, RotAngleType rotAngleType, float angle) => default; // 0x0000000183136990-0x0000000183136C40
}

