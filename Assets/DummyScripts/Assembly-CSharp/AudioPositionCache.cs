/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class AudioPositionCache // TypeDefIndex: 11424
{
	// Fields
	private readonly Dictionary<ulong, Vector3> _cachedPosition; // 0x10
	private readonly Dictionary<ulong, AudioPositionArray> _cachedMultiPosition; // 0x18

	// Constructors
	public AudioPositionCache() {} // 0x00000001832CD5B0-0x00000001832CD690

	// Methods
	// [IDTag] // 0x0000000189A3E9B0-0x0000000189A3E9F0
	// [XID] // 0x0000000189A3E9B0-0x0000000189A3E9F0
	public void SaveSyncPosition(SyncId syncId, Vector3 position) {} // 0x00000001832CCB00-0x00000001832CCC20
	// [IDTag] // 0x0000000189A48FF0-0x0000000189A49030
	// [XID] // 0x0000000189A48FF0-0x0000000189A49030
	public void SaveSyncPosition(ulong syncId, Vector3 position) {} // 0x00000001832CC940-0x00000001832CCB00
	// [IDTag] // 0x0000000189A536F0-0x0000000189A53730
	// [XID] // 0x0000000189A536F0-0x0000000189A53730
	public void SaveSyncMultiPosition(SyncId syncId, AudioPositionArray array) {} // 0x00000001832CC740-0x00000001832CC860
	// [IDTag] // 0x0000000189A5E230-0x0000000189A5E270
	// [XID] // 0x0000000189A5E230-0x0000000189A5E270
	public void SaveSyncMultiPosition(ulong syncId, AudioPositionArray array) {} // 0x00000001832CC580-0x00000001832CC740
	// [XID] // 0x0000000189743F80-0x0000000189743FA0
	public void Remove(SyncId syncId) {} // 0x00000001832CC860-0x00000001832CC940
	// [XID] // 0x000000018971EA40-0x000000018971EA60
	public void ClearSyncCache(ulong syncId) {} // 0x00000001832CD3F0-0x00000001832CD5B0
	// [IDTag] // 0x0000000189A77A00-0x0000000189A77A40
	// [XID] // 0x0000000189A77A00-0x0000000189A77A40
	public bool TryGetCachePosition(SyncId syncId, out Vector3 position) {
		position = default;
		return default;
	} // 0x00000001832CD2F0-0x00000001832CD3F0
	// [IDTag] // 0x0000000189A824A0-0x0000000189A824E0
	// [XID] // 0x0000000189A824A0-0x0000000189A824E0
	public bool TryGetCachePosition(ulong gameObjectId, out Vector3 position) {
		position = default;
		return default;
	} // 0x00000001832CD0E0-0x00000001832CD2F0
	// [IDTag] // 0x0000000189A8CEA0-0x0000000189A8CEE0
	// [XID] // 0x0000000189A8CEA0-0x0000000189A8CEE0
	public bool TryGetCacheDistanceSqrTo(SyncId syncId, Vector3 position, out float distanceSqr) {
		distanceSqr = default;
		return default;
	} // 0x00000001832CCC20-0x00000001832CCD60
	// [IDTag] // 0x0000000189A974F0-0x0000000189A97530
	// [XID] // 0x0000000189A974F0-0x0000000189A97530
	public bool TryGetCacheDistanceSqrTo(ulong syncId, Vector3 position, out float distanceSqr) {
		distanceSqr = default;
		return default;
	} // 0x00000001832CCD60-0x00000001832CD0E0
}

