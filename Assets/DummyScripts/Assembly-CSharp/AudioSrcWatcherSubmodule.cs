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

public class AudioSrcWatcherSubmodule // TypeDefIndex: 11262
{
	// Fields
	private readonly AudioManager _manager; // 0x10
	private Dictionary<int, Dictionary<int, int>> _srcCnt; // 0x18
	private Dictionary<int, Dictionary<int, List<EvtAudio.EvtAudioParam>>> _srcParam; // 0x20

	// Constructors
	public AudioSrcWatcherSubmodule() {} // Dummy constructor
	public AudioSrcWatcherSubmodule(AudioManager manager) {} // 0x000000018164D560-0x000000018164D620

	// Methods
	// [XID] // 0x0000000189848980-0x00000001898489A0
	public void Init() {} // 0x000000018164CB60-0x000000018164CC00
	// [XID] // 0x0000000189935DA0-0x0000000189935DC0
	public void OnDestroy() {} // 0x000000018164C970-0x000000018164CA40
	// [XID] // 0x00000001898574E0-0x0000000189857500
	public void OnLevelExit() {} // 0x000000018164D490-0x000000018164D560
	// [XID] // 0x000000018985E700-0x000000018985E720
	public void Add(EvtAudio.OP op, EvtAudio.AUDIO_SRC src, EvtAudio.EvtAudioParam param) {} // 0x000000018164D1A0-0x000000018164D490
	// [XID] // 0x0000000189865F50-0x0000000189865F70
	public void Clear(EvtAudio.OP op, EvtAudio.AUDIO_SRC src) {} // 0x000000018164CC00-0x000000018164CDD0
	// [XID] // 0x0000000189A5FC80-0x0000000189A5FCA0
	public int Get(EvtAudio.OP op, EvtAudio.AUDIO_SRC src) => default; // 0x000000018164CDD0-0x000000018164CF10
	// [XID] // 0x0000000189A676C0-0x0000000189A676E0
	public List<EvtAudio.EvtAudioParam> GetParams(EvtAudio.OP op, EvtAudio.AUDIO_SRC src) => default; // 0x000000018164CF10-0x000000018164D050
	// [XID] // 0x0000000189944E90-0x0000000189944EB0
	public void ClearOp(EvtAudio.OP op, EvtAudio.AUDIO_SRC src) {} // 0x000000018164CA40-0x000000018164CB60
	// [XID] // 0x000000018996A350-0x000000018996A370
	private void ClearOpInternal(EvtAudio.OP op, int cnt, List<EvtAudio.EvtAudioParam> paramList) {} // 0x000000018164D050-0x000000018164D1A0
}

