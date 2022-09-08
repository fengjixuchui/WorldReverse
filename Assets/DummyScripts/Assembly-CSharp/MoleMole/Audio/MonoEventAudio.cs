/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole.Audio
{
	public abstract class MonoEventAudio : MonoBehaviour // TypeDefIndex: 31645
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject[] _placeholders; // 0x18
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private ExDrivenAudioEvents.TimedEvent[] _tickEvents; // 0x20
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private ExDrivenAudioEvents.Event[] _enableEvents; // 0x28
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private ExDrivenAudioEvents.Event[] _disableEvents; // 0x30
	
		// Properties
		public abstract ExDrivenAudioEvents exDrivenEvents { get; }
		protected GameObject[] placeholders { /* [XID] */ /* 0x000000018982E5C0-0x000000018982E5E0 */ get; } // 0x000000018672A500-0x000000018672A5A0 
		protected ExDrivenAudioEvents.TimedEvent[] tickEvents { /* [XID] */ /* 0x0000000189835F30-0x0000000189835F50 */ get; } // 0x000000018672A5A0-0x000000018672A640 
		protected ExDrivenAudioEvents.Event[] enableEvents { /* [XID] */ /* 0x000000018983D430-0x000000018983D450 */ get; } // 0x000000018672A640-0x000000018672A6E0 
		protected ExDrivenAudioEvents.Event[] disableEvents { /* [XID] */ /* 0x0000000189844C90-0x0000000189844CB0 */ get; } // 0x000000018672A460-0x000000018672A500 
	
		// Constructors
		protected MonoEventAudio() {} // 0x000000018672A6E0-0x000000018672A740
	}
}
