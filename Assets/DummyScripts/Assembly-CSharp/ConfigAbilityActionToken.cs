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
public class ConfigAbilityActionToken : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 16319
{
	// Fields
	private SimpleSafeInt32 cancelWithEntityTickLodRawNum; // 0x10
	private SimpleSafeInt32 channelIdRawNum; // 0x14
	private SimpleSafeInt32 weightRawNum; // 0x18
	private SimpleSafeInt32 tokenCostTypeRawNum; // 0x1C
	private ActionTokenType _tokenType; // 0x20

	// Properties
	public int cancelWithEntityTickLod { /* [XID] */ /* 0x0000000189A037D0-0x0000000189A037F0 */ get => default; /* [XID] */ /* 0x0000000189B3EAC0-0x0000000189B3EAE0 */ private set {} } // 0x00000001816B00E0-0x00000001816B01B0 0x00000001816B0580-0x00000001816B0660
	public int channelId { /* [XID] */ /* 0x00000001896E04D0-0x00000001896E04F0 */ get => default; /* [XID] */ /* 0x0000000189B4DAC0-0x0000000189B4DAE0 */ private set {} } // 0x00000001816AFAB0-0x00000001816AFB80 0x00000001816B0FB0-0x00000001816B1090
	public int weight { /* [XID] */ /* 0x0000000189BBA540-0x0000000189BBA560 */ get => default; /* [XID] */ /* 0x0000000189B5CD10-0x0000000189B5CD30 */ private set {} } // 0x00000001816B1090-0x00000001816B1160 0x00000001816AFF00-0x00000001816AFFE0
	public int tokenCostType { /* [XID] */ /* 0x0000000189B643D0-0x0000000189B643F0 */ get => default; /* [XID] */ /* 0x0000000189B6B950-0x0000000189B6B970 */ private set {} } // 0x00000001816B04B0-0x00000001816B0580 0x00000001816B0ED0-0x00000001816B0FB0
	public ActionTokenType tokenType { /* [XID] */ /* 0x0000000189B730B0-0x0000000189B730D0 */ get => default; /* [XID] */ /* 0x0000000189B7A690-0x0000000189B7A6B0 */ private set {} } // 0x00000001816B0BA0-0x00000001816B0C40 0x00000001816B0AF0-0x00000001816B0BA0

	// Constructors
	public ConfigAbilityActionToken() {} // 0x00000001816B1200-0x00000001816B12D0

	// Methods
	// [XID] // 0x0000000189B81EB0-0x0000000189B81ED0
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001816B0C40-0x00000001816B0D90
	// [XID] // 0x0000000189B895F0-0x0000000189B89610
	public void InitEmpty() {} // 0x00000001816AFFE0-0x00000001816B00E0
	[BlackList] // 0x0000000189B90BD0-0x0000000189B90C10
	// [XID] // 0x0000000189B90BD0-0x0000000189B90C10
	public bool FromJson(JSONNode node) => default; // 0x00000001816AFB80-0x00000001816AFF00
	// [XID] // 0x0000000189B9AF00-0x0000000189B9AF20
	private bool InternalFromJson(JSONNode node) => default; // 0x00000001816AECD0-0x00000001816AF270
	// [XID] // 0x0000000189BA2750-0x0000000189BA2770
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF378C */, bool useObjectPool = false /* Metadata: 0x00AF3790 */) => default; // 0x00000001816B01B0-0x00000001816B04B0
	// [XID] // 0x0000000189BC7EF0-0x0000000189BC7F10
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3791 */, bool useObjectPool = false /* Metadata: 0x00AF3795 */) => default; // 0x00000001816AF6E0-0x00000001816AFAB0
	[BlackList] // 0x0000000189BB1430-0x0000000189BB1470
	// [XID] // 0x0000000189BB1430-0x0000000189BB1470
	public bool ToBinary(ByteArray byteArray) => default; // 0x00000001816AF270-0x00000001816AF540
	// [XID] // 0x0000000189BBB5F0-0x0000000189BBB610
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001816B0660-0x00000001816B0AF0
	[BlackList] // 0x0000000189BC3410-0x0000000189BC3450
	// [XID] // 0x0000000189BC3410-0x0000000189BC3450
	public virtual void AutoAllocTypeFields() {} // 0x00000001816AF540-0x00000001816AF5E0
	[BlackList] // 0x0000000189BCDC40-0x0000000189BCDC80
	// [XID] // 0x0000000189BCDC40-0x0000000189BCDC80
	public virtual void AutoRecycleTypeFields() {} // 0x00000001816AF5E0-0x00000001816AF6E0
	[BlackList] // 0x0000000189BD7FD0-0x0000000189BD8010
	// [XID] // 0x0000000189BD7FD0-0x0000000189BD8010
	public virtual void ReturnToObjectPool() {} // 0x00000001816B1160-0x00000001816B1200
	[BlackList] // 0x00000001895E7C90-0x00000001895E7CD0
	// [XID] // 0x00000001895E7C90-0x00000001895E7CD0
	public virtual void OnPoolAllocated() {} // 0x00000001816B0E30-0x00000001816B0ED0
	[BlackList] // 0x00000001895F2310-0x00000001895F2350
	// [XID] // 0x00000001895F2310-0x00000001895F2350
	public virtual void OnBeforePoolRecycled() {} // 0x00000001816B0D90-0x00000001816B0E30
}

