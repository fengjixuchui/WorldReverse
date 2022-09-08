/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;
using IFix.Core;
using MoleMole.Audio.Mmoron;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class CommandThreadEngineFunctionalities : CommandThreadFunctionalities<SharedEngineFunctionalities> // TypeDefIndex: 11275
{
	// Fields
	private const string PLATFORM_NAME = "Windows"; // Metadata: 0x00AE95BC
	private const string INIT_PARAMS_FILE_NAME = "MmoronInitParams_Windows"; // Metadata: 0x00AE95C7
	private float _mechanicMemorySize; // 0x20

	// Properties
	public bool isInitialized { /* [XID] */ /* 0x0000000189A154F0-0x0000000189A15510 */ get => default; } // 0x00000001833F62C0-0x00000001833F6390 
	public ResourceMode resourceMode { /* [XID] */ /* 0x0000000189A80A80-0x0000000189A80AA0 */ get => default; } // 0x00000001833F84B0-0x00000001833F8570 
	public string currentLanguage { /* [XID] */ /* 0x0000000189A88520-0x0000000189A88540 */ get => default; } // 0x00000001833F7240-0x00000001833F7300 
	public float reservedMemorySizeInMb { /* [XID] */ /* 0x00000001899A3D60-0x00000001899A3D80 */ get => default; } // 0x00000001833F6430-0x00000001833F64E0 

	// Nested types
	private static class Texts // TypeDefIndex: 11276
	{
		// Fields
		public const string INIT_ENTINE_LOG_TEXT = "MmoronUnity: Initialize sound engine ..."; // Metadata: 0x00AE95E3
		public const string INIT_FAILED_LOG_TEXT = "MmoronUnity: Failed to initialize the sound engine. Abort."; // Metadata: 0x00AE960F
		public const string INVALID_BASE_PATH_LOG_TEXT = "MmoronUnity: Couldn\'t find any soundbanks base path. Terminate sound engine."; // Metadata: 0x00AE964D
		public const string INIT_SUCCESS_LOG_TEXT = "MmoronUnity: Sound engine initialized."; // Metadata: 0x00AE969D
	}

	// Constructors
	public CommandThreadEngineFunctionalities() {} // Dummy constructor
	public CommandThreadEngineFunctionalities(CommandThreadContext context, SharedEngineFunctionalities data) {} // 0x00000001833F9540-0x00000001833F95D0

	// Methods
	// [XID] // 0x0000000189A97530-0x0000000189A97550
	public override void Init() {} // 0x00000001833F75B0-0x00000001833F7A90
	// [XID] // 0x0000000189A9E8F0-0x0000000189A9E910
	public override void Tick(float deltaTime) {} // 0x00000001833F7A90-0x00000001833F7B40
	// [XID] // 0x0000000189AA6260-0x0000000189AA6280
	public override void EnterHomeWorld(bool firstTime) {} // 0x00000001833F8390-0x00000001833F84B0
	// [XID] // 0x0000000189AC3070-0x0000000189AC3090
	public override void ExitHomeWorld() {} // 0x00000001833F8C80-0x00000001833F8D20
	// [XID] // 0x0000000189ACA7D0-0x0000000189ACA7F0
	public override void ExitGameWorld() {} // 0x00000001833F8920-0x00000001833F89C0
	// [XID] // 0x0000000189ABCD60-0x0000000189ABCD80
	public override void CreateLevel() {} // 0x00000001833F6390-0x00000001833F6430
	// [XID] // 0x0000000189AC46B0-0x0000000189AC46D0
	public override void EnterLevel() {} // 0x00000001833F81F0-0x00000001833F8290
	// [XID] // 0x0000000189AE1740-0x0000000189AE1760
	public override void ExitLevel() {} // 0x00000001833F7470-0x00000001833F7510
	// [XID] // 0x0000000189AD3730-0x0000000189AD3750
	public override void DumpCriticalInfo(StringBuilder builder) {} // 0x00000001833F9180-0x00000001833F9340
	// [XID] // 0x0000000189ADB1F0-0x0000000189ADB210
	public override void Destroy() {} // 0x00000001833F65A0-0x00000001833F6640
	// [XID] // 0x0000000189AE28E0-0x0000000189AE2900
	public void SwitchLanguage(string language) {} // 0x00000001833F6EF0-0x00000001833F7070
	// [XID] // 0x0000000189AEA430-0x0000000189AEA450
	public void LoadFullPackageResources() {} // 0x00000001833F7B40-0x00000001833F7C20
	// [XID] // 0x0000000189AF1ED0-0x0000000189AF1EF0
	private void LoadLibraryManually() {} // 0x00000001833F7510-0x00000001833F75B0
	// [XID] // 0x0000000189AF98A0-0x0000000189AF98C0
	private bool InitializeEngine(MmoronInitParams initParams) => default; // 0x00000001833F7C20-0x00000001833F81F0
	// [XID] // 0x00000001899300B0-0x00000001899300D0
	private void GetBasePathsFromConfig(MmoronInitParams initParams, out string internalBasePath, out string externalBasePath) {
		internalBasePath = default;
		externalBasePath = default;
	} // 0x00000001833F89C0-0x00000001833F8B40
	// [XID] // 0x0000000189B082D0-0x0000000189B082F0
	private void SetBasePaths(string internalBasePath, string externalBasePath) {} // 0x00000001833F8D20-0x00000001833F8EF0
	// [XID] // 0x0000000189AB9B20-0x0000000189AB9B40
	private void RegisterAuxDevices(MmoronInitParams initParams) {} // 0x00000001833F9000-0x00000001833F9180
	// [XID] // 0x0000000189B16D40-0x0000000189B16D60
	public void LoadVolumeSetting() {} // 0x00000001833F6AF0-0x00000001833F6D50
	// [XID] // 0x0000000189B1E560-0x0000000189B1E580
	private void LoadVibrationSetting() {} // 0x00000001833F8EF0-0x00000001833F9000
	// [XID] // 0x0000000189B25EE0-0x0000000189B25F00
	public void SetVibrationEnable(bool enable) {} // 0x00000001833F8780-0x00000001833F8920
	// [XID] // 0x0000000189B2D170-0x0000000189B2D190
	private void SetVolumeSetting(int value, AudioSettingSlider sliderConfig) {} // 0x00000001833F8B40-0x00000001833F8C80
	// [XID] // 0x0000000189B346F0-0x0000000189B34710
	private void CreateMmoronSettings(out MmoronMemorySettings memorySettings, out MmoronStreamingSettings streamingSettings, out MmoronDeviceSettings deviceSettings, out MmoronInitSettings initSettings, out MmoronPlatformSettings platformSettings, out MmoronMusicSettings musicSettings, out MmoronSpatialAudioSettings spatialSettings, out MmoronCustomSettings customSettings, MmoronInitParams initParams, string productName) {
		memorySettings = default;
		streamingSettings = default;
		deviceSettings = default;
		initSettings = default;
		platformSettings = default;
		musicSettings = default;
		spatialSettings = default;
		customSettings = default;
	} // 0x00000001833F8570-0x00000001833F8780
	// [XID] // 0x0000000189B3BF90-0x0000000189B3BFB0
	private MmoronMemorySettings CreateMmoronMemorySettings(MmoronInitParams initParams) => default; // 0x00000001833F69F0-0x00000001833F6AF0
	// [XID] // 0x0000000189B43B30-0x0000000189B43B50
	private MmoronStreamingSettings CreateMmoronStreamingSettings(MmoronInitParams initParams) => default; // 0x00000001833F8290-0x00000001833F8390
	// [XID] // 0x0000000189B4B120-0x0000000189B4B140
	private MmoronDeviceSettings CreateMmoronDeviceSettings(MmoronInitParams initParams) => default; // 0x00000001833F7300-0x00000001833F7470
	// [XID] // 0x0000000189A5E4C0-0x0000000189A5E4E0
	private MmoronInitSettings CreateMmoronInitSettings(MmoronInitParams initParams) => default; // 0x00000001833F6070-0x00000001833F62C0
	// [XID] // 0x0000000189B5A3A0-0x0000000189B5A3C0
	private MmoronPlatformSettings CreateMmoronPlatformSettings(MmoronInitParams initParams) => default; // 0x00000001833F6640-0x00000001833F69F0
	// [XID] // 0x00000001899BA560-0x00000001899BA580
	private MmoronMusicSettings CreateMmoronMusicSettings(MmoronInitParams initParams) => default; // 0x00000001833F64E0-0x00000001833F65A0
	// [XID] // 0x0000000189B693F0-0x0000000189B69410
	private MmoronSpatialAudioSettings CreateMmoronSpatialSettings(MmoronInitParams initParams) => default; // 0x00000001833F9340-0x00000001833F9540
	// [XID] // 0x0000000189928B90-0x0000000189928BB0
	private MmoronCustomSettings CreateMmoronCustomSettings(MmoronInitParams initParams, string productName) => default; // 0x00000001833F6D50-0x00000001833F6EF0
	// [XID] // 0x0000000189AAA860-0x0000000189AAA880
	private void DeleteMmoronSettings(ref MmoronMemorySettings memorySettings, ref MmoronStreamingSettings streamingSettings, ref MmoronDeviceSettings deviceSettings, ref MmoronInitSettings initSettings, ref MmoronPlatformSettings platformSettings, ref MmoronMusicSettings musicSettings, ref MmoronSpatialAudioSettings spatialSettings, ref MmoronCustomSettings customSettings) {} // 0x00000001833F7070-0x00000001833F7240
}

