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
public class ConfigEffectLOD : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17926
{
	// Fields
	private EntityType[] _useDistanceLODEntityTypes; // 0x10

	// Properties
	public EntityType[] useDistanceLODEntityTypes { /* [XID] */ /* 0x00000001896D5C80-0x00000001896D5CA0 */ get => default; /* [XID] */ /* 0x00000001897952A0-0x00000001897952C0 */ private set {} } // 0x0000000183243460-0x0000000183243500 0x0000000183243030-0x00000001832430E0

	// Constructors
	public ConfigEffectLOD() {} // 0x0000000183243D80-0x0000000183243DE0

	// Methods
	// [XID] // 0x000000018979D6B0-0x000000018979D6D0
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000183243AC0-0x0000000183243BA0
	// [XID] // 0x00000001897A4990-0x00000001897A49B0
	public void InitEmpty() {} // 0x0000000183243500-0x00000001832435D0
	[BlackList] // 0x00000001897ABFA0-0x00000001897ABFE0
	// [XID] // 0x00000001897ABFA0-0x00000001897ABFE0
	public bool FromJson(JSONNode node) => default; // 0x00000001832430E0-0x0000000183243460
	// [XID] // 0x00000001897B7130-0x00000001897B7150
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000183242830-0x0000000183242A10
	// [XID] // 0x00000001897BEF30-0x00000001897BEF50
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF8245 */, bool useObjectPool = false /* Metadata: 0x00AF8249 */) => default; // 0x00000001832435D0-0x00000001832438D0
	// [XID] // 0x0000000189A55320-0x0000000189A55340
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF824A */, bool useObjectPool = false /* Metadata: 0x00AF824E */) => default; // 0x0000000183242E20-0x0000000183243030
	[BlackList] // 0x00000001897CDD60-0x00000001897CDDA0
	// [XID] // 0x00000001897CDD60-0x00000001897CDDA0
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000183242A10-0x0000000183242CE0
	// [XID] // 0x00000001897D89F0-0x00000001897D8A10
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001832438D0-0x0000000183243AC0
	[BlackList] // 0x00000001897DFB70-0x00000001897DFBB0
	// [XID] // 0x00000001897DFB70-0x00000001897DFBB0
	public virtual void AutoAllocTypeFields() {} // 0x0000000183242CE0-0x0000000183242D80
	[BlackList] // 0x00000001897EA560-0x00000001897EA5A0
	// [XID] // 0x00000001897EA560-0x00000001897EA5A0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000183242D80-0x0000000183242E20
	[BlackList] // 0x00000001897F4F10-0x00000001897F4F50
	// [XID] // 0x00000001897F4F10-0x00000001897F4F50
	public virtual void ReturnToObjectPool() {} // 0x0000000183243CE0-0x0000000183243D80
	[BlackList] // 0x00000001897FF710-0x00000001897FF750
	// [XID] // 0x00000001897FF710-0x00000001897FF750
	public virtual void OnPoolAllocated() {} // 0x0000000183243C40-0x0000000183243CE0
	[BlackList] // 0x0000000189809C70-0x0000000189809CB0
	// [XID] // 0x0000000189809C70-0x0000000189809CB0
	public virtual void OnBeforePoolRecycled() {} // 0x0000000183243BA0-0x0000000183243C40
}

