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

public class NewRoutePoint // TypeDefIndex: 32169
{
	// Fields
	public Vector3 position; // 0x10
	public float velocity; // 0x1C
	public uint waitTime; // 0x20
	public Quaternion rotation; // 0x24
	public Quaternion rotationSpeed; // 0x34
	public Quaternion axisSpeed; // 0x44
	public RoutePoint.MoveParamsOneofCase moveCase; // 0x54
	public RoutePoint.RotateParamsOneofCase rotCase; // 0x58
	public RotAngleType rotAngleType; // 0x5C
	public RotType rotType; // 0x60
	public uint timeToNextPoint; // 0x64
	public RouteAxisAngle axisAngleToNextPoint; // 0x68

	// Constructors
	public NewRoutePoint() {} // 0x00000001832A0E00-0x00000001832A0E60

	// Methods
	// [XID] // 0x0000000189930230-0x0000000189930250
	public void FromOtherPoint(NewRoutePoint otherPoint) {} // 0x00000001832A0790-0x00000001832A0890
	// [XID] // 0x00000001899376D0-0x00000001899376F0
	public static RouteAxisAngle CalcAxisAngleMove(NewRoutePoint fromPoint, NewRoutePoint toPoint) => default; // 0x00000001832A0630-0x00000001832A0790
	// [IDTag] // 0x000000018993F140-0x000000018993F180
	// [XID] // 0x000000018993F140-0x000000018993F180
	public static RouteAxisAngle CalcAxisAngle(Quaternion fromRot, Quaternion toRot, int roundN) => default; // 0x00000001832A0B10-0x00000001832A0E00
	// [IDTag] // 0x00000001899497F0-0x0000000189949830
	// [XID] // 0x00000001899497F0-0x0000000189949830
	public static RouteAxisAngle CalcAxisAngle(RotAngleType rotAngleType, float rad, uint timeN) => default; // 0x00000001832A0890-0x00000001832A0B10
	// [XID] // 0x0000000189953D40-0x0000000189953D60
	public static Vector3 GetAxisByRotAngleType(RotAngleType type) => default; // 0x00000001832A0500-0x00000001832A0630
}

