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
	public sealed class MonoEffectPluginAudio : BaseMonoEffectPlugin // TypeDefIndex: 19685
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject[] _placeholders; // 0x28
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private ExDrivenAudioEvents.TimedEvent[] _tickEvents; // 0x30
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private ExDrivenAudioEvents.Event[] _setDestroyEvents; // 0x38
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private ExDrivenAudioEvents3D.DurableEvent[] _stoppageEvents; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private ExDrivenAudioEvents3D.DurableEvent[] _exitEvents; // 0x48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private ExDrivenAudioEvents.Event[] _enableEvents; // 0x50
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private ExDrivenAudioEvents.Event[] _disableEvents; // 0x58
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private ExDrivenAudioEvents3D.MultiPositionEvent _mulPosEvent; // 0x60
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private bool _enableSpatial; // 0x68
		private bool _firstDestroy; // 0x69
		private ExDrivenAudioEvents3D _drivenEvents; // 0x70
	
		// Properties
		public ExDrivenAudioEvents3D exDrivenEvents { /* [XID] */ /* 0x0000000189781EE0-0x0000000189781F00 */ get => default; } // 0x00000001846A05A0-0x00000001846A0640 
	
		// Constructors
		public MonoEffectPluginAudio() {} // 0x00000001846A0510-0x00000001846A05A0
	
		// Methods
		// [XID] // 0x00000001897892C0-0x00000001897892E0
		public override void Clear() {} // 0x000000018469FD80-0x000000018469FE60
		// [XID] // 0x0000000189790910-0x0000000189790930
		public override void OnEmittingStopped() {} // 0x00000001846A0310-0x00000001846A03D0
		// [XID] // 0x0000000189798220-0x0000000189798240
		public override void Init() {} // 0x00000001846A0100-0x00000001846A01F0
		// [XID] // 0x00000001897A0110-0x00000001897A0130
		public override void Awaked() {} // 0x000000018469FBD0-0x000000018469FD20
		// [XID] // 0x00000001897A7660-0x00000001897A7680
		public override void Enabled() {} // 0x000000018469FF30-0x00000001846A0020
		// [XID] // 0x00000001897AF0F0-0x00000001897AF110
		public override void Disabled() {} // 0x000000018469FE60-0x000000018469FF30
		// [XID] // 0x00000001897B6D70-0x00000001897B6D90
		public override void Tick(float inDeltaTime) {} // 0x00000001846A03D0-0x00000001846A0510
		// [XID] // 0x00000001897BED50-0x00000001897BED70
		private ListenerPersonality DecideListenerPersonality() => default; // 0x000000018469F9C0-0x000000018469FB70
	}
}
