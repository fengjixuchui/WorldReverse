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

public sealed class WorkerThreadSoundBankFunctionalities : WorkerThreadFunctionalities<SharedSoundBankFunctionalities> // TypeDefIndex: 11407
{
	// Fields
	private const string MINIMUM_SOUNDBANK_NAME = "Minimum"; // Metadata: 0x00AE982B
	private readonly uint _minimumBankId; // 0x20
	private readonly SoundBankTicker _soundBankTicker; // 0x28
	private readonly Dictionary<uint, uint> _reusedSwitchMap; // 0x30
	private readonly Dictionary<uint, uint> _reusedStateMap; // 0x38
	private readonly HashSet<uint> _reusedBankIdSet; // 0x40
	private readonly List<uint> _reusedBankIdList; // 0x48
	private readonly AVLTreeOnArray<BankUsage> _bankUsageTree; // 0x50
	private readonly List<BankUsage> _reusedBankUsageList; // 0x58

	// Nested types
	private struct BankUsage // TypeDefIndex: 11408
	{
		// Properties
		public int eventOrdinal { /* [XID] */ /* 0x0000000189BD86F0-0x0000000189BD8730 */ get; /* [XID] */ /* 0x00000001895E8370-0x00000001895E83B0 */ set; } // 0x00000001847F7D10-0x00000001847F7D70 0x00000001847F7DD0-0x00000001847F7E30
		public uint bankId { /* [XID] */ /* 0x00000001895F2980-0x00000001895F29C0 */ get; /* [XID] */ /* 0x0000000189A47B90-0x0000000189A47BD0 */ set; } // 0x00000001847F7E30-0x00000001847F7E90 0x00000001847F7D70-0x00000001847F7DD0
	}

	private class BankUsageComparer : IComparer<BankUsage> // TypeDefIndex: 11409
	{
		// Constructors
		public BankUsageComparer() {} // 0x00000001847F7CB0-0x00000001847F7D10

		// Methods
		// [XID] // 0x0000000189607860-0x0000000189607880
		public int Compare(BankUsage x, BankUsage y) => default; // 0x00000001847F7A80-0x00000001847F7CB0
	}

	// Constructors
	public WorkerThreadSoundBankFunctionalities() {} // Dummy constructor
	public WorkerThreadSoundBankFunctionalities(WorkerThreadContext context, SharedSoundBankFunctionalities shared) {} // 0x00000001847DA8A0-0x00000001847DAAA0

	// Methods
	// [XID] // 0x000000018998E6D0-0x000000018998E6F0
	public override void Init() {} // 0x00000001847D9D90-0x00000001847D9E80
	// [XID] // 0x0000000189B3D640-0x0000000189B3D660
	public override void Destroy() {} // 0x00000001847D9630-0x00000001847D96D0
	// [XID] // 0x0000000189621250-0x0000000189621270
	public override void Tick(TimeSpan deltaTime) {} // 0x00000001847D9E80-0x00000001847D9F40
	// [XID] // 0x0000000189B4CAF0-0x0000000189B4CB10
	public void SetStageExitFlagOnSoundBanks() {} // 0x00000001847DA4E0-0x00000001847DA590
	// [XID] // 0x000000018996E9D0-0x000000018996E9F0
	public void Stop() {} // 0x00000001847D8DA0-0x00000001847D8E60
	// [XID] // 0x0000000189B6DA90-0x0000000189B6DAB0
	public void LoadMinimumSoundBank() {} // 0x00000001847DA430-0x00000001847DA4E0
	// [XID] // 0x0000000189B63160-0x0000000189B63180
	public void UnloadMinimumSoundBank() {} // 0x00000001847D9580-0x00000001847D9630
	// [XID] // 0x0000000189B6AA50-0x0000000189B6AA70
	public void LoadAllInOneSoundBank() {} // 0x00000001847D9B20-0x00000001847D9BB0
	// [XID] // 0x000000018990F380-0x000000018990F3A0
	public void UnloadSaneBanks() {} // 0x00000001847D9190-0x00000001847D9240
	// [XID] // 0x0000000189B79650-0x0000000189B79670
	public ResourceStatus AddOrTouchSoundBanks(List<uint> soundBankIds) => default; // 0x00000001847DA120-0x00000001847DA230
	// [XID] // 0x0000000189B809F0-0x0000000189B80A10
	public void AddSoundBankUsage(int eventOrdinal, List<uint> bankIds) {} // 0x00000001847D9BB0-0x00000001847D9D90
	// [XID] // 0x0000000189AF0B10-0x0000000189AF0B30
	public void RemoveSoundBankUsage(int eventOrdinal) {} // 0x00000001847DA230-0x00000001847DA430
	// [XID] // 0x0000000189672820-0x0000000189672840
	public void FindSoundBanksForEvent(uint eventId, SyncId syncId, List<uint> bankIdList) {} // 0x00000001847D98E0-0x00000001847D9B20
	// [XID] // 0x0000000189B96DC0-0x0000000189B96DE0
	public void UpdateSoundBankUsageForEvent(EventInstance eventInstance) {} // 0x00000001847D9240-0x00000001847D9580
	// [XID] // 0x0000000189B9E1D0-0x0000000189B9E1F0
	public void CheckResourceExistence(List<uint> bankIds, List<string> externalFileNames, IResourceExistenceCallbackHandler callback) {} // 0x00000001847DA590-0x00000001847DA730
	// [XID] // 0x0000000189BA5B30-0x0000000189BA5B50
	private void GetBankUsageByEvent(int eventOrdinal, List<BankUsage> bankUsageList) {} // 0x00000001847D96D0-0x00000001847D98E0
	// [XID] // 0x0000000189BACE60-0x0000000189BACE80
	private void CheckBanksExist(WwiseInterface lowLevel, List<uint> ids, HashSet<uint> results) {} // 0x00000001847DA730-0x00000001847DA8A0
	// [XID] // 0x0000000189AF8150-0x0000000189AF8170
	private void CheckExternalFilesExist(WwiseInterface lowLevel, List<string> names, HashSet<string> results) {} // 0x00000001847D8E60-0x00000001847D9190
	// [Conditional] // 0x00000001896BE330-0x00000001896BE360
	private unsafe void CheckExternalFileExists(char* pPath, int nPath, ref bool result, ref string[] basePaths, ref StringBuilder builder) {} // 0x00000001847D9F40-0x00000001847DA120
}

