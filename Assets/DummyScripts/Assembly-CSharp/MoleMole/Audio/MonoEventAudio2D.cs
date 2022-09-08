/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole.Audio
{
	public class MonoEventAudio2D : MonoEventAudio<ExDrivenAudioEvents2D>, IAudioUiTickable // TypeDefIndex: 31646
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private ExDrivenAudioEvents.Event[] _exitEvents; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private AudioEnableDelayParams _enableDelayParams; // 0x48
		private AudioEnableDelay _enableDelay; // 0x50
	
		// Nested types
		public class DelayedWorker : AudioDelayedWorker<MonoEventAudio2D> // TypeDefIndex: 31647
		{
			// Constructors
			public DelayedWorker() {} // 0x00000001867286D0-0x0000000186728740
	
			// Methods
			// [XID] // 0x0000000189886E60-0x0000000189886E80
			public override void DoWork() {} // 0x00000001867285C0-0x00000001867286D0
			// [XID] // 0x000000018988DF50-0x000000018988DF70
			public override void Recycle() {} // 0x0000000186728500-0x00000001867285C0
		}
	
		// Constructors
		public MonoEventAudio2D() {} // 0x0000000186729F50-0x0000000186729FC0
	
		// Methods
		// [XID] // 0x000000018985ACA0-0x000000018985ACC0
		protected override ExDrivenAudioEvents2D CreateExDrivenEvents(GameObject[] placeholders, ExDrivenAudioEvents.TimedEvent[] tickEvents, ExDrivenAudioEvents.Event[] enableEvents, ExDrivenAudioEvents.Event[] disableEvents) => default; // 0x00000001867299E0-0x0000000186729B10
		// [XID] // 0x0000000189862130-0x0000000189862150
		public void Tick() {} // 0x0000000186729E90-0x0000000186729F50
		// [XID] // 0x0000000189869610-0x0000000189869630
		protected override void OnEnable() {} // 0x0000000186729DD0-0x0000000186729E90
		// [XID] // 0x0000000189870850-0x0000000189870870
		protected override void OnDisable() {} // 0x0000000186729C70-0x0000000186729DD0
		// [XID] // 0x00000001898782E0-0x0000000189878300
		private void InvokeBaseOnEnable() {} // 0x0000000186729BC0-0x0000000186729C70
		// [XID] // 0x000000018987F790-0x000000018987F7B0
		int MoleMole.IAudioUiTickable.GetInstanceID() => default; // 0x0000000186729B10-0x0000000186729BC0
	}
}
