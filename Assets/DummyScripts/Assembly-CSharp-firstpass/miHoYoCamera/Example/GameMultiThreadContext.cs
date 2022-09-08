/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;
using miHoYoCamera;
using UnityEngine;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace miHoYoCamera.Example
{
	public class GameMultiThreadContext : MonoBehaviour // TypeDefIndex: 8968
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private PlayerCtrl _player; // 0x18
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _target; // 0x20
		public bool MULTI_THREAD; // 0x28
		private CameraStateMgr _stateMgr; // 0x30
		private CameraMgrSchedulerBeforeTask _stateBefore; // 0x38
		private CameraMgrSchedulerAfterTask _stateAfter; // 0x40
		public static float frameDeltaTime; // 0x00
	
		// Constructors
		public GameMultiThreadContext() {} // 0x0000000187332B90-0x0000000187332C40
		static GameMultiThreadContext() {} // 0x0000000187332B30-0x0000000187332B90
	
		// Methods
		// [XID] // 0x0000000189A35BC0-0x0000000189A35BE0
		private void Awake() {} // 0x0000000187331C90-0x0000000187331E00
		// [XID] // 0x0000000189647F00-0x0000000189647F20
		private void Start() {} // 0x0000000187332930-0x0000000187332A00
		// [XID] // 0x00000001896ED410-0x00000001896ED430
		private void InitCfg() {} // 0x0000000187332310-0x0000000187332570
		// [XID] // 0x0000000189A4C1C0-0x0000000189A4C1E0
		private void CheckRunner() {} // 0x0000000187331E00-0x0000000187331EE0
		// [XID] // 0x0000000189A53990-0x0000000189A539B0
		private void OnGUI() {} // 0x0000000187332760-0x0000000187332930
		// [XID] // 0x0000000189A5B060-0x0000000189A5B080
		private void Update() {} // 0x0000000187332A00-0x0000000187332B30
		// [XID] // 0x0000000189A628E0-0x0000000189A62900
		private void LateUpdate() {} // 0x0000000187332570-0x00000001873326A0
		// [XID] // 0x0000000189A6A640-0x0000000189A6A660
		private void OnDestroy() {} // 0x00000001873326A0-0x0000000187332760
		// [XID] // 0x0000000189A59BA0-0x0000000189A59BC0
		private void CreateCameraExampleTask() {} // 0x0000000187331EE0-0x0000000187332310
	}
}
