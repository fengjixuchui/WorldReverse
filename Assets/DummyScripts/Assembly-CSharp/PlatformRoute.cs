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

public class PlatformRoute // TypeDefIndex: 32168
{
	// Fields
	private RouteType _type; // 0x14
	private RotType _rotType; // 0x18
	private bool _isForward; // 0x1C
	private uint _totalTime; // 0x20
	private RotAngleType _rotAngleType; // 0x24
	private float _rotTotalAngle; // 0x28
	private List<PlatformRoutePoint> _pointList; // 0x30

	// Properties
	public uint id { /* [XID] */ /* 0x0000000189864DB0-0x0000000189864DF0 */ get; set; } // 0x000000018316B640-0x000000018316B6A0 0x0000000183169AF0-0x0000000183169B50

	// Constructors
	public PlatformRoute() {} // Dummy constructor
	public PlatformRoute(uint id, ConfigRoute config) {} // 0x000000018316C110-0x000000018316C340

	// Methods
	// [XID] // 0x00000001897BE220-0x00000001897BE240
	public RotType GetRotType() => default; // 0x0000000183169650-0x00000001831696F0
	// [XID] // 0x00000001897D4650-0x00000001897D4670
	public RotAngleType GetRotAngleType() => default; // 0x000000018316A6A0-0x000000018316A740
	// [XID] // 0x00000001898857D0-0x00000001898857F0
	public void IntegratePointlist(List<PlatformRoutePoint> pointList, RouteType type, bool isForward) {} // 0x0000000183169970-0x0000000183169AF0
	// [XID] // 0x0000000189652940-0x0000000189652960
	public void AdjustOffset(PlatformInitInfo info) {} // 0x000000018316B6A0-0x000000018316BB60
	// [XID] // 0x0000000189894190-0x00000001898941B0
	public void RouteChange(SceneRouteChangeInfo info, uint sceneTime) {} // 0x0000000183168640-0x0000000183168700
	// [XID] // 0x000000018965A030-0x000000018965A050
	public void CalcRouteTotalTimeAndUpdatePointTime(List<PlatformRoutePoint> pointList, RouteType type, RotType rotType, RotAngleType rotAngleType, bool isForward, ref uint totalTime, ref float totalAngle) {} // 0x0000000183168EA0-0x0000000183169650
	// [XID] // 0x00000001898A2C20-0x00000001898A2C40
	public void CheckRouteChangeTime() {} // 0x00000001831697F0-0x0000000183169890
	// [XID] // 0x00000001896B3F10-0x00000001896B3F30
	private bool IsVaildIndex(int index) => default; // 0x000000018316A5C0-0x000000018316A6A0
	// [XID] // 0x0000000189B2BBA0-0x0000000189B2BBC0
	private bool IsVaildIndexAndRotType(int index, RotType rotType) => default; // 0x0000000183169890-0x0000000183169970
	// [XID] // 0x00000001898B9610-0x00000001898B9630
	private int GetNextIndex(int index) => default; // 0x0000000183168700-0x00000001831687F0
	// [XID] // 0x00000001898C0B50-0x00000001898C0B70
	public Vector3 GetPositionByTimeAndIndex(uint routeTime, int index) => default; // 0x000000018316A8F0-0x000000018316AE50
	// [XID] // 0x00000001898C83B0-0x00000001898C83D0
	public float GetAngleByTimeAndIndex(uint routeTime, int index) => default; // 0x000000018316BB60-0x000000018316C110
	// [XID] // 0x00000001898CFE40-0x00000001898CFE60
	public Quaternion GetRotationByTimeAndIndex(uint routeTime, int index) => default; // 0x0000000183169B50-0x000000018316A370
	// [XID] // 0x00000001896D8C70-0x00000001896D8C90
	public int GetFirstIndex() => default; // 0x00000001831687F0-0x0000000183168890
	// [IDTag] // 0x00000001898DF100-0x00000001898DF140
	// [XID] // 0x00000001898DF100-0x00000001898DF140
	public bool IsAtOneWayEnd(int index) => default; // 0x0000000183168890-0x0000000183168970
	// [IDTag] // 0x00000001898E9C30-0x00000001898E9C70
	// [XID] // 0x00000001898E9C30-0x00000001898E9C70
	public bool IsAtOneWayEnd(int startIndex, uint startRouteTime, uint timeSpan) => default; // 0x0000000183168970-0x0000000183168A70
	// [XID] // 0x00000001898F4120-0x00000001898F4140
	public bool GetPositionByIndex(int index, out Vector3 pos) {
		pos = default;
		return default;
	} // 0x000000018316A470-0x000000018316A5C0
	// [XID] // 0x00000001898FB800-0x00000001898FB820
	public bool GetRotationByIndex(int index, out Quaternion rot) {
		rot = default;
		return default;
	} // 0x0000000183168A70-0x0000000183168C10
	// [XID] // 0x00000001899032D0-0x00000001899032F0
	public float GetMoveAngleSpeedByIndex(int index) => default; // 0x000000018316A370-0x000000018316A470
	// [XID] // 0x000000018988B030-0x000000018988B050
	public float GetWaitAngleSpeedByIndex(int index) => default; // 0x00000001831696F0-0x00000001831697F0
	// [XID] // 0x0000000189912440-0x0000000189912460
	public bool IsRotWhenStoped(int index) => default; // 0x0000000183168DA0-0x0000000183168EA0
	// [XID] // 0x0000000189B6ABF0-0x0000000189B6AC10
	public int GetBelongIndexByIndexAndTime(int index, uint route_time, ref float angleSpeed) => default; // 0x0000000183168C10-0x0000000183168DA0
	// [XID] // 0x00000001899215A0-0x00000001899215C0
	public uint getLeftTimeToEndPoint(int index, uint route_time, uint time_span) => default; // 0x000000018316A740-0x000000018316A8F0
	// [XID] // 0x0000000189928D00-0x0000000189928D20
	public bool SimulateRoute(uint lastRouteTime, int lastIndex, uint timeSpan, ref uint routeTime, ref int index, ref Vector3 pos, ref float angleDiff) => default; // 0x000000018316AE50-0x000000018316B640
}

