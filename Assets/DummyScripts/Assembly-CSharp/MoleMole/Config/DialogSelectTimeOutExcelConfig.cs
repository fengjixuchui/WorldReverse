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
	[LuaCallCSharp] // 0x0000000189A1D3A0-0x0000000189A1D3E0
	[RecycleType] // 0x0000000189A1D3A0-0x0000000189A1D3E0
	public class DialogSelectTimeOutExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15974
	{
		// Fields
		protected uint _id; // 0x10
		protected float _timeLimit; // 0x14
		protected uint _nextDialogID; // 0x18
	
		// Properties
		public uint id { /* [XID] */ /* 0x00000001898A2140-0x00000001898A2160 */ get => default; /* [XID] */ /* 0x00000001898A98D0-0x00000001898A98F0 */ set {} } // 0x0000000188D51C80-0x0000000188D51D20 0x0000000188D51E70-0x0000000188D51F20
		public float timeLimit { /* [XID] */ /* 0x00000001898B11E0-0x00000001898B1200 */ get => default; /* [XID] */ /* 0x00000001898B8A80-0x00000001898B8AA0 */ set {} } // 0x0000000188D51DC0-0x0000000188D51E70 0x0000000188D51FD0-0x0000000188D52080
		public uint nextDialogID { /* [XID] */ /* 0x00000001898C0080-0x00000001898C00A0 */ get => default; /* [XID] */ /* 0x00000001898C7980-0x00000001898C79A0 */ set {} } // 0x0000000188D51D20-0x0000000188D51DC0 0x0000000188D51F20-0x0000000188D51FD0
	
		// Constructors
		public DialogSelectTimeOutExcelConfig() {} // 0x0000000188D51C20-0x0000000188D51C80
	
		// Methods
		// [IDTag] // 0x00000001898CF0F0-0x00000001898CF130
		// [XID] // 0x00000001898CF0F0-0x00000001898CF130
		public virtual bool ParseFromLine(string line) => default; // 0x0000000188D51600-0x0000000188D518E0
		// [IDTag] // 0x00000001898D98F0-0x00000001898D9930
		// [XID] // 0x00000001898D98F0-0x00000001898D9930
		public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000188D518E0-0x0000000188D51B80
		// [XID] // 0x00000001898E44A0-0x00000001898E44C0
		public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF2CB1 */, bool useObjectPool = false /* Metadata: 0x00AF2CB5 */) => default; // 0x0000000188D510B0-0x0000000188D514C0
		[BlackList] // 0x00000001898EBF30-0x00000001898EBF70
		// [XID] // 0x00000001898EBF30-0x00000001898EBF70
		public virtual void AutoAllocTypeFields() {} // 0x0000000188D50F70-0x0000000188D51010
		[BlackList] // 0x00000001898F68E0-0x00000001898F6920
		// [XID] // 0x00000001898F68E0-0x00000001898F6920
		public virtual void AutoRecycleTypeFields() {} // 0x0000000188D51010-0x0000000188D510B0
		[BlackList] // 0x0000000189901150-0x0000000189901190
		// [XID] // 0x0000000189901150-0x0000000189901190
		public virtual void ReturnToObjectPool() {} // 0x0000000188D51B80-0x0000000188D51C20
		[BlackList] // 0x000000018990B790-0x000000018990B7D0
		// [XID] // 0x000000018990B790-0x000000018990B7D0
		public virtual void OnPoolAllocated() {} // 0x0000000188D51560-0x0000000188D51600
		[BlackList] // 0x00000001899160E0-0x0000000189916120
		// [XID] // 0x00000001899160E0-0x0000000189916120
		public virtual void OnBeforePoolRecycled() {} // 0x0000000188D514C0-0x0000000188D51560
	}
}
