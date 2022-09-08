/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

public class CriFsRequest : CriDisposable // TypeDefIndex: 7128
{
	// Properties
	public DoneDelegate doneDelegate { get; protected set; } // 0x0000000187A33680-0x0000000187A336E0 0x0000000187A33800-0x0000000187A33860
	public bool isDone { get; private set; } // 0x0000000187A337A0-0x0000000187A33800 0x0000000187A33920-0x0000000187A33980
	public string error { get; protected set; } // 0x0000000187A336E0-0x0000000187A33740 0x0000000187A33860-0x0000000187A338C0
	public bool isDisposed { get; protected set; } // 0x0000000187A33740-0x0000000187A337A0 0x0000000187A338C0-0x0000000187A33920

	// Nested types
	public delegate void DoneDelegate(CriFsRequest request); // TypeDefIndex: 7129; 0x0000000187A39DB0-0x0000000187A3A010

	// Constructors
	public CriFsRequest() {} // 0x0000000187A33620-0x0000000187A33680

	// Methods
	public override void Dispose() {} // 0x0000000187A33140-0x0000000187A33240
	public virtual void Stop() {} // 0x0000000187A334F0-0x0000000187A33540
	public YieldInstruction WaitForDone(MonoBehaviour mb) => default; // 0x0000000187A33590-0x0000000187A33620
	protected virtual void Dispose(bool disposing) {} // 0x0000000187A33240-0x0000000187A33290
	public virtual void Update() {} // 0x0000000187A33540-0x0000000187A33590
	protected void Done() {} // 0x0000000187A33290-0x0000000187A333C0
	[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
	private IEnumerator CheckDone() => default; // 0x0000000187A33070-0x0000000187A33140
	~CriFsRequest() {} // 0x0000000187A333C0-0x0000000187A334F0
}

