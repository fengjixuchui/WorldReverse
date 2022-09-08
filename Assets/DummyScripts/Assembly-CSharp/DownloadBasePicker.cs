/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class DownloadBasePicker // TypeDefIndex: 11615
{
	// Fields
	public List<string> badList; // 0x10
	public List<string> deleteList; // 0x18
	public long totalLocalSpace; // 0x20
	public long totalDownloadSize; // 0x28
	public long alreadyDownloadedSize; // 0x30
	public int totalScanCnt; // 0x38
	public int totalPickCnt; // 0x3C

	// Constructors
	public DownloadBasePicker() {} // 0x0000000181BD0430-0x0000000181BD04E0

	// Methods
	// [XID] // 0x000000018987F670-0x000000018987F690
	public void Reset() {} // 0x0000000181BCEA70-0x0000000181BCEB50
	// [XID] // 0x0000000189702530-0x0000000189702550
	public List<FilePickInfo> Pick(DownloadVersionMap remoteVersion, DownloadVersionMap persistVersion, DownloadVersionMap streamingVersion, DownloadBaseInformer informer, string cacheFilePath, bool checkMd5, ref bool enable) => default; // 0x0000000181BCEB50-0x0000000181BCED30
	// [XID] // 0x0000000189709CD0-0x0000000189709CF0
	protected virtual void SelectLangItems(DownloadVersionMap remoteVersion, DownloadVersionMap persistVersion, DownloadVersionMap streamingVersion) {} // 0x0000000181BCE900-0x0000000181BCE9D0
	// [XID] // 0x0000000189B7F3A0-0x0000000189B7F3C0
	protected virtual void PickDownloads(DownloadVersionMap remoteVersions, DownloadVersionMap localExternalVersions, DownloadVersionMap localStreamingVersions, DownloadBaseInformer informer, List<string> badList, List<string> deleteList, List<FilePickInfo> downloadList, ref long totalNeededSize, ref long totalDownloadSize, ref long alreadyDownloadedSize, string cacheFilePath, bool checkMd5, ref bool enable) {} // 0x0000000181BCF660-0x0000000181BCFF60
	// [XID] // 0x0000000189720360-0x0000000189720380
	private bool IsFilePerfectInStreaming(DownloadVersionInfo remoteVersion, DownloadVersionInfo streamingVersion, string localRelativeFilePath, bool checkMd5) => default; // 0x0000000181BD0010-0x0000000181BD01A0
	// [XID] // 0x0000000189B8E120-0x0000000189B8E140
	protected virtual bool IsFileReallyPerfectInStreaming(string localRelativeFilePath, DownloadVersionInfo remoteVersion, bool checkMd5) => default; // 0x0000000181BCE5C0-0x0000000181BCE900
	// [XID] // 0x0000000189B955A0-0x0000000189B955C0
	protected virtual string GetReallyPersistentPath(string persistentPath, string localRelativeFilePath) => default; // 0x0000000181BCF500-0x0000000181BCF5C0
	// [XID] // 0x0000000189B9CBF0-0x0000000189B9CC10
	private string GetRelativePath(string fileNameInVersion, bool isLocalPath = false /* Metadata: 0x00AEA36E */) => default; // 0x0000000181BCED30-0x0000000181BCEE90
	// [XID] // 0x0000000189BA4280-0x0000000189BA42A0
	public virtual string GetRemoteResVersionFileNameOnNetDisk() => default; // 0x0000000181BCEF30-0x0000000181BCEFE0
	// [XID] // 0x000000018964F990-0x000000018964F9B0
	public string GetRemoteVersionFileNameInPkgOnNetDisk() => default; // 0x0000000181BCF3C0-0x0000000181BCF500
	// [XID] // 0x000000018962A320-0x000000018962A340
	public virtual string GetRemoteBaseRevisionFileNameOnNetDisk() => default; // 0x0000000181BCF130-0x0000000181BCF1E0
	// [XID] // 0x0000000189BBA200-0x0000000189BBA220
	public virtual string GetRemoteAssetIndexFileName() => default; // 0x0000000181BCEFE0-0x0000000181BCF090
	// [XID] // 0x0000000189666060-0x0000000189666080
	public virtual string GetRemoteDataVersionFileNameOnNetDisk() => default; // 0x0000000181BD0380-0x0000000181BD0430
	// [XID] // 0x0000000189BC9930-0x0000000189BC9950
	public virtual string GetRemoteSilenceDataVersionFileNameOnNetDisk() => default; // 0x0000000181BCFF60-0x0000000181BD0010
	// [XID] // 0x0000000189BD1070-0x0000000189BD1090
	public virtual bool ForceDownloadRes() => default; // 0x0000000181BCF5C0-0x0000000181BCF660
	// [XID] // 0x0000000189657320-0x0000000189657340
	public virtual bool ForceDownloadData() => default; // 0x0000000181BCE9D0-0x0000000181BCEA70
	// [XID] // 0x000000018966D7B0-0x000000018966D7D0
	public virtual bool ForceDownloadSilence() => default; // 0x0000000181BCE520-0x0000000181BCE5C0
	// [XID] // 0x0000000189613C20-0x0000000189613C40
	public virtual bool NeedDownloadRes() => default; // 0x0000000181BCF320-0x0000000181BCF3C0
	// [XID] // 0x00000001895F42F0-0x00000001895F4310
	public virtual bool NeedDownloadData() => default; // 0x0000000181BCF1E0-0x0000000181BCF280
	// [XID] // 0x00000001895FBB00-0x00000001895FBB20
	public virtual bool NeedDownloadSilence() => default; // 0x0000000181BCE480-0x0000000181BCE520
	// [XID] // 0x00000001898A43A0-0x00000001898A43C0
	public virtual bool NeedWriteRevisionFile() => default; // 0x0000000181BD02E0-0x0000000181BD0380
	// [XID] // 0x000000018960AC60-0x000000018960AC80
	public virtual bool HasUI() => default; // 0x0000000181BCF280-0x0000000181BCF320
	// [XID] // 0x0000000189861AC0-0x0000000189861AE0
	public virtual bool NeedVerifyAllMd5() => default; // 0x0000000181BD0240-0x0000000181BD02E0
	// [XID] // 0x0000000189619BB0-0x0000000189619BD0
	public virtual bool NeedDeleteAllResFilesNotInPersistVersion() => default; // 0x0000000181BCEE90-0x0000000181BCEF30
	// [XID] // 0x00000001897A6CE0-0x00000001897A6D00
	public virtual void OnStartDownload() {} // 0x0000000181BD01A0-0x0000000181BD0240
	// [XID] // 0x00000001898BACF0-0x00000001898BAD10
	public virtual void DidDownload() {} // 0x0000000181BCF090-0x0000000181BCF130
}

