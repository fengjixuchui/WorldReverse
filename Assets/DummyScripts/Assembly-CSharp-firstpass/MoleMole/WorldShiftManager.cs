/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;
using UnityEngine;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace MoleMole
{
	public class WorldShiftManager : GlobalManager // TypeDefIndex: 10655
	{
		// Fields
		private const float DEFAULT_LIMIT_LENGTH = 1024f; // Metadata: 0x00AE8034
		private HashSet<IWorldShiftAgent> _agentSet; // 0x10
		private static Vector3 _curWorldPositionShift; // 0x00
		private Vector3 _initWorldPositionShift; // 0x18
		private IWorldShiftCenter _centerAgent; // 0x28
		private static bool _enable; // 0x0C
		private float _tileMaxLimitLengthSqr; // 0x30
		public static bool DebugMode; // 0x0D
		public int shiftCount; // 0x34
	
		// Properties
		public static bool Enable { /* [XID] */ /* 0x00000001896519E0-0x0000000189651A00 */ get => default; } // 0x000000018609E660-0x000000018609E790 
	
		// Constructors
		public WorldShiftManager() {} // 0x000000018609E5F0-0x000000018609E660
		static WorldShiftManager() {} // 0x000000018609E580-0x000000018609E5F0
	
		// Methods
		// [XID] // 0x000000018970FC90-0x000000018970FCB0
		public override void Init() {} // 0x000000018609D4D0-0x000000018609D610
		// [XID] // 0x0000000189716F30-0x0000000189716F50
		public override void Destroy() {} // 0x000000018609CA70-0x000000018609CB30
		// [XID] // 0x000000018971E8E0-0x000000018971E900
		public override void ReloadRes() {} // 0x000000018609DBA0-0x000000018609DC40
		// [XID] // 0x0000000189726020-0x0000000189726040
		public override void ClearOnLevelDestroy() {} // 0x000000018609C930-0x000000018609CA70
		// [XID] // 0x000000018972D590-0x000000018972D5B0
		public override void Tick() {} // 0x000000018609DCF0-0x000000018609DD90
		// [XID] // 0x0000000189734CF0-0x0000000189734D10
		public void UpdateByPos(Vector3 pos) {} // 0x000000018609E470-0x000000018609E580
		// [XID] // 0x0000000189B94870-0x0000000189B94890
		public void UpdateByCenterAgentPosition() {} // 0x000000018609E250-0x000000018609E470
		// [XID] // 0x0000000189743D20-0x0000000189743D40
		private bool IsPosNeedShift(Vector3 pos) => default; // 0x000000018609D610-0x000000018609D760
		// [XID] // 0x000000018974B950-0x000000018974B970
		public void SetMaxLimitDistance(float dis) {} // 0x000000018609DC40-0x000000018609DCF0
		// [XID] // 0x0000000189785FD0-0x0000000189785FF0
		public void RegisterWorldCenter(IWorldShiftCenter agent) {} // 0x000000018609D9F0-0x000000018609DAB0
		// [XID] // 0x00000001896141B0-0x00000001896141D0
		public void RegisteAllManagers() {} // 0x000000018609D760-0x000000018609D9F0
		// [XID] // 0x0000000189761E40-0x0000000189761E60
		public void InitWorldCenterOffset(Vector3 pos) {} // 0x000000018609D400-0x000000018609D4D0
		// [XID] // 0x00000001897C0360-0x00000001897C0380
		public void EnableMgr(bool enable) {} // 0x000000018609CB30-0x000000018609CC10
		// [XID] // 0x00000001897708D0-0x00000001897708F0
		public void Register(IWorldShiftAgent agent) {} // 0x000000018609DAB0-0x000000018609DBA0
		// [XID] // 0x000000018977E7E0-0x000000018977E800
		public void Unregister(IWorldShiftAgent agent) {} // 0x000000018609DDF0-0x000000018609DEC0
		// [XID] // 0x000000018977F600-0x000000018977F620
		private void UpdateAllAgentPosition(Vector3 shift) {} // 0x000000018609DEC0-0x000000018609E250
		// [XID] // 0x0000000189787000-0x0000000189787020
		public static Vector3 GetCurShift() => default; // 0x000000018609CFD0-0x000000018609D0D0
		// [IDTag] // 0x000000018978E640-0x000000018978E680
		// [XID] // 0x000000018978E640-0x000000018978E680
		public static Vector3 GetAbsolutePosition(Vector3 pos) => default; // 0x000000018609CE30-0x000000018609CFD0
		// [IDTag] // 0x0000000189798C90-0x0000000189798CD0
		// [XID] // 0x0000000189798C90-0x0000000189798CD0
		public static Vector3 GetRelativePosition(Vector3 pos) => default; // 0x000000018609D0D0-0x000000018609D270
		// [IDTag] // 0x00000001897A3B30-0x00000001897A3B70
		// [XID] // 0x00000001897A3B30-0x00000001897A3B70
		public static Vector3d GetAbsolutePosition(Vector3d pos) => default; // 0x000000018609CCB0-0x000000018609CE30
		// [IDTag] // 0x00000001897AE240-0x00000001897AE280
		// [XID] // 0x00000001897AE240-0x00000001897AE280
		public static Vector3d GetRelativePosition(Vector3d pos) => default; // 0x000000018609D270-0x000000018609D400
		// [XID] // 0x0000000189906710-0x0000000189906730
		public static Transform FilterCutsceneParent(Transform trans) => default; // 0x000000018609CC10-0x000000018609CCB0
	}
}
