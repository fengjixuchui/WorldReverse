/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class DownloadTextLangPicker : DownloadBasePicker // TypeDefIndex: 11627
{
	// Fields
	public string textLanguage; // 0x40

	// Constructors
	public DownloadTextLangPicker() {} // 0x00000001833474D0-0x0000000183347530

	// Methods
	// [XID] // 0x00000001896CD000-0x00000001896CD020
	protected override void SelectLangItems(DownloadVersionMap remoteVersion, DownloadVersionMap persistVersion, DownloadVersionMap streamingVersion) {} // 0x0000000183346AD0-0x0000000183346BD0
	// [XID] // 0x00000001896D44A0-0x00000001896D44C0
	private void SelectTextLangItem(DownloadVersionMap versionDict, string lang) {} // 0x0000000183347130-0x00000001833473C0
	// [XID] // 0x000000018982F9D0-0x000000018982F9F0
	public override bool ForceDownloadRes() => default; // 0x0000000183346F20-0x0000000183346FC0
	// [XID] // 0x00000001898372B0-0x00000001898372D0
	public override bool ForceDownloadData() => default; // 0x0000000183346BD0-0x0000000183346C70
	// [XID] // 0x000000018983E810-0x000000018983E830
	public override bool NeedDownloadSilence() => default; // 0x0000000183346A30-0x0000000183346AD0
	// [XID] // 0x00000001896F1930-0x00000001896F1950
	public override bool NeedWriteRevisionFile() => default; // 0x00000001833473C0-0x0000000183347460
	// [XID] // 0x00000001896F9370-0x00000001896F9390
	public override bool NeedDeleteAllResFilesNotInPersistVersion() => default; // 0x0000000183346C70-0x0000000183346D10
	// [XID] // 0x0000000189854530-0x0000000189854550
	public override void DidDownload() {} // 0x0000000183346D10-0x0000000183346DE0
}

