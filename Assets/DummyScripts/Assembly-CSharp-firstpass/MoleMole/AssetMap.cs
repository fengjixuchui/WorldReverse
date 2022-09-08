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
	public class AssetMap : AssetContainer // TypeDefIndex: 7551
	{
		// Fields
		private Dictionary<int, LoadedAsset> _assetCollection; // 0x10
	
		// Constructors
		public AssetMap() {} // 0x00000001868EA500-0x00000001868EA590
	
		// Methods
		// [XID] // 0x0000000189B06180-0x0000000189B061A0
		public void AddAssset(int hash, LoadedAsset asset) {} // 0x00000001868E9DC0-0x00000001868E9EA0
		// [XID] // 0x0000000189B0D930-0x0000000189B0D950
		public void SetPrefabHash(ulong hash) {} // 0x00000001868EA410-0x00000001868EA500
		// [XID] // 0x00000001899799A0-0x00000001899799C0
		public Dictionary<int, UnityEngine.Object> allLoadedAssets() => default; // 0x00000001868EA590-0x00000001868EA7A0
		// [XID] // 0x0000000189980BB0-0x0000000189980BD0
		public void Dump(StringBuilder builder) {} // 0x00000001868E9EA0-0x00000001868EA080
		// [XID] // 0x0000000189988480-0x00000001899884A0
		public LoadedAsset GetAsset(int hash) => default; // 0x00000001868EA080-0x00000001868EA160
		// [XID] // 0x000000018998FF90-0x000000018998FFB0
		public bool HasAssetLoaded(int hash) => default; // 0x00000001868EA160-0x00000001868EA230
		// [XID] // 0x00000001899978D0-0x00000001899978F0
		public void Recycle() {} // 0x00000001868EA230-0x00000001868EA410
	}
}
