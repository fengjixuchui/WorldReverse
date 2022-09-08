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
	public class MonoAudioEnableEvent2D : MonoAudioGeneralEvent2D, IAudioUiTickable // TypeDefIndex: 31632
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private AudioEnableDelayParams _enableDelayParams; // 0x20
		private AudioEnableDelay _enableDelay; // 0x28
	
		// Nested types
		public class DelayedWorker : AudioDelayedWorker<MonoAudioEnableEvent2D> // TypeDefIndex: 31633
		{
			// Constructors
			public DelayedWorker() {} // 0x0000000184C810E0-0x0000000184C81150
	
			// Methods
			// [XID] // 0x000000018974D500-0x000000018974D520
			public override void DoWork() {} // 0x0000000184C80FC0-0x0000000184C810E0
			// [XID] // 0x0000000189754BB0-0x0000000189754BD0
			public override void Recycle() {} // 0x0000000184C80F00-0x0000000184C80FC0
		}
	
		// Constructors
		public MonoAudioEnableEvent2D() {} // 0x0000000184C9D400-0x0000000184C9D460
	
		// Methods
		// [XID] // 0x000000018972F1B0-0x000000018972F1D0
		public void Tick() {} // 0x0000000184C9D340-0x0000000184C9D400
		// [XID] // 0x0000000189736BC0-0x0000000189736BE0
		protected virtual void OnEnable() {} // 0x0000000184C9D280-0x0000000184C9D340
		// [XID] // 0x000000018973E760-0x000000018973E780
		protected virtual void OnDisable() {} // 0x0000000184C9D1C0-0x0000000184C9D280
		// [XID] // 0x0000000189745A80-0x0000000189745AA0
		int MoleMole.IAudioUiTickable.GetInstanceID() => default; // 0x0000000184C9D110-0x0000000184C9D1C0
	}
}
