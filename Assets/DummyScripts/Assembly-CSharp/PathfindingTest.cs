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

public class PathfindingTest // TypeDefIndex: 27812
{
	// Fields
	private static List<GameObject> pathGos; // 0x00
	public static uint runtimeID; // 0x08
	private static GameObject start; // 0x10
	private static GameObject dest; // 0x18
	public static bool showLastSuccessPath; // 0x20
	public static float obstacleRefreshTime; // 0x24
	private static uint obstacleRefreshTimeToken; // 0x28
	private static Transform obstacleRoot; // 0x30
	private static MonoScenePathfindingNavMeshTester navmesh; // 0x38

	// Constructors
	public PathfindingTest() {} // 0x000000018484D610-0x000000018484D670
	static PathfindingTest() {} // 0x000000018484D580-0x000000018484D610

	// Methods
	// [XID] // 0x0000000189717670-0x0000000189717690
	public static void ShowDestination(Vector3 pos) {} // 0x000000018484B3D0-0x000000018484B6C0
	// [XID] // 0x000000018971F130-0x000000018971F150
	public static void ShowPathByRuntimeId(PathQueryTask task) {} // 0x000000018484C5D0-0x000000018484D190
	// [XID] // 0x0000000189726830-0x0000000189726850
	public static void HidePath() {} // 0x000000018484B9F0-0x000000018484BCA0
	// [XID] // 0x000000018972DD50-0x000000018972DD70
	public static void ShowObstacles() {} // 0x000000018484B100-0x000000018484B3D0
	// [XID] // 0x00000001897353F0-0x0000000189735410
	private static bool OnRefreshObstacle(float delay) => default; // 0x000000018484B010-0x000000018484B100
	// [XID] // 0x000000018973CEA0-0x000000018973CEC0
	public static void OnShowObstacle(GMShowObstacleRsp pbObstalces) {} // 0x000000018484BCA0-0x000000018484C3C0
	// [XID] // 0x0000000189744490-0x00000001897444B0
	public static void HideObstacles() {} // 0x000000018484C3C0-0x000000018484C5D0
	// [XID] // 0x000000018974C110-0x000000018974C130
	public static void ShowNavMesh(Vector3 extent) {} // 0x000000018484D190-0x000000018484D4F0
	// [XID] // 0x00000001897533F0-0x0000000189753410
	public static void OnShowNavMesh(GMShowNavMeshRsp pbShowNavMesh) {} // 0x000000018484B6C0-0x000000018484B9F0
	// [XID] // 0x000000018975A830-0x000000018975A850
	public static void HideNavMesh() {} // 0x000000018484AE70-0x000000018484B010
	// [XID] // 0x0000000189762420-0x0000000189762440
	public static void Stats() {} // 0x000000018484D4F0-0x000000018484D580
}

