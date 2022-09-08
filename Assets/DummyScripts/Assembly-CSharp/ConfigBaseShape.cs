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
public class ConfigBaseShape : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 18982
{
	// Fields
	private bool _useHeight; // 0x10
	private SimpleSafeFloat heightRawNum; // 0x14
	private HeightPosType _heightType; // 0x18

	// Properties
	public bool useHeight { /* [XID] */ /* 0x00000001896BD600-0x00000001896BD620 */ get => default; /* [XID] */ /* 0x00000001896C4C50-0x00000001896C4C70 */ private set {} } // 0x000000018383ABE0-0x000000018383AC80 0x000000018383AB30-0x000000018383ABE0
	public float height { /* [XID] */ /* 0x00000001896CC030-0x00000001896CC050 */ get => default; /* [XID] */ /* 0x00000001896D3360-0x00000001896D3380 */ private set {} } // 0x000000018383A7F0-0x000000018383A8D0 0x000000018383A390-0x000000018383A470
	public HeightPosType heightType { /* [XID] */ /* 0x00000001896DAEE0-0x00000001896DAF00 */ get => default; /* [XID] */ /* 0x00000001896E2780-0x00000001896E27A0 */ private set {} } // 0x0000000183839B50-0x0000000183839BF0 0x0000000183839430-0x00000001838394E0

	// Constructors
	public ConfigBaseShape() {} // 0x000000018383AD20-0x000000018383AD90

	// Methods
	// [XID] // 0x00000001896E9CA0-0x00000001896E9CC0
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x000000018383A8D0-0x000000018383A9F0
	// [XID] // 0x00000001896F0E20-0x00000001896F0E40
	public virtual void ForeachRefTypeMember(Action<object> callback) {} // 0x000000018383A470-0x000000018383A520
	// [XID] // 0x00000001896F86A0-0x00000001896F86C0
	public virtual ConfigBaseShape Clone(bool useObjectPool = false /* Metadata: 0x00AFB63F */) => default; // 0x000000018383A0B0-0x000000018383A190
	// [XID] // 0x0000000189700000-0x0000000189700020
	public virtual int GetHashNum() => default; // 0x0000000183839060-0x0000000183839130
	// [XID] // 0x00000001897076D0-0x00000001897076F0
	public virtual void InitEmpty() {} // 0x0000000183839BF0-0x0000000183839CC0
	[BlackList] // 0x000000018970F0E0-0x000000018970F120
	// [XID] // 0x000000018970F0E0-0x000000018970F120
	public virtual bool FromJson(JSONNode node) => default; // 0x00000001838394E0-0x0000000183839860
	// [XID] // 0x0000000189719790-0x00000001897197B0
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000183838840-0x0000000183838C10
	[BlackList] // 0x0000000189720CB0-0x0000000189720CF0
	// [XID] // 0x0000000189720CB0-0x0000000189720CF0
	public static ConfigBaseShape ParseFromJson(JSONNode node) => default; // 0x000000018383A190-0x000000018383A390
	// [XID] // 0x000000018972B130-0x000000018972B150
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB640 */, bool useObjectPool = false /* Metadata: 0x00AFB644 */) => default; // 0x0000000183839DB0-0x000000018383A0B0
	// [XID] // 0x0000000189732900-0x0000000189732920
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB645 */, bool useObjectPool = false /* Metadata: 0x00AFB649 */) => default; // 0x0000000183839130-0x0000000183839430
	// [XID] // 0x000000018973A0F0-0x000000018973A110
	public static ConfigBaseShape ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB64A */, bool useObjectPool = false /* Metadata: 0x00AFB64E */) => default; // 0x0000000183839860-0x0000000183839A30
	[BlackList] // 0x0000000189741C00-0x0000000189741C40
	// [XID] // 0x0000000189741C00-0x0000000189741C40
	public virtual bool ToBinary(ByteArray byteArray) => default; // 0x0000000183838C10-0x0000000183838EE0
	// [XID] // 0x000000018974C600-0x000000018974C620
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x000000018383A520-0x000000018383A7F0
	[BlackList] // 0x0000000189753880-0x00000001897538C0
	// [XID] // 0x0000000189753880-0x00000001897538C0
	public virtual bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000183839CC0-0x0000000183839DB0
	[BlackList] // 0x000000018975DDF0-0x000000018975DE30
	// [XID] // 0x000000018975DDF0-0x000000018975DE30
	public virtual void AutoAllocTypeFields() {} // 0x0000000183838EE0-0x0000000183838F80
	[BlackList] // 0x00000001897685C0-0x0000000189768600
	// [XID] // 0x00000001897685C0-0x0000000189768600
	public virtual void AutoRecycleTypeFields() {} // 0x0000000183838F80-0x0000000183839060
	[BlackList] // 0x0000000189772C20-0x0000000189772C60
	// [XID] // 0x0000000189772C20-0x0000000189772C60
	public virtual void ReturnToObjectPool() {} // 0x000000018383AC80-0x000000018383AD20
	[BlackList] // 0x000000018977D400-0x000000018977D440
	// [XID] // 0x000000018977D400-0x000000018977D440
	public virtual void OnPoolAllocated() {} // 0x000000018383AA90-0x000000018383AB30
	[BlackList] // 0x0000000189787B60-0x0000000189787BA0
	// [XID] // 0x0000000189787B60-0x0000000189787BA0
	public virtual void OnBeforePoolRecycled() {} // 0x000000018383A9F0-0x000000018383AA90
	// [XID] // 0x00000001897A9B10-0x00000001897A9B30
	public virtual BaseShape CreateShape(Vector3 position, Vector3 direction, bool useHeight, float height, float sizeRatio) => default; // 0x0000000183839A30-0x0000000183839B50
}

