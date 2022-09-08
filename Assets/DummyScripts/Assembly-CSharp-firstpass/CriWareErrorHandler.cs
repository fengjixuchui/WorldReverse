/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AOT;
using UnityEngine;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

// [AddComponentMenu] // 0x000000018973AEB0-0x000000018973AEE0
public class CriWareErrorHandler : CriMonoBehaviour // TypeDefIndex: 7193
{
	// Fields
	public bool enableDebugPrintOnTerminal; // 0x28
	public bool enableForceCrashOnError; // 0x29
	public bool dontDestroyOnLoad; // 0x2A
	public static Callback callback; // 0x08
	private static int initializationCount; // 0x10

	// Properties
	public static string errorMessage { get; set; } // 0x00000001864452F0-0x0000000186445380 0x0000000186445380-0x0000000186445410

	// Nested types
	public delegate void Callback(string message); // TypeDefIndex: 7194; 0x000000018642D210-0x000000018642D470

	// [UnmanagedFunctionPointer] // 0x000000018987C730-0x000000018987C750
	public delegate void ErrorCallbackFunc(string errmsg); // TypeDefIndex: 7195; 0x0000000186446DB0-0x0000000186447010

	// Constructors
	public CriWareErrorHandler() {} // 0x0000000186445280-0x00000001864452F0
	static CriWareErrorHandler() {} // 0x0000000186445210-0x0000000186445280

	// Methods
	private void Awake() {} // 0x00000001864440C0-0x00000001864442E0
	protected override void OnEnable() {} // 0x0000000186444CE0-0x0000000186444E50
	protected override void OnDisable() {} // 0x0000000186444C50-0x0000000186444CE0
	private void Start() {} // 0x00000001864451C0-0x0000000186445210
	public override void CriInternalUpdate() {} // 0x0000000186444980-0x0000000186444A00
	public override void CriInternalLateUpdate() {} // 0x0000000186444930-0x0000000186444980
	private void OnDestroy() {} // 0x0000000186444B90-0x0000000186444C50
	private static void OutputErrorMessage() {} // 0x0000000186445010-0x00000001864451C0
	private static void HandleMessage(string errmsg) {} // 0x0000000186444A90-0x0000000186444B90
	private static void OutputDefaultLog(string errmsg) {} // 0x0000000186444E50-0x0000000186445010
	// [MonoPInvokeCallback] // 0x000000018976C4F0-0x000000018976C540
	private static void ErrorCallbackFromNative(string errmsg) {} // 0x0000000186444A00-0x0000000186444A90
	private static extern void CRIWAREE5005D92(); // 0x0000000186444850-0x0000000186444930
	private static extern void CRIWARE6FF199CE(); // 0x00000001864442E0-0x00000001864443C0
	private static extern IntPtr CRIWARE94B4687C(); // 0x0000000186444590-0x0000000186444670
	private static extern void CRIWARE921AC20B(); // 0x00000001864444B0-0x0000000186444590
	private static extern void CRIWARE7511F117(bool sw); // 0x00000001864443C0-0x00000001864444B0
	private static extern void CRIWARE96CD2992(bool sw); // 0x0000000186444670-0x0000000186444760
	private static extern void CRIWAREA10D44BF(ErrorCallbackFunc callback); // 0x0000000186444760-0x0000000186444850
}

