/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class ThreadDebugTask : DataThreadTask<ThreadDebugData> // TypeDefIndex: 21351
{
	// Fields
	private ThreadDebugData _debugData; // 0x20

	// Constructors
	public ThreadDebugTask() {} // 0x0000000181876200-0x0000000181876270

	// Methods
	// [XID] // 0x0000000189669BE0-0x0000000189669C00
	public override void Init() {} // 0x0000000181875E10-0x0000000181875F80
	// [XID] // 0x0000000189671820-0x0000000189671840
	public override void Tick(float dt, float updateTime) {} // 0x0000000181875F80-0x0000000181876040
	// [XID] // 0x0000000189679010-0x0000000189679030
	public void DebugTick(long debugUpdateTick, long debugBufferUpdateTick) {} // 0x0000000181876130-0x0000000181876200
	// [XID] // 0x0000000189680770-0x0000000189680790
	public override void TickBuffer(int front) {} // 0x0000000181875C90-0x0000000181875D40
	// [XID] // 0x0000000189688300-0x0000000189688320
	public void DebugTickBuffer(int front) {} // 0x0000000181876040-0x0000000181876130
}

