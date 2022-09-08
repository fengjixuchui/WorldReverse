/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	public sealed class MonoEffectPluginCameraShake : BaseMonoEffectPlugin // TypeDefIndex: 19698
	{
		// Fields
		public CameraShakeType shakeType; // 0x28
		public float shakeValue; // 0x2C
		public float shakeRange; // 0x30
		public Vector3 dir; // 0x34
		private ShakeSource _shakeSource; // 0x40
		private int _handle; // 0x48
	
		// Constructors
		public MonoEffectPluginCameraShake() {} // 0x0000000184E39600-0x0000000184E396E0
	
		// Methods
		// [XID] // 0x00000001899757D0-0x00000001899757F0
		public override void Init() {} // 0x0000000184E39270-0x0000000184E39310
		// [XID] // 0x000000018997C8F0-0x000000018997C910
		public override void Tick(float inDeltaTime) {} // 0x0000000184E39470-0x0000000184E39600
		// [XID] // 0x0000000189984650-0x0000000189984670
		public override void Enabled() {} // 0x0000000184E39060-0x0000000184E39100
		// [XID] // 0x000000018998C0B0-0x000000018998C0D0
		public override void Disabled() {} // 0x0000000184E38FC0-0x0000000184E39060
		// [XID] // 0x0000000189993DD0-0x0000000189993DF0
		public override void OnEmittingStopped() {} // 0x0000000184E393D0-0x0000000184E39470
		// [XID] // 0x000000018999B680-0x000000018999B6A0
		private void StartShake() {} // 0x0000000184E38CD0-0x0000000184E38F60
		// [XID] // 0x00000001899A2D70-0x00000001899A2D90
		private void StopShake() {} // 0x0000000184E39180-0x0000000184E39270
	}
}
