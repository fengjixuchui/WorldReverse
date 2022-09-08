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

public sealed class SilenceDataManager : GlobalManager // TypeDefIndex: 21312
{
	// Fields
	private BundleDownloadJobSystem _downloadJobSys; // 0x10
	private bool _startDownloading; // 0x18
	private Queue<uint> reqQueue; // 0x20

	// Constructors
	public SilenceDataManager() {} // 0x0000000181721100-0x00000001817211A0

	// Methods
	// [XID] // 0x00000001895FC4D0-0x00000001895FC4F0
	public override void Init() {} // 0x00000001817208A0-0x0000000181720940
	// [XID] // 0x0000000189603E70-0x0000000189603E90
	public override void Destroy() {} // 0x00000001817205B0-0x0000000181720670
	// [XID] // 0x000000018960B770-0x000000018960B790
	public override void ClearOnLevelDestroy() {} // 0x00000001817203C0-0x0000000181720460
	// [XID] // 0x0000000189612C00-0x0000000189612C20
	public override void ReloadRes() {} // 0x0000000181720FA0-0x0000000181721040
	// [XID] // 0x000000018961A4C0-0x000000018961A4E0
	public override void Tick() {} // 0x0000000181721040-0x0000000181721100
	// [XID] // 0x0000000189621A40-0x0000000189621A60
	public void StartSilenceDataUpdate(uint version) {} // 0x0000000181720C80-0x0000000181720E90
	// [XID] // 0x0000000189629350-0x0000000189629370
	private void OnSilenceDataDownloadFinish(byte dataTypeFlag) {} // 0x0000000181720940-0x0000000181720C80
	// [XID] // 0x0000000189630CA0-0x0000000189630CC0
	private void OnSilenceDataDownloadQuit() {} // 0x00000001817206D0-0x00000001817208A0
	// [XID] // 0x0000000189638700-0x0000000189638720
	private void OnDownloadFinish(bool isResUpdated, bool isDataUpdated, bool isSilenceDataUpdated) {} // 0x0000000181720460-0x00000001817205B0
	// [XID] // 0x000000018963FB90-0x000000018963FBB0
	private void ClearSilenceDataDownloadJob() {} // 0x0000000181720E90-0x0000000181720FA0
}

