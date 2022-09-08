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

public abstract class DownloadBaseInformer : IDownloadInformer // TypeDefIndex: 11613
{
	// Fields
	protected int _remoteRevision; // 0x10
	protected string _remoteRevisionSuffix; // 0x18
	protected string _remoteVersionMd5; // 0x20
	protected string _remoteUrlRoot; // 0x28

	// Constructors
	public DownloadBaseInformer() {} // 0x00000001837D9A80-0x00000001837D9B00

	// Methods
	protected abstract void FreezeRemoteRevision();
	public abstract string GetPersistRevisionFilePath();
	public abstract string GetStreamingRevisionFilePath();
	public abstract string GetRemoteVersionFilePath();
	public abstract string GetStreamingVersionFilePath();
	public abstract string GetPersistVersionFilePath();
	public abstract string GetRemoteUrl();
	public abstract string GetRemoteBaseUrl();
	// [XID] // 0x0000000189AF1EB0-0x0000000189AF1ED0
	public void FreezeRemoteRevisionToValue(int revision, string suffix, string versionMd5, string urlRoot) {} // 0x00000001837D8BB0-0x00000001837D8CB0
	// [XID] // 0x000000018960C4C0-0x000000018960C4E0
	public int GetRemoteRevision() => default; // 0x00000001837D97B0-0x00000001837D9850
	// [XID] // 0x0000000189B00C50-0x0000000189B00C70
	public string GetRemoteRevisionSuffix() => default; // 0x00000001837D8E50-0x00000001837D8EF0
	// [XID] // 0x0000000189B082B0-0x0000000189B082D0
	public string GetRemoteVersionMd5Content() => default; // 0x00000001837D8EF0-0x00000001837D8F90
	// [XID] // 0x0000000189B0FB10-0x0000000189B0FB30
	public int GetLocalRevision() => default; // 0x00000001837D8D90-0x00000001837D8E50
	// [XID] // 0x0000000189B16CE0-0x0000000189B16D00
	public DownloadVersionMap GetRemoteVersion() => default; // 0x00000001837D8A30-0x00000001837D8AF0
	// [XID] // 0x0000000189B1E540-0x0000000189B1E560
	public DownloadVersionMap GetStreamingVersion() => default; // 0x00000001837D92B0-0x00000001837D9370
	// [XID] // 0x0000000189B25E80-0x0000000189B25EA0
	public DownloadVersionMap GetPersistVersion() => default; // 0x00000001837D8AF0-0x00000001837D8BB0
	// [XID] // 0x0000000189B2D150-0x0000000189B2D170
	public int GetStreamingRevision() => default; // 0x00000001837D8CB0-0x00000001837D8D90
	// [XID] // 0x0000000189B346D0-0x0000000189B346F0
	public int GetPersistRevision() => default; // 0x00000001837D8F90-0x00000001837D9070
	// [XID] // 0x0000000189B3BEF0-0x0000000189B3BF10
	public bool WriteRevisionFile() => default; // 0x00000001837D9850-0x00000001837D99A0
	// [XID] // 0x0000000189B43AD0-0x0000000189B43AF0
	public bool CopyRemoteVersionFileToPersist() => default; // 0x00000001837D9070-0x00000001837D92B0
	// [XID] // 0x0000000189B4B100-0x0000000189B4B120
	public bool NeedDownload() => default; // 0x00000001837D8960-0x00000001837D8A30
	// [XID] // 0x0000000189779A20-0x0000000189779A40
	public List<FileDownloadInfo> GetDownloadList(List<FilePickInfo> pickList, bool writeCacheFile) => default; // 0x00000001837D9370-0x00000001837D96D0
	// [XID] // 0x00000001896483A0-0x00000001896483C0
	public virtual string GetPersistentPath(string relativePath) => default; // 0x00000001837D96D0-0x00000001837D97B0
	// [XID] // 0x0000000189B617E0-0x0000000189B61800
	public virtual string GetStreamingPath(string relativePath) => default; // 0x00000001837D99A0-0x00000001837D9A80
}

