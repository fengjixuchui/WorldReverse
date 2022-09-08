/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	[CreateAssetMenu] // 0x00000001897552D0-0x0000000189755310
	public class CharacterViewStyle : ScriptableObject // TypeDefIndex: 19610
	{
		// Fields
		public Style[] styles; // 0x18
	
		// Nested types
		[Serializable]
		public struct Style // TypeDefIndex: 19611
		{
			// Fields
			public uint configId; // 0x00
			public float manekinIdleTime; // 0x04
			public List<string> manekinIdleTriggerList; // 0x08
			public List<int> manekinIdleWeightList; // 0x10
			public HeadControllerStyle headController; // 0x18
		}
	
		// Constructors
		public CharacterViewStyle() {} // 0x0000000181ADC9C0-0x0000000181ADCA20
	
		// Methods
		// [XID] // 0x000000018975DD10-0x000000018975DD30
		public Style GetStyleByConfigID(uint configId) => default; // 0x0000000181ADC5D0-0x0000000181ADC9C0
	}
}
