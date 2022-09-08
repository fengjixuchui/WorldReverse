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
public class ConfigAudioGeneral : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17587
{
	// Fields
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigWwiseString _pauseGameObjectEvent; // 0x10
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigWwiseString _resumeGameObjectEvent; // 0x18
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigWwiseString _pauseBusEvent; // 0x20
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigWwiseString _resumeBusEvent; // 0x28
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigWwiseString _stopAllEvent; // 0x30

	// Properties
	public ConfigWwiseString pauseGameObjectEvent { /* [XID] */ /* 0x000000018990CE30-0x000000018990CE50 */ get => default; /* [XID] */ /* 0x0000000189914620-0x0000000189914640 */ private set {} } // 0x0000000181B4BE00-0x0000000181B4BEA0 0x0000000181B4CA20-0x0000000181B4CAD0
	public ConfigWwiseString resumeGameObjectEvent { /* [XID] */ /* 0x00000001897E4FF0-0x00000001897E5010 */ get => default; /* [XID] */ /* 0x00000001899238A0-0x00000001899238C0 */ private set {} } // 0x0000000181B4D7B0-0x0000000181B4D850 0x0000000181B4C850-0x0000000181B4C900
	public ConfigWwiseString pauseBusEvent { /* [XID] */ /* 0x00000001898374F0-0x0000000189837510 */ get => default; /* [XID] */ /* 0x00000001899325A0-0x00000001899325C0 */ private set {} } // 0x0000000181B4CDD0-0x0000000181B4CE70 0x0000000181B4D380-0x0000000181B4D430
	public ConfigWwiseString resumeBusEvent { /* [XID] */ /* 0x0000000189939FB0-0x0000000189939FD0 */ get => default; /* [XID] */ /* 0x00000001899411A0-0x00000001899411C0 */ private set {} } // 0x0000000181B4CE70-0x0000000181B4CF10 0x0000000181B4D430-0x0000000181B4D4E0
	public ConfigWwiseString stopAllEvent { /* [XID] */ /* 0x0000000189A8B950-0x0000000189A8B970 */ get => default; /* [XID] */ /* 0x0000000189950450-0x0000000189950470 */ private set {} } // 0x0000000181B4C430-0x0000000181B4C4D0 0x0000000181B4BD50-0x0000000181B4BE00

	// Constructors
	public ConfigAudioGeneral() {} // 0x0000000181B4D8F0-0x0000000181B4D950

	// Methods
	// [XID] // 0x00000001899579E0-0x0000000189957A00
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000181B4D4E0-0x0000000181B4D670
	// [XID] // 0x000000018995F230-0x000000018995F250
	public void InitEmpty() {} // 0x0000000181B4C900-0x0000000181B4CA20
	[BlackList] // 0x0000000189966B30-0x0000000189966B70
	// [XID] // 0x0000000189966B30-0x0000000189966B70
	public bool FromJson(JSONNode node) => default; // 0x0000000181B4C4D0-0x0000000181B4C850
	// [XID] // 0x0000000189971700-0x0000000189971720
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000181B4B130-0x0000000181B4B700
	// [XID] // 0x0000000189979050-0x0000000189979070
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF73D9 */, bool useObjectPool = false /* Metadata: 0x00AF73DD */) => default; // 0x0000000181B4CAD0-0x0000000181B4CDD0
	// [XID] // 0x0000000189980140-0x0000000189980160
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF73DE */, bool useObjectPool = false /* Metadata: 0x00AF73E2 */) => default; // 0x0000000181B4BEA0-0x0000000181B4C430
	[BlackList] // 0x00000001899878D0-0x0000000189987910
	// [XID] // 0x00000001899878D0-0x0000000189987910
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000181B4B700-0x0000000181B4B9D0
	// [XID] // 0x0000000189992630-0x0000000189992650
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000181B4CF10-0x0000000181B4D380
	[BlackList] // 0x000000018999A390-0x000000018999A3D0
	// [XID] // 0x000000018999A390-0x000000018999A3D0
	public virtual void AutoAllocTypeFields() {} // 0x0000000181B4B9D0-0x0000000181B4BA70
	[BlackList] // 0x00000001899A4B10-0x00000001899A4B50
	// [XID] // 0x00000001899A4B10-0x00000001899A4B50
	public virtual void AutoRecycleTypeFields() {} // 0x0000000181B4BA70-0x0000000181B4BD50
	[BlackList] // 0x00000001899AF470-0x00000001899AF4B0
	// [XID] // 0x00000001899AF470-0x00000001899AF4B0
	public virtual void ReturnToObjectPool() {} // 0x0000000181B4D850-0x0000000181B4D8F0
	[BlackList] // 0x00000001899B9870-0x00000001899B98B0
	// [XID] // 0x00000001899B9870-0x00000001899B98B0
	public virtual void OnPoolAllocated() {} // 0x0000000181B4D710-0x0000000181B4D7B0
	[BlackList] // 0x00000001899C4440-0x00000001899C4480
	// [XID] // 0x00000001899C4440-0x00000001899C4480
	public virtual void OnBeforePoolRecycled() {} // 0x0000000181B4D670-0x0000000181B4D710
}

