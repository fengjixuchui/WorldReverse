/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class CommandThreadSoundBankFunctionalities : CommandThreadFunctionalities<SharedSoundBankFunctionalities> // TypeDefIndex: 11402
{
	// Constructors
	public CommandThreadSoundBankFunctionalities() {} // Dummy constructor
	public CommandThreadSoundBankFunctionalities(CommandThreadContext context, SharedSoundBankFunctionalities shared) {} // 0x0000000181E05270-0x0000000181E05300

	// Methods
	// [XID] // 0x0000000189952740-0x0000000189952760
	public override void Init() {} // 0x0000000181E04BD0-0x0000000181E04C70
	// [XID] // 0x000000018995B3B0-0x000000018995B3D0
	public override void Tick(float deltaTime) {} // 0x0000000181E04C70-0x0000000181E04D20
	// [XID] // 0x0000000189ABE5A0-0x0000000189ABE5C0
	public override void EnterHomeWorld(bool firstTime) {} // 0x0000000181E04E00-0x0000000181E04EF0
	// [XID] // 0x0000000189655C80-0x0000000189655CA0
	public override void ExitHomeWorld() {} // 0x0000000181E05120-0x0000000181E051C0
	// [XID] // 0x0000000189ACD660-0x0000000189ACD680
	public override void ExitGameWorld() {} // 0x0000000181E04EF0-0x0000000181E04F90
	// [XID] // 0x0000000189AD5400-0x0000000189AD5420
	public override void CreateLevel() {} // 0x0000000181E047F0-0x0000000181E04890
	// [XID] // 0x0000000189ADCDD0-0x0000000189ADCDF0
	public override void EnterLevel() {} // 0x0000000181E04D20-0x0000000181E04E00
	// [XID] // 0x0000000189AE4600-0x0000000189AE4620
	public override void ExitLevel() {} // 0x0000000181E04AF0-0x0000000181E04BD0
	// [XID] // 0x0000000189AEBD70-0x0000000189AEBD90
	public override void DumpCriticalInfo(StringBuilder builder) {} // 0x0000000181E051C0-0x0000000181E05270
	// [XID] // 0x0000000189AF37E0-0x0000000189AF3800
	public override void Destroy() {} // 0x0000000181E04970-0x0000000181E04A10
	// [XID] // 0x0000000189778370-0x0000000189778390
	public void LoadAllInOneSoundBank() {} // 0x0000000181E04A10-0x0000000181E04AF0
	// [XID] // 0x000000018982B840-0x000000018982B860
	public void UnloadSaneBanks() {} // 0x0000000181E04890-0x0000000181E04970
	// [XID] // 0x0000000189B09C40-0x0000000189B09C60
	public void Stop() {} // 0x0000000181E04710-0x0000000181E047F0
	// [XID] // 0x000000018988F7E0-0x000000018988F800
	public void CheckResourceExistence(IEnumerable<uint> bankIds, IEnumerable<string> externalFileNames, IResourceExistenceCallbackHandler callback) {} // 0x0000000181E04F90-0x0000000181E05120
}

