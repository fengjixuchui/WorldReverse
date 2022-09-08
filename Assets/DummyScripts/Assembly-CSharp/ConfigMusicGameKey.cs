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
using SimpleJSON;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[RecycleType] // 0x00000001898C45A0-0x00000001898C45C0
public class ConfigMusicGameKey : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 18775
{
	// Fields
	private MusicKeyType _button; // 0x10
	private SimpleSafeUInt32 timeRawNum; // 0x14
	private SimpleSafeInt32 noteRawNum; // 0x18

	// Properties
	public MusicKeyType button { /* [XID] */ /* 0x00000001897FDB40-0x00000001897FDB60 */ get => default; /* [XID] */ /* 0x0000000189805310-0x0000000189805330 */ private set {} } // 0x00000001851354F0-0x0000000185135590 0x0000000185134E90-0x0000000185134F40
	public uint time { /* [XID] */ /* 0x000000018980C910-0x000000018980C930 */ get => default; /* [XID] */ /* 0x0000000189814070-0x0000000189814090 */ private set {} } // 0x0000000185136440-0x0000000185136510 0x0000000185136100-0x00000001851361E0
	public int note { /* [XID] */ /* 0x000000018981BC60-0x000000018981BC80 */ get => default; /* [XID] */ /* 0x0000000189823050-0x0000000189823070 */ private set {} } // 0x0000000185134F40-0x0000000185135010 0x0000000185135D00-0x0000000185135DE0

	// Constructors
	public ConfigMusicGameKey() {} // 0x00000001851365B0-0x0000000185136610

	// Methods
	// [XID] // 0x000000018982AA90-0x000000018982AAB0
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001851361E0-0x0000000185136300
	// [XID] // 0x0000000189831F50-0x0000000189831F70
	public void InitEmpty() {} // 0x0000000185135910-0x0000000185135A00
	[BlackList] // 0x00000001898395E0-0x0000000189839620
	// [XID] // 0x00000001898395E0-0x0000000189839620
	public bool FromJson(JSONNode node) => default; // 0x0000000185135590-0x0000000185135910
	// [XID] // 0x0000000189843CA0-0x0000000189843CC0
	private bool InternalFromJson(JSONNode node) => default; // 0x00000001851347A0-0x0000000185134BC0
	// [XID] // 0x000000018984B150-0x000000018984B170
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFABD5 */, bool useObjectPool = false /* Metadata: 0x00AFABD9 */) => default; // 0x0000000185135A00-0x0000000185135D00
	// [XID] // 0x0000000189852400-0x0000000189852420
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFABDA */, bool useObjectPool = false /* Metadata: 0x00AFABDE */) => default; // 0x00000001851351C0-0x00000001851354F0
	[BlackList] // 0x0000000189859CF0-0x0000000189859D30
	// [XID] // 0x0000000189859CF0-0x0000000189859D30
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000185134BC0-0x0000000185134E90
	// [XID] // 0x0000000189864210-0x0000000189864230
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000185135DE0-0x0000000185136100
	[BlackList] // 0x000000018986B6C0-0x000000018986B700
	// [XID] // 0x000000018986B6C0-0x000000018986B700
	public virtual void AutoAllocTypeFields() {} // 0x0000000185135010-0x00000001851350B0
	[BlackList] // 0x0000000189875A40-0x0000000189875A80
	// [XID] // 0x0000000189875A40-0x0000000189875A80
	public virtual void AutoRecycleTypeFields() {} // 0x00000001851350B0-0x00000001851351C0
	[BlackList] // 0x00000001898801A0-0x00000001898801E0
	// [XID] // 0x00000001898801A0-0x00000001898801E0
	public virtual void ReturnToObjectPool() {} // 0x0000000185136510-0x00000001851365B0
	[BlackList] // 0x000000018988A3F0-0x000000018988A430
	// [XID] // 0x000000018988A3F0-0x000000018988A430
	public virtual void OnPoolAllocated() {} // 0x00000001851363A0-0x0000000185136440
	[BlackList] // 0x0000000189894970-0x00000001898949B0
	// [XID] // 0x0000000189894970-0x00000001898949B0
	public virtual void OnBeforePoolRecycled() {} // 0x0000000185136300-0x00000001851363A0
}

