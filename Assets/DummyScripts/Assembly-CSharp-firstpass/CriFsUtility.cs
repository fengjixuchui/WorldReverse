/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

public static class CriFsUtility // TypeDefIndex: 7139
{
	// Fields
	public const int DefaultReadUnitSize = 1048576; // Metadata: 0x00ADE59A

	// Methods
	public static CriFsLoadFileRequest LoadFile(string path, int readUnitSize = 1048576 /* Metadata: 0x00ADE586 */) => default; // 0x0000000187A35930-0x0000000187A359F0
	public static CriFsLoadFileRequest LoadFile(string path, CriFsRequest.DoneDelegate doneDelegate, int readUnitSize = 1048576 /* Metadata: 0x00ADE58A */) => default; // 0x0000000187A35860-0x0000000187A35930
	public static CriFsLoadFileRequest LoadFile(CriFsBinder binder, string path, int readUnitSize = 1048576 /* Metadata: 0x00ADE58E */) => default; // 0x0000000187A359F0-0x0000000187A35AC0
	public static CriFsLoadAssetBundleRequest LoadAssetBundle(string path, int readUnitSize = 1048576 /* Metadata: 0x00ADE592 */) => default; // 0x0000000187A357E0-0x0000000187A35860
	public static CriFsLoadAssetBundleRequest LoadAssetBundle(CriFsBinder binder, string path, int readUnitSize = 1048576 /* Metadata: 0x00ADE596 */) => default; // 0x0000000187A35710-0x0000000187A357E0
	public static CriFsInstallRequest Install(string srcPath, string dstPath) => default; // 0x0000000187A35510-0x0000000187A355A0
	public static CriFsInstallRequest Install(string srcPath, string dstPath, CriFsRequest.DoneDelegate doneDeleagate) => default; // 0x0000000187A35670-0x0000000187A35710
	public static CriFsInstallRequest Install(CriFsBinder srcBinder, string srcPath, string dstPath) => default; // 0x0000000187A35440-0x0000000187A35510
	public static CriFsInstallRequest Install(CriFsBinder srcBinder, string srcPath, string dstPath, CriFsRequest.DoneDelegate doneDeleagate) => default; // 0x0000000187A355A0-0x0000000187A35670
	public static CriFsInstallRequest WebInstall(string srcPath, string dstPath, CriFsRequest.DoneDelegate doneDeleagate) => default; // 0x0000000187A35C20-0x0000000187A35CF0
	public static CriFsBindRequest BindCpk(CriFsBinder targetBinder, string srcPath) => default; // 0x0000000187A34D60-0x0000000187A34DF0
	public static CriFsBindRequest BindCpk(CriFsBinder targetBinder, CriFsBinder srcBinder, string srcPath) => default; // 0x0000000187A34C90-0x0000000187A34D60
	public static CriFsBindRequest BindDirectory(CriFsBinder targetBinder, string srcPath) => default; // 0x0000000187A34DF0-0x0000000187A34EB0
	public static CriFsBindRequest BindDirectory(CriFsBinder targetBinder, CriFsBinder srcBinder, string srcPath) => default; // 0x0000000187A34EB0-0x0000000187A34F80
	public static CriFsBindRequest BindFile(CriFsBinder targetBinder, string srcPath) => default; // 0x0000000187A35050-0x0000000187A35110
	public static CriFsBindRequest BindFile(CriFsBinder targetBinder, CriFsBinder srcBinder, string srcPath) => default; // 0x0000000187A34F80-0x0000000187A35050
	public static void SetUserAgentString(string userAgentString) {} // 0x0000000187A35BB0-0x0000000187A35C20
	public static void SetProxyServer(string proxyPath, ushort proxyPort) {} // 0x0000000187A35B30-0x0000000187A35BB0
	public static void SetPathSeparator(string filter) {} // 0x0000000187A35AC0-0x0000000187A35B30
	private static extern bool CRIWARED410F863(string userAgentString); // 0x0000000187A35220-0x0000000187A35330
	private static extern bool CRIWARE99818C19(string proxyPath, ushort proxyPort); // 0x0000000187A35110-0x0000000187A35220
	private static extern bool CRIWAREEF16F50B(string filter); // 0x0000000187A35330-0x0000000187A35440
}

