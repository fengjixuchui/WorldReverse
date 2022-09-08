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
	public abstract class MonoAudioState2D : MonoBehaviour // TypeDefIndex: 31671
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private StateValue[] _states; // 0x18
	
		// Nested types
		[Serializable]
		public struct StateValue // TypeDefIndex: 31672
		{
			// Fields
			private bool _hasConverted; // 0x00
			private uint _stateNameHash; // 0x04
			private uint _stateValueHash; // 0x08
			[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
			private string _stateName; // 0x10
			[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
			private string _stateValue; // 0x18
	
			// Properties
			public uint stateName { /* [XID] */ /* 0x0000000189BA1720-0x0000000189BA1740 */ get => default; } // 0x0000000184237120-0x00000001842371E0 
			public uint stateValue { /* [XID] */ /* 0x0000000189BA8B50-0x0000000189BA8B70 */ get => default; } // 0x00000001842371E0-0x0000000184237370 
	
			// Methods
			// [XID] // 0x0000000189BB02A0-0x0000000189BB02C0
			private void ConvertHashes() {} // 0x0000000184237060-0x0000000184237120
		}
	
		// Constructors
		protected MonoAudioState2D() {} // 0x0000000184218740-0x00000001842187A0
	
		// Methods
		// [XID] // 0x0000000189B8B330-0x0000000189B8B350
		protected virtual void SetStateValues() {} // 0x0000000184218510-0x0000000184218740
	}
}
