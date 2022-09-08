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

public sealed class SimpleVoicePlaylist : VoicePlaylist // TypeDefIndex: 11459
{
	// Fields
	private ExternalVoiceSound[] _candidates; // 0x10

	// Constructors
	public SimpleVoicePlaylist() {} // 0x0000000180DD36F0-0x0000000180DD3750

	// Methods
	// [XID] // 0x0000000189838C20-0x0000000189838C40
	public void Initialize(List<ExternalVoiceSound> candidates) {} // 0x0000000180DD2F50-0x0000000180DD3080
	// [XID] // 0x00000001896C2640-0x00000001896C2660
	public override bool Next(VoicePickerParams @params, out ExternalVoiceSound voice) {
		voice = default;
		return default;
	} // 0x0000000180DD33E0-0x0000000180DD36F0
	// [XID] // 0x00000001896C9B90-0x00000001896C9BB0
	public override bool HasAnyChildWithSwitch(uint avatarSwitch) => default; // 0x0000000180DD3080-0x0000000180DD31C0
	// [XID] // 0x00000001896D1380-0x00000001896D13A0
	public override void EnumerateSounds(IList<ExternalVoiceSound> tempList) {} // 0x0000000180DD31C0-0x0000000180DD33E0
	// [XID] // 0x00000001896D8AC0-0x00000001896D8AE0
	public override void Clear() {} // 0x0000000180DD2EB0-0x0000000180DD2F50
}

