/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

public class CriFsLoadAssetBundleRequest : CriFsRequest // TypeDefIndex: 7133
{
	// Fields
	private CriFsLoadFileRequest loadFileReq; // 0x50
	private AssetBundleCreateRequest assetBundleReq; // 0x58

	// Properties
	public string path { get; private set; } // 0x0000000187A2FCE0-0x0000000187A2FD40 0x0000000187A2FDA0-0x0000000187A2FE00
	public AssetBundle assetBundle { get; private set; } // 0x0000000187A2FC80-0x0000000187A2FCE0 0x0000000187A2FD40-0x0000000187A2FDA0

	// Constructors
	public CriFsLoadAssetBundleRequest() {} // Dummy constructor
	public CriFsLoadAssetBundleRequest(CriFsBinder binder, string path, int readUnitSize) {} // 0x0000000187A2FB40-0x0000000187A2FC80

	// Methods
	public override void Update() {} // 0x0000000187A2F9A0-0x0000000187A2FB40
	protected override void Dispose(bool disposing) {} // 0x0000000187A2F8F0-0x0000000187A2F9A0
}

