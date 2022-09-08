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

public sealed class SingleVoicePlaylist : VoicePlaylist // TypeDefIndex: 11460
{
	// Fields
	private ExternalVoiceSound _sound; // 0x10

	// Constructors
	public SingleVoicePlaylist() {} // 0x000000018212ACD0-0x000000018212AD30

	// Methods
	// [XID] // 0x00000001896E02F0-0x00000001896E0310
	public void Initialize(ExternalVoiceSound sound) {} // 0x000000018212A850-0x000000018212A920
	// [XID] // 0x00000001896E7600-0x00000001896E7620
	public override bool Next(VoicePickerParams @params, out ExternalVoiceSound voice) {
		voice = default;
		return default;
	} // 0x000000018212ABB0-0x000000018212ACD0
	// [XID] // 0x00000001896EEC40-0x00000001896EEC60
	public override bool HasAnyChildWithSwitch(uint avatarSwitch) => default; // 0x000000018212A920-0x000000018212A9E0
	// [XID] // 0x00000001896F6620-0x00000001896F6640
	public override void EnumerateSounds(IList<ExternalVoiceSound> tempList) {} // 0x000000018212A9E0-0x000000018212ABB0
	// [XID] // 0x00000001896FDD70-0x00000001896FDD90
	public override void Clear() {} // 0x000000018212A7B0-0x000000018212A850
}

