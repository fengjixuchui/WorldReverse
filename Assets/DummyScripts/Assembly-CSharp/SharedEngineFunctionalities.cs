/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class SharedEngineFunctionalities : SharedFunctionalities // TypeDefIndex: 11279
{
	// Fields
	private const string DEFAULT_LANGUAGE = "English(US)"; // Metadata: 0x00AE96D3
	private static readonly Dictionary<int, string> _platformNames; // 0x00
	private readonly StringBuilder _packageNameBuilder; // 0x20
	private readonly List<uint> _fullPackageIds; // 0x28
	private readonly List<uint> _externalSourcePackageIds; // 0x30
	private readonly BankCallback _loadInitBankCallback; // 0x38
	private readonly uint _initBankId; // 0x40
	private ResourceMode _resourceMode; // 0x44
	private bool _isInitBankLoaded; // 0x48
	private MmoronCodecId _externalSourceCodecId; // 0x4C
	private string _currentLanguage; // 0x50

	// Properties
	public ResourceMode resourceMode { /* [XID] */ /* 0x0000000189B95600-0x0000000189B95620 */ get => default; /* [XID] */ /* 0x0000000189996240-0x0000000189996260 */ set {} } // 0x00000001833CB1A0-0x00000001833CB240 0x00000001833CB690-0x00000001833CB740
	public bool isInitBankLoaded { /* [XID] */ /* 0x0000000189B3AD10-0x0000000189B3AD30 */ get => default; } // 0x00000001833CB240-0x00000001833CB2F0 
	public MmoronCodecId externalSourceCodecId { /* [XID] */ /* 0x0000000189BAB8F0-0x0000000189BAB910 */ get => default; /* [XID] */ /* 0x0000000189BB2E30-0x0000000189BB2E50 */ set {} } // 0x00000001833CB5F0-0x00000001833CB690 0x00000001833CAB50-0x00000001833CAC00
	public string currentLanguage { /* [XID] */ /* 0x0000000189BBA280-0x0000000189BBA2A0 */ get => default; } // 0x00000001833CA8A0-0x00000001833CA950 

	// Nested types
	private static class Texts // TypeDefIndex: 11280
	{
		// Fields
		public const string INIT_BANK_NAME = "Init"; // Metadata: 0x00AE96E2
		public const string MINIMUM_PACKAGE_NAME = "Minimum.pck"; // Metadata: 0x00AE96EA

		// Nested types
		public static class Platforms // TypeDefIndex: 11281
		{
			// Fields
			public const string IOS = "iOS"; // Metadata: 0x00AE96F9
			public const string WINDOWS = "Windows"; // Metadata: 0x00AE9700
		}
	}

	// Constructors
	public SharedEngineFunctionalities() {} // Dummy constructor
	static SharedEngineFunctionalities() {} // 0x00000001833CBFD0-0x00000001833CC0B0
	public SharedEngineFunctionalities(SharedContext sharedContext) {} // 0x00000001833CC0B0-0x00000001833CC210

	// Methods
	// [XID] // 0x0000000189BC2320-0x0000000189BC2340
	public void SetLanguage(string language) {} // 0x00000001833CB9A0-0x00000001833CBAE0
	// [XID] // 0x0000000189BC9950-0x0000000189BC9970
	public void SwitchLanguage(string language) {} // 0x00000001833CA250-0x00000001833CA350
	// [XID] // 0x0000000189BD10B0-0x0000000189BD10D0
	public void LoadInitSoundBank() {} // 0x00000001833CB510-0x00000001833CB5F0
	// [XID] // 0x0000000189BD8730-0x0000000189BD8750
	public void LoadMinimumResources() {} // 0x00000001833CAD70-0x00000001833CAE70
	// [XID] // 0x00000001897751B0-0x00000001897751D0
	public void LoadFullResources() {} // 0x00000001833CB2F0-0x00000001833CB510
	// [XID] // 0x00000001895ECD20-0x00000001895ECD40
	public void UnloadFullResources() {} // 0x00000001833CA0E0-0x00000001833CA250
	// [XID] // 0x00000001895F4370-0x00000001895F4390
	private static string GetPlatformName() => default; // 0x00000001833CA950-0x00000001833CAB50
	// [XID] // 0x00000001895FBB40-0x00000001895FBB60
	private static void FindIndicesOfLastTwoPathSeperators(string path, out int iLastButOne, out int iLast) {
		iLastButOne = default;
		iLast = default;
	} // 0x00000001833C9DF0-0x00000001833C9F90
	// [XID] // 0x0000000189603300-0x0000000189603320
	private void LoadIncrementalPackages(ConfigAudioResource configResource) {} // 0x00000001833CB8B0-0x00000001833CB9A0
	// [XID] // 0x000000018960ACE0-0x000000018960AD00
	private void LoadExternalSourcePackages(ConfigAudioResource config) {} // 0x00000001833CAF80-0x00000001833CB1A0
	// [XID] // 0x0000000189983E50-0x0000000189983E70
	private void LoadIncrementalExternalSourcePackages(ConfigAudioResource configResource) {} // 0x00000001833CBAE0-0x00000001833CBEF0
	// [XID] // 0x00000001897CD220-0x00000001897CD240
	private void LoadFilePackageSeries(string filePackageNameBase, string filePackageExt, byte countLg2, List<uint> packageIds) {} // 0x00000001833CA350-0x00000001833CA5D0
	// [XID] // 0x0000000189B028B0-0x0000000189B028D0
	private void LoadPackages(string[] packageNames, List<uint> packageIds) {} // 0x00000001833CAE70-0x00000001833CAF80
	// [XID] // 0x00000001896287C0-0x00000001896287E0
	private bool LoadPackage(string name, List<uint> packageIds) => default; // 0x00000001833CAC00-0x00000001833CAD70
	// [XID] // 0x0000000189630130-0x0000000189630150
	private void UnloadExternalSourcePackages() {} // 0x00000001833C9F90-0x00000001833CA0E0
	// [XID] // 0x0000000189637E00-0x0000000189637E20
	private ConfigAudioIncrementalResources GetConfigIncrementalResources(ConfigAudioResource config) => default; // 0x00000001833CB740-0x00000001833CB8B0
	// [XID] // 0x000000018963F050-0x000000018963F070
	private void LoadInitBankCallback(uint bankID, AkResult eLoadResult, object cookie) {} // 0x00000001833CBEF0-0x00000001833CBFD0
	// [XID] // 0x0000000189646960-0x0000000189646980
	private string[] AppendDirectorySeparatorIfNecessary(string[] paths) => default; // 0x00000001833CA5D0-0x00000001833CA8A0
}

