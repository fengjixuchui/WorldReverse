/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

internal sealed class IFixManager : GlobalManager // TypeDefIndex: 20734
{
	// Fields
	private const string PATCH_PATH = "Data/InjectFix/"; // Metadata: 0x00AFE210

	// Constructors
	public IFixManager() {} // 0x0000000182118ED0-0x0000000182118F30

	// Methods
	// [XID] // 0x000000018982C150-0x000000018982C170
	public void SetInjectfixVersion(int version) {} // 0x0000000182118190-0x00000001821182D0
	// [XID] // 0x0000000189833620-0x0000000189833640
	public void LoadPatch(bool patchAtBegin = false /* Metadata: 0x00AFE20F */) {} // 0x0000000182117510-0x00000001821180F0
	// [XID] // 0x000000018983AB00-0x000000018983AB20
	public void LoadPatchByByts(byte[] injectFixData) {} // 0x0000000182118BB0-0x0000000182118D90
	[PatchAtBegin] // 0x0000000189842180-0x00000001898421C0
	// [XID] // 0x0000000189842180-0x00000001898421C0
	public void FixAfterServerDispatch() {} // 0x0000000182118A70-0x0000000182118B10
	// [XID] // 0x000000018984C700-0x000000018984C720
	public void FixAfterBundleDownloadPatch() {} // 0x0000000182118B10-0x0000000182118BB0
	// [XID] // 0x0000000189853780-0x00000001898537A0
	public void FixAfterSilenceDownload() {} // 0x0000000182118930-0x00000001821189D0
	// [XID] // 0x000000018985B230-0x000000018985B250
	public void FixAfterServerStopLoadPatch() {} // 0x0000000182118D90-0x0000000182118E30
	// [XID] // 0x0000000189862770-0x0000000189862790
	public override void ClearOnLevelDestroy() {} // 0x00000001821180F0-0x0000000182118190
	// [XID] // 0x0000000189869B60-0x0000000189869B80
	public override void Destroy() {} // 0x0000000182118890-0x0000000182118930
	// [XID] // 0x0000000189870F00-0x0000000189870F20
	public override void Init() {} // 0x00000001821189D0-0x0000000182118A70
	// [XID] // 0x00000001898788B0-0x00000001898788D0
	public override void ReloadRes() {} // 0x0000000182118E30-0x0000000182118ED0
	// [XID] // 0x000000018987FE80-0x000000018987FEA0
	public void UsedOnlyForAOTCodeGeneration() {} // 0x00000001821182D0-0x0000000182118890
}

