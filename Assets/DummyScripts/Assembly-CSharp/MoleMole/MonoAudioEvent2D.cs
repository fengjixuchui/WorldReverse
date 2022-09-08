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
	public abstract class MonoAudioEvent2D : MonoBehaviour // TypeDefIndex: 31635
	{
		// Nested types
		[Serializable]
		public struct Event // TypeDefIndex: 31636
		{
			// Fields
			private bool _hasConverted; // 0x00
			private uint _audioEventId; // 0x04
			[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
			private string _audioEvent; // 0x08
	
			// Properties
			public uint audioEvent { /* [XID] */ /* 0x0000000189779BB0-0x0000000189779BD0 */ get => default; } // 0x0000000184215DA0-0x0000000184215E10 
	
			// Methods
			// [XID] // 0x00000001897817B0-0x00000001897817D0
			public static explicit operator Event(string name) => default; // 0x0000000184215B60-0x0000000184215DA0
		}
	
		// Constructors
		protected MonoAudioEvent2D() {} // 0x0000000184216000-0x0000000184216060
	
		// Methods
		// [XID] // 0x000000018976AF50-0x000000018976AF70
		protected virtual void TriggerEvents(Event[] events) {} // 0x0000000184215E10-0x0000000184216000
	}
}
