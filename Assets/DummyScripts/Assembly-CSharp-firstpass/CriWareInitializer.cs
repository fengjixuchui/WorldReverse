/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

// [AddComponentMenu] // 0x000000018977F860-0x000000018977F890
public class CriWareInitializer : CriMonoBehaviour // TypeDefIndex: 7215
{
	// Fields
	public bool initializesFileSystem; // 0x28
	public CriFsConfig fileSystemConfig; // 0x30
	public bool initializesAtom; // 0x38
	public CriAtomConfig atomConfig; // 0x40
	public bool initializesMana; // 0x48
	public CriManaConfig manaConfig; // 0x50
	public bool useDecrypter; // 0x58
	public CriWareDecrypterConfig decrypterConfig; // 0x60
	public bool dontInitializeOnAwake; // 0x68
	public bool dontDestroyOnLoad; // 0x69
	private bool _dllLoadSuccess; // 0x6A
	private const int MAX_LOAD_DLL_RETRIAL = 1; // Metadata: 0x00ADE703
	private static int initializationCount; // 0x00

	// Properties
	public bool dllLoadSuccess { get => default; } // 0x0000000186446B90-0x0000000186446BF0 

	// Constructors
	public CriWareInitializer() {} // 0x0000000186446A90-0x0000000186446B90
	static CriWareInitializer() {} // 0x0000000186446A30-0x0000000186446A90

	// Methods
	private void Awake() {} // 0x00000001864454C0-0x0000000186445680
	protected override void OnEnable() {} // 0x00000001864467B0-0x0000000186446810
	private void Start() {} // 0x00000001864469E0-0x0000000186446A30
	private void OnDestroy() {} // 0x0000000186446750-0x00000001864467B0
	public override void CriInternalUpdate() {} // 0x00000001864456D0-0x0000000186445720
	public override void CriInternalLateUpdate() {} // 0x0000000186445680-0x00000001864456D0
	public void Initialize() {} // 0x0000000186446100-0x0000000186446690
	public void Shutdown() {} // 0x0000000186446810-0x00000001864469E0
	public static bool IsInitialized() => default; // 0x0000000186446690-0x0000000186446750
	public static void AddAudioEffectInterface(IntPtr effect_interface) {} // 0x0000000186445410-0x00000001864454C0
	public static bool InitializeFileSystem(CriFsConfig config) => default; // 0x0000000186445D40-0x0000000186445EF0
	public static bool InitializeAtom(CriAtomConfig config) => default; // 0x0000000186445720-0x0000000186445CB0
	public static bool InitializeMana(CriManaConfig config) => default; // 0x0000000186445EF0-0x0000000186446100
	[Obsolete] // 0x0000000189788A40-0x0000000189788A70
	public static bool InitializeDecrypter(CriWareDecrypterConfig config) => default; // 0x0000000186445CB0-0x0000000186445D40
}

