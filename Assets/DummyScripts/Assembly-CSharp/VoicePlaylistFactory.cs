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

public static class VoicePlaylistFactory // TypeDefIndex: 11463
{
	// Methods
	// [XID] // 0x0000000189722E70-0x0000000189722E90
	public static SingleVoicePlaylist CreateSingle(ExternalVoiceSound sound) => default; // 0x0000000182ACF170-0x0000000182ACF270
	// [XID] // 0x000000018984EF70-0x000000018984EF90
	public static SimpleVoicePlaylist CreateSimple(List<ExternalVoiceSound> candidates) => default; // 0x0000000182ACF350-0x0000000182ACF420
	// [XID] // 0x0000000189731D00-0x0000000189731D20
	public static CharacterizedVoicePlaylist CreateCharacterized(Dictionary<uint, List<ExternalVoiceSound>> candidates, int avoidRepeat) => default; // 0x0000000182ACF270-0x0000000182ACF350
	// [XID] // 0x0000000189739260-0x0000000189739280
	public static void Recycle(VoicePlaylist playlist) {} // 0x0000000182ACF040-0x0000000182ACF170
}

