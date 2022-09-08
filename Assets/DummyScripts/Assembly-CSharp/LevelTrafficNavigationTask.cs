/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using miHoYoThread;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class LevelTrafficNavigationTask : ThreadTask<LevelTrafficNavigationData> // TypeDefIndex: 26611
{
	// Fields
	private const string _taskName = "LevelTrafficNavigation"; // Metadata: 0x00B0C6A6
	private Queue<TrafficPathQueryPattern> _pathComputingPatterns; // 0x48
	private Queue<TrafficPathQueryPattern> _pathComputedPatterns; // 0x50

	// Properties
	public override string taskName { /* [XID] */ /* 0x000000018979FDD0-0x000000018979FDF0 */ get => default; } // 0x00000001847952A0-0x0000000184795350 

	// Constructors
	public LevelTrafficNavigationTask() {} // 0x00000001847951E0-0x00000001847952A0

	// Methods
	// [XID] // 0x00000001897A7310-0x00000001897A7330
	public override void Collect() {} // 0x0000000184794A30-0x0000000184794AD0
	// [XID] // 0x00000001897AEDC0-0x00000001897AEDE0
	private void DispatchTrafficPathQueries() {} // 0x0000000184794E80-0x0000000184794FF0
	// [XID] // 0x00000001897B6B10-0x00000001897B6B30
	public override void Execute() {} // 0x0000000184794C00-0x0000000184794D20
	// [XID] // 0x00000001897BE9B0-0x00000001897BE9D0
	public override void Flush() {} // 0x0000000184794D20-0x0000000184794E20
	// [XID] // 0x00000001897C6040-0x00000001897C6060
	protected override void OnDestroy() {} // 0x0000000184794FF0-0x00000001847950D0
	// [XID] // 0x00000001897CD8A0-0x00000001897CD8C0
	public TrafficPathQueryPattern CreateTrafficPathQueryPattern(TrafficPathfinder trafficPathfinder, Action<bool, List<Vector3>> onPathfindingComplete) => default; // 0x00000001847950D0-0x00000001847951E0
}

