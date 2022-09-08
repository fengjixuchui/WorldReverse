/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using IFix.Core;
using UnityEngine;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace MoleMole
{
	public class AssetArray : AssetContainer // TypeDefIndex: 7552
	{
		// Fields
		private LoadedAsset[] _assetCollection; // 0x10
		private int[] _hashCollection; // 0x18
		private int count; // 0x20
	
		// Constructors
		public AssetArray() {} // 0x00000001853EC3E0-0x00000001853EC440
	
		// Methods
		// [XID] // 0x000000018999F3C0-0x000000018999F3E0
		public void SetPrefabHash(ulong hash) {} // 0x00000001853EC2F0-0x00000001853EC3E0
		// [XID] // 0x00000001899A6E10-0x00000001899A6E30
		public void Init(int n) {} // 0x00000001853EC070-0x00000001853EC180
		// [XID] // 0x00000001899AE5A0-0x00000001899AE5C0
		public void AddAssset(int hash, LoadedAsset asset) {} // 0x00000001853EBBC0-0x00000001853EBD20
		// [XID] // 0x00000001899B5C80-0x00000001899B5CA0
		public LoadedAsset GetAsset(int hash) => default; // 0x00000001853EBE50-0x00000001853EBF80
		// [XID] // 0x00000001899BD530-0x00000001899BD550
		public bool HasAssetLoaded(int hash) => default; // 0x00000001853EBF80-0x00000001853EC070
		// [XID] // 0x00000001899C5030-0x00000001899C5050
		public void Recycle() {} // 0x00000001853EC180-0x00000001853EC2F0
		// [XID] // 0x0000000189B83BF0-0x0000000189B83C10
		public void Dump(StringBuilder builder) {} // 0x00000001853EBD20-0x00000001853EBE50
		// [XID] // 0x00000001899D3BB0-0x00000001899D3BD0
		public Dictionary<int, UnityEngine.Object> allLoadedAssets() => default; // 0x00000001853EC440-0x00000001853EC5B0
	}
}
