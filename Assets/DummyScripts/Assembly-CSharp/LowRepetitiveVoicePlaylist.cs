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

public class LowRepetitiveVoicePlaylist // TypeDefIndex: 11458
{
	// Fields
	private static readonly HashSet<int> _historyIndexSet; // 0x00
	private CyclicBlock<int> _history; // 0x10
	private ExternalVoiceSound[] _candidates; // 0x18

	// Properties
	public ExternalVoiceSound[] candidates { /* [XID] */ /* 0x000000018969E140-0x000000018969E160 */ get => default; } // 0x00000001820CDD10-0x00000001820CDDB0 

	// Constructors
	static LowRepetitiveVoicePlaylist() {} // 0x00000001820CE250-0x00000001820CE2E0
	public LowRepetitiveVoicePlaylist() {} // 0x00000001820CE2E0-0x00000001820CE340

	// Methods
	// [XID] // 0x0000000189696B90-0x0000000189696BB0
	public void Initialize(List<ExternalVoiceSound> candidates, int avoidRepeat) {} // 0x00000001820CDB30-0x00000001820CDD10
	// [XID] // 0x00000001896A51B0-0x00000001896A51D0
	public bool Next(GenderApplicability genderApplicability, out ExternalVoiceSound voice) {
		voice = default;
		return default;
	} // 0x00000001820CDDB0-0x00000001820CE250
	// [XID] // 0x00000001896ACAA0-0x00000001896ACAC0
	public void Clear() {} // 0x00000001820CDA90-0x00000001820CDB30
	// [XID] // 0x00000001896B3D90-0x00000001896B3DB0
	private static bool SingleSwitchValue(List<ExternalVoiceSound> sounds) => default; // 0x00000001820CD890-0x00000001820CDA90
}

