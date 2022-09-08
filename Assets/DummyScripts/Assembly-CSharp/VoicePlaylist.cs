/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public abstract class VoicePlaylist // TypeDefIndex: 11462
{
	// Constructors
	protected VoicePlaylist() {} // 0x0000000181D51BA0-0x0000000181D51C00

	// Methods
	public abstract bool Next(VoicePickerParams @params, out ExternalVoiceSound voice);
	public abstract bool HasAnyChildWithSwitch(uint avatarSwitch);
	public abstract void EnumerateSounds(IList<ExternalVoiceSound> tempList);
	public abstract void Clear();
}

