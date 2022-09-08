/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace MoleMole
{
	public class AssetIndexDeserializer // TypeDefIndex: 7351
	{
		// Fields
		public string filePath; // 0x10
		public ResourceIndex resourceIndex; // 0x18
		private int bundleCount; // 0x20
	
		// Constructors
		public AssetIndexDeserializer() {} // Dummy constructor
		public AssetIndexDeserializer(string filePath, ResourceIndex resourceIndex) {} // 0x00000001868E7740-0x00000001868E77D0
	
		// Methods
		// [XID] // 0x000000018986ACA0-0x000000018986ACC0
		public bool DeserializeBinary(bool onlyStreaming = false /* Metadata: 0x00ADE9A1 */) => default; // 0x00000001868E63D0-0x00000001868E66A0
		// [XID] // 0x00000001898720E0-0x0000000189872100
		private void ReadBlockSortList(AssetIndexBinaryReader br) {} // 0x00000001868E6E20-0x00000001868E6F30
		// [XID] // 0x0000000189879900-0x0000000189879920
		private void ReadAssetTypeNameMap_B(AssetIndexBinaryReader br) {} // 0x00000001868E68C0-0x00000001868E69D0
		// [XID] // 0x0000000189880E70-0x0000000189880E90
		private void ReadAssetInfoMap_B(AssetIndexBinaryReader br) {} // 0x00000001868E66A0-0x00000001868E68C0
		// [XID] // 0x0000000189888270-0x0000000189888290
		private void ReadBundleInfoMap_B(AssetIndexBinaryReader br) {} // 0x00000001868E6F30-0x00000001868E7460
		// [XID] // 0x000000018988F820-0x000000018988F840
		private void ReadPreloadBlocks_B(AssetIndexBinaryReader br) {} // 0x00000001868E7460-0x00000001868E75D0
		// [XID] // 0x0000000189896DF0-0x0000000189896E10
		private void ReadPreloadShaderBlocks_B(AssetIndexBinaryReader br) {} // 0x00000001868E75D0-0x00000001868E7740
		// [XID] // 0x000000018989E290-0x000000018989E2B0
		private bool ReadBlockInfo_B(AssetIndexBinaryReader br, bool onlyStreaming) => default; // 0x00000001868E69D0-0x00000001868E6E20
	}
}
