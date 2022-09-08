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

namespace MoleMole.Config
{
	[LuaCallCSharp] // 0x0000000189A1D3A0-0x0000000189A1D3E0
	[RecycleType] // 0x0000000189A1D3A0-0x0000000189A1D3E0
	public class ConfigNpcBornPos : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 18783
	{
		// Fields
		private uint _id; // 0x10
		private uint _configId; // 0x14
		private uint _roomId; // 0x18
		private Vector _pos; // 0x1C
		private Vector _rot; // 0x28
		private uint _groupId; // 0x34
		private uint _suiteId; // 0x38
		private uint[] _suiteIdList; // 0x40
	
		// Properties
		public uint id { /* [XID] */ /* 0x0000000189665310-0x0000000189665330 */ get => default; /* [XID] */ /* 0x000000018966CB00-0x000000018966CB20 */ set {} } // 0x0000000188844060-0x0000000188844100 0x0000000188844600-0x00000001888446B0
		public uint configId { /* [XID] */ /* 0x00000001896748D0-0x00000001896748F0 */ get => default; /* [XID] */ /* 0x000000018967C240-0x000000018967C260 */ set {} } // 0x0000000188843F20-0x0000000188843FC0 0x00000001888444A0-0x0000000188844550
		public uint roomId { /* [XID] */ /* 0x00000001896837F0-0x0000000189683810 */ get => default; /* [XID] */ /* 0x000000018968B490-0x000000018968B4B0 */ set {} } // 0x00000001888441E0-0x0000000188844280 0x0000000188844780-0x0000000188844830
		public Vector pos { /* [XID] */ /* 0x0000000189693140-0x0000000189693160 */ get => default; /* [XID] */ /* 0x000000018969A370-0x000000018969A390 */ set {} } // 0x0000000188844100-0x00000001888441E0 0x00000001888446B0-0x0000000188844780
		public Vector rot { /* [XID] */ /* 0x00000001896A1C00-0x00000001896A1C20 */ get => default; /* [XID] */ /* 0x00000001896A9060-0x00000001896A9080 */ set {} } // 0x0000000188844280-0x0000000188844360 0x0000000188844830-0x0000000188844900
		public uint groupId { /* [XID] */ /* 0x00000001896B01F0-0x00000001896B0210 */ get => default; /* [XID] */ /* 0x00000001896B7A50-0x00000001896B7A70 */ set {} } // 0x0000000188843FC0-0x0000000188844060 0x0000000188844550-0x0000000188844600
		public uint suiteId { /* [XID] */ /* 0x00000001896BEAB0-0x00000001896BEAD0 */ get => default; /* [XID] */ /* 0x00000001896C6470-0x00000001896C6490 */ set {} } // 0x0000000188844400-0x00000001888444A0 0x00000001888449B0-0x0000000188844A60
		public uint[] suiteIdList { /* [XID] */ /* 0x00000001896CDA90-0x00000001896CDAB0 */ get => default; /* [XID] */ /* 0x00000001896D5000-0x00000001896D5020 */ private set {} } // 0x0000000188844360-0x0000000188844400 0x0000000188844900-0x00000001888449B0
	
		// Constructors
		public ConfigNpcBornPos() {} // 0x0000000188843EC0-0x0000000188843F20
	
		// Methods
		// [XID] // 0x00000001896DC6A0-0x00000001896DC6C0
		public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000188843930-0x0000000188843A10
		// [XID] // 0x00000001896E3EF0-0x00000001896E3F10
		public void InitEmpty() {} // 0x0000000188842540-0x0000000188842640
		[BlackList] // 0x00000001896EB320-0x00000001896EB360
		// [XID] // 0x00000001896EB320-0x00000001896EB360
		public bool FromJson(JSONNode node) => default; // 0x00000001888421C0-0x0000000188842540
		// [XID] // 0x00000001896F5A00-0x00000001896F5A20
		private bool InternalFromJson(JSONNode node) => default; // 0x0000000188842BF0-0x0000000188843320
		// [XID] // 0x00000001896FD1B0-0x00000001896FD1D0
		public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFAC19 */, bool useObjectPool = false /* Metadata: 0x00AFAC1D */) => default; // 0x0000000188841EC0-0x00000001888421C0
		// [XID] // 0x00000001897046B0-0x00000001897046D0
		private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFAC1E */, bool useObjectPool = false /* Metadata: 0x00AFAC22 */) => default; // 0x0000000188842640-0x0000000188842BF0
		[BlackList] // 0x000000018970BED0-0x000000018970BF10
		// [XID] // 0x000000018970BED0-0x000000018970BF10
		public bool ToBinary(ByteArray byteArray) => default; // 0x0000000188843BF0-0x0000000188843EC0
		// [XID] // 0x0000000189716560-0x0000000189716580
		private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000188843320-0x0000000188843930
		[BlackList] // 0x000000018971DF00-0x000000018971DF40
		// [XID] // 0x000000018971DF00-0x000000018971DF40
		public virtual void AutoAllocTypeFields() {} // 0x0000000188841D50-0x0000000188841DF0
		[BlackList] // 0x00000001897283D0-0x0000000189728410
		// [XID] // 0x00000001897283D0-0x0000000189728410
		public virtual void AutoRecycleTypeFields() {} // 0x0000000188841DF0-0x0000000188841EC0
		[BlackList] // 0x0000000189732980-0x00000001897329C0
		// [XID] // 0x0000000189732980-0x00000001897329C0
		public virtual void ReturnToObjectPool() {} // 0x0000000188843B50-0x0000000188843BF0
		[BlackList] // 0x000000018973D3F0-0x000000018973D430
		// [XID] // 0x000000018973D3F0-0x000000018973D430
		public virtual void OnPoolAllocated() {} // 0x0000000188843AB0-0x0000000188843B50
		[BlackList] // 0x0000000189747B10-0x0000000189747B50
		// [XID] // 0x0000000189747B10-0x0000000189747B50
		public virtual void OnBeforePoolRecycled() {} // 0x0000000188843A10-0x0000000188843AB0
	}
}
