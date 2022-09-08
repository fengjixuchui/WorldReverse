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

public class AudioSwitchCache // TypeDefIndex: 11434
{
	// Fields
	private readonly Dictionary<ulong, AudioGameObjectWithSwitches> _gameObjects; // 0x10
	private readonly WorkerThreadContext _context; // 0x18

	// Constructors
	public AudioSwitchCache() {} // Dummy constructor
	public AudioSwitchCache(WorkerThreadContext context) {} // 0x0000000183975DF0-0x0000000183975EA0

	// Methods
	// [XID] // 0x000000018961CB40-0x000000018961CB60
	public AudioGameObjectWithSwitches GetGameObjectById(ulong gameObjectId) => default; // 0x0000000183975D00-0x0000000183975DF0
	// [XID] // 0x0000000189624000-0x0000000189624020
	public void GetSwitchesOnGameObject(ulong gameObjectId, Dictionary<uint, uint> map) {} // 0x0000000183975B00-0x0000000183975D00
	// [XID] // 0x000000018962B790-0x000000018962B7B0
	public void SetSwitch(SyncId syncId, uint group, uint value) {} // 0x0000000183975870-0x0000000183975B00
	// [XID] // 0x0000000189632FD0-0x0000000189632FF0
	public void UnregisterGameObject(SyncId syncId) {} // 0x0000000183975700-0x0000000183975870
}

