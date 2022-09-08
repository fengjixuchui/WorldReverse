/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole.Audio.Data.SoundBank;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class SoundBankLookupData // TypeDefIndex: 19394
{
	// Fields
	private static readonly UnloadPolicy _defaultUnloadPolicy; // 0x00
	private static readonly UnloadPolicy _lunaticUnloadPolicy; // 0x08
	private static readonly UnloadPolicy _sensibleUnloadPolicy; // 0x10
	private static SoundBankLookupData _currentLoaded; // 0x18
	private readonly Dictionary<uint, int> _eventIndices; // 0x10
	private readonly HashSet<uint> _unworthySwitchGroupIds; // 0x18
	private readonly HashSet<uint> _unworthyStateGroupIds; // 0x20
	private readonly UnloadPolicy _customDefaultUnloadPolicy; // 0x28
	private readonly unsafe SoundBankDataHeader* _pHeader; // 0x30
	private readonly unsafe AudioEventUnion* _pEvents; // 0x38
	private readonly unsafe uint* _pBankIds; // 0x40
	private readonly unsafe uint* _pConditionals; // 0x48
	private bool _hasCleared; // 0x50

	// Properties
	public static UnloadPolicy lunaticUnloadPolicy { /* [XID] */ /* 0x000000018996C5D0-0x000000018996C5F0 */ get => default; } // 0x0000000183660C60-0x0000000183660D30 
	public static UnloadPolicy sensibleUnloadPolicy { /* [XID] */ /* 0x0000000189974050-0x0000000189974070 */ get => default; } // 0x00000001836607D0-0x00000001836608A0 

	// Constructors
	public SoundBankLookupData() {} // Dummy constructor
	static SoundBankLookupData() {} // 0x00000001836612F0-0x0000000183661430
	public unsafe SoundBankLookupData(SoundBankDataHeader* pHeader) {} // 0x0000000183661430-0x0000000183661680

	// Methods
	// [XID] // 0x000000018997B7B0-0x000000018997B7D0
	public static void ReloadFromFile() {} // 0x0000000183660450-0x0000000183660620
	[DebuggerHidden] // 0x0000000189983270-0x00000001899832B0
	// [XID] // 0x0000000189983270-0x00000001899832B0
	public static IEnumerator ReloadFromFileAsync(float progressSpan = 0f /* Metadata: 0x00AFC803 */, Action<float> moveOneStepCallback = null, Action<string> finishCallback = null) => default; // 0x00000001836609E0-0x0000000183660B20
	// [XID] // 0x000000018998DA20-0x000000018998DA40
	public static UnloadPolicy GetUnloadPolicy(uint soundBankId) => default; // 0x00000001836608A0-0x00000001836609E0
	// [XID] // 0x00000001899954B0-0x00000001899954D0
	public static void GetNecessaryBankIds(uint eventId, List<uint> bankIds, Dictionary<uint, uint> effectiveSwitches, Dictionary<uint, uint> effectiveStates) {} // 0x0000000183660170-0x00000001836602D0
	// [XID] // 0x000000018999CF10-0x000000018999CF30
	public static void GetAffectiveSwitchesAndStates(uint eventId, List<uint> switches, List<uint> states) {} // 0x0000000183660B20-0x0000000183660C60
	// [XID] // 0x00000001899A4850-0x00000001899A4870
	private void GetNecessaryBankIdsFromInstance(uint eventId, List<uint> bankIds, Dictionary<uint, uint> effectiveSwitches, Dictionary<uint, uint> effectiveStates) {} // 0x0000000183661010-0x00000001836611D0
	// [XID] // 0x0000000189A13F90-0x0000000189A13FB0
	private void GetAffectiveSwitchesAndStatesFromInstance(uint eventId, List<uint> switches, List<uint> states) {} // 0x000000018365FF50-0x0000000183660170
	// [XID] // 0x00000001897BE3B0-0x00000001897BE3D0
	private void AddBatchedBankIdsToList(List<uint> list, int startIndex, int count) {} // 0x00000001836611D0-0x00000001836612F0
	// [XID] // 0x00000001899BAE60-0x00000001899BAE80
	private void AddConditionalBankIds(int conditionalsStartIndex, List<uint> bankIds, Dictionary<uint, uint> effectiveSwitches, Dictionary<uint, uint> effectiveStates) {} // 0x0000000183660620-0x00000001836607D0
	// [XID] // 0x000000018978E900-0x000000018978E920
	private unsafe bool TryGetEventPtr(uint id, out AudioEventUnion* p) {
		p = default;
		return default;
	} // 0x0000000183660D30-0x0000000183660E70
	public unsafe void BuildEventIndexMap(AudioEventUnion* p, int n) {} // 0x0000000183660F20-0x0000000183661010
	private unsafe void AddToShortIdHashSet(uint* ptr, int count, HashSet<uint> hashSet) {} // 0x0000000183660E70-0x0000000183660F20
	// [XID] // 0x00000001899C9EE0-0x00000001899C9F00
	private void Clear() {} // 0x00000001836602D0-0x0000000183660450
}

