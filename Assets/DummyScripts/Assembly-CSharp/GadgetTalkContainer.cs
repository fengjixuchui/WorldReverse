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

public class GadgetTalkContainer : ITickableObject<TickObjectDoubleKey>, ISimplePoolObject // TypeDefIndex: 21673
{
	// Fields
	private uint _mapInstId; // 0x10
	private uint _groupId; // 0x14
	private uint _curDirtyFlag; // 0x18
	private List<ConfigTalkScheme> _validTalkList; // 0x20
	private Dictionary<uint, ConfigTalkScheme> _candidateTalkDic; // 0x28
	private static SimpleObjectPool<GadgetTalkContainer> _pool; // 0x00

	// Properties
	public TickObjectDoubleKey key { /* [XID] */ /* 0x0000000189845150-0x0000000189845170 */ get => default; } // 0x0000000181A872E0-0x0000000181A873A0 
	public int index { get; set; } // 0x0000000181A87A20-0x0000000181A87A80 0x0000000181A87A80-0x0000000181A87AE0
	private bool _isDirty { /* [XID] */ /* 0x00000001897F4380-0x00000001897F43A0 */ get => default; } // 0x0000000181A87C80-0x0000000181A87D50 
	public uint validTalkId { /* [XID] */ /* 0x000000018980A7D0-0x000000018980A7F0 */ get => default; } // 0x0000000181A873A0-0x0000000181A874F0 

	// Constructors
	public GadgetTalkContainer() {} // 0x0000000181A88190-0x0000000181A88260
	static GadgetTalkContainer() {} // 0x0000000181A88120-0x0000000181A88190

	// Methods
	// [XID] // 0x0000000189862630-0x0000000189862650
	public static GadgetTalkContainer Get(uint mapInstId, uint groupId) => default; // 0x0000000181A87700-0x0000000181A87820
	// [XID] // 0x0000000189869A20-0x0000000189869A40
	public static void Release(GadgetTalkContainer container) {} // 0x0000000181A87B90-0x0000000181A87C80
	// [XID] // 0x0000000189870D20-0x0000000189870D40
	public void SetDirty() {} // 0x0000000181A874F0-0x0000000181A87590
	// [XID] // 0x0000000189878750-0x0000000189878770
	public void ResetDirty() {} // 0x0000000181A87E50-0x0000000181A87F10
	// [XID] // 0x000000018987FD00-0x000000018987FD20
	public bool IsNeedRefreshValidTalkId() => default; // 0x0000000181A87AE0-0x0000000181A87B90
	// [XID] // 0x0000000189887320-0x0000000189887340
	public void AddCandidateTalk(ConfigTalkScheme talkConfig) {} // 0x0000000181A871A0-0x0000000181A872E0
	// [XID] // 0x000000018988E480-0x000000018988E4A0
	public void RemoveCandidateTalk(uint talkId) {} // 0x0000000181A87D50-0x0000000181A87E50
	// [XID] // 0x0000000189895AA0-0x0000000189895AC0
	public void RefreshValidTalkId() {} // 0x0000000181A87820-0x0000000181A87A20
	// [XID] // 0x000000018989D140-0x000000018989D160
	private bool IsTalkValid(ConfigTalkScheme talkConfig, uint mainQuestId, uint currentPriority) => default; // 0x0000000181A87F10-0x0000000181A88040
	// [XID] // 0x00000001898ABF40-0x00000001898ABF60
	public void Init(uint mapInstId, uint groupId) {} // 0x0000000181A87590-0x0000000181A87650
	// [XID] // 0x00000001898B3620-0x00000001898B3640
	public void ResetObject() {} // 0x0000000181A88040-0x0000000181A88120
	// [XID] // 0x00000001898BB450-0x00000001898BB470
	public void Tick(float deltaTime) {} // 0x0000000181A87650-0x0000000181A87700
}

