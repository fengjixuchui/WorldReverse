/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class TickArray // TypeDefIndex: 19862
{
	// Fields
	private EntityTickFunction[] _elements; // 0x10

	// Properties
	public int length { /* [XID] */ /* 0x00000001899FCB10-0x00000001899FCB50 */ get; /* [XID] */ /* 0x0000000189A07060-0x0000000189A070A0 */ private set; } // 0x00000001845A06E0-0x00000001845A0740 0x00000001845A0330-0x00000001845A0390
	public int capacity { /* [XID] */ /* 0x0000000189A118E0-0x0000000189A11900 */ get => default; } // 0x00000001845A0280-0x00000001845A0330 

	// Constructors
	private TickArray() {} // 0x00000001845A0AE0-0x00000001845A0B40
	public TickArray(int inCapacity) {} // 0x00000001845A0A60-0x00000001845A0AE0

	// Methods
	// [XID] // 0x0000000189A18B50-0x0000000189A18B70
	private void Expand(int inCapacity) {} // 0x000000018459FEB0-0x00000001845A01A0
	// [XID] // 0x0000000189A20230-0x0000000189A20250
	public EntityTickFunction At(int index) => default; // 0x00000001845A01A0-0x00000001845A0280
	// [XID] // 0x0000000189A27640-0x0000000189A27660
	public void AddTail(EntityTickFunction inFunction) {} // 0x00000001845A0800-0x00000001845A0A60
	// [XID] // 0x0000000189A2EDE0-0x0000000189A2EE00
	public void Clear(bool bDisposeElement = true /* Metadata: 0x00AFCF93 */) {} // 0x00000001845A0390-0x00000001845A06E0
	// [XID] // 0x0000000189A36690-0x0000000189A366B0
	public void Flush(bool bDisposeElement = true /* Metadata: 0x00AFCF94 */) {} // 0x00000001845A0740-0x00000001845A0800
}

