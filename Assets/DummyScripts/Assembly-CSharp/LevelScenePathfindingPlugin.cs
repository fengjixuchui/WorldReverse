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
using UnityEngine.AI;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class LevelScenePathfindingPlugin : BaseComponentPlugin // TypeDefIndex: 12104
{
	// Fields
	private const float DELAY_SEND_OBSTACLE_TIME = 0.1f; // Metadata: 0x00AEB4CE
	private const float CHECK_OBSTACLE_MOVE_INTERVAL = 0.5f; // Metadata: 0x00AEB4D2
	private static Dictionary<int, PathQueryTask> _queryDict; // 0x00
	private static Dictionary<int, ObstacleInfoInstance> _modifyObstacleDict; // 0x08
	private static Dictionary<int, MonoSceneNavMeshObstacle> _obstacleDict; // 0x10
	private const int CHECK_MOVE_LIST_COUNT = 15; // Metadata: 0x00AEB4D6
	private static int _checkMoveListAddIndex; // 0x18
	private static List<MonoSceneNavMeshObstacle>[] _checkMoveList; // 0x20
	private static uint _obstacleTimerToken; // 0x28
	public static PathfindingType pathfindingType; // 0x30
	private int _checkMoveListIndex; // 0x58
	private static uint _enterSceneReqRetryTimerToken; // 0x34
	private static float _enterSceneReqRetryDelayTime; // 0x38
	private static readonly float MAX_ENTER_SCENE_REQ_RETRY_TIME; // 0x3C
	private static AsyncBakeOperation localBakeInfo; // 0x40

	// Properties
	public override int metaTypeID { /* [XID] */ /* 0x0000000189BBBC30-0x0000000189BBBC50 */ get => default; } // 0x000000018363CC40-0x000000018363CCE0 
	public static StateType state { /* [XID] */ /* 0x0000000189BC3AD0-0x0000000189BC3B10 */ get; /* [XID] */ /* 0x0000000189BCE200-0x0000000189BCE240 */ set; } // 0x0000000183639B80-0x0000000183639C10 0x0000000183638E20-0x0000000183638EB0

	// Nested types
	private class ObstacleInfoInstance : IReusable // TypeDefIndex: 12105
	{
		// Fields
		public MonoSceneNavMeshObstacle info; // 0x10
		public int optionCount; // 0x18

		// Nested types
		public class Spawner : ISpawner<ObstacleInfoInstance> // TypeDefIndex: 12106
		{
			// Constructors
			public Spawner() {} // 0x00000001836248A0-0x0000000183624900

			// Methods
			// [XID] // 0x000000018968A5E0-0x000000018968A600
			public ObstacleInfoInstance Spawn() => default; // 0x00000001836247A0-0x00000001836248A0
		}

		// Constructors
		private ObstacleInfoInstance() {} // 0x0000000183644020-0x0000000183644080

		// Methods
		// [XID] // 0x0000000189682A20-0x0000000189682A40
		void IReusable.BeforeRecycle() {} // 0x0000000183643F80-0x0000000183644020
	}

	public enum StateType // TypeDefIndex: 12107
	{
		Uninit = 0,
		Panding = 1,
		Init = 2
	}

	public enum PathfindingType // TypeDefIndex: 12108
	{
		None = 0,
		Server = 1,
		Client = 2
	}

	private struct AsyncBakeOperation // TypeDefIndex: 12109
	{
		// Fields
		public NavMeshSurface surface; // 0x00
		public NavMeshData bakeData; // 0x08
		public AsyncOperation bakeOperation; // 0x10
	}

	// Constructors
	static LevelScenePathfindingPlugin() {} // 0x000000018363C9D0-0x000000018363CBE0
	public LevelScenePathfindingPlugin() {} // 0x000000018363CBE0-0x000000018363CC40

	// Methods
	// [XID] // 0x0000000189BD85A0-0x0000000189BD85C0
	public override void Init() {} // 0x000000018363ABF0-0x000000018363AED0
	// [XID] // 0x0000000189BDFEA0-0x0000000189BDFEC0
	public static AsyncOperation StartBuildNavMesh(Vector3 center, Vector3 size) => default; // 0x000000018363A430-0x000000018363ABF0
	// [XID] // 0x00000001895ECB60-0x00000001895ECB80
	public static AsyncOperation CheckNavMeshBuildState() => default; // 0x000000018363C200-0x000000018363C480
	// [XID] // 0x00000001895F41D0-0x00000001895F41F0
	public override void Destroy() {} // 0x0000000183639720-0x0000000183639B80
	// [XID] // 0x00000001895FBA00-0x00000001895FBA20
	public override void LateTick(float deltaTime) {} // 0x000000018363C0B0-0x000000018363C190
	// [XID] // 0x0000000189603160-0x0000000189603180
	public static uint GetCurrentSceneID() => default; // 0x0000000183639C10-0x0000000183639CF0
	// [XID] // 0x000000018960AB80-0x000000018960ABA0
	private static void StartLaterRetrySendEnterSceneReqTimer() {} // 0x0000000183639CF0-0x0000000183639F90
	// [XID] // 0x0000000189612130-0x0000000189612150
	private static void StopLaterRetrySendEnterSceneReqTimer() {} // 0x0000000183638FC0-0x0000000183639120
	// [XID] // 0x0000000189619AB0-0x0000000189619AD0
	private static bool OnLaterRetrySendEnterSceneReqHandler(float delay) => default; // 0x0000000183638EB0-0x0000000183638FC0
	// [XID] // 0x0000000189620F50-0x0000000189620F70
	private void OnObstacleMoveCheckHandler() {} // 0x000000018363C570-0x000000018363C9D0
	// [XID] // 0x00000001896286E0-0x0000000189628700
	private static void StartObstacleTimer() {} // 0x000000018363A1B0-0x000000018363A430
	// [XID] // 0x000000018962FFD0-0x000000018962FFF0
	private static void StopObstacleTimer() {} // 0x0000000183638AE0-0x0000000183638C70
	// [XID] // 0x0000000189637CC0-0x0000000189637CE0
	private static bool CheckObstacleNotifyLimit(ObstacleModifyNotify notify) => default; // 0x0000000183639F90-0x000000018363A0B0
	// [XID] // 0x000000018963EF10-0x000000018963EF30
	private static void DoSendObstacleNotify(ObstacleModifyNotify notify) {} // 0x000000018363BF80-0x000000018363C0B0
	// [XID] // 0x0000000189646840-0x0000000189646860
	private static bool OnSendObstacleHandler(float delay) => default; // 0x000000018363AF30-0x000000018363B4F0
	// [XID] // 0x000000018964DFA0-0x000000018964DFC0
	public static void OnQueryTaskAdd(PathQueryTask task) {} // 0x000000018363C480-0x000000018363C570
	// [XID] // 0x0000000189655850-0x0000000189655870
	public static PathQueryTask GetQueryPathTask(int queryID) => default; // 0x000000018363A0B0-0x000000018363A1B0
	// [XID] // 0x000000018965D040-0x000000018965D060
	public static void OnQueryTaskRemove(int queryID) {} // 0x000000018363B7B0-0x000000018363B920
	// [XID] // 0x00000001896645D0-0x00000001896645F0
	public static void OnObstacleAdd(int obstacleId, MonoSceneNavMeshObstacle obstacleInfo) {} // 0x000000018363B920-0x000000018363BF80
	// [XID] // 0x000000018966BBF0-0x000000018966BC10
	public static void OnObstacleRemove(int obstacleId) {} // 0x000000018363B4F0-0x000000018363B7B0
	// [XID] // 0x0000000189673A20-0x0000000189673A40
	public static void SyncSceneReq() {} // 0x0000000183639120-0x00000001836396A0
	// [XID] // 0x00000001896AF660-0x00000001896AF680
	public static bool SendQueryPathReq(QueryPathReq req) => default; // 0x0000000183638C70-0x0000000183638DC0
}

