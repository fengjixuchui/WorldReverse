/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace MoleMole
{
	public class ResourceIndex // TypeDefIndex: 7543
	{
		// Fields
		private IDictionary<int, ulong> _bundleDependencyMap; // 0x10
		private readonly HashSet<int> _preloadBlockSet; // 0x18
		private readonly HashSet<int> _preloadShaderBlockSet; // 0x20
		private BlockInfo[] _blockInfoMap; // 0x28
		private readonly IDictionary<int, char> _blockStreamingMap; // 0x30
		private readonly IDictionary<int, ResourceIdentifierSave>[] _assetLocationMap; // 0x38
		private int[] _bundleDependencyArray; // 0x40
		private IDictionary<string, string> _assetTypeNameMap; // 0x48
		private const ulong lowBit = 4294967295; // Metadata: 0x00ADECB5
		private readonly List<int> _blockSortList; // 0x50
		public static ResourceIndex r; // 0x00
	
		// Constructors
		public ResourceIndex() {} // 0x0000000186C41420-0x0000000186C415F0
	
		// Methods
		// [XID] // 0x0000000189864CB0-0x0000000189864CD0
		public void Clear() {} // 0x0000000186C3EC30-0x0000000186C3EE20
		// [XID] // 0x000000018986C280-0x000000018986C2A0
		public void AddTypeName(string hash, string typeName) {} // 0x0000000186C3E760-0x0000000186C3E850
		// [XID] // 0x0000000189873770-0x0000000189873790
		public void AddSortList(int id) {} // 0x0000000186C3E690-0x0000000186C3E760
		// [XID] // 0x000000018987B270-0x000000018987B290
		public bool CheckIsLegitAssetPath(ulong internalAsset) => default; // 0x0000000186C3EB20-0x0000000186C3EC30
		// [XID] // 0x0000000189BACEC0-0x0000000189BACEE0
		public ulong GetPathHash(InternalAsset oldOne) => default; // 0x0000000186C40460-0x0000000186C40640
		// [XID] // 0x00000001898899E0-0x0000000189889A00
		private void ChangeString(string s, int id, int languageCode) {} // 0x0000000186C3E850-0x0000000186C3EB20
		// [XID] // 0x0000000189890F00-0x0000000189890F20
		public HashSet<int> GetDataBundles(HashSet<int> blockIDs) => default; // 0x0000000186C3FE20-0x0000000186C40020
		// [XID] // 0x00000001899E5D20-0x00000001899E5D40
		public void GetBundles(int id, List<int> list) {} // 0x0000000186C3FCB0-0x0000000186C3FE20
		// [XID] // 0x000000018989F6D0-0x000000018989F6F0
		public void AddAssetLocation(BundleContent bundleRepresentation) {} // 0x0000000186C3DE90-0x0000000186C3E0E0
		// [XID] // 0x0000000189834400-0x0000000189834420
		public string HashToPath(ulong hash) => default; // 0x0000000186C40B20-0x0000000186C40C60
		// [XID] // 0x00000001898AEC50-0x00000001898AEC70
		public List<string> DoHashTest() => default; // 0x0000000186C3EE20-0x0000000186C3F830
		// [XID] // 0x00000001898B5FF0-0x00000001898B6010
		public bool GetBlockInfo(int bundleNameHash, out BlockInfo info) {
			info = default;
			return default;
		} // 0x0000000186C3FB80-0x0000000186C3FCB0
		// [XID] // 0x00000001898BD840-0x00000001898BD860
		public BlockFile GetBlockFile(int id) => default; // 0x0000000186C3F830-0x0000000186C3FA40
		// [XID] // 0x00000001898C5160-0x00000001898C5180
		public List<int> GetSortedBlocks() => default; // 0x0000000186C40A80-0x0000000186C40B20
		// [IDTag] // 0x00000001898CC520-0x00000001898CC560
		// [XID] // 0x00000001898CC520-0x00000001898CC560
		public void RefreshBlockFile() {} // 0x0000000186C40C60-0x0000000186C41000
		// [IDTag] // 0x00000001898D7230-0x00000001898D7270
		// [XID] // 0x00000001898D7230-0x00000001898D7270
		public void RefreshBlockFile(int id) {} // 0x0000000186C41000-0x0000000186C41280
		// [XID] // 0x00000001898E1E50-0x00000001898E1E70
		public void SetBundleNum(int count) {} // 0x0000000186C41350-0x0000000186C41420
		// [XID] // 0x00000001898E9B70-0x00000001898E9B90
		public bool AddBlockInfo(int bundleNameHash, byte languageCode, BlockInfo info, bool onlyStreaming) => default; // 0x0000000186C3E0E0-0x0000000186C3E4F0
		// [XID] // 0x00000001898F1080-0x00000001898F10A0
		public void SetBundleDependency(IDictionary<int, ulong> dic, int[] array) {} // 0x0000000186C41280-0x0000000186C41350
		// [XID] // 0x00000001898F8A10-0x00000001898F8A30
		public ResourceIdentifier GetResourceIdentifier(ulong internalAsset) => default; // 0x0000000186C40780-0x0000000186C40A80
		// [XID] // 0x0000000189900330-0x0000000189900350
		public void AddPreloadBlock(int block) {} // 0x0000000186C3E4F0-0x0000000186C3E5C0
		// [XID] // 0x00000001899079F0-0x0000000189907A10
		public void AddPreloadShaderBlock(int block) {} // 0x0000000186C3E5C0-0x0000000186C3E690
		// [XID] // 0x00000001899CF450-0x00000001899CF470
		public HashSet<int> GetPreloadBlock() => default; // 0x0000000186C40640-0x0000000186C406E0
		// [XID] // 0x00000001899C03F0-0x00000001899C0410
		public HashSet<int> GetPreloadShaderBlock() => default; // 0x0000000186C406E0-0x0000000186C40780
		// [XID] // 0x000000018991E300-0x000000018991E320
		private int GetBlockID(int bundleNameHash) => default; // 0x0000000186C3FA40-0x0000000186C3FB80
		// [IDTag] // 0x0000000189925BB0-0x0000000189925BF0
		// [XID] // 0x0000000189925BB0-0x0000000189925BF0
		public void GetDependencyBundleAbsolutePaths(int bundleNameHash, List<int> dependencies) {} // 0x0000000186C40240-0x0000000186C40460
		// [IDTag] // 0x00000001899300D0-0x0000000189930110
		// [XID] // 0x00000001899300D0-0x0000000189930110
		public void GetDependencyBundleAbsolutePaths(int bundleNameHash, HashSet<int> dependencies) {} // 0x0000000186C40020-0x0000000186C40240
	}
}
