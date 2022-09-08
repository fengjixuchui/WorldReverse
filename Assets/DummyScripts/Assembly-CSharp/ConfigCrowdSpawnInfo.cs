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
using MoleMole.Config;
using SimpleJSON;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[RecycleType] // 0x00000001898C45A0-0x00000001898C45C0
public class ConfigCrowdSpawnInfo : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17773
{
	// Fields
	private SimpleSafeInt32 crowdTypeIDRawNum; // 0x10
	private SimpleSafeInt32 animConfigIDRawNum; // 0x14
	private MoleMole.Config.Vector _spawnPosition; // 0x18
	private MoleMole.Config.Vector _spawnFaceFwd; // 0x24
	private bool _hasCollider; // 0x30
	private bool _sitOnChair; // 0x31
	private ColorVector _hairColor; // 0x34
	private ColorVector[] _bodyColors; // 0x48

	// Properties
	public int crowdTypeID { /* [XID] */ /* 0x0000000189B86600-0x0000000189B86620 */ get => default; /* [XID] */ /* 0x0000000189B8D710-0x0000000189B8D730 */ private set {} } // 0x00000001848A4090-0x00000001848A4160 0x00000001848A3140-0x00000001848A3220
	public int animConfigID { /* [XID] */ /* 0x0000000189B94D10-0x0000000189B94D30 */ get => default; /* [XID] */ /* 0x0000000189B9C440-0x0000000189B9C460 */ private set {} } // 0x00000001848A2BD0-0x00000001848A2CA0 0x00000001848A28C0-0x00000001848A29A0
	public MoleMole.Config.Vector spawnPosition { /* [XID] */ /* 0x0000000189BA3A50-0x0000000189BA3A70 */ get => default; /* [XID] */ /* 0x0000000189BAAF00-0x0000000189BAAF20 */ private set {} } // 0x00000001848A2AF0-0x00000001848A2BD0 0x00000001848A3370-0x00000001848A3440
	public MoleMole.Config.Vector spawnFaceFwd { /* [XID] */ /* 0x0000000189BB2510-0x0000000189BB2530 */ get => default; /* [XID] */ /* 0x0000000189BB9960-0x0000000189BB9980 */ private set {} } // 0x00000001848A2FA0-0x00000001848A3080 0x00000001848A3BC0-0x00000001848A3C90
	public bool hasCollider { /* [XID] */ /* 0x0000000189BC1840-0x0000000189BC1860 */ get => default; /* [XID] */ /* 0x0000000189BC8EC0-0x0000000189BC8EE0 */ private set {} } // 0x00000001848A1DE0-0x00000001848A1E80 0x00000001848A32C0-0x00000001848A3370
	public bool sitOnChair { /* [XID] */ /* 0x0000000189BD0730-0x0000000189BD0750 */ get => default; /* [XID] */ /* 0x0000000189BD7CD0-0x0000000189BD7CF0 */ private set {} } // 0x00000001848A4160-0x00000001848A4200 0x00000001848A2490-0x00000001848A2540
	public ColorVector hairColor { /* [XID] */ /* 0x0000000189BDF8C0-0x0000000189BDF8E0 */ get => default; /* [XID] */ /* 0x00000001895EC410-0x00000001895EC430 */ private set {} } // 0x00000001848A3440-0x00000001848A3510 0x00000001848A3080-0x00000001848A3140
	public ColorVector[] bodyColors { /* [XID] */ /* 0x00000001895F3870-0x00000001895F3890 */ get => default; /* [XID] */ /* 0x00000001895FB190-0x00000001895FB1B0 */ private set {} } // 0x00000001848A3220-0x00000001848A32C0 0x00000001848A3C90-0x00000001848A3D40

	// Constructors
	public ConfigCrowdSpawnInfo() {} // 0x00000001848A42A0-0x00000001848A4300

	// Methods
	// [XID] // 0x00000001896028F0-0x0000000189602910
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001848A3D40-0x00000001848A3F50
	// [XID] // 0x000000018960A290-0x000000018960A2B0
	public void InitEmpty() {} // 0x00000001848A29A0-0x00000001848A2AF0
	[BlackList] // 0x0000000189611A00-0x0000000189611A40
	// [XID] // 0x0000000189611A00-0x0000000189611A40
	public bool FromJson(JSONNode node) => default; // 0x00000001848A2540-0x00000001848A28C0
	// [XID] // 0x000000018961C1E0-0x000000018961C200
	private bool InternalFromJson(JSONNode node) => default; // 0x00000001848A1160-0x00000001848A1940
	// [XID] // 0x0000000189623620-0x0000000189623640
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7BAF */, bool useObjectPool = false /* Metadata: 0x00AF7BB3 */) => default; // 0x00000001848A2CA0-0x00000001848A2FA0
	// [XID] // 0x000000018962AF60-0x000000018962AF80
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7BB4 */, bool useObjectPool = false /* Metadata: 0x00AF7BB8 */) => default; // 0x00000001848A1E80-0x00000001848A2490
	[BlackList] // 0x00000001896326A0-0x00000001896326E0
	// [XID] // 0x00000001896326A0-0x00000001896326E0
	public bool ToBinary(ByteArray byteArray) => default; // 0x00000001848A1940-0x00000001848A1C10
	// [XID] // 0x000000018963D250-0x000000018963D270
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001848A3510-0x00000001848A3BC0
	[BlackList] // 0x0000000189644770-0x00000001896447B0
	// [XID] // 0x0000000189644770-0x00000001896447B0
	public virtual void AutoAllocTypeFields() {} // 0x00000001848A1C10-0x00000001848A1CB0
	[BlackList] // 0x000000018964ED80-0x000000018964EDC0
	// [XID] // 0x000000018964ED80-0x000000018964EDC0
	public virtual void AutoRecycleTypeFields() {} // 0x00000001848A1CB0-0x00000001848A1DE0
	[BlackList] // 0x0000000189659670-0x00000001896596B0
	// [XID] // 0x0000000189659670-0x00000001896596B0
	public virtual void ReturnToObjectPool() {} // 0x00000001848A4200-0x00000001848A42A0
	[BlackList] // 0x0000000189663D40-0x0000000189663D80
	// [XID] // 0x0000000189663D40-0x0000000189663D80
	public virtual void OnPoolAllocated() {} // 0x00000001848A3FF0-0x00000001848A4090
	[BlackList] // 0x000000018966E680-0x000000018966E6C0
	// [XID] // 0x000000018966E680-0x000000018966E6C0
	public virtual void OnBeforePoolRecycled() {} // 0x00000001848A3F50-0x00000001848A3FF0
}

