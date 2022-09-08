/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole.Config;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class NewRoute // TypeDefIndex: 32170
{
	// Fields
	public RouteType routeType; // 0x10
	public List<NewRoutePoint> newRoutePointList; // 0x18
	private uint totalTime; // 0x20
	private float totalAngle; // 0x24

	// Constructors
	public NewRoute() {} // Dummy constructor
	public NewRoute(Route route, Quaternion startRot, int startIndex) {} // 0x0000000184BF4450-0x0000000184BF4E70

	// Methods
	// [XID] // 0x000000018995B5E0-0x000000018995B600
	public void IntegratePointlist(List<NewRoutePoint> pointList, RouteType type, bool isForward) {} // 0x0000000184BF2AF0-0x0000000184BF2C70
	// [XID] // 0x0000000189963100-0x0000000189963120
	public void CalcRouteTotalTimeAndUpdatePointTime(List<NewRoutePoint> pointList, RouteType type, bool isForward, int startIndex, ref uint totalTime, ref float totalAngle) {} // 0x0000000184BF1FC0-0x0000000184BF2870
	// [XID] // 0x000000018996A5A0-0x000000018996A5C0
	public bool IsVaildIndex(int index) => default; // 0x0000000184BF3660-0x0000000184BF3740
	// [XID] // 0x00000001899721E0-0x0000000189972200
	private bool IsVaildIndexAndRotType(int index, RotType rotationType) => default; // 0x0000000184BF29F0-0x0000000184BF2AF0
	// [XID] // 0x0000000189979A80-0x0000000189979AA0
	public float GetMoveAngleSpeedByIndex(int index) => default; // 0x0000000184BF3400-0x0000000184BF3510
	// [XID] // 0x000000018986D7E0-0x000000018986D800
	public uint GetLeftTimeToEndPoint(int index, uint route_time, uint time_span) => default; // 0x0000000184BF2870-0x0000000184BF29F0
	// [XID] // 0x0000000189988970-0x0000000189988990
	private int GetNextIndex(int index) => default; // 0x0000000184BF1C90-0x0000000184BF1D80
	// [XID] // 0x0000000189990180-0x00000001899901A0
	public Vector3 GetPositionByTimeAndIndex(uint routeTime, int index) => default; // 0x0000000184BF3740-0x0000000184BF3AB0
	// [XID] // 0x00000001898A10A0-0x00000001898A10C0
	public Quaternion GetRotationByTimeAndIndex(uint routeTime, int index) => default; // 0x0000000184BF2FB0-0x0000000184BF3400
	// [XID] // 0x0000000189718AA0-0x0000000189718AC0
	public bool GetPositionByIndex(int index, out Vector3 pos) {
		pos = default;
		return default;
	} // 0x0000000184BF3510-0x0000000184BF3660
	// [XID] // 0x0000000189B24750-0x0000000189B24770
	public bool GetRotationByIndex(int index, out Quaternion rot) {
		rot = default;
		return default;
	} // 0x0000000184BF1E80-0x0000000184BF1FC0
	// [XID] // 0x00000001899AE8C0-0x00000001899AE8E0
	public float GetAngleByTimeAndIndex(uint routeTime, int index) => default; // 0x0000000184BF4190-0x0000000184BF4450
	// [XID] // 0x00000001899B5CA0-0x00000001899B5CC0
	public bool IsAtOneWayEnd(int startIndex, uint startRouteTime, uint timeSpan) => default; // 0x0000000184BF1D80-0x0000000184BF1E80
	// [XID] // 0x00000001899BD940-0x00000001899BD960
	public float GetSpeedAtIndex(int index) => default; // 0x0000000184BF2C70-0x0000000184BF2FB0
	// [XID] // 0x0000000189808F70-0x0000000189808F90
	public bool SimulateRoute(uint lastRouteTime, int lastIndex, uint timeSpan, ref uint routeTime, ref int index, ref Vector3 pos, ref float angleDiff) => default; // 0x0000000184BF3AB0-0x0000000184BF4190
}

