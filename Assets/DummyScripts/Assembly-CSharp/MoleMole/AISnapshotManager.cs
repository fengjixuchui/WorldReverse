/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	[LuaCallCSharp] // 0x0000000189BA67A0-0x0000000189BA67C0
	public static class AISnapshotManager // TypeDefIndex: 20468
	{
		// Fields
		public const float SNAPSHOT_IGNORE_DISTANCE = 50f; // Metadata: 0x00AFDB06
		private static TimerReceiver _collectTimer; // 0x00
		private static readonly float _collectInterval; // 0x08
		private static readonly int _maxCount; // 0x0C
		public static CodedOutputStream _outputStream; // 0x10
		private static LuaFunction _luaFunc; // 0x18
		private static LCAIManager _aiManager; // 0x20
	
		// Constructors
		static AISnapshotManager() {} // 0x0000000184E788C0-0x0000000184E78970
	
		// Methods
		[BlackList] // 0x0000000189BC70B0-0x0000000189BC70F0
		// [XID] // 0x0000000189BC70B0-0x0000000189BC70F0
		public static void InitManager(LCAIManager aiManager) {} // 0x0000000184E78180-0x0000000184E784A0
		[BlackList] // 0x0000000189BD1C80-0x0000000189BD1CC0
		// [XID] // 0x0000000189BD1C80-0x0000000189BD1CC0
		public static void UninitManager() {} // 0x0000000184E78660-0x0000000184E787A0
		[BlackList] // 0x0000000189BDC4A0-0x0000000189BDC4E0
		// [XID] // 0x0000000189BDC4A0-0x0000000189BDC4E0
		public static bool Collect() => default; // 0x0000000184E77A00-0x0000000184E77D40
		// [XID] // 0x00000001895EC070-0x00000001895EC090
		public static string GenerateSnapshot() => default; // 0x0000000184E77D40-0x0000000184E78180
		[BlackList] // 0x00000001895F3490-0x00000001895F34D0
		// [XID] // 0x00000001895F3490-0x00000001895F34D0
		public static void RecordAvatarBeingHit(EvtBeingHit evt, uint victimID) {} // 0x0000000184E784A0-0x0000000184E78660
		// [XID] // 0x00000001895FDB60-0x00000001895FDB80
		private static bool ValidateCriteria(LCAIBeta lcai) => default; // 0x0000000184E787A0-0x0000000184E788C0
	}
}
