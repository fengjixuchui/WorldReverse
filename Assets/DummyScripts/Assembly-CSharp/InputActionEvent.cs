/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MihoyoOptimization;
using SimpleJSON;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public struct InputActionEvent : IEmptyInitable, IHashable // TypeDefIndex: 19103
{
	// Fields
	private SimpleSafeInt32 priorityRawNum; // 0x00
	private InputEventType _eventType; // 0x04
	private ContextEventType _nextToHandle; // 0x08
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigBaseInputEvent _eventConfig; // 0x10
	private InputEventType _proxyEventType; // 0x18
	private ContextEventType _contextEvent; // 0x1C

	// Properties
	public int priority { /* [XID] */ /* 0x0000000189BDF6C0-0x0000000189BDF6E0 */ get => default; /* [XID] */ /* 0x00000001895EC190-0x00000001895EC1B0 */ set {} } // 0x00000001836B0F20-0x00000001836B10D0 0x00000001836B01F0-0x00000001836B02B0
	public InputEventType eventType { /* [XID] */ /* 0x0000000189814DD0-0x0000000189814DF0 */ get => default; /* [XID] */ /* 0x00000001895FAF90-0x00000001895FAFB0 */ set {} } // 0x00000001836B1820-0x00000001836B1850 0x00000001836B02B0-0x00000001836B0640
	public ContextEventType nextToHandle { /* [XID] */ /* 0x00000001896027D0-0x00000001896027F0 */ get => default; /* [XID] */ /* 0x000000018960A110-0x000000018960A130 */ private set {} } // 0x00000001836AF9B0-0x00000001836AFA60 0x00000001836B0700-0x00000001836B07E0
	public ConfigBaseInputEvent eventConfig { /* [XID] */ /* 0x00000001896118C0-0x00000001896118E0 */ get => default; /* [XID] */ /* 0x000000018981C880-0x000000018981C8A0 */ set {} } // 0x00000001836AF900-0x00000001836AF9B0 0x00000001836B0B30-0x00000001836B0E40
	public InputEventType proxyEventType { /* [XID] */ /* 0x00000001896206C0-0x00000001896206E0 */ get => default; /* [XID] */ /* 0x0000000189627BD0-0x0000000189627BF0 */ private set {} } // 0x00000001836B11A0-0x00000001836B1650 0x00000001836B08A0-0x00000001836B0960
	public ContextEventType contextEvent { /* [XID] */ /* 0x0000000189A51FC0-0x0000000189A51FE0 */ get => default; /* [XID] */ /* 0x0000000189637080-0x00000001896370A0 */ set {} } // 0x00000001836AF850-0x00000001836AF900 0x00000001836AFB20-0x00000001836AFFF0

	// Methods
	// [IDTag] // 0x000000018963E5E0-0x000000018963E620
	// [XID] // 0x000000018963E5E0-0x000000018963E620
	public bool Equals(InputActionEvent otherVal) => default; // 0x00000001836B10D0-0x00000001836B11A0
	// [IDTag] // 0x0000000189648DC0-0x0000000189648E00
	// [XID] // 0x0000000189648DC0-0x0000000189648E00
	public override bool Equals(object other) => default; // 0x00000001836B0110-0x00000001836B01F0
	// [XID] // 0x00000001896534C0-0x00000001896534E0
	public override int GetHashCode() => default; // 0x00000001836B07E0-0x00000001836B08A0
	// [XID] // 0x000000018965AD10-0x000000018965AD30
	public void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001836B1770-0x00000001836B1820
	// [XID] // 0x0000000189662220-0x0000000189662240
	public void InitEmpty() {} // 0x00000001836B0A70-0x00000001836B0B30
	[BlackList] // 0x0000000189669E00-0x0000000189669E40
	// [XID] // 0x0000000189669E00-0x0000000189669E40
	public bool FromJson(JSONNode node) => default; // 0x00000001836B0640-0x00000001836B0700
	// [XID] // 0x0000000189674830-0x0000000189674850
	private bool InternalFromJson(JSONNode node) => default; // 0x00000001836AF4C0-0x00000001836AF7A0
	// [XID] // 0x000000018967C1E0-0x000000018967C200
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFC1D9 */, bool useObjectPool = false /* Metadata: 0x00AFC1DD */) => default; // 0x00000001836B0E40-0x00000001836B0F20
	// [XID] // 0x0000000189B5A580-0x0000000189B5A5A0
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFC1DE */, bool useObjectPool = false /* Metadata: 0x00AFC1E2 */) => default; // 0x00000001836AFFF0-0x00000001836B0110
	[BlackList] // 0x000000018968B410-0x000000018968B450
	// [XID] // 0x000000018968B410-0x000000018968B450
	public bool ToBinary(ByteArray byteArray) => default; // 0x00000001836AF7A0-0x00000001836AF850
	// [XID] // 0x0000000189695EF0-0x0000000189695F10
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001836B1650-0x00000001836B1770
}

