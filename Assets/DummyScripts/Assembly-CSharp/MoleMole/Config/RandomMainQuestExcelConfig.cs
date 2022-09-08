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

namespace MoleMole.Config
{
	[LuaCallCSharp] // 0x0000000189A1D3A0-0x0000000189A1D3E0
	[RecycleType] // 0x0000000189A1D3A0-0x0000000189A1D3E0
	public class RandomMainQuestExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15988
	{
		// Fields
		public static Func<uint, string> getLocalizedTextHandler; // 0x00
		protected uint _id; // 0x10
		protected QuestType _type; // 0x14
		protected uint _titleTextMapHash; // 0x18
		protected uint _descTextMapHash; // 0x1C
		protected string _luaPath; // 0x20
		protected uint _recommendLevel; // 0x28
		protected bool _repeatable; // 0x2C
		protected PlayMode _activeMode; // 0x30
		protected uint[] _suggestTrackMainQuestList; // 0x38
		protected bool _suggestTrackOutOfOrder; // 0x40
		protected QuestShowType _showType; // 0x44
		protected uint _chapterId; // 0x48
		protected string _rewardIdList; // 0x50
	
		// Properties
		public uint id { /* [XID] */ /* 0x00000001899A3410-0x00000001899A3430 */ get => default; /* [XID] */ /* 0x00000001899AAF20-0x00000001899AAF40 */ set {} } // 0x0000000188D59030-0x0000000188D590D0 0x0000000188D59A00-0x0000000188D59AB0
		public QuestType type { /* [XID] */ /* 0x00000001899B2970-0x00000001899B2990 */ get => default; /* [XID] */ /* 0x00000001899B9B50-0x00000001899B9B70 */ set {} } // 0x0000000188D59750-0x0000000188D597F0 0x0000000188D5A030-0x0000000188D5A0E0
		[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
		public uint titleTextMapHash { /* [XID] */ /* 0x00000001899C1670-0x00000001899C1690 */ get => default; /* [XID] */ /* 0x00000001899C8C20-0x00000001899C8C40 */ protected set {} } // 0x0000000188D59530-0x0000000188D595D0 0x0000000188D59F80-0x0000000188D5A030
		public string title { /* [XID] */ /* 0x00000001899D0650-0x00000001899D0670 */ get => default; } // 0x0000000188D595D0-0x0000000188D59750 
		[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
		public uint descTextMapHash { /* [XID] */ /* 0x00000001899D7AF0-0x00000001899D7B10 */ get => default; /* [XID] */ /* 0x00000001899DEF90-0x00000001899DEFB0 */ protected set {} } // 0x0000000188D58E10-0x0000000188D58EB0 0x0000000188D59950-0x0000000188D59A00
		public string desc { /* [XID] */ /* 0x00000001899E6BF0-0x00000001899E6C10 */ get => default; } // 0x0000000188D58EB0-0x0000000188D59030 
		public string luaPath { /* [XID] */ /* 0x00000001899EE080-0x00000001899EE0A0 */ get => default; /* [XID] */ /* 0x00000001899F5930-0x00000001899F5950 */ set {} } // 0x0000000188D590D0-0x0000000188D59170 0x0000000188D59AB0-0x0000000188D59B60
		public uint recommendLevel { /* [XID] */ /* 0x00000001899FD0F0-0x00000001899FD110 */ get => default; /* [XID] */ /* 0x0000000189A04570-0x0000000189A04590 */ set {} } // 0x0000000188D59170-0x0000000188D59210 0x0000000188D59B60-0x0000000188D59C10
		public bool repeatable { /* [XID] */ /* 0x0000000189A0BD10-0x0000000189A0BD30 */ get => default; /* [XID] */ /* 0x0000000189A135A0-0x0000000189A135C0 */ set {} } // 0x0000000188D59210-0x0000000188D592B0 0x0000000188D59C10-0x0000000188D59CC0
		public PlayMode activeMode { /* [XID] */ /* 0x0000000189A1A750-0x0000000189A1A770 */ get => default; /* [XID] */ /* 0x0000000189A21FD0-0x0000000189A21FF0 */ set {} } // 0x0000000188D58CD0-0x0000000188D58D70 0x0000000188D597F0-0x0000000188D598A0
		public uint[] suggestTrackMainQuestList { /* [XID] */ /* 0x0000000189A29420-0x0000000189A29440 */ get => default; /* [XID] */ /* 0x0000000189A309F0-0x0000000189A30A10 */ set {} } // 0x0000000188D593F0-0x0000000188D59490 0x0000000188D59E20-0x0000000188D59ED0
		public bool suggestTrackOutOfOrder { /* [XID] */ /* 0x0000000189A38410-0x0000000189A38430 */ get => default; /* [XID] */ /* 0x0000000189A3FBA0-0x0000000189A3FBC0 */ set {} } // 0x0000000188D59490-0x0000000188D59530 0x0000000188D59ED0-0x0000000188D59F80
		public QuestShowType showType { /* [XID] */ /* 0x0000000189A47290-0x0000000189A472B0 */ get => default; /* [XID] */ /* 0x0000000189A4EB90-0x0000000189A4EBB0 */ set {} } // 0x0000000188D59350-0x0000000188D593F0 0x0000000188D59D70-0x0000000188D59E20
		public uint chapterId { /* [XID] */ /* 0x0000000189A56260-0x0000000189A56280 */ get => default; /* [XID] */ /* 0x0000000189A5DCC0-0x0000000189A5DCE0 */ set {} } // 0x0000000188D58D70-0x0000000188D58E10 0x0000000188D598A0-0x0000000188D59950
		public string rewardIdList { /* [XID] */ /* 0x0000000189A654A0-0x0000000189A654C0 */ get => default; /* [XID] */ /* 0x0000000189A6CBC0-0x0000000189A6CBE0 */ set {} } // 0x0000000188D592B0-0x0000000188D59350 0x0000000188D59CC0-0x0000000188D59D70
	
		// Constructors
		public RandomMainQuestExcelConfig() {} // 0x0000000188D58C70-0x0000000188D58CD0
	
		// Methods
		// [IDTag] // 0x0000000189A74310-0x0000000189A74350
		// [XID] // 0x0000000189A74310-0x0000000189A74350
		public virtual bool ParseFromLine(string line) => default; // 0x0000000188D578B0-0x0000000188D58230
		// [IDTag] // 0x0000000189A7ED00-0x0000000189A7ED40
		// [XID] // 0x0000000189A7ED00-0x0000000189A7ED40
		public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000188D58230-0x0000000188D58BD0
		// [XID] // 0x0000000189A89890-0x0000000189A898B0
		public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF2D10 */, bool useObjectPool = false /* Metadata: 0x00AF2D14 */) => default; // 0x0000000188D56D00-0x0000000188D57770
		[BlackList] // 0x0000000189A90F70-0x0000000189A90FB0
		// [XID] // 0x0000000189A90F70-0x0000000189A90FB0
		public virtual void AutoAllocTypeFields() {} // 0x0000000188D56BA0-0x0000000188D56C40
		[BlackList] // 0x0000000189A9B6C0-0x0000000189A9B700
		// [XID] // 0x0000000189A9B6C0-0x0000000189A9B700
		public virtual void AutoRecycleTypeFields() {} // 0x0000000188D56C40-0x0000000188D56D00
		[BlackList] // 0x0000000189AA5C00-0x0000000189AA5C40
		// [XID] // 0x0000000189AA5C00-0x0000000189AA5C40
		public virtual void ReturnToObjectPool() {} // 0x0000000188D58BD0-0x0000000188D58C70
		[BlackList] // 0x0000000189AB0460-0x0000000189AB04A0
		// [XID] // 0x0000000189AB0460-0x0000000189AB04A0
		public virtual void OnPoolAllocated() {} // 0x0000000188D57810-0x0000000188D578B0
		[BlackList] // 0x0000000189ABB190-0x0000000189ABB1D0
		// [XID] // 0x0000000189ABB190-0x0000000189ABB1D0
		public virtual void OnBeforePoolRecycled() {} // 0x0000000188D57770-0x0000000188D57810
	}
}
