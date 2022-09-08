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
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole.Config
{
	[LuaCallCSharp] // 0x00000001895F3770-0x00000001895F37B0
	[RecycleType] // 0x00000001895F3770-0x00000001895F37B0
	public class RandomQuestTemplateExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15983
	{
		// Fields
		protected uint _mainId; // 0x10
		// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
		protected RandomQuestElem[] _elemList; // 0x18
	
		// Properties
		public uint mainId { /* [XID] */ /* 0x0000000189727280-0x00000001897272A0 */ get => default; /* [XID] */ /* 0x000000018972E790-0x000000018972E7B0 */ set {} } // 0x0000000186B69B70-0x0000000186B69C10 0x0000000186B69CC0-0x0000000186B69D70
		public RandomQuestElem[] elemList { /* [XID] */ /* 0x0000000189735F20-0x0000000189735F40 */ get => default; /* [XID] */ /* 0x000000018973DB90-0x000000018973DBB0 */ set {} } // 0x0000000186B69AD0-0x0000000186B69B70 0x0000000186B69C10-0x0000000186B69CC0
	
		// Constructors
		public RandomQuestTemplateExcelConfig() {} // 0x0000000186B69A70-0x0000000186B69AD0
	
		// Methods
		// [IDTag] // 0x0000000189744F10-0x0000000189744F50
		// [XID] // 0x0000000189744F10-0x0000000189744F50
		public virtual bool ParseFromLine(string line) => default; // 0x0000000186B69650-0x0000000186B699D0
		// [IDTag] // 0x000000018974F910-0x000000018974F950
		// [XID] // 0x000000018974F910-0x000000018974F950
		public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000186B69360-0x0000000186B69650
		// [XID] // 0x0000000189759AE0-0x0000000189759B00
		public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF2CED */, bool useObjectPool = false /* Metadata: 0x00AF2CF1 */) => default; // 0x0000000186B68EB0-0x0000000186B69220
		[BlackList] // 0x0000000189761730-0x0000000189761770
		// [XID] // 0x0000000189761730-0x0000000189761770
		public virtual void AutoAllocTypeFields() {} // 0x0000000186B68D60-0x0000000186B68E00
		[BlackList] // 0x000000018976BC80-0x000000018976BCC0
		// [XID] // 0x000000018976BC80-0x000000018976BCC0
		public virtual void AutoRecycleTypeFields() {} // 0x0000000186B68E00-0x0000000186B68EB0
		[BlackList] // 0x0000000189776400-0x0000000189776440
		// [XID] // 0x0000000189776400-0x0000000189776440
		public virtual void ReturnToObjectPool() {} // 0x0000000186B699D0-0x0000000186B69A70
		[BlackList] // 0x0000000189780AA0-0x0000000189780AE0
		// [XID] // 0x0000000189780AA0-0x0000000189780AE0
		public virtual void OnPoolAllocated() {} // 0x0000000186B692C0-0x0000000186B69360
		[BlackList] // 0x000000018978B300-0x000000018978B340
		// [XID] // 0x000000018978B300-0x000000018978B340
		public virtual void OnBeforePoolRecycled() {} // 0x0000000186B69220-0x0000000186B692C0
	}
}
