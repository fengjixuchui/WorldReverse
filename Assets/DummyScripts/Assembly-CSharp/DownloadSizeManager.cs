/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class DownloadSizeManager : GlobalManager // TypeDefIndex: 20717
{
	// Fields
	private List<BundleDownloadBaseSystem> _systems; // 0x10
	private List<BundleDownloadBaseSystem> _toRemove; // 0x18

	// Constructors
	public DownloadSizeManager() {} // 0x0000000181A8ACF0-0x0000000181A8AD50

	// Methods
	// [XID] // 0x00000001897F95D0-0x00000001897F95F0
	public override void Init() {} // 0x0000000181A8A140-0x0000000181A8A230
	// [XID] // 0x0000000189800B30-0x0000000189800B50
	public override void Destroy() {} // 0x0000000181A8A040-0x0000000181A8A0E0
	// [XID] // 0x0000000189808080-0x00000001898080A0
	public override void ClearOnLevelDestroy() {} // 0x0000000181A89FA0-0x0000000181A8A040
	// [XID] // 0x000000018980FA90-0x000000018980FAB0
	public override void ReloadRes() {} // 0x0000000181A8A990-0x0000000181A8AA30
	// [XID] // 0x0000000189817060-0x0000000189817080
	public override void Tick() {} // 0x0000000181A8AA30-0x0000000181A8ACF0
	// [XID] // 0x000000018981E970-0x000000018981E990
	public void CalcDownloadSize(JobType type, Action<long, long> callBack, Action errorCallback = null) {} // 0x0000000181A8A230-0x0000000181A8A700
	// [XID] // 0x0000000189825E00-0x0000000189825E20
	private void PrepareFakeGlobalVars() {} // 0x0000000181A8A700-0x0000000181A8A990
}

