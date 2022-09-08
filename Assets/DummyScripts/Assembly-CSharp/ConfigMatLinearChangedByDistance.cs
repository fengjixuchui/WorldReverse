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
public class ConfigMatLinearChangedByDistance : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17951
{
	// Fields
	private string _transformName; // 0x10
	private string[] _textureProperty; // 0x18
	private string[] _floatProperty; // 0x20
	private SimpleSafeFloat minRatioRawNum; // 0x28
	private SimpleSafeFloat maxRatioRawNum; // 0x2C
	private SimpleSafeFloat minDistanceRawNum; // 0x30
	private SimpleSafeFloat maxDistanceRawNum; // 0x34

	// Properties
	public string transformName { /* [XID] */ /* 0x0000000189B81B70-0x0000000189B81B90 */ get => default; /* [XID] */ /* 0x0000000189B89250-0x0000000189B89270 */ private set {} } // 0x0000000183302C30-0x0000000183302CD0 0x0000000183302A00-0x0000000183302AB0
	public string[] textureProperty { /* [XID] */ /* 0x0000000189B907F0-0x0000000189B90810 */ get => default; /* [XID] */ /* 0x0000000189B97CA0-0x0000000189B97CC0 */ private set {} } // 0x0000000183303E50-0x0000000183303EF0 0x0000000183303DA0-0x0000000183303E50
	public string[] floatProperty { /* [XID] */ /* 0x0000000189B9F030-0x0000000189B9F050 */ get => default; /* [XID] */ /* 0x0000000189BA6920-0x0000000189BA6940 */ private set {} } // 0x0000000183302B90-0x0000000183302C30 0x00000001833036D0-0x0000000183303780
	public float minRatio { /* [XID] */ /* 0x0000000189BADB00-0x0000000189BADB20 */ get => default; /* [XID] */ /* 0x0000000189BB52B0-0x0000000189BB52D0 */ private set {} } // 0x00000001833038E0-0x00000001833039C0 0x00000001833023B0-0x0000000183302490
	public float maxRatio { /* [XID] */ /* 0x0000000189BBCA50-0x0000000189BBCA70 */ get => default; /* [XID] */ /* 0x0000000189BC46E0-0x0000000189BC4700 */ private set {} } // 0x0000000183302AB0-0x0000000183302B90 0x0000000183302920-0x0000000183302A00
	public float minDistance { /* [XID] */ /* 0x0000000189BCC060-0x0000000189BCC080 */ get => default; /* [XID] */ /* 0x0000000189BD35F0-0x0000000189BD3610 */ private set {} } // 0x0000000183303CC0-0x0000000183303DA0 0x0000000183301AE0-0x0000000183301BC0
	public float maxDistance { /* [XID] */ /* 0x0000000189BDAF00-0x0000000189BDAF20 */ get => default; /* [XID] */ /* 0x00000001895E78D0-0x00000001895E78F0 */ private set {} } // 0x0000000183304710-0x00000001833047F0 0x0000000183303270-0x0000000183303350

	// Constructors
	public ConfigMatLinearChangedByDistance() {} // 0x0000000183304890-0x0000000183304940

	// Methods
	// [XID] // 0x00000001895EF200-0x00000001895EF220
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000183304440-0x00000001833045D0
	// [XID] // 0x00000001895F6C60-0x00000001895F6C80
	public void InitEmpty() {} // 0x0000000183303780-0x00000001833038E0
	[BlackList] // 0x00000001895FE020-0x00000001895FE060
	// [XID] // 0x00000001895FE020-0x00000001895FE060
	public bool FromJson(JSONNode node) => default; // 0x0000000183303350-0x00000001833036D0
	// [XID] // 0x0000000189608B30-0x0000000189608B50
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000183301BC0-0x00000001833023B0
	// [XID] // 0x0000000189610310-0x0000000189610330
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF848D */, bool useObjectPool = false /* Metadata: 0x00AF8491 */) => default; // 0x00000001833039C0-0x0000000183303CC0
	// [XID] // 0x0000000189617570-0x0000000189617590
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF8492 */, bool useObjectPool = false /* Metadata: 0x00AF8496 */) => default; // 0x0000000183302CD0-0x0000000183303270
	[BlackList] // 0x000000018961F160-0x000000018961F1A0
	// [XID] // 0x000000018961F160-0x000000018961F1A0
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000183302490-0x0000000183302760
	// [XID] // 0x0000000189629850-0x0000000189629870
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000183303EF0-0x0000000183304440
	[BlackList] // 0x0000000189631120-0x0000000189631160
	// [XID] // 0x0000000189631120-0x0000000189631160
	public virtual void AutoAllocTypeFields() {} // 0x0000000183302760-0x0000000183302800
	[BlackList] // 0x000000018963B8A0-0x000000018963B8E0
	// [XID] // 0x000000018963B8A0-0x000000018963B8E0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000183302800-0x0000000183302920
	[BlackList] // 0x0000000189645EC0-0x0000000189645F00
	// [XID] // 0x0000000189645EC0-0x0000000189645F00
	public virtual void ReturnToObjectPool() {} // 0x00000001833047F0-0x0000000183304890
	[BlackList] // 0x0000000189650690-0x00000001896506D0
	// [XID] // 0x0000000189650690-0x00000001896506D0
	public virtual void OnPoolAllocated() {} // 0x0000000183304670-0x0000000183304710
	[BlackList] // 0x000000018965AF50-0x000000018965AF90
	// [XID] // 0x000000018965AF50-0x000000018965AF90
	public virtual void OnBeforePoolRecycled() {} // 0x00000001833045D0-0x0000000183304670
}

