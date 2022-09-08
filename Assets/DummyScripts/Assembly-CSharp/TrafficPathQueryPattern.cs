/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class TrafficPathQueryPattern : ISimplePoolObject // TypeDefIndex: 26609
{
	// Fields
	private static SimpleObjectPool<TrafficPathQueryPattern> _pool; // 0x00
	private TrafficPathfinder _trafficPathfinder; // 0x10
	private Action<bool, List<Vector3>> _onPathfindingComplete; // 0x18
	private Vector3? _start; // 0x20
	private Vector3? _goal; // 0x30
	private float _searchRange; // 0x40
	private bool _walkable; // 0x44
	private bool _auxiliary; // 0x45
	private bool _result; // 0x46
	private List<Vector3> _resultPath; // 0x48

	// Constructors
	public TrafficPathQueryPattern() {} // 0x0000000181680300-0x0000000181680370
	static TrafficPathQueryPattern() {} // 0x0000000181680290-0x0000000181680300

	// Methods
	// [XID] // 0x00000001897072F0-0x0000000189707310
	public static TrafficPathQueryPattern Create(TrafficPathfinder trafficPathfinder, Action<bool, List<Vector3>> onPathfindingComplete) => default; // 0x000000018167FB70-0x000000018167FC90
	// [XID] // 0x000000018970EB90-0x000000018970EBB0
	public static void Release(TrafficPathQueryPattern pattern) {} // 0x00000001816800C0-0x00000001816801B0
	// [XID] // 0x0000000189715F90-0x0000000189715FB0
	public void Init(TrafficPathfinder trafficPathfinder, Action<bool, List<Vector3>> onPathfindingComplete) {} // 0x000000018167FAA0-0x000000018167FB70
	// [XID] // 0x000000018971D9D0-0x000000018971D9F0
	public void AddQueryData(Vector3 start, Vector3 goal, float searchRange, bool requireWalkable, bool includeAuxiliary, List<Vector3> resultPath) {} // 0x000000018167FE30-0x000000018167FFE0
	// [XID] // 0x0000000189724E70-0x0000000189724E90
	public void ResetObject() {} // 0x00000001816801B0-0x0000000181680290
	// [XID] // 0x000000018972C5A0-0x000000018972C5C0
	public void ComputePath() {} // 0x000000018167FC90-0x000000018167FE30
	// [XID] // 0x0000000189733CC0-0x0000000189733CE0
	public void Flush() {} // 0x000000018167FFE0-0x00000001816800C0
	// [XID] // 0x000000018973B460-0x000000018973B480
	public bool IsCancelled() => default; // 0x000000018167F950-0x000000018167FA00
	// [XID] // 0x0000000189742DC0-0x0000000189742DE0
	public void Cancel() {} // 0x000000018167FA00-0x000000018167FAA0
}

