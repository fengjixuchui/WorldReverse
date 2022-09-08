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
public class ConfigCustomAttackBox : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17944
{
	// Fields
	private SimpleSafeFloat customAttackBox_Size_XRawNum; // 0x10
	private SimpleSafeFloat customAttackBox_Size_YRawNum; // 0x14
	private SimpleSafeFloat customAttackBox_Size_ZRawNum; // 0x18

	// Properties
	public float customAttackBox_Size_X { /* [XID] */ /* 0x0000000189B379A0-0x0000000189B379C0 */ get => default; /* [XID] */ /* 0x00000001896E6D20-0x00000001896E6D40 */ private set {} } // 0x000000018276A920-0x000000018276AA00 0x00000001827691F0-0x00000001827692D0
	public float customAttackBox_Size_Y { /* [XID] */ /* 0x00000001896EE230-0x00000001896EE250 */ get => default; /* [XID] */ /* 0x00000001896F5B60-0x00000001896F5B80 */ private set {} } // 0x0000000182769B50-0x0000000182769C30 0x000000018276A360-0x000000018276A440
	public float customAttackBox_Size_Z { /* [XID] */ /* 0x00000001896FD390-0x00000001896FD3B0 */ get => default; /* [XID] */ /* 0x0000000189704830-0x0000000189704850 */ private set {} } // 0x000000018276A280-0x000000018276A360 0x000000018276A840-0x000000018276A920

	// Constructors
	public ConfigCustomAttackBox() {} // 0x000000018276AFD0-0x000000018276B090

	// Methods
	// [XID] // 0x000000018970C010-0x000000018970C030
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x000000018276ACD0-0x000000018276ADF0
	// [XID] // 0x0000000189713940-0x0000000189713960
	public void InitEmpty() {} // 0x000000018276A440-0x000000018276A540
	[BlackList] // 0x000000018971B200-0x000000018971B240
	// [XID] // 0x000000018971B200-0x000000018971B240
	public bool FromJson(JSONNode node) => default; // 0x0000000182769F00-0x000000018276A280
	// [XID] // 0x0000000189725560-0x0000000189725580
	private bool InternalFromJson(JSONNode node) => default; // 0x00000001827692D0-0x00000001827696E0
	// [XID] // 0x000000018972CB60-0x000000018972CB80
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF8445 */, bool useObjectPool = false /* Metadata: 0x00AF8449 */) => default; // 0x000000018276A540-0x000000018276A840
	// [XID] // 0x0000000189734310-0x0000000189734330
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF844A */, bool useObjectPool = false /* Metadata: 0x00AF844E */) => default; // 0x0000000182769C30-0x0000000182769F00
	[BlackList] // 0x000000018973BAF0-0x000000018973BB30
	// [XID] // 0x000000018973BAF0-0x000000018973BB30
	public bool ToBinary(ByteArray byteArray) => default; // 0x00000001827696E0-0x00000001827699B0
	// [XID] // 0x0000000189746420-0x0000000189746440
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x000000018276AA00-0x000000018276ACD0
	[BlackList] // 0x000000018974DED0-0x000000018974DF10
	// [XID] // 0x000000018974DED0-0x000000018974DF10
	public virtual void AutoAllocTypeFields() {} // 0x00000001827699B0-0x0000000182769A50
	[BlackList] // 0x0000000189757F30-0x0000000189757F70
	// [XID] // 0x0000000189757F30-0x0000000189757F70
	public virtual void AutoRecycleTypeFields() {} // 0x0000000182769A50-0x0000000182769B50
	[BlackList] // 0x00000001897629B0-0x00000001897629F0
	// [XID] // 0x00000001897629B0-0x00000001897629F0
	public virtual void ReturnToObjectPool() {} // 0x000000018276AF30-0x000000018276AFD0
	[BlackList] // 0x000000018976CF40-0x000000018976CF80
	// [XID] // 0x000000018976CF40-0x000000018976CF80
	public virtual void OnPoolAllocated() {} // 0x000000018276AE90-0x000000018276AF30
	[BlackList] // 0x00000001897775B0-0x00000001897775F0
	// [XID] // 0x00000001897775B0-0x00000001897775F0
	public virtual void OnBeforePoolRecycled() {} // 0x000000018276ADF0-0x000000018276AE90
}

