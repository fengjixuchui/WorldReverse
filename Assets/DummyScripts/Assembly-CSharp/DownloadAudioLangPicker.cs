/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class DownloadAudioLangPicker : DownloadBasePicker // TypeDefIndex: 11609
{
	// Fields
	public string audioLanguage; // 0x40

	// Constructors
	public DownloadAudioLangPicker() {} // 0x00000001828345D0-0x0000000182834630

	// Methods
	// [XID] // 0x0000000189A626A0-0x0000000189A626C0
	protected override void SelectLangItems(DownloadVersionMap remoteVersion, DownloadVersionMap persistVersion, DownloadVersionMap streamingVersion) {} // 0x0000000182833910-0x0000000182833A20
	// [XID] // 0x00000001899D6B90-0x00000001899D6BB0
	private void SelectAudioLangItem(DownloadVersionMap versionDict, string lang) {} // 0x0000000182833F20-0x0000000182834170
	// [XID] // 0x00000001899DE070-0x00000001899DE090
	public override bool ForceDownloadRes() => default; // 0x0000000182834240-0x00000001828342E0
	// [XID] // 0x0000000189A79370-0x0000000189A79390
	public override bool NeedDownloadData() => default; // 0x0000000182833E10-0x0000000182833EB0
	// [XID] // 0x00000001899ED000-0x00000001899ED020
	public override bool NeedDownloadSilence() => default; // 0x0000000182833800-0x00000001828338A0
	// [XID] // 0x0000000189A884C0-0x0000000189A884E0
	public override bool NeedWriteRevisionFile() => default; // 0x0000000182834530-0x00000001828345D0
	// [XID] // 0x00000001899FC2E0-0x00000001899FC300
	public override bool NeedDeleteAllResFilesNotInPersistVersion() => default; // 0x0000000182833B10-0x0000000182833BB0
	// [XID] // 0x0000000189A974D0-0x0000000189A974F0
	public override void DidDownload() {} // 0x0000000182833D40-0x0000000182833E10
	// [XID] // 0x0000000189A9E890-0x0000000189A9E8B0
	public static string GetSystemDefaultAudioLanguage() => default; // 0x0000000182833BB0-0x0000000182833D40
	// [XID] // 0x0000000189AA6240-0x0000000189AA6260
	public static string GetUserCurrentAudioLanguage() => default; // 0x0000000182833A20-0x0000000182833B10
	// [XID] // 0x0000000189AAD800-0x0000000189AAD820
	private static string VoiceLanguageTypeToDownloadAudioLang(VoiceLanguageType type) => default; // 0x0000000182834370-0x0000000182834450
}

