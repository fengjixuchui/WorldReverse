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
	public class AssetSingle : AssetContainer // TypeDefIndex: 7553
	{
		// Fields
		private LoadedAsset _asset; // 0x10
		private int _hash; // 0x18
		private ulong _prefabHash; // 0x20
	
		// Constructors
		public AssetSingle() {} // 0x00000001868EB340-0x00000001868EB3A0
	
		// Methods
		// [XID] // 0x00000001899DB1C0-0x00000001899DB1E0
		public void SetPrefabHash(ulong hash) {} // 0x00000001868EB290-0x00000001868EB340
		// [XID] // 0x00000001899E2A40-0x00000001899E2A60
		public void AddAssset(int hash, LoadedAsset asset) {} // 0x00000001868EAE50-0x00000001868EAF20
		// [XID] // 0x000000018964EE80-0x000000018964EEA0
		public LoadedAsset GetAsset(int hash) => default; // 0x00000001868EB010-0x00000001868EB0D0
		// [XID] // 0x00000001899F1790-0x00000001899F17B0
		public bool HasAssetLoaded(int hash) => default; // 0x00000001868EB0D0-0x00000001868EB190
		// [XID] // 0x00000001899F9050-0x00000001899F9070
		public void Recycle() {} // 0x00000001868EB190-0x00000001868EB290
		// [XID] // 0x0000000189A005E0-0x0000000189A00600
		public void Dump(StringBuilder builder) {} // 0x00000001868EAF20-0x00000001868EB010
		// [XID] // 0x0000000189A07E70-0x0000000189A07E90
		public Dictionary<int, UnityEngine.Object> allLoadedAssets() => default; // 0x00000001868EB3A0-0x00000001868EB490
	}
}
