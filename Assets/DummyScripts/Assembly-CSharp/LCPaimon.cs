/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class LCPaimon : LCBase // TypeDefIndex: 11754
{
	// Fields
	private VCPaimon _vcPaimon; // 0x130
	public ConfigPaimon config; // 0x138
	public bool isAppear; // 0x140
	private bool _directly; // 0x142
	private bool _lookAtCamera; // 0x143

	// Properties
	public override int metaTypeID { /* [XID] */ /* 0x00000001899A3C60-0x00000001899A3C80 */ get => default; } // 0x0000000183EAE020-0x0000000183EAE0C0 
	public bool setAppearByTask { /* [XID] */ /* 0x00000001898952E0-0x0000000189895320 */ get; /* [XID] */ /* 0x000000018989F4A0-0x000000018989F4E0 */ private set; } // 0x0000000183EADA50-0x0000000183EADAB0 0x0000000183EAD130-0x0000000183EAD1A0

	// Constructors
	public LCPaimon() {} // 0x0000000183EADFB0-0x0000000183EAE020

	// Methods
	// [XID] // 0x00000001898A9DC0-0x00000001898A9DE0
	public override void Init() {} // 0x0000000183EADC50-0x0000000183EADD50
	// [XID] // 0x00000001898B17B0-0x00000001898B17D0
	private void AppearOnEntityReadyPost(EvtEntityReadyPost evt) {} // 0x0000000183EADD50-0x0000000183EADE10
	// [XID] // 0x00000001898B9120-0x00000001898B9140
	private void DisappearOnEntityReadyPost(EvtEntityReadyPost evt) {} // 0x0000000183EAD080-0x0000000183EAD130
	// [XID] // 0x00000001898C06A0-0x00000001898C06C0
	public void SetAppear(PaimonRequestFrom from, bool directly = false /* Metadata: 0x00AEA797 */, bool lookAtCamera = true /* Metadata: 0x00AEA798 */) {} // 0x0000000183EAD640-0x0000000183EADA50
	// [XID] // 0x00000001898C7E80-0x00000001898C7EA0
	private void OnAppearReady(bool directly, bool lookAtCamera) {} // 0x0000000183EAD370-0x0000000183EAD640
	// [XID] // 0x00000001898CF6C0-0x00000001898CF6E0
	public void SetDisappear(PaimonRequestFrom from, bool immediately = false /* Metadata: 0x00AEA799 */) {} // 0x0000000183EAD1A0-0x0000000183EAD370
	// [XID] // 0x00000001898D6EF0-0x00000001898D6F10
	public void OnDisappearEnd() {} // 0x0000000183EADAB0-0x0000000183EADC50
	// [XID] // 0x000000018990F0B0-0x000000018990F0D0
	public void TryPaimonSkill(PaimonRequestFrom from, PaimonSkill skillID) {} // 0x0000000183EADE80-0x0000000183EADFB0
}

