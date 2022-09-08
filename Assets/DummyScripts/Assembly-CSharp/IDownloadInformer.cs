/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public interface IDownloadInformer // TypeDefIndex: 11612
{
	// Methods
	int GetLocalRevision();
	int GetRemoteRevision();
	int GetPersistRevision();
	int GetStreamingRevision();
	DownloadVersionMap GetRemoteVersion();
	DownloadVersionMap GetStreamingVersion();
	DownloadVersionMap GetPersistVersion();
	string GetRemoteVersionMd5Content();
	string GetStreamingRevisionFilePath();
	string GetPersistRevisionFilePath();
	string GetRemoteVersionFilePath();
	string GetStreamingVersionFilePath();
	string GetPersistVersionFilePath();
	string GetRemoteUrl();
	bool NeedDownload();
	bool WriteRevisionFile();
	bool CopyRemoteVersionFileToPersist();
	List<FileDownloadInfo> GetDownloadList(List<FilePickInfo> relativePathList, bool writeCacheFile);
}

