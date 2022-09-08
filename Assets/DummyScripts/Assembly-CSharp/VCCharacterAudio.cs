/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public abstract class VCCharacterAudio : VCBaseAudio // TypeDefIndex: 11841
{
	// Properties
	public override int metaTypeID { /* [XID] */ /* 0x000000018981F790-0x000000018981F7B0 */ get; } // 0x0000000183882510-0x00000001838825B0 

	// Constructors
	protected VCCharacterAudio() {} // 0x00000001838824B0-0x0000000183882510

	// Methods
	// [XID] // 0x00000001898F7030-0x00000001898F7050
	public override void Init() {} // 0x00000001838822F0-0x0000000183882440
	protected abstract ConfigAnimationAudio GetConfigAnimationAudio(ConfigCharacter configCharacter);
	// [XID] // 0x0000000189BDEB80-0x0000000189BDEBA0
	protected void SetAnimationAudioConfig() {} // 0x00000001838821A0-0x00000001838822F0
}

