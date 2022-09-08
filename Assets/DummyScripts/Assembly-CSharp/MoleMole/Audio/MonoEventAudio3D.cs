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

namespace MoleMole.Audio
{
	public class MonoEventAudio3D : MonoEventAudio<ExDrivenAudioEvents3D> // TypeDefIndex: 31648
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private ExDrivenAudioEvents3D.DurableEvent[] _exitEvents; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private ExDrivenAudioEvents3D.MultiPositionEvent _mulPosEvent; // 0x48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private bool _enableSpatial; // 0x50
	
		// Constructors
		public MonoEventAudio3D() {} // 0x000000018672A3F0-0x000000018672A460
	
		// Methods
		// [XID] // 0x00000001898AB9B0-0x00000001898AB9D0
		protected override ExDrivenAudioEvents3D CreateExDrivenEvents(GameObject[] placeholders, ExDrivenAudioEvents.TimedEvent[] tickEvents, ExDrivenAudioEvents.Event[] enableEvents, ExDrivenAudioEvents.Event[] disableEvents) => default; // 0x000000018672A020-0x000000018672A160
		// [XID] // 0x00000001898B3170-0x00000001898B3190
		protected override void Update() {} // 0x000000018672A2B0-0x000000018672A3F0
		// [XID] // 0x00000001898BAE90-0x00000001898BAEB0
		protected override void OnDisable() {} // 0x000000018672A1C0-0x000000018672A2B0
	}
}
