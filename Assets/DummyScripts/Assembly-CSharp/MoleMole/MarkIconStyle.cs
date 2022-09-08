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
	[CreateAssetMenu] // 0x0000000189AD2BC0-0x0000000189AD2C00
	public class MarkIconStyle : ScriptableObject // TypeDefIndex: 19650
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private List<Style> _styles; // 0x18
		private Dictionary<int, Style> _dic; // 0x20
	
		// Nested types
		[Serializable]
		public class Style // TypeDefIndex: 19651
		{
			// Fields
			public MarkIconType iconType; // 0x10
			public string iconName; // 0x18
			public uint materialIndex; // 0x20
	
			// Constructors
			public Style() {} // 0x0000000184F1DC00-0x0000000184F1DC60
		}
	
		// Constructors
		public MarkIconStyle() {} // 0x0000000184F1B500-0x0000000184F1B580
	
		// Methods
		// [XID] // 0x0000000189AE38D0-0x0000000189AE38F0
		private void OnEnable() {} // 0x0000000184F1B320-0x0000000184F1B500
		// [XID] // 0x0000000189AEB150-0x0000000189AEB170
		public Style GetStyle(MarkIconType iconType) => default; // 0x0000000184F1B210-0x0000000184F1B320
	}
}
