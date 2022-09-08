/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public interface IBMCaseRunner // TypeDefIndex: 27586
{
	// Methods
	IEnumerator Run(int startCaseID, Action<string, int> onStartBMCase, Action<string, int> onEndBMCase, Action<string> onExecuteCommand, Action<string, object> onExecuteCommandWithObject, Action<string> onExecuteLuaShell, float timeScale = 1f /* Metadata: 0x00B0CA53 */);
}

