/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

public class CriFsServer : CriMonoBehaviour // TypeDefIndex: 7141
{
	// Fields
	private static CriFsServer _instance; // 0x00
	private List<CriFsRequest> requestList; // 0x28

	// Properties
	public static CriFsServer instance { get => default; } // 0x0000000187A34BA0-0x0000000187A34C30 
	public int installBufferSize { get; private set; } // 0x0000000187A34B40-0x0000000187A34BA0 0x0000000187A34C30-0x0000000187A34C90

	// Constructors
	public CriFsServer() {} // 0x0000000187A34AD0-0x0000000187A34B40
	static CriFsServer() {} // 0x0000000187A34A70-0x0000000187A34AD0

	// Methods
	public static void CreateInstance() {} // 0x0000000187A33E30-0x0000000187A33FF0
	public static void DestroyInstance() {} // 0x0000000187A342E0-0x0000000187A34400
	private void Awake() {} // 0x0000000187A33A10-0x0000000187A33BF0
	private void OnDestroy() {} // 0x0000000187A346B0-0x0000000187A348A0
	public override void CriInternalUpdate() {} // 0x0000000187A34040-0x0000000187A342E0
	public override void CriInternalLateUpdate() {} // 0x0000000187A33FF0-0x0000000187A34040
	public void AddRequest(CriFsRequest request) {} // 0x0000000187A33980-0x0000000187A33A10
	public CriFsLoadFileRequest LoadFile(CriFsBinder binder, string path, CriFsRequest.DoneDelegate doneDelegate, int readUnitSize) => default; // 0x0000000187A345F0-0x0000000187A346B0
	public CriFsLoadAssetBundleRequest LoadAssetBundle(CriFsBinder binder, string path, int readUnitSize) => default; // 0x0000000187A34530-0x0000000187A345F0
	public CriFsInstallRequest Install(CriFsBinder srcBinder, string srcPath, string dstPath, CriFsRequest.DoneDelegate doneDelegate) => default; // 0x0000000187A34400-0x0000000187A34530
	public CriFsInstallRequest WebInstall(string srcPath, string dstPath, CriFsRequest.DoneDelegate doneDelegate) => default; // 0x0000000187A349A0-0x0000000187A34A70
	public CriFsBindRequest BindCpk(CriFsBinder targetBinder, CriFsBinder srcBinder, string path) => default; // 0x0000000187A33BF0-0x0000000187A33CB0
	public CriFsBindRequest BindDirectory(CriFsBinder targetBinder, CriFsBinder srcBinder, string path) => default; // 0x0000000187A33CB0-0x0000000187A33D70
	public CriFsBindRequest BindFile(CriFsBinder targetBinder, CriFsBinder srcBinder, string path) => default; // 0x0000000187A33D70-0x0000000187A33E30
}

