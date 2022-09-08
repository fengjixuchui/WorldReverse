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

public sealed class CharacterizedVoicePlaylist : VoicePlaylist // TypeDefIndex: 11457
{
	// Fields
	private uint[] _switches; // 0x10
	private LowRepetitiveVoicePlaylist[] _children; // 0x18

	// Constructors
	public CharacterizedVoicePlaylist() {} // 0x000000018217B4B0-0x000000018217B510

	// Methods
	// [XID] // 0x00000001897F5A30-0x00000001897F5A50
	public void Initialize(Dictionary<uint, List<ExternalVoiceSound>> candidates, int avoidRepeat) {} // 0x000000018217A900-0x000000018217ACA0
	// [XID] // 0x0000000189670B60-0x0000000189670B80
	public override bool Next(VoicePickerParams @params, out ExternalVoiceSound voice) {
		voice = default;
		return default;
	} // 0x000000018217B2C0-0x000000018217B4B0
	// [XID] // 0x00000001896783F0-0x0000000189678410
	public override bool HasAnyChildWithSwitch(uint avatarSwitch) => default; // 0x000000018217ACA0-0x000000018217AD70
	// [XID] // 0x000000018967FCD0-0x000000018967FCF0
	public override void EnumerateSounds(IList<ExternalVoiceSound> tempList) {} // 0x000000018217B0D0-0x000000018217B2C0
	// [XID] // 0x0000000189687320-0x0000000189687340
	public override void Clear() {} // 0x000000018217A7F0-0x000000018217A900
	// [XID] // 0x00000001897EE290-0x00000001897EE2B0
	private void SortChildrenBySwitches(uint[] switches, LowRepetitiveVoicePlaylist[] children, int start, int end) {} // 0x000000018217AD70-0x000000018217B0D0
}

