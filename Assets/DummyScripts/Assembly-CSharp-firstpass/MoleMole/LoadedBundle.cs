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
	public class LoadedBundle : IReusable // TypeDefIndex: 7528
	{
		// Fields
		private AssetBundle _assetBundle; // 0x10
		private AssetContainer _loadedAssets; // 0x18
	
		// Properties
		public Dictionary<int, UnityEngine.Object> allLoadedAssets { /* [XID] */ /* 0x0000000189AF6850-0x0000000189AF6870 */ get => default; } // 0x0000000189BF6BA0-0x0000000189BF6C80 
		public int usageCount { /* [XID] */ /* 0x0000000189B05610-0x0000000189B05650 */ get; /* [XID] */ /* 0x0000000189B0FE50-0x0000000189B0FE90 */ set; } // 0x0000000189BF6C80-0x0000000189BF6CE0 0x0000000189BF6CE0-0x0000000189BF6D40
	
		// Nested types
		public class Spawner : ISpawner<LoadedBundle, AssetBundle> // TypeDefIndex: 7529
		{
			// Constructors
			public Spawner() {} // 0x0000000189C01120-0x0000000189C01180
	
			// Methods
			// [XID] // 0x00000001898077E0-0x0000000189807800
			public LoadedBundle Spawn(AssetBundle param1) => default; // 0x0000000189C00D60-0x0000000189C00E30
		}
	
		public class Polisher : IPolisher<LoadedBundle, AssetBundle> // TypeDefIndex: 7530
		{
			// Constructors
			public Polisher() {} // 0x0000000189BFE400-0x0000000189BFE460
	
			// Methods
			// [XID] // 0x0000000189800140-0x0000000189800160
			public void Polish(LoadedBundle reused, AssetBundle param1) {} // 0x0000000189BFE180-0x0000000189BFE250
		}
	
		// Constructors
		public LoadedBundle() {} // Dummy constructor
		private LoadedBundle(AssetBundle assetBundle) {} // 0x0000000189BF6B30-0x0000000189BF6BA0
	
		// Methods
		// [XID] // 0x0000000189AFDDF0-0x0000000189AFDE10
		public override string ToString() => default; // 0x0000000189BF6730-0x0000000189BF67E0
		// [XID] // 0x0000000189716E30-0x0000000189716E50
		public void SetPrefabHash(ulong hash) {} // 0x0000000189BF6530-0x0000000189BF6600
		// [XID] // 0x0000000189B21640-0x0000000189B21660
		public GameObject Instanite(int assetPathHash) => default; // 0x0000000189BF54A0-0x0000000189BF56B0
		// [XID] // 0x0000000189B28E10-0x0000000189B28E30
		public byte[] LoadBinData(int hash, int offset, int length) => default; // 0x0000000189BF5B90-0x0000000189BF61E0
		// [XID] // 0x0000000189B302D0-0x0000000189B302F0
		public int GetBinDataLength(int hash) => default; // 0x0000000189BF5230-0x0000000189BF52F0
		// [XID] // 0x0000000189B37A40-0x0000000189B37A60
		public AssetBundle GetAssetBundle() => default; // 0x0000000189BF5190-0x0000000189BF5230
		// [XID] // 0x0000000189B3F3C0-0x0000000189B3F3E0
		public ulong LoadBinDataASync(int hash, int offset, int length) => default; // 0x0000000189BF5880-0x0000000189BF5B90
		// [XID] // 0x0000000189B46D60-0x0000000189B46D80
		public bool HasAssetLoaded(int assetPathHash) => default; // 0x0000000189BF53D0-0x0000000189BF54A0
		// [XID] // 0x0000000189B4E5D0-0x0000000189B4E5F0
		public uint LoadAsset(int assetPathHash) => default; // 0x0000000189BF56B0-0x0000000189BF5880
		// [XID] // 0x0000000189B55BE0-0x0000000189B55C00
		public uint LoadPrefab(int assetPathHash) => default; // 0x0000000189BF61E0-0x0000000189BF6470
		// [XID] // 0x0000000189B5D620-0x0000000189B5D640
		public UnityEngine.Object SyncLoadAsset(int assetPathHash) => default; // 0x0000000189BF6600-0x0000000189BF6730
		// [XID] // 0x0000000189B64D80-0x0000000189B64DA0
		public void AddLoadedAsset(int assetPathHash, UnityEngine.Object asset) {} // 0x0000000189BF4CE0-0x0000000189BF4E70
		// [XID] // 0x0000000189885210-0x0000000189885230
		public UnityEngine.Object UseLoadedAsset(int assetPathHash) => default; // 0x0000000189BF6A70-0x0000000189BF6B30
		// [XID] // 0x0000000189699890-0x00000001896998B0
		public bool Unload() => default; // 0x0000000189BF6850-0x0000000189BF6A70
		// [XID] // 0x00000001897D2CC0-0x00000001897D2CE0
		public void BeforeRecycle() {} // 0x0000000189BF4E70-0x0000000189BF4FD0
		// [XID] // 0x0000000189B828A0-0x0000000189B828C0
		public void Recycle() {} // 0x0000000189BF6470-0x0000000189BF6530
		// [XID] // 0x0000000189B89FC0-0x0000000189B89FE0
		private UnityEngine.Object GetLoadedAsset(int assetPathHash) => default; // 0x0000000189BF52F0-0x0000000189BF53D0
		// [XID] // 0x0000000189B91610-0x0000000189B91630
		public int DumpLoadedAssets(StringBuilder str) => default; // 0x0000000189BF4FD0-0x0000000189BF5190
	}
}
