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
	public static class ResourceConstants // TypeDefIndex: 7501
	{
		// Fields
		public const string PATCH_MARK = "P"; // Metadata: 0x00ADEAD5
		public const string ASSET_INDEX_FILE_NAME = "asset_index"; // Metadata: 0x00ADEADA
		public const string ASSET_INDEX_BLK_NAME = "00/31049740.blk"; // Metadata: 0x00ADEAE9
		public const int ASSET_INDEX_HASH = 111; // Metadata: 0x00ADEAFC
		public const string MEDIUM_ASSET_INDEX_FILE_NAME = "medium_asset_index"; // Metadata: 0x00ADEB00
		public const string RELEASE_MEDIUM_ASSET_INDEX_FILE_NAME = "release_medium_asset_index"; // Metadata: 0x00ADEB16
		public const string RELEASE_ASSET_INDEX_FILE_NAME = "release_asset_index"; // Metadata: 0x00ADEB34
		public const string BUNDLE_VERSION_FILE_NAME = "bundle_versions"; // Metadata: 0x00ADEB4B
		public const string PREV_BUNDLE_VERSION_FILE_NAME = "prev_bundle_versions"; // Metadata: 0x00ADEB5E
		public const string RES_REVISION_FILE_NAME = "res_revision"; // Metadata: 0x00ADEB76
		public const string DATA_REVISION_FILE_NAME = "data_revision"; // Metadata: 0x00ADEB86
		public const string SILENCE_REVISION_FILE_NAME = "silence_revision"; // Metadata: 0x00ADEB97
		public const string SVC_CATALOG_FILE_NAME = "svc_catalog"; // Metadata: 0x00ADEBAB
		public const string BLOCK_DIC_NAME = "blocks"; // Metadata: 0x00ADEBBA
		public const string ASSET_BUNDLE_ROOT_DIRECTORY = "AssetBundles/"; // Metadata: 0x00ADEBC4
		public const string DATA_BUNDLE_DIRECTORY = "DataBundles"; // Metadata: 0x00ADEBD5
		public const string SILENCE_BUNDLE_DIRECTORY = "SilenceDataBundles"; // Metadata: 0x00ADEBE4
		public const string STREAMING = "Streaming"; // Metadata: 0x00ADEBFA
		public const string EXTERNAL = "External"; // Metadata: 0x00ADEC07
		public const int SCATTERED_DOWNLOAD_COUNT = 30; // Metadata: 0x00ADEC13
		public const float SCATTERED_DOWNLOAD_RATIO = 0.6f; // Metadata: 0x00ADEC17
		private static string _streamingBundleDirectory; // 0x00
		private static string _streamingBundleVersionFile; // 0x08
		private static string _streamingAssetRevisionFile; // 0x10
		private static string _streamingAssetIndexFile; // 0x18
		private static string _externalBundleDirectory; // 0x20
		private static string _externalBundleVersionFile; // 0x28
		private static string _externalAssetRevisionFile; // 0x30
		private static string _externalAssetIndexFile; // 0x38
		private static string _svcCatalogFile; // 0x40
		private static string _streamingSvcCatalogFile; // 0x48
		private static string _internalBlockDirectory; // 0x50
		private static string _externalBlockDirectory; // 0x58
		private static string _blockDirectory; // 0x60
		private static IRuntimePathProvider _runtimePathProvider; // 0x68
	
		// Properties
		public static string platform { /* [XID] */ /* 0x00000001896C9E20-0x00000001896C9E40 */ get; } // 0x0000000186C3C9E0-0x0000000186C3CAA0 
		public static string streamingBundleDirectory { /* [XID] */ /* 0x00000001896D1600-0x00000001896D1620 */ get; } // 0x0000000186C3CDF0-0x0000000186C3CF20 
		public static string streamingBundleVersionFile { /* [XID] */ /* 0x00000001896D8D10-0x00000001896D8D30 */ get; } // 0x0000000186C3CF20-0x0000000186C3D050 
		public static string streamingAssetRevisionFile { /* [XID] */ /* 0x00000001896E04F0-0x00000001896E0510 */ get; } // 0x0000000186C3CCC0-0x0000000186C3CDF0 
		public static string streamingAssetIndexFile { /* [XID] */ /* 0x00000001896E7890-0x00000001896E78B0 */ get; } // 0x0000000186C3CB90-0x0000000186C3CCC0 
		public static string externalBundleDirectory { /* [XID] */ /* 0x00000001896EEE50-0x00000001896EEE70 */ get; } // 0x0000000186C3C640-0x0000000186C3C770 
		public static string BlockDirectory { /* [XID] */ /* 0x00000001896F6930-0x00000001896F6950 */ get; } // 0x0000000186C3C160-0x0000000186C3C2A0 
		public static string internalBlockDirectory { /* [XID] */ /* 0x00000001896FE040-0x00000001896FE060 */ get; } // 0x0000000186C3C8A0-0x0000000186C3C9E0 
		public static string externalBlockDirectory { /* [XID] */ /* 0x0000000189705390-0x00000001897053B0 */ get; } // 0x0000000186C3C500-0x0000000186C3C640 
		public static string externalBundleVersionFile { /* [XID] */ /* 0x000000018970CAF0-0x000000018970CB10 */ get; } // 0x0000000186C3C770-0x0000000186C3C8A0 
		public static string externalAssetRevisionFile { /* [XID] */ /* 0x0000000189714270-0x0000000189714290 */ get; } // 0x0000000186C3C3D0-0x0000000186C3C500 
		public static string externalAssetIndexFile { /* [XID] */ /* 0x000000018971BD40-0x000000018971BD60 */ get; } // 0x0000000186C3C2A0-0x0000000186C3C3D0 
		public static string svcCatalogFile { /* [XID] */ /* 0x00000001897230F0-0x0000000189723110 */ get; } // 0x0000000186C3D180-0x0000000186C3D2B0 
		public static string streamingSvcCatalogFile { /* [XID] */ /* 0x000000018972A8E0-0x000000018972A900 */ get; } // 0x0000000186C3D050-0x0000000186C3D180 
		private static IRuntimePathProvider runtimePathProvider { /* [XID] */ /* 0x0000000189731FA0-0x0000000189731FC0 */ get; } // 0x0000000186C3CAA0-0x0000000186C3CB90 
	
		// Nested types
		private interface IRuntimePathProvider // TypeDefIndex: 7502
		{
			// Properties
			string platform { get; }
			string streamingBundleDirectory { get; }
			string streamingBundleVersionFile { get; }
			string streamingAssetRevisionFile { get; }
			string streamingAssetIndexFile { get; }
			string externalBundleDirectory { get; }
			string externalBundleVersionFile { get; }
			string externalAssetRevisionFile { get; }
			string externalAssetIndexFile { get; }
			string svcCatalogFile { get; }
			string streamingSvcCatalogFile { get; }
		}
	
		private class StandaloneRuntimePathProvider : IRuntimePathProvider // TypeDefIndex: 7503
		{
			// Fields
			private const string BUNDLE_DIRECTORY_PATH = "AssetBundles/"; // Metadata: 0x00ADEC1B
	
			// Properties
			public string platform { get => default; } // 0x0000000186C41F80-0x0000000186C41FE0 
			public string streamingBundleDirectory { get => default; } // 0x0000000186C42140-0x0000000186C421F0 
			public string streamingBundleVersionFile { get => default; } // 0x0000000186C421F0-0x0000000186C422A0 
			public string streamingAssetRevisionFile { get => default; } // 0x0000000186C42090-0x0000000186C42140 
			public string streamingAssetIndexFile { get => default; } // 0x0000000186C41FE0-0x0000000186C42090 
			public string externalDirectory { get => default; } // 0x0000000186C41EE0-0x0000000186C41F80 
			public string externalBundleDirectory { get => default; } // 0x0000000186C41D80-0x0000000186C41E30 
			public string externalBundleVersionFile { get => default; } // 0x0000000186C41E30-0x0000000186C41EE0 
			public string externalAssetRevisionFile { get => default; } // 0x0000000186C41CD0-0x0000000186C41D80 
			public string externalAssetIndexFile { get => default; } // 0x0000000186C41C20-0x0000000186C41CD0 
			public string svcCatalogFile { get => default; } // 0x0000000186C42350-0x0000000186C42400 
			public string streamingSvcCatalogFile { get => default; } // 0x0000000186C422A0-0x0000000186C42350 
	
			// Constructors
			public StandaloneRuntimePathProvider() {} // 0x0000000186C41BC0-0x0000000186C41C20
		}
	}
}
