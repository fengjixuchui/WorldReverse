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
public class ConfigBornType : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17854
{
	// Fields
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private DynamicFloatVector _offset; // 0x10
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private BornRandom _bornRandom; // 0x18
	private bool _onGround; // 0x20
	private bool _onGroundIgnoreWater; // 0x21
	private SimpleSafeFloat onGroundRaycastUpDistRawNum; // 0x24
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigBornDirectionType _direction; // 0x28
	private bool _alongGround; // 0x30
	private bool _useRotation; // 0x31

	// Properties
	public DynamicFloatVector offset { /* [XID] */ /* 0x000000018961D8D0-0x000000018961D8F0 */ get => default; /* [XID] */ /* 0x0000000189624CF0-0x0000000189624D10 */ private set {} } // 0x0000000185162B50-0x0000000185162BF0 0x00000001851639E0-0x0000000185163A90
	public BornRandom bornRandom { /* [XID] */ /* 0x000000018962C4D0-0x000000018962C4F0 */ get => default; /* [XID] */ /* 0x00000001896340B0-0x00000001896340D0 */ private set {} } // 0x00000001851648A0-0x0000000185164940 0x0000000185162920-0x00000001851629D0
	public bool onGround { /* [XID] */ /* 0x000000018963B960-0x000000018963B980 */ get => default; /* [XID] */ /* 0x00000001896430C0-0x00000001896430E0 */ private set {} } // 0x0000000185163A90-0x0000000185163B30 0x0000000185163D30-0x0000000185163DE0
	public bool onGroundIgnoreWater { /* [XID] */ /* 0x000000018964A740-0x000000018964A760 */ get => default; /* [XID] */ /* 0x0000000189651F80-0x0000000189651FA0 */ private set {} } // 0x00000001851644D0-0x0000000185164570 0x00000001851634B0-0x0000000185163560
	public float onGroundRaycastUpDist { /* [XID] */ /* 0x0000000189659650-0x0000000189659670 */ get => default; /* [XID] */ /* 0x0000000189660DD0-0x0000000189660DF0 */ private set {} } // 0x0000000185162A70-0x0000000185162B50 0x00000001851621E0-0x00000001851622C0
	public ConfigBornDirectionType direction { /* [XID] */ /* 0x0000000189668700-0x0000000189668720 */ get => default; /* [XID] */ /* 0x0000000189670270-0x0000000189670290 */ private set {} } // 0x00000001851631F0-0x0000000185163290 0x0000000185163140-0x00000001851631F0
	public bool alongGround { /* [XID] */ /* 0x0000000189677B10-0x0000000189677B30 */ get => default; /* [XID] */ /* 0x000000018967F060-0x000000018967F080 */ private set {} } // 0x0000000185163560-0x0000000185163600 0x00000001851622C0-0x0000000185162370
	public bool useRotation { /* [XID] */ /* 0x0000000189686970-0x0000000189686990 */ get => default; /* [XID] */ /* 0x000000018968E7F0-0x000000018968E810 */ private set {} } // 0x00000001851629D0-0x0000000185162A70 0x0000000185162060-0x0000000185162110

	// Constructors
	public ConfigBornType() {} // 0x00000001851649E0-0x0000000185164A80

	// Methods
	// [XID] // 0x00000001896962D0-0x00000001896962F0
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000185164570-0x0000000185164760
	// [XID] // 0x000000018969D910-0x000000018969D930
	public virtual void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000185163DE0-0x0000000185163EF0
	// [XID] // 0x00000001896A4900-0x00000001896A4920
	public virtual ConfigBornType Clone(bool useObjectPool = false /* Metadata: 0x00AF7F29 */) => default; // 0x0000000185163900-0x00000001851639E0
	// [XID] // 0x00000001896AC0B0-0x00000001896AC0D0
	public virtual int GetHashNum() => default; // 0x0000000185162110-0x00000001851621E0
	// [XID] // 0x00000001896B3350-0x00000001896B3370
	public virtual void InitEmpty() {} // 0x0000000185163290-0x00000001851633C0
	[BlackList] // 0x00000001896BAB30-0x00000001896BAB70
	// [XID] // 0x00000001896BAB30-0x00000001896BAB70
	public virtual bool FromJson(JSONNode node) => default; // 0x0000000185162BF0-0x0000000185162F70
	// [XID] // 0x00000001896C4E90-0x00000001896C4EB0
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000185161330-0x0000000185161AA0
	[BlackList] // 0x00000001896CC2F0-0x00000001896CC330
	// [XID] // 0x00000001896CC2F0-0x00000001896CC330
	public static ConfigBornType ParseFromJson(JSONNode node) => default; // 0x0000000185163B30-0x0000000185163D30
	// [XID] // 0x00000001896D6980-0x00000001896D69A0
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7F2A */, bool useObjectPool = false /* Metadata: 0x00AF7F2E */) => default; // 0x0000000185163600-0x0000000185163900
	// [XID] // 0x00000001896DDFC0-0x00000001896DDFE0
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7F2F */, bool useObjectPool = false /* Metadata: 0x00AF7F33 */) => default; // 0x0000000185162370-0x0000000185162920
	// [XID] // 0x00000001896E5550-0x00000001896E5570
	public static ConfigBornType ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7F34 */, bool useObjectPool = false /* Metadata: 0x00AF7F38 */) => default; // 0x0000000185162F70-0x0000000185163140
	[BlackList] // 0x00000001896ECBA0-0x00000001896ECBE0
	// [XID] // 0x00000001896ECBA0-0x00000001896ECBE0
	public virtual bool ToBinary(ByteArray byteArray) => default; // 0x0000000185161AA0-0x0000000185161D70
	// [XID] // 0x00000001896F73D0-0x00000001896F73F0
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000185163EF0-0x00000001851644D0
	[BlackList] // 0x00000001896FED30-0x00000001896FED70
	// [XID] // 0x00000001896FED30-0x00000001896FED70
	public virtual bool SuperToBinary(ByteArray byteArray) => default; // 0x00000001851633C0-0x00000001851634B0
	[BlackList] // 0x0000000189709240-0x0000000189709280
	// [XID] // 0x0000000189709240-0x0000000189709280
	public virtual void AutoAllocTypeFields() {} // 0x0000000185161D70-0x0000000185161E10
	[BlackList] // 0x00000001897139A0-0x00000001897139E0
	// [XID] // 0x00000001897139A0-0x00000001897139E0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000185161E10-0x0000000185162060
	[BlackList] // 0x000000018971E040-0x000000018971E080
	// [XID] // 0x000000018971E040-0x000000018971E080
	public virtual void ReturnToObjectPool() {} // 0x0000000185164940-0x00000001851649E0
	[BlackList] // 0x0000000189728570-0x00000001897285B0
	// [XID] // 0x0000000189728570-0x00000001897285B0
	public virtual void OnPoolAllocated() {} // 0x0000000185164800-0x00000001851648A0
	[BlackList] // 0x0000000189732AE0-0x0000000189732B20
	// [XID] // 0x0000000189732AE0-0x0000000189732B20
	public virtual void OnBeforePoolRecycled() {} // 0x0000000185164760-0x0000000185164800
}

