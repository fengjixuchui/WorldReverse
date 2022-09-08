/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

public class CriAtomServer : CriMonoBehaviour // TypeDefIndex: 6984
{
	// Fields
	private static CriAtomServer _instance; // 0x00
	public Action<bool> onApplicationPausePreProcess; // 0x28
	public Action<bool> onApplicationPausePostProcess; // 0x30
	public static bool KeepPlayingSoundOnPause; // 0x08

	// Properties
	public static CriAtomServer instance { get => default; } // 0x00000001877C19E0-0x00000001877C1A70 

	// Constructors
	public CriAtomServer() {} // 0x00000001877C1980-0x00000001877C19E0
	static CriAtomServer() {} // 0x00000001877C1910-0x00000001877C1980

	// Methods
	public static void CreateInstance() {} // 0x00000001877C1360-0x00000001877C1460
	public static void DestroyInstance() {} // 0x00000001877C1500-0x00000001877C1620
	private void Awake() {} // 0x00000001877C1230-0x00000001877C1360
	protected override void OnEnable() {} // 0x00000001877C17B0-0x00000001877C1810
	protected override void OnDisable() {} // 0x00000001877C16A0-0x00000001877C17B0
	public override void CriInternalUpdate() {} // 0x00000001877C14B0-0x00000001877C1500
	public override void CriInternalLateUpdate() {} // 0x00000001877C1460-0x00000001877C14B0
	private void OnApplicationPause(bool appPause) {} // 0x00000001877C1620-0x00000001877C16A0
	private void ProcessApplicationPause(bool appPause) {} // 0x00000001877C1810-0x00000001877C1910
}

