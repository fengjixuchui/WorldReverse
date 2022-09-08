/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using MoleMole;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole.Config
{
	public sealed class SectorBinData : ScriptableObjectUseFiEdit // TypeDefIndex: 14800
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		public List<Item> datas; // 0x18
	
		// Nested types
		[Serializable]
		public struct Item // TypeDefIndex: 14801
		{
			// Fields
			public int offset; // 0x00
			public ulong hash; // 0x08
		}
	
		// Constructors
		public SectorBinData() {} // 0x0000000186B6E5D0-0x0000000186B6E660
	}
}
