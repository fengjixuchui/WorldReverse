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

namespace miHoYoCamera
{
	public class CameraStateMgr : ICameraStateMgr // TypeDefIndex: 8953
	{
		// Fields
		protected Queue<CameraStateCmd> _cmdQueue; // 0x10
		protected Dictionary<int, ICameraState> _statePool; // 0x18
		protected List<ICameraState> _stateList; // 0x20
		protected CameraStack _stack; // 0x28
		protected CameraStateBlender _blender; // 0x30
		protected ICameraState _state0; // 0x38
		protected ICameraState _state1; // 0x40
		protected CameraStatePostProcesser _postProcesser; // 0x48
		protected Camera _camera; // 0x50
	
		// Properties
		public List<ICameraState> stateList { /* [XID] */ /* 0x000000018982B7C0-0x000000018982B7E0 */ get => default; } // 0x0000000185A77960-0x0000000185A77A00 
		public CameraStateBlender blender { /* [XID] */ /* 0x0000000189A146C0-0x0000000189A146E0 */ get => default; } // 0x0000000185A776E0-0x0000000185A77780 
		public ICameraState state0 { /* [XID] */ /* 0x0000000189AB7550-0x0000000189AB7570 */ get => default; } // 0x0000000185A77820-0x0000000185A778C0 
		public ICameraState state1 { /* [XID] */ /* 0x0000000189ABF010-0x0000000189ABF030 */ get => default; } // 0x0000000185A778C0-0x0000000185A77960 
		public CameraStatePostProcesser postProcesser { /* [XID] */ /* 0x0000000189848B40-0x0000000189848B60 */ get => default; } // 0x0000000185A77780-0x0000000185A77820 
	
		// Nested types
		public enum CmdType // TypeDefIndex: 8954
		{
			SPAWN = 0,
			UNSPAWN = 1
		}
	
		public struct CameraStateCmd // TypeDefIndex: 8955
		{
			// Fields
			public CmdType cmdType; // 0x00
			public int stateId; // 0x04
		}
	
		// Constructors
		public CameraStateMgr() {} // 0x0000000185A775B0-0x0000000185A776E0
	
		// Methods
		// [XID] // 0x000000018990CBD0-0x000000018990CBF0
		public void SetPostProcesser(CameraStatePostProcesser postProcesser) {} // 0x0000000185A765B0-0x0000000185A76660
		// [XID] // 0x000000018996DC20-0x000000018996DC40
		public string DumpStackInfo() => default; // 0x0000000185A75460-0x0000000185A75610
		// [XID] // 0x000000018985E870-0x000000018985E890
		public void Clear() {} // 0x0000000185A74E00-0x0000000185A74EB0
		// [XID] // 0x0000000189AFE890-0x0000000189AFE8B0
		public void BindCamera(Camera camera) {} // 0x0000000185A74D50-0x0000000185A74E00
		// [XID] // 0x000000018986D880-0x000000018986D8A0
		public void RegisterState(ICameraState state) {} // 0x0000000185A763E0-0x0000000185A765B0
		// [XID] // 0x0000000189874CD0-0x0000000189874CF0
		public void UnregisterState(ICameraState state) {} // 0x0000000185A773D0-0x0000000185A775B0
		public PostModuleType RegisterPostModule<PostModuleType>()
			where PostModuleType : CameraStatePostModule, new() => default;
		// [XID] // 0x0000000189948800-0x0000000189948820
		public ICameraState GetStateByType(int stateType) => default; // 0x0000000185A761C0-0x0000000185A76300
		// [XID] // 0x0000000189883870-0x0000000189883890
		public void SpawnState(int stateId) {} // 0x0000000185A76B60-0x0000000185A76C40
		// [XID] // 0x000000018988B090-0x000000018988B0B0
		public void SpawnStateImmdiately(int stateId) {} // 0x0000000185A767C0-0x0000000185A76870
		// [XID] // 0x0000000189B99120-0x0000000189B99140
		public void SpawnStateByType(int stateType) {} // 0x0000000185A76660-0x0000000185A767C0
		// [XID] // 0x0000000189B933D0-0x0000000189B933F0
		private void SpawnStateInternal(int stateId) {} // 0x0000000185A76870-0x0000000185A76B60
		// [XID] // 0x00000001898A1140-0x00000001898A1160
		public void UnSpawnState(int stateId) {} // 0x0000000185A772F0-0x0000000185A773D0
		// [XID] // 0x000000018994FF90-0x000000018994FFB0
		public void UnSpawnStateImmdiately(int stateId) {} // 0x0000000185A76FD0-0x0000000185A77080
		// [XID] // 0x00000001898B0280-0x00000001898B02A0
		public void UnSpawnStateByType(int stateType) {} // 0x0000000185A76E70-0x0000000185A76FD0
		// [XID] // 0x0000000189610050-0x0000000189610070
		private void UnSpawnStateInternal(int stateId) {} // 0x0000000185A77080-0x0000000185A772F0
		// [XID] // 0x00000001898BEE60-0x00000001898BEE80
		private void CollectTop(float deltaTime) {} // 0x0000000185A752B0-0x0000000185A75380
		// [XID] // 0x00000001898C67B0-0x00000001898C67D0
		private ICameraState FindTop() => default; // 0x0000000185A75740-0x0000000185A75870
		// [XID] // 0x0000000189623440-0x0000000189623460
		private void CollectNext(float deltaTime) {} // 0x0000000185A750D0-0x0000000185A751A0
		// [XID] // 0x00000001898D57B0-0x00000001898D57D0
		private ICameraState FindNext() => default; // 0x0000000185A75610-0x0000000185A75740
		// [XID] // 0x0000000189B57F80-0x0000000189B57FA0
		public void Collect(float deltaTime) {} // 0x0000000185A75380-0x0000000185A75460
		// [XID] // 0x0000000189B324A0-0x0000000189B324C0
		protected void CollectComd() {} // 0x0000000185A74EB0-0x0000000185A74FD0
		// [XID] // 0x00000001898EC660-0x00000001898EC680
		protected void CollectInternal(ICameraState state, float deltaTime) {} // 0x0000000185A74FD0-0x0000000185A750D0
		// [XID] // 0x0000000189B06140-0x0000000189B06160
		protected void CollectPostProcesser(float deltaTime) {} // 0x0000000185A751A0-0x0000000185A752B0
		// [XID] // 0x00000001898FB480-0x00000001898FB4A0
		public void Tick(float deltaTime) {} // 0x0000000185A76D40-0x0000000185A76E70
		// [XID] // 0x0000000189903110-0x0000000189903130
		protected void TickInternal(ICameraState state, float deltaTime) {} // 0x0000000185A76C40-0x0000000185A76D40
		// [XID] // 0x000000018990A6E0-0x000000018990A700
		public void Flush(float deltaTime) {} // 0x0000000185A75E70-0x0000000185A761C0
		// [XID] // 0x0000000189912090-0x00000001899120B0
		private void FlushStateInternal(ICameraState state, float deltaTime) {} // 0x0000000185A75D70-0x0000000185A75E70
		// [XID] // 0x0000000189919B80-0x0000000189919BA0
		private void FlushPostProcesserInternal(float deltaTime) {} // 0x0000000185A75870-0x0000000185A75940
		// [XID] // 0x00000001899210D0-0x00000001899210F0
		private void FlushStateData(CameraStateData data) {} // 0x0000000185A75940-0x0000000185A75D70
		// [XID] // 0x0000000189928AF0-0x0000000189928B10
		private void PostFlushTop(ICameraState state) {} // 0x0000000185A76300-0x0000000185A763E0
	}
}
