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
	public class RandomQuestContent : IAutoAllocRecycle // TypeDefIndex: 15977
	{
		// Fields
		protected QuestContentType _type; // 0x10
		protected string[] _param; // 0x18
		protected string _param_str; // 0x20
		protected string _count; // 0x28
	
		// Properties
		public QuestContentType type { /* [XID] */ /* 0x0000000189A237C0-0x0000000189A237E0 */ get => default; /* [XID] */ /* 0x0000000189A2AC40-0x0000000189A2AC60 */ set {} } // 0x0000000188D5BBB0-0x0000000188D5BC50 0x0000000188D5BE60-0x0000000188D5BF10
		public string[] param { /* [XID] */ /* 0x0000000189A32180-0x0000000189A321A0 */ get => default; /* [XID] */ /* 0x0000000189A39B30-0x0000000189A39B50 */ set {} } // 0x0000000188D5BA70-0x0000000188D5BB10 0x0000000188D5BD00-0x0000000188D5BDB0
		public string param_str { /* [XID] */ /* 0x0000000189A413B0-0x0000000189A413D0 */ get => default; /* [XID] */ /* 0x0000000189A48A50-0x0000000189A48A70 */ set {} } // 0x0000000188D5BB10-0x0000000188D5BBB0 0x0000000188D5BDB0-0x0000000188D5BE60
		public string count { /* [XID] */ /* 0x0000000189A501E0-0x0000000189A50200 */ get => default; /* [XID] */ /* 0x0000000189A57770-0x0000000189A57790 */ set {} } // 0x0000000188D5B9D0-0x0000000188D5BA70 0x0000000188D5BC50-0x0000000188D5BD00
	
		// Constructors
		public RandomQuestContent() {} // 0x0000000188D5B970-0x0000000188D5B9D0
	
		// Methods
		// [XID] // 0x0000000189A5F290-0x0000000189A5F2B0
		public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000188D5B4E0-0x0000000188D5B8D0
		// [XID] // 0x0000000189A66B80-0x0000000189A66BA0
		public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF2CCA */, bool useObjectPool = false /* Metadata: 0x00AF2CCE */) => default; // 0x0000000188D5AEF0-0x0000000188D5B3A0
		[BlackList] // 0x0000000189A6E460-0x0000000189A6E4A0
		// [XID] // 0x0000000189A6E460-0x0000000189A6E4A0
		public virtual void AutoAllocTypeFields() {} // 0x0000000188D5ADA0-0x0000000188D5AE40
		[BlackList] // 0x0000000189A78D20-0x0000000189A78D60
		// [XID] // 0x0000000189A78D20-0x0000000189A78D60
		public virtual void AutoRecycleTypeFields() {} // 0x0000000188D5AE40-0x0000000188D5AEF0
		[BlackList] // 0x0000000189A836E0-0x0000000189A83720
		// [XID] // 0x0000000189A836E0-0x0000000189A83720
		public virtual void ReturnToObjectPool() {} // 0x0000000188D5B8D0-0x0000000188D5B970
		[BlackList] // 0x0000000189A8E030-0x0000000189A8E070
		// [XID] // 0x0000000189A8E030-0x0000000189A8E070
		public virtual void OnPoolAllocated() {} // 0x0000000188D5B440-0x0000000188D5B4E0
		[BlackList] // 0x0000000189A988C0-0x0000000189A98900
		// [XID] // 0x0000000189A988C0-0x0000000189A98900
		public virtual void OnBeforePoolRecycled() {} // 0x0000000188D5B3A0-0x0000000188D5B440
	}
}
