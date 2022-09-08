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
public class AudioImpactOverrideEvent : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17564
{
	// Fields
	private SimpleSafeUInt32 entityIdRawNum; // 0x10
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private AudioOneTimeEvent _impactEvent; // 0x18

	// Properties
	public uint entityId { /* [XID] */ /* 0x00000001897953C0-0x00000001897953E0 */ get => default; /* [XID] */ /* 0x000000018979D770-0x000000018979D790 */ private set {} } // 0x000000018252E120-0x000000018252E1F0 0x000000018252E040-0x000000018252E120
	public AudioOneTimeEvent impactEvent { /* [XID] */ /* 0x00000001897A4A30-0x00000001897A4A50 */ get => default; /* [XID] */ /* 0x00000001897AC080-0x00000001897AC0A0 */ private set {} } // 0x000000018252D4C0-0x000000018252D560 0x000000018252E970-0x000000018252EA20

	// Constructors
	public AudioImpactOverrideEvent() {} // 0x000000018252EFB0-0x000000018252F010

	// Methods
	// [XID] // 0x00000001897B3F70-0x00000001897B3F90
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x000000018252ECB0-0x000000018252EDD0
	// [XID] // 0x00000001897BBC90-0x00000001897BBCB0
	public void InitEmpty() {} // 0x000000018252E570-0x000000018252E670
	[BlackList] // 0x00000001897C34D0-0x00000001897C3510
	// [XID] // 0x00000001897C34D0-0x00000001897C3510
	public bool FromJson(JSONNode node) => default; // 0x000000018252E1F0-0x000000018252E570
	// [XID] // 0x00000001897CDE60-0x00000001897CDE80
	private bool InternalFromJson(JSONNode node) => default; // 0x000000018252D560-0x000000018252D880
	// [XID] // 0x00000001897D5370-0x00000001897D5390
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7311 */, bool useObjectPool = false /* Metadata: 0x00AF7315 */) => default; // 0x000000018252E670-0x000000018252E970
	// [XID] // 0x00000001897DCAB0-0x00000001897DCAD0
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7316 */, bool useObjectPool = false /* Metadata: 0x00AF731A */) => default; // 0x000000018252DD50-0x000000018252E040
	[BlackList] // 0x00000001897E44F0-0x00000001897E4530
	// [XID] // 0x00000001897E44F0-0x00000001897E4530
	public bool ToBinary(ByteArray byteArray) => default; // 0x000000018252D880-0x000000018252DB50
	// [XID] // 0x00000001897EEF70-0x00000001897EEF90
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x000000018252EA20-0x000000018252ECB0
	[BlackList] // 0x00000001897F65E0-0x00000001897F6620
	// [XID] // 0x00000001897F65E0-0x00000001897F6620
	public virtual void AutoAllocTypeFields() {} // 0x000000018252DB50-0x000000018252DBF0
	[BlackList] // 0x0000000189800E20-0x0000000189800E60
	// [XID] // 0x0000000189800E20-0x0000000189800E60
	public virtual void AutoRecycleTypeFields() {} // 0x000000018252DBF0-0x000000018252DD50
	[BlackList] // 0x000000018980B3A0-0x000000018980B3E0
	// [XID] // 0x000000018980B3A0-0x000000018980B3E0
	public virtual void ReturnToObjectPool() {} // 0x000000018252EF10-0x000000018252EFB0
	[BlackList] // 0x0000000189815CF0-0x0000000189815D30
	// [XID] // 0x0000000189815CF0-0x0000000189815D30
	public virtual void OnPoolAllocated() {} // 0x000000018252EE70-0x000000018252EF10
	[BlackList] // 0x00000001898207F0-0x0000000189820830
	// [XID] // 0x00000001898207F0-0x0000000189820830
	public virtual void OnBeforePoolRecycled() {} // 0x000000018252EDD0-0x000000018252EE70
}

