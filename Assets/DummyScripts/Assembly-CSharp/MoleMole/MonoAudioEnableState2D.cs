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
	public class MonoAudioEnableState2D : MonoAudioState2D, IAudioUiTickable // TypeDefIndex: 31664
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private AudioEnableDelayParams _enableDelayParams; // 0x20
		private AudioEnableDelay _enableDelay; // 0x28
	
		// Nested types
		public class DelayedWorker : AudioDelayedWorker<MonoAudioEnableState2D> // TypeDefIndex: 31665
		{
			// Constructors
			public DelayedWorker() {} // 0x0000000184C80B40-0x0000000184C80BB0
	
			// Methods
			// [XID] // 0x0000000189B31D40-0x0000000189B31D60
			public override void DoWork() {} // 0x0000000184C80A20-0x0000000184C80B40
			// [XID] // 0x0000000189B394D0-0x0000000189B394F0
			public override void Recycle() {} // 0x0000000184C80960-0x0000000184C80A20
		}
	
		// Constructors
		public MonoAudioEnableState2D() {} // 0x0000000184C9D750-0x0000000184C9D7B0
	
		// Methods
		// [XID] // 0x0000000189B14590-0x0000000189B145B0
		public void Tick() {} // 0x0000000184C9D690-0x0000000184C9D750
		// [XID] // 0x0000000189B1BD90-0x0000000189B1BDB0
		protected virtual void OnEnable() {} // 0x0000000184C9D5D0-0x0000000184C9D690
		// [XID] // 0x0000000189B23510-0x0000000189B23530
		protected virtual void OnDisable() {} // 0x0000000184C9D510-0x0000000184C9D5D0
		// [XID] // 0x0000000189B2A790-0x0000000189B2A7B0
		int MoleMole.IAudioUiTickable.GetInstanceID() => default; // 0x0000000184C9D460-0x0000000184C9D510
	}
}
