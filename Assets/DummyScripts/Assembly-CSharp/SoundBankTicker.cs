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

public sealed class SoundBankTicker : AudioStuffTicker<LoadedSoundBank> // TypeDefIndex: 11504
{
	// Fields
	private const double TOO_LONG_FOR_ASYNC = 100; // Metadata: 0x00AE9913
	private readonly WorkerThreadContext _context; // 0x18
	private readonly TimeSpan _asyncTimeOut; // 0x20
	private readonly Dictionary<uint, LoadedSoundBank> _loadedSoundBanks; // 0x28
	private readonly HashSet<uint> _usedBetweenTicks; // 0x30
	private readonly BankCallback _loadBankCallback; // 0x38
	private readonly BankCallback _unloadBankCallback; // 0x40
	private readonly Dictionary<uint, DateTime> _banksBeingLoaded; // 0x48
	private readonly Dictionary<uint, DateTime> _banksBeingUnloaded; // 0x50
	private DateTime _latestKnownTime; // 0x58
	private DateTime _foreseenTime; // 0x68
	private HashSet<uint> _failedInLastFrame; // 0x78
	private HashSet<uint> _failedInThisFrame; // 0x80

	// Nested types
	private enum SoundBankStatus // TypeDefIndex: 11505
	{
		Wild = 0,
		Loading = 1,
		Loaded = 2,
		Unloading = 3,
		Failed = 4
	}

	// Constructors
	public SoundBankTicker() {} // Dummy constructor
	public SoundBankTicker(WorkerThreadContext context) {} // 0x0000000181E68550-0x0000000181E68790

	// Methods
	// [IDTag] // 0x0000000189A419E0-0x0000000189A41A20
	// [XID] // 0x0000000189A419E0-0x0000000189A41A20
	public override void Tick(float deltaTime) {} // 0x0000000181E66FA0-0x0000000181E670E0
	// [IDTag] // 0x0000000189A4BFB0-0x0000000189A4BFF0
	// [XID] // 0x0000000189A4BFB0-0x0000000189A4BFF0
	public void Tick(TimeSpan deltaTime) {} // 0x0000000181E66ED0-0x0000000181E66FA0
	// [XID] // 0x0000000189A56640-0x0000000189A56660
	public void AddSoundBankUsage(List<uint> bankIds) {} // 0x0000000181E66C80-0x0000000181E66D40
	// [XID] // 0x0000000189687620-0x0000000189687640
	public void RemoveSoundBankUsage(List<uint> bankIds) {} // 0x0000000181E673C0-0x0000000181E67480
	// [IDTag] // 0x0000000189A65A20-0x0000000189A65A60
	// [XID] // 0x0000000189A65A20-0x0000000189A65A60
	public ResourceStatus AddOrTouch(List<uint> soundBankIds) => default; // 0x0000000181E67880-0x0000000181E679B0
	// [XID] // 0x0000000189A701A0-0x0000000189A701C0
	public void AddOrTouchLunatically(uint soundBankId) {} // 0x0000000181E66660-0x0000000181E66720
	// [XID] // 0x0000000189A779C0-0x0000000189A779E0
	public void UnloadImmediately(uint soundBankId) {} // 0x0000000181E679B0-0x0000000181E67C20
	// [XID] // 0x0000000189A7F080-0x0000000189A7F0A0
	public void MarkStageDestroyed() {} // 0x0000000181E68420-0x0000000181E68550
	// [XID] // 0x0000000189A86AA0-0x0000000189A86AC0
	public void UnloadSaneBanks(uint irregularBankId) {} // 0x0000000181E66820-0x0000000181E66A50
	// [XID] // 0x00000001898C5100-0x00000001898C5120
	protected override void Added(LoadedSoundBank t) {} // 0x0000000181E66D40-0x0000000181E66DF0
	// [IDTag] // 0x0000000189A95A50-0x0000000189A95A90
	// [XID] // 0x0000000189A95A50-0x0000000189A95A90
	protected override void Tick(float deltaTime, LoadedSoundBank t) {} // 0x0000000181E66DF0-0x0000000181E66ED0
	// [XID] // 0x0000000189AA0180-0x0000000189AA01A0
	protected override bool IsFinished(LoadedSoundBank t) => default; // 0x0000000181E68020-0x0000000181E680E0
	// [XID] // 0x0000000189AA79D0-0x0000000189AA79F0
	protected override void Terminate(LoadedSoundBank t, bool natural) {} // 0x0000000181E682D0-0x0000000181E68420
	// [XID] // 0x0000000189AAF1F0-0x0000000189AAF210
	protected override void Removed(LoadedSoundBank t) {} // 0x0000000181E67310-0x0000000181E673C0
	// [XID] // 0x0000000189AB6A90-0x0000000189AB6AB0
	protected override void Destroyed() {} // 0x0000000181E68220-0x0000000181E682D0
	// [IDTag] // 0x0000000189ABE560-0x0000000189ABE5A0
	// [XID] // 0x0000000189ABE560-0x0000000189ABE5A0
	private SoundBankStatus AddOrTouch(uint bankId, bool lunatic) => default; // 0x0000000181E67480-0x0000000181E67880
	// [XID] // 0x00000001898B5F90-0x00000001898B5FB0
	private void ExtendUsedBanksLifetime() {} // 0x0000000181E67160-0x0000000181E67310
	// [XID] // 0x0000000189AD04C0-0x0000000189AD04E0
	private void PushBackFailedRecords() {} // 0x0000000181E66720-0x0000000181E66820
	// [XID] // 0x0000000189AD81B0-0x0000000189AD81D0
	private LoadedSoundBank FindSoundBankById(uint bankId) => default; // 0x0000000181E67F30-0x0000000181E68020
	// [XID] // 0x0000000189ADFE80-0x0000000189ADFEA0
	private void ChangeSoundBankUsage(List<uint> bankIds, bool add) {} // 0x0000000181E680E0-0x0000000181E68220
	// [XID] // 0x0000000189AE74C0-0x0000000189AE74E0
	private void LoadBankCallback(uint bankId, AkResult loadResult, object cookie) {} // 0x0000000181E67C20-0x0000000181E67F30
	// [XID] // 0x0000000189AEF250-0x0000000189AEF270
	private void UnloadBankCallback(uint bankId, AkResult loadResult, object cookie) {} // 0x0000000181E66A50-0x0000000181E66C80
}

