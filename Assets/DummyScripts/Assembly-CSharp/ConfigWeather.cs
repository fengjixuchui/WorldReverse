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
public class ConfigWeather : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 19116
{
	// Fields
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigElemBall[] _dropElemBalls; // 0x10
	private string _shapeName; // 0x18
	private SimpleSafeFloat[] _position; // 0x20
	private SimpleSafeInt32 priorityRawNum; // 0x28
	private string _defaultEnviro; // 0x30
	private string[] _weatherList; // 0x38
	private SimpleSafeFloat[] _weatherWeightList; // 0x40
	private SimpleSafeFloat refreshTimeRawNum; // 0x48

	// Properties
	public ConfigElemBall[] dropElemBalls { /* [XID] */ /* 0x0000000189657C90-0x0000000189657CB0 */ get => default; /* [XID] */ /* 0x000000018965F3C0-0x000000018965F3E0 */ private set {} } // 0x000000018286BCA0-0x000000018286BD40 0x000000018286A660-0x000000018286A710
	public string shapeName { /* [XID] */ /* 0x0000000189666C50-0x0000000189666C70 */ get => default; /* [XID] */ /* 0x000000018966E2E0-0x000000018966E300 */ private set {} } // 0x000000018286B3C0-0x000000018286B460 0x000000018286C440-0x000000018286C4F0
	public SimpleSafeFloat[] position { /* [XID] */ /* 0x0000000189676080-0x00000001896760A0 */ get => default; /* [XID] */ /* 0x000000018967D960-0x000000018967D980 */ private set {} } // 0x000000018286BA80-0x000000018286BB20 0x000000018286B5F0-0x000000018286B6A0
	public int priority { /* [XID] */ /* 0x0000000189684F60-0x0000000189684F80 */ get => default; /* [XID] */ /* 0x000000018968CA60-0x000000018968CA80 */ private set {} } // 0x000000018286BB20-0x000000018286BBF0 0x000000018286AD70-0x000000018286AE50
	public string defaultEnviro { /* [XID] */ /* 0x00000001896945C0-0x00000001896945E0 */ get => default; /* [XID] */ /* 0x000000018969BBC0-0x000000018969BBE0 */ private set {} } // 0x000000018286B320-0x000000018286B3C0 0x000000018286B270-0x000000018286B320
	public string[] weatherList { /* [XID] */ /* 0x00000001896A31C0-0x00000001896A31E0 */ get => default; /* [XID] */ /* 0x00000001896AA650-0x00000001896AA670 */ private set {} } // 0x000000018286BD40-0x000000018286BDE0 0x000000018286BBF0-0x000000018286BCA0
	public SimpleSafeFloat[] weatherWeightList { /* [XID] */ /* 0x00000001896B1590-0x00000001896B15B0 */ get => default; /* [XID] */ /* 0x00000001896B9070-0x00000001896B9090 */ private set {} } // 0x000000018286AE50-0x000000018286AEF0 0x000000018286A4D0-0x000000018286A580
	public float refreshTime { /* [XID] */ /* 0x00000001896C03C0-0x00000001896C03E0 */ get => default; /* [XID] */ /* 0x00000001896C7B70-0x00000001896C7B90 */ private set {} } // 0x000000018286A580-0x000000018286A660 0x000000018286B9A0-0x000000018286BA80

	// Constructors
	public ConfigWeather() {} // 0x000000018286C880-0x000000018286C920

	// Methods
	// [XID] // 0x00000001896CF550-0x00000001896CF570
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x000000018286C4F0-0x000000018286C6A0
	// [XID] // 0x00000001896D6700-0x00000001896D6720
	public void InitEmpty() {} // 0x000000018286B460-0x000000018286B5F0
	[BlackList] // 0x00000001896DDD20-0x00000001896DDD60
	// [XID] // 0x00000001896DDD20-0x00000001896DDD60
	public bool FromJson(JSONNode node) => default; // 0x000000018286AEF0-0x000000018286B270
	// [XID] // 0x00000001896E8180-0x00000001896E81A0
	private bool InternalFromJson(JSONNode node) => default; // 0x00000001828697E0-0x000000018286A030
	// [XID] // 0x00000001896EF840-0x00000001896EF860
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFC27F */, bool useObjectPool = false /* Metadata: 0x00AFC283 */) => default; // 0x000000018286B6A0-0x000000018286B9A0
	// [XID] // 0x00000001896F7130-0x00000001896F7150
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFC284 */, bool useObjectPool = false /* Metadata: 0x00AFC288 */) => default; // 0x000000018286A710-0x000000018286AD70
	[BlackList] // 0x00000001896FEB10-0x00000001896FEB50
	// [XID] // 0x00000001896FEB10-0x00000001896FEB50
	public bool ToBinary(ByteArray byteArray) => default; // 0x000000018286A030-0x000000018286A300
	// [XID] // 0x0000000189708EC0-0x0000000189708EE0
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x000000018286BDE0-0x000000018286C440
	[BlackList] // 0x0000000189710770-0x00000001897107B0
	// [XID] // 0x0000000189710770-0x00000001897107B0
	public virtual void AutoAllocTypeFields() {} // 0x000000018286A300-0x000000018286A3A0
	[BlackList] // 0x000000018971AEC0-0x000000018971AF00
	// [XID] // 0x000000018971AEC0-0x000000018971AF00
	public virtual void AutoRecycleTypeFields() {} // 0x000000018286A3A0-0x000000018286A4D0
	[BlackList] // 0x0000000189725380-0x00000001897253C0
	// [XID] // 0x0000000189725380-0x00000001897253C0
	public virtual void ReturnToObjectPool() {} // 0x000000018286C7E0-0x000000018286C880
	[BlackList] // 0x000000018972FA30-0x000000018972FA70
	// [XID] // 0x000000018972FA30-0x000000018972FA70
	public virtual void OnPoolAllocated() {} // 0x000000018286C740-0x000000018286C7E0
	[BlackList] // 0x000000018973A070-0x000000018973A0B0
	// [XID] // 0x000000018973A070-0x000000018973A0B0
	public virtual void OnBeforePoolRecycled() {} // 0x000000018286C6A0-0x000000018286C740
}

