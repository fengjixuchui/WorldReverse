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
	public abstract class MonoAudioSwitch2D : MonoBehaviour // TypeDefIndex: 31686
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private SwitchValue[] _switches; // 0x18
	
		// Nested types
		[Serializable]
		public struct SwitchValue // TypeDefIndex: 31687
		{
			// Fields
			private bool _hasConverted; // 0x00
			private uint _switchNameHash; // 0x04
			private uint _switchValueHash; // 0x08
			[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
			private string _switchName; // 0x10
			[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
			private string _switchValue; // 0x18
	
			// Properties
			public uint switchName { /* [XID] */ /* 0x000000018968F5D0-0x000000018968F5F0 */ get => default; } // 0x0000000184237430-0x00000001842374F0 
			public uint switchValue { /* [XID] */ /* 0x0000000189696FF0-0x0000000189697010 */ get => default; } // 0x00000001842374F0-0x00000001842375A0 
	
			// Methods
			// [XID] // 0x000000018969E510-0x000000018969E530
			private void ConvertHashes() {} // 0x0000000184237370-0x0000000184237430
		}
	
		// Constructors
		protected MonoAudioSwitch2D() {} // 0x00000001842189D0-0x0000000184218A30
	
		// Methods
		// [XID] // 0x0000000189678980-0x00000001896789A0
		protected virtual void SetSwitchValues() {} // 0x00000001842187A0-0x00000001842189D0
	}
}
