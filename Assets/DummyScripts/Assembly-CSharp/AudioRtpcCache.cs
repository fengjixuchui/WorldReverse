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

public class AudioRtpcCache // TypeDefIndex: 11431
{
	// Fields
	private readonly Dictionary<AudioSyncProperty, float> _cachedValues; // 0x10
	private readonly Dictionary<ulong, AudioPropertyNameList> _appliedProperties; // 0x18
	private readonly WorkerThreadContext _context; // 0x20

	// Constructors
	public AudioRtpcCache() {} // Dummy constructor
	public AudioRtpcCache(WorkerThreadContext context) {} // 0x0000000182B74090-0x0000000182B74170

	// Methods
	// [IDTag] // 0x0000000189BA42C0-0x0000000189BA4300
	// [XID] // 0x0000000189BA42C0-0x0000000189BA4300
	public void SetRtpcValue(uint hashId, float value, SyncId syncId) {} // 0x0000000182B73930-0x0000000182B73B30
	// [IDTag] // 0x0000000189BAE480-0x0000000189BAE4C0
	// [XID] // 0x0000000189BAE480-0x0000000189BAE4C0
	public void SetRtpcValue(uint hashId, float value) {} // 0x0000000182B737D0-0x0000000182B73930
	// [XID] // 0x0000000189BB89A0-0x0000000189BB89C0
	public void Remove(SyncId syncId) {} // 0x0000000182B73B30-0x0000000182B73D50
	// [XID] // 0x0000000189BC03A0-0x0000000189BC03C0
	private bool UpdatePropertyValue(AudioSyncProperty syncProperty, float value) => default; // 0x0000000182B73D50-0x0000000182B73F00
	// [XID] // 0x00000001896CD0A0-0x00000001896CD0C0
	private void RecordAppliedProperty(AudioSyncProperty syncProperty) {} // 0x0000000182B73F00-0x0000000182B74090
}

