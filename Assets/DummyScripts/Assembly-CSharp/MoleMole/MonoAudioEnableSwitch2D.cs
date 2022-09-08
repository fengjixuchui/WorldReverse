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
	public class MonoAudioEnableSwitch2D : MonoAudioSwitch2D, IAudioUiTickable // TypeDefIndex: 31679
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private AudioEnableDelayParams _enableDelayParams; // 0x20
		private AudioEnableDelay _enableDelay; // 0x28
	
		// Nested types
		public class DelayedWorker : AudioDelayedWorker<MonoAudioEnableSwitch2D> // TypeDefIndex: 31680
		{
			// Constructors
			public DelayedWorker() {} // 0x0000000184C80E90-0x0000000184C80F00
	
			// Methods
			// [XID] // 0x000000018961E780-0x000000018961E7A0
			public override void DoWork() {} // 0x0000000184C80D70-0x0000000184C80E90
			// [XID] // 0x0000000189625B60-0x0000000189625B80
			public override void Recycle() {} // 0x0000000184C80CB0-0x0000000184C80D70
		}
	
		// Constructors
		public MonoAudioEnableSwitch2D() {} // 0x0000000184C9DAA0-0x0000000184C9DB00
	
		// Methods
		// [XID] // 0x00000001896006A0-0x00000001896006C0
		public void Tick() {} // 0x0000000184C9D9E0-0x0000000184C9DAA0
		// [XID] // 0x0000000189607FB0-0x0000000189607FD0
		protected virtual void OnEnable() {} // 0x0000000184C9D920-0x0000000184C9D9E0
		// [XID] // 0x000000018960F980-0x000000018960F9A0
		protected virtual void OnDisable() {} // 0x0000000184C9D860-0x0000000184C9D920
		// [XID] // 0x0000000189616B90-0x0000000189616BB0
		int MoleMole.IAudioUiTickable.GetInstanceID() => default; // 0x0000000184C9D7B0-0x0000000184C9D860
	}
}
