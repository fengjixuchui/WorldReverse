/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class CoroutineManager : GlobalManager // TypeDefIndex: 20683
{
	// Fields
	private List<Coroutine> _coroutines; // 0x10

	// Constructors
	private CoroutineManager() {} // 0x00000001828FFCE0-0x00000001828FFD70

	// Methods
	// [XID] // 0x00000001898E0ED0-0x00000001898E0EF0
	public override void Init() {} // 0x00000001828FF360-0x00000001828FF400
	// [XID] // 0x00000001898E89A0-0x00000001898E89C0
	public override void Tick() {} // 0x00000001828FFC40-0x00000001828FFCE0
	// [XID] // 0x00000001898F00C0-0x00000001898F00E0
	public override void ReloadRes() {} // 0x00000001828FFBA0-0x00000001828FFC40
	// [XID] // 0x00000001898F79F0-0x00000001898F7A10
	public override void Destroy() {} // 0x00000001828FF190-0x00000001828FF230
	// [XID] // 0x00000001898FF050-0x00000001898FF070
	public override void ClearOnLevelDestroy() {} // 0x00000001828FEDB0-0x00000001828FEE50
	// [XID] // 0x00000001899067D0-0x00000001899067F0
	public override void ClearOnDisconnect() {} // 0x00000001828FED10-0x00000001828FEDB0
	// [XID] // 0x000000018990E310-0x000000018990E330
	public Coroutine StartCoroutine(IEnumerator routine, bool addToManager = true /* Metadata: 0x00AFE05C */) => default; // 0x00000001828FE7B0-0x00000001828FE8E0
	// [XID] // 0x0000000189915A40-0x0000000189915A60
	public void StopCoroutine(Coroutine routine) {} // 0x00000001828FF840-0x00000001828FF9F0
	// [XID] // 0x000000018991D3D0-0x000000018991D3F0
	public void StopAllCoroutines() {} // 0x00000001828FEE50-0x00000001828FF040
	// [XID] // 0x0000000189810890-0x00000001898108B0
	public void RemoveCoroutine(Coroutine routine) {} // 0x00000001828FF230-0x00000001828FF300
	// [XID] // 0x00000001897FA5A0-0x00000001897FA5C0
	public Coroutine Invoke(float duration, Action callback, bool addToManager = true /* Metadata: 0x00AFE05D */) => default; // 0x00000001828FF400-0x00000001828FF620
	// [XID] // 0x00000001899336C0-0x00000001899336E0
	public Coroutine InvokeAfterSplashScreen(float duration, Action callback, bool addToManager = true /* Metadata: 0x00AFE05E */) => default; // 0x00000001828FF620-0x00000001828FF840
	// [XID] // 0x000000018993B350-0x000000018993B370
	public Coroutine InvokeNextFrame(Action callback, bool addToManager = true /* Metadata: 0x00AFE05F */) => default; // 0x00000001828FEB00-0x00000001828FED10
	// [XID] // 0x0000000189942480-0x00000001899424A0
	public Coroutine InvokeAfterFrames(int frames, Action callback, bool addToManager = true /* Metadata: 0x00AFE060 */) => default; // 0x00000001828FE8E0-0x00000001828FEB00
	[DebuggerHidden] // 0x0000000189949DA0-0x0000000189949DE0
	// [XID] // 0x0000000189949DA0-0x0000000189949DE0
	private IEnumerator InvokeCoroutine(float duration, Action callback, Action onFinish) => default; // 0x00000001828FFA50-0x00000001828FFBA0
	[DebuggerHidden] // 0x00000001899543F0-0x0000000189954430
	// [XID] // 0x00000001899543F0-0x0000000189954430
	private IEnumerator InvokeCoroutineAfterSplashScreen(float duration, Action callback, Action onFinish) => default; // 0x00000001828FF040-0x00000001828FF190
	[DebuggerHidden] // 0x000000018995EE30-0x000000018995EE70
	// [XID] // 0x000000018995EE30-0x000000018995EE70
	private IEnumerator InvokeAfterFramesCoroutine(int frames, Action callback, Action onFinish) => default; // 0x00000001828FE670-0x00000001828FE7B0
}

