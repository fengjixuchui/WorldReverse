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
public class ConfigBoundary : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17645
{
	// Fields
	private string _name; // 0x10
	private SimpleSafeInt32 priorityRawNum; // 0x18
	private string _shape; // 0x20
	private MoleMole.Config.Vector _offset; // 0x28
	private MoleMole.Config.Vector _euler; // 0x34
	private SimpleSafeFloat heightRawNum; // 0x40

	// Properties
	public string name { /* [XID] */ /* 0x0000000189906CF0-0x0000000189906D10 */ get => default; /* [XID] */ /* 0x000000018990E710-0x000000018990E730 */ private set {} } // 0x0000000183857560-0x0000000183857600 0x0000000183856400-0x00000001838564B0
	public int priority { /* [XID] */ /* 0x0000000189915D60-0x0000000189915D80 */ get => default; /* [XID] */ /* 0x000000018991D810-0x000000018991D830 */ private set {} } // 0x0000000183856910-0x00000001838569E0 0x0000000183855D40-0x0000000183855E20
	public string shape { /* [XID] */ /* 0x0000000189925000-0x0000000189925020 */ get => default; /* [XID] */ /* 0x000000018992C5E0-0x000000018992C600 */ private set {} } // 0x0000000183855770-0x0000000183855810 0x0000000183855E20-0x0000000183855ED0
	public MoleMole.Config.Vector offset { /* [XID] */ /* 0x0000000189933C40-0x0000000189933C60 */ get => default; /* [XID] */ /* 0x000000018993B850-0x000000018993B870 */ private set {} } // 0x0000000183855FA0-0x0000000183856080 0x00000001838569E0-0x0000000183856AB0
	public MoleMole.Config.Vector euler { /* [XID] */ /* 0x0000000189942930-0x0000000189942950 */ get => default; /* [XID] */ /* 0x000000018994A180-0x000000018994A1A0 */ private set {} } // 0x00000001838570A0-0x0000000183857180 0x0000000183855ED0-0x0000000183855FA0
	public float height { /* [XID] */ /* 0x0000000189951C70-0x0000000189951C90 */ get => default; /* [XID] */ /* 0x0000000189959190-0x00000001899591B0 */ private set {} } // 0x0000000183857180-0x0000000183857260 0x0000000183856AB0-0x0000000183856B90

	// Constructors
	public ConfigBoundary() {} // 0x00000001838576A0-0x0000000183857700

	// Methods
	// [XID] // 0x00000001899609E0-0x0000000189960A00
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000183857260-0x0000000183857420
	// [XID] // 0x00000001899681A0-0x00000001899681C0
	public void InitEmpty() {} // 0x00000001838564B0-0x0000000183856610
	[BlackList] // 0x000000018996F580-0x000000018996F5C0
	// [XID] // 0x000000018996F580-0x000000018996F5C0
	public bool FromJson(JSONNode node) => default; // 0x0000000183856080-0x0000000183856400
	// [XID] // 0x000000018997A3D0-0x000000018997A3F0
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000183854C10-0x00000001838552D0
	// [XID] // 0x0000000189981B80-0x0000000189981BA0
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF75F1 */, bool useObjectPool = false /* Metadata: 0x00AF75F5 */) => default; // 0x0000000183856610-0x0000000183856910
	// [XID] // 0x0000000189989560-0x0000000189989580
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF75F6 */, bool useObjectPool = false /* Metadata: 0x00AF75FA */) => default; // 0x0000000183855810-0x0000000183855D40
	[BlackList] // 0x0000000189990D50-0x0000000189990D90
	// [XID] // 0x0000000189990D50-0x0000000189990D90
	public bool ToBinary(ByteArray byteArray) => default; // 0x00000001838552D0-0x00000001838555A0
	// [XID] // 0x000000018999B820-0x000000018999B840
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000183856B90-0x00000001838570A0
	[BlackList] // 0x00000001899A3070-0x00000001899A30B0
	// [XID] // 0x00000001899A3070-0x00000001899A30B0
	public virtual void AutoAllocTypeFields() {} // 0x00000001838555A0-0x0000000183855640
	[BlackList] // 0x00000001899ADAC0-0x00000001899ADB00
	// [XID] // 0x00000001899ADAC0-0x00000001899ADB00
	public virtual void AutoRecycleTypeFields() {} // 0x0000000183855640-0x0000000183855770
	[BlackList] // 0x00000001899B8030-0x00000001899B8070
	// [XID] // 0x00000001899B8030-0x00000001899B8070
	public virtual void ReturnToObjectPool() {} // 0x0000000183857600-0x00000001838576A0
	[BlackList] // 0x00000001899C2BE0-0x00000001899C2C20
	// [XID] // 0x00000001899C2BE0-0x00000001899C2C20
	public virtual void OnPoolAllocated() {} // 0x00000001838574C0-0x0000000183857560
	[BlackList] // 0x00000001899CD2F0-0x00000001899CD330
	// [XID] // 0x00000001899CD2F0-0x00000001899CD330
	public virtual void OnBeforePoolRecycled() {} // 0x0000000183857420-0x00000001838574C0
}

