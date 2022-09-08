/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class SharedContext : SharedByThreads // TypeDefIndex: 11221
{
	// Fields
	private readonly List<AudioCmd> _freshCmds; // 0x18
	private readonly List<AudioReport> _freshReports; // 0x20
	private readonly WwiseInterface _wwiseInterface; // 0x28

	// Properties
	public WwiseInterface wwiseInterface { /* [XID] */ /* 0x0000000189639380-0x00000001896393A0 */ get => default; } // 0x00000001831EBF90-0x00000001831EC030 

	// Constructors
	public SharedContext() {} // Dummy constructor
	public SharedContext(WwiseInterface wwiseInterface) {} // 0x00000001831EC1B0-0x00000001831EC270

	// Methods
	// [XID] // 0x0000000189792F10-0x0000000189792F30
	public void CopyCmdsFrom(List<AudioCmd> cmds) {} // 0x00000001831EC030-0x00000001831EC0F0
	// [XID] // 0x00000001896480C0-0x00000001896480E0
	public void CopyCmdsTo(List<AudioCmd> cmds) {} // 0x00000001831EBE10-0x00000001831EBED0
	// [XID] // 0x000000018964F7B0-0x000000018964F7D0
	public void CopyReportsFrom(List<AudioReport> reports) {} // 0x00000001831EBED0-0x00000001831EBF90
	// [XID] // 0x0000000189657180-0x00000001896571A0
	public void CopyReportsTo(List<AudioReport> reports) {} // 0x00000001831EC0F0-0x00000001831EC1B0
	private void CopyList<T>(List<T> from, List<T> to) {}
}

