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

public class PathQueryTask : IReusable // TypeDefIndex: 14743
{
	// Fields
	private const float QUERY_PATH_OVER_TIME = 3f; // Metadata: 0x00AEBEA0
	public static readonly float DISTANCE_AGENT_RADIUS; // 0x00
	private static readonly float DISTANCE_ARRIVE_POSITION; // 0x04
	private static int QUERY_ID_INCREATE; // 0x08
	public int queryID; // 0x10
	public uint enityRuntimeID; // 0x14
	public QueryStatus status; // 0x18
	public Vector3 start; // 0x1C
	public Vector3 destination; // 0x28
	public List<Vector3> corners; // 0x38
	public float startTime; // 0x40
	private int _nextPathCorner; // 0x44
	private PathFollowInfo _pathFollowInfo; // 0x48
	private uint _lifeTimerToken; // 0x50

	// Nested types
	public enum QueryStatus // TypeDefIndex: 14744
	{
		Inactive = 0,
		Pending = 1,
		Partial = 2,
		Success = 3,
		Fail = 4
	}

	public enum ArriveCornerType // TypeDefIndex: 14745
	{
		Arrived = 0,
		Near = 1,
		Far = 2
	}

	public class Spawner : ISpawner<PathQueryTask> // TypeDefIndex: 14746
	{
		// Constructors
		public Spawner() {} // 0x0000000184063E90-0x0000000184063EF0

		// Methods
		// [XID] // 0x000000018991C970-0x000000018991C990
		public PathQueryTask Spawn() => default; // 0x0000000184063DD0-0x0000000184063E90
	}

	// Constructors
	private PathQueryTask() {} // 0x0000000184046DB0-0x0000000184046E60
	static PathQueryTask() {} // 0x0000000184046D40-0x0000000184046DB0

	// Methods
	// [XID] // 0x00000001898D0E20-0x00000001898D0E40
	public void Init(Vector3 start, Vector3 destination, float createTime, bool isServer = true /* Metadata: 0x00AEBE9F */) {} // 0x0000000184046520-0x0000000184046770
	// [XID] // 0x00000001895E8430-0x00000001895E8450
	public void StopOutTimeTimer() {} // 0x0000000184046430-0x0000000184046520
	// [XID] // 0x00000001896DBAA0-0x00000001896DBAC0
	private ArriveCornerType CheckArriveConner(ref Vector3 currentPosition, int index, float almostReachedDistance) => default; // 0x0000000184046920-0x0000000184046D40
	// [XID] // 0x00000001896D4260-0x00000001896D4280
	public Vector3? GetNextConner(Vector3 currentPosition, float almostReachedDistance) => default; // 0x0000000184045CD0-0x0000000184046430
	// [XID] // 0x00000001898EF480-0x00000001898EF4A0
	public Vector3? GetDirection(Vector3 currentPosition, float almostReachedDistance) => default; // 0x0000000184045AC0-0x0000000184045CD0
	// [XID] // 0x0000000189739380-0x00000001897393A0
	public bool MoveToNextConner() => default; // 0x0000000184046840-0x0000000184046920
	// [XID] // 0x0000000189692530-0x0000000189692550
	private bool OnTimeOut(float delay) => default; // 0x0000000184045700-0x00000001840458E0
	// [XID] // 0x0000000189905C00-0x0000000189905C20
	public void BeforeRecycle() {} // 0x0000000184045990-0x0000000184045AC0
	// [XID] // 0x000000018990D640-0x000000018990D660
	public bool Failed() => default; // 0x00000001840458E0-0x0000000184045990
	// [XID] // 0x0000000189914D10-0x0000000189914D30
	public bool Succeeded() => default; // 0x0000000184046770-0x0000000184046840
}

