/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MihoyoOptimization;
using MoleMole;
using Newtonsoft.Json;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[RecycleType] // 0x00000001898C45A0-0x00000001898C45C0
public class ActivityMistTrialWatcherListDataExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15141
{
	// Fields
	public static Func<uint, string> getLocalizedTextHandler; // 0x00
	protected SimpleSafeUInt32 IdRawNum; // 0x10
	protected SimpleSafeUInt32 scheduleIdRawNum; // 0x14
	protected SimpleSafeUInt32 challengeWatcherIdRawNum; // 0x18
	protected MistTrialClientSyncType _dungeonShowContentType; // 0x1C
	protected string[] _showParam; // 0x20
	protected uint _progressFormatTextMapHash; // 0x28

	// Properties
	public uint Id { /* [XID] */ /* 0x00000001899C4900-0x00000001899C4920 */ get => default; /* [XID] */ /* 0x00000001899CC060-0x00000001899CC080 */ protected set {} } // 0x0000000181C44F10-0x0000000181C44FE0 0x0000000181C45A70-0x0000000181C45B50
	public uint scheduleId { /* [XID] */ /* 0x00000001899D3610-0x00000001899D3630 */ get => default; /* [XID] */ /* 0x00000001899DABE0-0x00000001899DAC00 */ protected set {} } // 0x0000000181C44000-0x0000000181C440D0 0x0000000181C458C0-0x0000000181C459A0
	public uint challengeWatcherId { /* [XID] */ /* 0x00000001899E2480-0x00000001899E24A0 */ get => default; /* [XID] */ /* 0x00000001899E99C0-0x00000001899E99E0 */ protected set {} } // 0x0000000181C459A0-0x0000000181C45A70 0x0000000181C44FE0-0x0000000181C450C0
	public MistTrialClientSyncType dungeonShowContentType { /* [XID] */ /* 0x00000001899F11B0-0x00000001899F11D0 */ get => default; /* [XID] */ /* 0x00000001899F8A50-0x00000001899F8A70 */ protected set {} } // 0x0000000181C44270-0x0000000181C44310 0x0000000181C45760-0x0000000181C45810
	public string[] showParam { /* [XID] */ /* 0x00000001899FFF80-0x00000001899FFFA0 */ get => default; /* [XID] */ /* 0x0000000189A077F0-0x0000000189A07810 */ protected set {} } // 0x0000000181C45BF0-0x0000000181C45C90 0x0000000181C45810-0x0000000181C458C0
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint progressFormatTextMapHash { /* [XID] */ /* 0x0000000189A0ED30-0x0000000189A0ED50 */ get => default; /* [XID] */ /* 0x0000000189A164C0-0x0000000189A164E0 */ protected set {} } // 0x0000000181C45B50-0x0000000181C45BF0 0x0000000181C450C0-0x0000000181C45170
	public string progressFormat { /* [XID] */ /* 0x0000000189A1DA60-0x0000000189A1DA80 */ get => default; } // 0x0000000181C44D90-0x0000000181C44F10 

	// Constructors
	public ActivityMistTrialWatcherListDataExcelConfig() {} // 0x0000000181C45E70-0x0000000181C45ED0

	// Methods
	// [IDTag] // 0x0000000189A24F10-0x0000000189A24F50
	// [XID] // 0x0000000189A24F10-0x0000000189A24F50
	public virtual bool ParseFromLine(string line) => default; // 0x0000000181C44830-0x0000000181C44D90
	// [IDTag] // 0x0000000189A2F510-0x0000000189A2F550
	// [XID] // 0x0000000189A2F510-0x0000000189A2F550
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000181C44310-0x0000000181C44830
	// [XID] // 0x0000000189A39C90-0x0000000189A39CB0
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF0203 */, bool useObjectPool = false /* Metadata: 0x00AF0207 */) => default; // 0x0000000181C45170-0x0000000181C45760
	[BlackList] // 0x0000000189A414B0-0x0000000189A414F0
	// [XID] // 0x0000000189A414B0-0x0000000189A414F0
	public virtual void AutoAllocTypeFields() {} // 0x0000000181C440D0-0x0000000181C44170
	[BlackList] // 0x0000000189A4BB00-0x0000000189A4BB40
	// [XID] // 0x0000000189A4BB00-0x0000000189A4BB40
	public virtual void AutoRecycleTypeFields() {} // 0x0000000181C44170-0x0000000181C44270
	[BlackList] // 0x0000000189A56340-0x0000000189A56380
	// [XID] // 0x0000000189A56340-0x0000000189A56380
	public virtual void ReturnToObjectPool() {} // 0x0000000181C45DD0-0x0000000181C45E70
	[BlackList] // 0x0000000189A60CE0-0x0000000189A60D20
	// [XID] // 0x0000000189A60CE0-0x0000000189A60D20
	public virtual void OnPoolAllocated() {} // 0x0000000181C45D30-0x0000000181C45DD0
	[BlackList] // 0x0000000189A6B7D0-0x0000000189A6B810
	// [XID] // 0x0000000189A6B7D0-0x0000000189A6B810
	public virtual void OnBeforePoolRecycled() {} // 0x0000000181C45C90-0x0000000181C45D30
}

