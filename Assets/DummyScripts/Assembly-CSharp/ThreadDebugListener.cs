/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class ThreadDebugListener : DataThreadListener<ThreadDebugData, ThreadDebugTask> // TypeDefIndex: 21349
{
	// Fields
	private const float BAGEET = 33.333f; // Metadata: 0x00AFF4C8
	private ThreadDebugData _debugData; // 0x28
	private ThreadDebugDrawData _debugDrawData; // 0x40
	private bool _threadDebugging; // 0x48
	private ThreadDebugDialogContext _threadDebugUI; // 0x50

	// Constructors
	public ThreadDebugListener() {} // 0x0000000182745DD0-0x0000000182745E50

	// Methods
	// [XID] // 0x000000018963CEB0-0x000000018963CED0
	public override void Init(IThreadTask task) {} // 0x0000000182745880-0x0000000182745960
	// [XID] // 0x0000000189644470-0x0000000189644490
	private void InitUI() {} // 0x00000001827457B0-0x0000000182745880
	// [XID] // 0x000000018964BCF0-0x000000018964BD10
	public void OpenDebug() {} // 0x0000000182745A30-0x0000000182745B20
	// [XID] // 0x0000000189653300-0x0000000189653320
	public void CloseDebug() {} // 0x0000000182745960-0x0000000182745A30
	// [XID] // 0x000000018965AB90-0x000000018965ABB0
	public override void RenderTick(int renderFront, float renderTime) {} // 0x0000000182745D10-0x0000000182745DD0
	// [XID] // 0x0000000189662040-0x0000000189662060
	public void DebugRenderTick(int renderFront, ThreadDebugData debugData) {} // 0x0000000182745B20-0x0000000182745D10
}

