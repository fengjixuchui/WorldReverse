/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using Newtonsoft.Json;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public static class BenchmarkNPC // TypeDefIndex: 27665
{
	// Fields
	public static BenchmarkSessionCancellation cancellation; // 0x00
	public static bool needDetailStat; // 0x01
	public static bool disableAutoStatLOD; // 0x02
	public static readonly List<BenchmarkSession> _benchmarkSessions; // 0x08

	// Nested types
	public class BenchmarkSession : IDisposable // TypeDefIndex: 27666
	{
		// Fields
		public static uint minRuntimID; // 0x00
		public int tickStrategy; // 0x10
		private uint configID; // 0x14
		private uint resHandle; // 0x18
		private GameObject loadedPrefab; // 0x20
		private List<GameObject> _gameObjects; // 0x28
		private List<BaseEntity> _entities; // 0x30
		private Dictionary<object, TargetTransform> targetTransformMap; // 0x38

		// Properties
		public int count { /* [XID] */ /* 0x0000000189859980-0x00000001898599A0 */ get => default; } // 0x0000000183DF85C0-0x0000000183DF86A0 

		// Nested types
		public struct TargetTransform // TypeDefIndex: 27667
		{
			// Fields
			public Vector3 pos; // 0x00
			public Quaternion rot; // 0x0C

			// Constructors
			public TargetTransform(Vector3 inPos, Quaternion inRot) {
				pos = default;
				rot = default;
			} // 0x0000000183E18C10-0x0000000183E18CA0
		}

		// Constructors
		public BenchmarkSession() {} // Dummy constructor
		public BenchmarkSession(int inConfigID) {} // 0x0000000183DF8700-0x0000000183DF8910
		static BenchmarkSession() {} // 0x0000000183DF86A0-0x0000000183DF8700

		// Methods
		// [XID] // 0x0000000189860B00-0x0000000189860B20
		private static uint ParseConfigID(int inID, ref bool bNeedGameObject) => default; // 0x0000000183DF7F90-0x0000000183DF8050
		// [XID] // 0x00000001898681F0-0x0000000189868210
		public void SyncTargetTransform() {} // 0x0000000183DF7B40-0x0000000183DF7F90
		// [XID] // 0x000000018986F730-0x000000018986F750
		public void Spawn(Vector3 pos, Quaternion rot, bool bNeedBehaviour = true /* Metadata: 0x00B0CAB3 */) {} // 0x0000000183DF8050-0x0000000183DF85C0
		// [XID] // 0x0000000189876D00-0x0000000189876D20
		public void Dispose() {} // 0x0000000183DF7820-0x0000000183DF7B40
	}

	// Constructors
	static BenchmarkNPC() {} // 0x0000000183E10930-0x0000000183E109D0

	// Methods
	// [XID] // 0x000000018981B780-0x000000018981B7A0
	public static void SyncAllNPCTransform() {} // 0x0000000183E0E730-0x0000000183E0E8E0
	// [XID] // 0x0000000189822D40-0x0000000189822D60
	public static void ClearAll() {} // 0x0000000183E0DBF0-0x0000000183E0E020
	// [XID] // 0x000000018982A650-0x000000018982A670
	public static bool AllNPCReady() => default; // 0x0000000183E10140-0x0000000183E10360
	// [XID] // 0x00000001898319B0-0x00000001898319D0
	public static BenchmarkSession SpawnNPCByCount(int configID, int count) => default; // 0x0000000183E10360-0x0000000183E10930
	// [XID] // 0x0000000189839080-0x00000001898390A0
	public static BenchmarkSession SpawnRectNPC(int configID, int width, int height, int interval, int forceTickStrategy = -1 /* Metadata: 0x00B0CAAE */, bool bHasBehaviour = true /* Metadata: 0x00B0CAB2 */) => default; // 0x0000000183E0FB70-0x0000000183E10140
	// [XID] // 0x0000000189840720-0x0000000189840740
	public static BenchmarkSession SpawnFanNPC(int configID, int innerRadius, int outerRadius, int fov, int interval) => default; // 0x0000000183E0E020-0x0000000183E0E730
	// [XID] // 0x0000000189847C10-0x0000000189847C30
	public static bool OnConsoleCommand(string[] strs) => default; // 0x0000000183E0E8E0-0x0000000183E0FAD0
}

