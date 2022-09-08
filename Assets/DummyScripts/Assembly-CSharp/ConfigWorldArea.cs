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
using UnityEngine;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[RecycleType] // 0x00000001898C45A0-0x00000001898C45C0
public class ConfigWorldArea : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 14971
{
	// Fields
	private SimpleSafeUInt32 id1RawNum; // 0x10
	private SimpleSafeUInt32 id2RawNum; // 0x14
	private SimpleSafeUInt32 greyLevelRawNum; // 0x18
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigPolygonArea _polygonData; // 0x20

	// Properties
	public uint id1 { /* [XID] */ /* 0x00000001898777F0-0x0000000189877810 */ get => default; /* [XID] */ /* 0x000000018987F0E0-0x000000018987F100 */ private set {} } // 0x0000000181211A90-0x0000000181211B60 0x00000001812112D0-0x00000001812113B0
	public uint id2 { /* [XID] */ /* 0x00000001898866A0-0x00000001898866C0 */ get => default; /* [XID] */ /* 0x000000018988D8C0-0x000000018988D8E0 */ private set {} } // 0x0000000181211490-0x0000000181211560 0x00000001812113B0-0x0000000181211490
	public uint greyLevel { /* [XID] */ /* 0x0000000189894F70-0x0000000189894F90 */ get => default; /* [XID] */ /* 0x000000018989C620-0x000000018989C640 */ private set {} } // 0x0000000181210CF0-0x0000000181210DC0 0x0000000181210E70-0x0000000181210F50
	public ConfigPolygonArea polygonData { /* [XID] */ /* 0x00000001898A3D80-0x00000001898A3DA0 */ get => default; /* [XID] */ /* 0x00000001898AB000-0x00000001898AB020 */ private set {} } // 0x0000000181210820-0x00000001812108C0 0x0000000181210DC0-0x0000000181210E70

	// Constructors
	public ConfigWorldArea() {} // 0x0000000181212290-0x00000001812122F0

	// Methods
	// [XID] // 0x0000000189870180-0x00000001898701A0
	public bool IsInArea(Vector3 worldPosition, bool isLevel2Area) => default; // 0x0000000181211980-0x0000000181211A90
	// [XID] // 0x00000001898B2910-0x00000001898B2930
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000181211F60-0x00000001812120B0
	// [XID] // 0x00000001898BA780-0x00000001898BA7A0
	public void InitEmpty() {} // 0x0000000181211560-0x0000000181211680
	[BlackList] // 0x00000001898C18E0-0x00000001898C1920
	// [XID] // 0x00000001898C18E0-0x00000001898C1920
	public bool FromJson(JSONNode node) => default; // 0x0000000181210F50-0x00000001812112D0
	// [XID] // 0x00000001898CC050-0x00000001898CC070
	private bool InternalFromJson(JSONNode node) => default; // 0x000000018120FE00-0x0000000181210330
	// [XID] // 0x00000001898D38F0-0x00000001898D3910
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEFCC4 */, bool useObjectPool = false /* Metadata: 0x00AEFCC8 */) => default; // 0x0000000181211680-0x0000000181211980
	// [XID] // 0x00000001898DB100-0x00000001898DB120
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEFCC9 */, bool useObjectPool = false /* Metadata: 0x00AEFCCD */) => default; // 0x00000001812108C0-0x0000000181210CF0
	[BlackList] // 0x00000001898E2E60-0x00000001898E2EA0
	// [XID] // 0x00000001898E2E60-0x00000001898E2EA0
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000181210330-0x0000000181210600
	// [XID] // 0x00000001898ED980-0x00000001898ED9A0
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000181211B60-0x0000000181211F60
	[BlackList] // 0x00000001898F5280-0x00000001898F52C0
	// [XID] // 0x00000001898F5280-0x00000001898F52C0
	public virtual void AutoAllocTypeFields() {} // 0x0000000181210600-0x00000001812106A0
	[BlackList] // 0x00000001898FFAF0-0x00000001898FFB30
	// [XID] // 0x00000001898FFAF0-0x00000001898FFB30
	public virtual void AutoRecycleTypeFields() {} // 0x00000001812106A0-0x0000000181210820
	[BlackList] // 0x000000018990A140-0x000000018990A180
	// [XID] // 0x000000018990A140-0x000000018990A180
	public virtual void ReturnToObjectPool() {} // 0x00000001812121F0-0x0000000181212290
	[BlackList] // 0x0000000189914AC0-0x0000000189914B00
	// [XID] // 0x0000000189914AC0-0x0000000189914B00
	public virtual void OnPoolAllocated() {} // 0x0000000181212150-0x00000001812121F0
	[BlackList] // 0x000000018991F2A0-0x000000018991F2E0
	// [XID] // 0x000000018991F2A0-0x000000018991F2E0
	public virtual void OnBeforePoolRecycled() {} // 0x00000001812120B0-0x0000000181212150
}

