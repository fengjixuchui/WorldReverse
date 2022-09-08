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
using Newtonsoft.Json;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[RecycleType] // 0x00000001898C45A0-0x00000001898C45C0
public class BlessingScanTypeExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15031
{
	// Fields
	public static Func<uint, string> getLocalizedTextHandler; // 0x00
	protected SimpleSafeUInt32 idRawNum; // 0x10
	protected SimpleSafeUInt32 typeIdRawNum; // 0x14
	protected SimpleSafeUInt32 priorityRawNum; // 0x18
	protected SimpleSafeUInt32[] _upPoolId; // 0x20
	protected SimpleSafeUInt32 dailyScanLimitRawNum; // 0x28
	protected uint _typeNameTextMapHash; // 0x2C
	protected uint _typeNameWithColorTextMapHash; // 0x30

	// Properties
	public uint id { /* [XID] */ /* 0x00000001897FB7F0-0x00000001897FB810 */ get => default; /* [XID] */ /* 0x0000000189802C60-0x0000000189802C80 */ protected set {} } // 0x0000000184EB0DE0-0x0000000184EB0EB0 0x0000000184EB0200-0x0000000184EB02E0
	public uint typeId { /* [XID] */ /* 0x000000018980A230-0x000000018980A250 */ get => default; /* [XID] */ /* 0x0000000189811980-0x00000001898119A0 */ protected set {} } // 0x0000000184EAF050-0x0000000184EAF120 0x0000000184EB0A40-0x0000000184EB0B20
	public uint priority { /* [XID] */ /* 0x00000001898195B0-0x00000001898195D0 */ get => default; /* [XID] */ /* 0x0000000189820CF0-0x0000000189820D10 */ protected set {} } // 0x0000000184EB0970-0x0000000184EB0A40 0x0000000184EB0070-0x0000000184EB0150
	public SimpleSafeUInt32[] upPoolId { /* [XID] */ /* 0x0000000189828300-0x0000000189828320 */ get => default; /* [XID] */ /* 0x000000018982F5E0-0x000000018982F600 */ protected set {} } // 0x0000000184EAEE60-0x0000000184EAEF00 0x0000000184EAEDB0-0x0000000184EAEE60
	public uint dailyScanLimit { /* [XID] */ /* 0x0000000189836EB0-0x0000000189836ED0 */ get => default; /* [XID] */ /* 0x000000018983E2C0-0x000000018983E2E0 */ protected set {} } // 0x0000000184EAFCA0-0x0000000184EAFD70 0x0000000184EB0BC0-0x0000000184EB0CA0
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint typeNameTextMapHash { /* [XID] */ /* 0x0000000189845AB0-0x0000000189845AD0 */ get => default; /* [XID] */ /* 0x000000018984D020-0x000000018984D040 */ protected set {} } // 0x0000000184EAEFB0-0x0000000184EAF050 0x0000000184EB0150-0x0000000184EB0200
	public string typeName { /* [XID] */ /* 0x0000000189854180-0x00000001898541A0 */ get => default; } // 0x0000000184EAFD70-0x0000000184EAFEF0 
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint typeNameWithColorTextMapHash { /* [XID] */ /* 0x000000018985BB10-0x000000018985BB30 */ get => default; /* [XID] */ /* 0x00000001898630B0-0x00000001898630D0 */ protected set {} } // 0x0000000184EB0B20-0x0000000184EB0BC0 0x0000000184EAEF00-0x0000000184EAEFB0
	public string typeNameWithColor { /* [XID] */ /* 0x000000018986A560-0x000000018986A580 */ get => default; } // 0x0000000184EAFEF0-0x0000000184EB0070 

	// Constructors
	public BlessingScanTypeExcelConfig() {} // 0x0000000184EB0F50-0x0000000184EB0FB0

	// Methods
	// [IDTag] // 0x00000001898719F0-0x0000000189871A30
	// [XID] // 0x00000001898719F0-0x0000000189871A30
	public virtual bool ParseFromLine(string line) => default; // 0x0000000184EAF120-0x0000000184EAF700
	// [IDTag] // 0x000000018987C1A0-0x000000018987C1E0
	// [XID] // 0x000000018987C1A0-0x000000018987C1E0
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000184EAF700-0x0000000184EAFCA0
	// [XID] // 0x0000000189886620-0x0000000189886640
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEFEEB */, bool useObjectPool = false /* Metadata: 0x00AEFEEF */) => default; // 0x0000000184EB02E0-0x0000000184EB0970
	[BlackList] // 0x000000018988D800-0x000000018988D840
	// [XID] // 0x000000018988D800-0x000000018988D840
	public virtual void AutoAllocTypeFields() {} // 0x0000000184EAEC00-0x0000000184EAECA0
	[BlackList] // 0x0000000189897DA0-0x0000000189897DE0
	// [XID] // 0x0000000189897DA0-0x0000000189897DE0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000184EAECA0-0x0000000184EAEDB0
	[BlackList] // 0x00000001898A2300-0x00000001898A2340
	// [XID] // 0x00000001898A2300-0x00000001898A2340
	public virtual void ReturnToObjectPool() {} // 0x0000000184EB0EB0-0x0000000184EB0F50
	[BlackList] // 0x00000001898ACB40-0x00000001898ACB80
	// [XID] // 0x00000001898ACB40-0x00000001898ACB80
	public virtual void OnPoolAllocated() {} // 0x0000000184EB0D40-0x0000000184EB0DE0
	[BlackList] // 0x00000001898B7150-0x00000001898B7190
	// [XID] // 0x00000001898B7150-0x00000001898B7190
	public virtual void OnBeforePoolRecycled() {} // 0x0000000184EB0CA0-0x0000000184EB0D40
}

