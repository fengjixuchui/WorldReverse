/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;
using IFix.Core;
using MoleMole;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public abstract class AudioComponentPlugin : BaseComponentPlugin // TypeDefIndex: 12008
{
	// Properties
	public override int metaTypeID { /* [XID] */ /* 0x0000000189A1ADB0-0x0000000189A1ADD0 */ get; } // 0x0000000181FC4430-0x0000000181FC44D0 
	protected VCBaseAudio component { /* [XID] */ /* 0x0000000189A226B0-0x0000000189A226F0 */ get; private set; } // 0x0000000181FC41D0-0x0000000181FC4230 0x0000000181FC4170-0x0000000181FC41D0

	// Constructors
	protected AudioComponentPlugin() {} // Dummy constructor
	protected AudioComponentPlugin(VCBaseAudio component) {} // 0x0000000181FC4350-0x0000000181FC4430

	// Methods
	// [XID] // 0x0000000189A33F20-0x0000000189A33F40
	public virtual void DumpCriticalInfo(StringBuilder builder) {} // 0x0000000181FC42A0-0x0000000181FC4350
}

