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
	public abstract class MonoAudioGeneralEvent2D : MonoAudioEvent2D // TypeDefIndex: 31637
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Event[] _events; // 0x18
	
		// Properties
		public Event[] events { /* [XID] */ /* 0x00000001897901B0-0x00000001897901D0 */ get; /* [XID] */ /* 0x0000000189797BD0-0x0000000189797BF0 */ set; } // 0x00000001842161B0-0x0000000184216250 0x0000000184216250-0x0000000184216300
	
		// Constructors
		protected MonoAudioGeneralEvent2D() {} // 0x0000000184216110-0x00000001842161B0
	
		// Methods
		// [XID] // 0x000000018979F890-0x000000018979F8B0
		protected virtual void TriggerEvents() {} // 0x0000000184216060-0x0000000184216110
	}
}
