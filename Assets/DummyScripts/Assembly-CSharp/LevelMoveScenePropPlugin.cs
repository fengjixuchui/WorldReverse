/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class LevelMoveScenePropPlugin : BaseComponentPlugin // TypeDefIndex: 12072
{
	// Fields
	private Dictionary<uint, PlatformRoute> _levelRouteDict; // 0x58
	private Dictionary<Transform, VCScenePropAccurateMoveBase> _MoveScenePropColliderDict; // 0x60
	private Dictionary<Transform, Vector3> _MoveScenePropColliderPosDict; // 0x68
	private HashSet<Collider> _rockGadgetColliders; // 0x70
	private int _layerMask; // 0x78

	// Properties
	public override int metaTypeID { /* [XID] */ /* 0x00000001898CF640-0x00000001898CF660 */ get => default; } // 0x0000000182122F20-0x0000000182122FC0 

	// Nested types
	public enum NearReferenceSystemResult // TypeDefIndex: 12073
	{
		SAFE = 0,
		ALMOST = 1,
		CLOSE = 2
	}

	// Constructors
	public LevelMoveScenePropPlugin() {} // 0x0000000182122E00-0x0000000182122F20

	// Methods
	// [XID] // 0x00000001898D6E70-0x00000001898D6E90
	public PlatformRoute FindRoute(uint routeId) => default; // 0x0000000182120E60-0x0000000182120FF0
	// [XID] // 0x00000001898DECB0-0x00000001898DECD0
	private static new EventID[] GetSelfOnEventIDsExcludingBase() => default; // 0x0000000182121E70-0x0000000182121F40
	// [XID] // 0x00000001898E6330-0x00000001898E6350
	public override bool OnEvent(BaseEvent evt) => default; // 0x0000000182122B00-0x0000000182122C60
	// [XID] // 0x00000001898EDC00-0x00000001898EDC20
	public void OnSceneRouteChangeNotify(EvtSceneRouteChange evt) {} // 0x0000000182121C30-0x0000000182121E70
	// [XID] // 0x00000001898F55B0-0x00000001898F55D0
	public void OnPlatformStartRouteNotify(EvtPlatformStartRoute evt) {} // 0x0000000182122300-0x00000001821224C0
	// [XID] // 0x00000001898FCC80-0x00000001898FCCA0
	public void OnPlatformStopRouteNotify(EvtPlatformStopRoute evt) {} // 0x00000001821224C0-0x0000000182122680
	// [XID] // 0x0000000189904660-0x0000000189904680
	public void OnPlatformChangeRouteNotify(EvtPlatformChangeRoute evt) {} // 0x0000000182122870-0x0000000182122A00
	// [XID] // 0x000000018990BE20-0x000000018990BE40
	public override void Tick(float deltaTime) {} // 0x0000000182122C60-0x0000000182122E00
	// [XID] // 0x00000001896DECD0-0x00000001896DECF0
	public void registerMoveScenePropCollider(VCScenePropAccurateMoveBase moveComponent) {} // 0x00000001821215F0-0x0000000182121AE0
	// [XID] // 0x000000018991B140-0x000000018991B160
	public void unregisterMoveScenePropCollider(VCScenePropAccurateMoveBase moveComponent) {} // 0x0000000182120FF0-0x0000000182121220
	// [XID] // 0x0000000189922790-0x00000001899227B0
	public bool IsMoveSceneProp(Collider col, out VCScenePropAccurateMoveBase rsMoveComponent) {
		rsMoveComponent = default;
		return default;
	} // 0x0000000182120D50-0x0000000182120E60
	// [XID] // 0x0000000189929EA0-0x0000000189929EC0
	public Dictionary<Transform, VCScenePropAccurateMoveBase> GetScenePropColliderDict() => default; // 0x0000000182122260-0x0000000182122300
	// [XID] // 0x0000000189B914F0-0x0000000189B91510
	public void AddRockGadgetCollider(Collider[] cols) {} // 0x0000000182122770-0x0000000182122870
	// [XID] // 0x0000000189938CE0-0x0000000189938D00
	public void RemoveRockGadgetCollider(Collider[] cols) {} // 0x0000000182122A00-0x0000000182122B00
	// [XID] // 0x00000001899404D0-0x00000001899404F0
	public bool IsRockGadgetCollider(Collider col) => default; // 0x0000000182121AE0-0x0000000182121BB0
	// [XID] // 0x0000000189947B10-0x0000000189947B30
	public NearReferenceSystemResult HasReferenceSystemNear(Vector3 pos, out Vector3 nearestScenePropPos, float thresholdNear = 10f /* Metadata: 0x00AEB460 */, float thresholdFar = 20f /* Metadata: 0x00AEB464 */) {
		nearestScenePropPos = default;
		return default;
	} // 0x0000000182121220-0x00000001821215F0
	// [XID] // 0x000000018994F210-0x000000018994F230
	public void refreshMoveScenePropColliderPos(VCScenePropAccurateMoveBase moveComponent) {} // 0x0000000182121F40-0x0000000182122260
}

