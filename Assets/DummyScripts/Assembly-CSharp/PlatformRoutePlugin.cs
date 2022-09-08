/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;
using MoleMole.Config;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class PlatformRoutePlugin : BaseComponentPlugin // TypeDefIndex: 12146
{
	// Fields
	private Vector3 _lastPos; // 0x58
	private Quaternion _lastRot; // 0x64
	private PlatformStateInfo _stateInfo; // 0x78
	private LevelMoveScenePropPlugin _platFormManager; // 0xD0
	private PlatformSimulateResult _result; // 0xD8
	public static int _debug_open_flag; // 0x00
	private bool _isResultCalculated; // 0xFC
	private bool _isOpendLog; // 0xFD
	private float _lastLogTime; // 0x100

	// Properties
	public override int metaTypeID { /* [XID] */ /* 0x00000001897EF7A0-0x00000001897EF7C0 */ get => default; } // 0x0000000182DEAD70-0x0000000182DEAE10 
	public Vector3 lastPos { /* [XID] */ /* 0x00000001897F6E40-0x00000001897F6E60 */ get => default; } // 0x0000000182DE8B00-0x0000000182DE8BE0 
	public Quaternion lastRot { /* [XID] */ /* 0x00000001897FE480-0x00000001897FE4A0 */ get => default; } // 0x0000000182DE8110-0x0000000182DE81E0 
	public PlatformSimulateResult result { /* [XID] */ /* 0x00000001897EAFD0-0x00000001897EAFF0 */ get => default; } // 0x0000000182DE9B00-0x0000000182DE9C20 
	public bool HasRoute { /* [XID] */ /* 0x000000018980D440-0x000000018980D460 */ get => default; } // 0x0000000182DE9C20-0x0000000182DE9CE0 
	public uint RouteId { /* [XID] */ /* 0x00000001896BB500-0x00000001896BB520 */ get => default; } // 0x0000000182DE85C0-0x0000000182DE8670 
	public int RouteIndex { /* [XID] */ /* 0x0000000189752E30-0x0000000189752E50 */ get => default; } // 0x0000000182DEA730-0x0000000182DEA7F0 
	public bool IsStopped { /* [XID] */ /* 0x0000000189823B20-0x0000000189823B40 */ get => default; } // 0x0000000182DE9CE0-0x0000000182DE9DB0 

	// Nested types
	public struct PlatformStateInfo // TypeDefIndex: 12147
	{
		// Fields
		public bool isStarted; // 0x00
		public PlatformRoute route; // 0x08
		public uint startSceneTime; // 0x10
		public uint startRouteTime; // 0x14
		public int startRouteIndex; // 0x18
		public uint tempStartRouteTime; // 0x1C
		public uint tempRouteTime; // 0x20
		public Vector3 tempRouteStartPos; // 0x24
		public Quaternion startRot; // 0x30
		public uint stopSceneTime; // 0x40
		public NewRoute newRoute; // 0x48
		public MovingPlatformType movingPlatformType; // 0x50

		// Methods
		// [XID] // 0x00000001898A4180-0x00000001898A41A0
		public override string ToString() => default; // 0x0000000182DDF530-0x0000000182DDF560
	}

	public struct PlatformSimulateResult // TypeDefIndex: 12148
	{
		// Fields
		public uint routeTime; // 0x00
		public int routeIndex; // 0x04
		public Vector3 position; // 0x08
		public Quaternion rotation; // 0x14
	}

	// Constructors
	public PlatformRoutePlugin() {} // 0x0000000182DEACC0-0x0000000182DEAD70
	static PlatformRoutePlugin() {} // 0x0000000182DEAC60-0x0000000182DEACC0

	// Methods
	// [XID] // 0x000000018982B4B0-0x000000018982B4D0
	public void ChangePlatformRouteByTempRoute(PlatformRoute targetRoute, uint sceneTime, uint tempRouteTime) {} // 0x0000000182DE8040-0x0000000182DE8110
	// [Conditional] // 0x0000000189832870-0x00000001898328C0
	// [XID] // 0x0000000189832870-0x00000001898328C0
	private void LogPlatform(string log) {} // 0x0000000182DE8670-0x0000000182DE8B00
	// [XID] // 0x000000018968F2C0-0x000000018968F2E0
	public void StartPlatform(uint sceneTime) {} // 0x0000000182DE82C0-0x0000000182DE8380
	// [XID] // 0x00000001898447B0-0x00000001898447D0
	public void StopPlatform(uint sceneTime) {} // 0x0000000182DEA200-0x0000000182DEA2F0
	// [XID] // 0x000000018974BA80-0x000000018974BAA0
	public void Reset(LevelMoveScenePropPlugin platFormManager) {} // 0x0000000182DE8380-0x0000000182DE8440
	// [XID] // 0x0000000189852BB0-0x0000000189852BD0
	public bool Initialized() => default; // 0x0000000182DE8510-0x0000000182DE85C0
	// [XID] // 0x000000018985A7A0-0x000000018985A7C0
	public bool SetInitRouteFromServer(PlatformInitInfo platformInfo, PlatformRoute customRoute = null) => default; // 0x0000000182DEA7F0-0x0000000182DEAC60
	// [XID] // 0x0000000189861850-0x0000000189861870
	public void SetInitRoute(uint id, Vector3 startPosition, uint tempRouteTime) {} // 0x0000000182DEA550-0x0000000182DEA730
	// [XID] // 0x0000000189869190-0x00000001898691B0
	public bool SimulatePlatformFromStartTime(uint sceneTime) => default; // 0x0000000182DE8BE0-0x0000000182DE9B00
	// [XID] // 0x00000001898A85A0-0x00000001898A85C0
	private void DebugSendRouteState(uint sceneTime, PlatformSimulateResult result) {} // 0x0000000182DE81E0-0x0000000182DE82C0
	// [XID] // 0x0000000189877B60-0x0000000189877B80
	public bool GetPositionByIndex(int index, out Vector3 pos) {
		pos = default;
		return default;
	} // 0x0000000182DE9FA0-0x0000000182DEA190
	// [XID] // 0x000000018987F3B0-0x000000018987F3D0
	public bool GetPositionByStartIndex(out Vector3 pos) {
		pos = default;
		return default;
	} // 0x0000000182DEA440-0x0000000182DEA550
	// [XID] // 0x00000001897A6C00-0x00000001897A6C20
	public bool GetStartIndex(out int index) {
		index = default;
		return default;
	} // 0x0000000182DE8440-0x0000000182DE8510
	// [XID] // 0x000000018988DB70-0x000000018988DB90
	public bool IsAtEnd(uint sceneTime) => default; // 0x0000000182DE9DB0-0x0000000182DE9EC0
	// [XID] // 0x0000000189895240-0x0000000189895260
	public float GetSpeed(int index = -1 /* Metadata: 0x00AEB579 */) => default; // 0x0000000182DE9EC0-0x0000000182DE9FA0
	// [XID] // 0x0000000189857560-0x0000000189857580
	public void DebugApplyRoute(ConfigRoute currentRoute) {} // 0x0000000182DEA2F0-0x0000000182DEA440
}

