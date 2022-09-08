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
	public class RandomQuestExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15990
	{
		// Fields
		public static Func<uint, string> getLocalizedTextHandler; // 0x00
		protected uint _subId; // 0x10
		protected uint _mainId; // 0x14
		protected int _order; // 0x18
		protected uint _subIdSet; // 0x1C
		protected uint _titleTextMapHash; // 0x20
		protected uint _descTextMapHash; // 0x24
		protected QuestShowType _showType; // 0x28
		protected LogicType _acceptCondComb; // 0x2C
		// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
		protected RandomQuestCond[] _acceptCond; // 0x30
		protected LogicType _finishCondComb; // 0x38
		// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
		protected RandomQuestContent[] _finishCond; // 0x40
		protected LogicType _failCondComb; // 0x48
		// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
		protected RandomQuestContent[] _failCond; // 0x50
		// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
		protected QuestGuide _guide; // 0x58
		protected ShowQuestGuideType _showGuide; // 0x60
		protected bool _finishParent; // 0x64
		protected bool _failParent; // 0x65
		protected QuestShowType _failParentShow; // 0x68
		protected bool _isRewind; // 0x6C
		protected IdCountConfig[] _awardItems; // 0x70
		// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
		protected QuestExec[] _beginExec; // 0x78
		// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
		protected QuestExec[] _finishExec; // 0x80
		// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
		protected QuestExec[] _failExec; // 0x88
		protected uint _exclusiveNpcPriority; // 0x90
		protected BanGroupType _banType; // 0x94
	
		// Properties
		public uint subId { /* [XID] */ /* 0x0000000189B8F230-0x0000000189B8F250 */ get => default; /* [XID] */ /* 0x0000000189B96700-0x0000000189B96720 */ set {} } // 0x0000000186B67970-0x0000000186B67A10 0x0000000186B68C00-0x0000000186B68CB0
		public uint mainId { /* [XID] */ /* 0x0000000189B9DC00-0x0000000189B9DC20 */ get => default; /* [XID] */ /* 0x0000000189BA55B0-0x0000000189BA55D0 */ set {} } // 0x0000000186B67650-0x0000000186B676F0 0x0000000186B68890-0x0000000186B68940
		public int order { /* [XID] */ /* 0x0000000189BAC790-0x0000000189BAC7B0 */ get => default; /* [XID] */ /* 0x0000000189BB4030-0x0000000189BB4050 */ set {} } // 0x0000000186B676F0-0x0000000186B67790 0x0000000186B68940-0x0000000186B689F0
		public uint subIdSet { /* [XID] */ /* 0x0000000189BBB6D0-0x0000000189BBB6F0 */ get => default; /* [XID] */ /* 0x0000000189BC3550-0x0000000189BC3570 */ set {} } // 0x0000000186B678D0-0x0000000186B67970 0x0000000186B68B50-0x0000000186B68C00
		[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
		public uint titleTextMapHash { /* [XID] */ /* 0x0000000189BCACD0-0x0000000189BCACF0 */ get => default; /* [XID] */ /* 0x0000000189BD2380-0x0000000189BD23A0 */ protected set {} } // 0x0000000186B67A10-0x0000000186B67AB0 0x0000000186B68CB0-0x0000000186B68D60
		public string title { /* [XID] */ /* 0x0000000189BD9940-0x0000000189BD9960 */ get => default; } // 0x0000000186B67AB0-0x0000000186B67C30 
		[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
		public uint descTextMapHash { /* [XID] */ /* 0x00000001895E6370-0x00000001895E6390 */ get => default; /* [XID] */ /* 0x00000001895EDDD0-0x00000001895EDDF0 */ protected set {} } // 0x0000000186B66C90-0x0000000186B66D30 0x0000000186B67FA0-0x0000000186B68050
		public string desc { /* [XID] */ /* 0x00000001895F5630-0x00000001895F5650 */ get => default; } // 0x0000000186B66D30-0x0000000186B66EB0 
		public QuestShowType showType { /* [XID] */ /* 0x00000001895FCBB0-0x00000001895FCBD0 */ get => default; /* [XID] */ /* 0x0000000189604570-0x0000000189604590 */ set {} } // 0x0000000186B67830-0x0000000186B678D0 0x0000000186B68AA0-0x0000000186B68B50
		public LogicType acceptCondComb { /* [XID] */ /* 0x000000018960BE40-0x000000018960BE60 */ get => default; /* [XID] */ /* 0x0000000189613380-0x00000001896133A0 */ set {} } // 0x0000000186B66970-0x0000000186B66A10 0x0000000186B67C30-0x0000000186B67CE0
		public RandomQuestCond[] acceptCond { /* [XID] */ /* 0x000000018961AC20-0x000000018961AC40 */ get => default; /* [XID] */ /* 0x00000001896221E0-0x0000000189622200 */ set {} } // 0x0000000186B66A10-0x0000000186B66AB0 0x0000000186B67CE0-0x0000000186B67D90
		public LogicType finishCondComb { /* [XID] */ /* 0x0000000189629B70-0x0000000189629B90 */ get => default; /* [XID] */ /* 0x00000001896313A0-0x00000001896313C0 */ set {} } // 0x0000000186B67280-0x0000000186B67320 0x0000000186B68470-0x0000000186B68520
		public RandomQuestContent[] finishCond { /* [XID] */ /* 0x0000000189638E50-0x0000000189638E70 */ get => default; /* [XID] */ /* 0x0000000189640250-0x0000000189640270 */ set {} } // 0x0000000186B67320-0x0000000186B673C0 0x0000000186B68520-0x0000000186B685D0
		public LogicType failCondComb { /* [XID] */ /* 0x0000000189647AB0-0x0000000189647AD0 */ get => default; /* [XID] */ /* 0x000000018964F160-0x000000018964F180 */ set {} } // 0x0000000186B66F50-0x0000000186B66FF0 0x0000000186B68100-0x0000000186B681B0
		public RandomQuestContent[] failCond { /* [XID] */ /* 0x0000000189656AD0-0x0000000189656AF0 */ get => default; /* [XID] */ /* 0x000000018965E190-0x000000018965E1B0 */ set {} } // 0x0000000186B66FF0-0x0000000186B67090 0x0000000186B681B0-0x0000000186B68260
		public QuestGuide guide { /* [XID] */ /* 0x0000000189665850-0x0000000189665870 */ get => default; /* [XID] */ /* 0x000000018966CF80-0x000000018966CFA0 */ set {} } // 0x0000000186B67510-0x0000000186B675B0 0x0000000186B68730-0x0000000186B687E0
		public ShowQuestGuideType showGuide { /* [XID] */ /* 0x0000000189674E30-0x0000000189674E50 */ get => default; /* [XID] */ /* 0x000000018967C660-0x000000018967C680 */ set {} } // 0x0000000186B67790-0x0000000186B67830 0x0000000186B689F0-0x0000000186B68AA0
		public bool finishParent { /* [XID] */ /* 0x0000000189683D30-0x0000000189683D50 */ get => default; /* [XID] */ /* 0x000000018968B990-0x000000018968B9B0 */ set {} } // 0x0000000186B67470-0x0000000186B67510 0x0000000186B68680-0x0000000186B68730
		public bool failParent { /* [XID] */ /* 0x00000001896935A0-0x00000001896935C0 */ get => default; /* [XID] */ /* 0x000000018969A890-0x000000018969A8B0 */ set {} } // 0x0000000186B671E0-0x0000000186B67280 0x0000000186B683C0-0x0000000186B68470
		public QuestShowType failParentShow { /* [XID] */ /* 0x00000001896A2280-0x00000001896A22A0 */ get => default; /* [XID] */ /* 0x00000001896A94C0-0x00000001896A94E0 */ set {} } // 0x0000000186B67140-0x0000000186B671E0 0x0000000186B68310-0x0000000186B683C0
		public bool isRewind { /* [XID] */ /* 0x00000001896B05F0-0x00000001896B0610 */ get => default; /* [XID] */ /* 0x00000001896B8030-0x00000001896B8050 */ set {} } // 0x0000000186B675B0-0x0000000186B67650 0x0000000186B687E0-0x0000000186B68890
		public IdCountConfig[] awardItems { /* [XID] */ /* 0x00000001896BF0B0-0x00000001896BF0D0 */ get => default; /* [XID] */ /* 0x00000001896C69D0-0x00000001896C69F0 */ set {} } // 0x0000000186B66AB0-0x0000000186B66B50 0x0000000186B67D90-0x0000000186B67E40
		public QuestExec[] beginExec { /* [XID] */ /* 0x00000001896CE0B0-0x00000001896CE0D0 */ get => default; /* [XID] */ /* 0x00000001896D55E0-0x00000001896D5600 */ set {} } // 0x0000000186B66BF0-0x0000000186B66C90 0x0000000186B67EF0-0x0000000186B67FA0
		public QuestExec[] finishExec { /* [XID] */ /* 0x00000001896DCAE0-0x00000001896DCB00 */ get => default; /* [XID] */ /* 0x00000001896E4410-0x00000001896E4430 */ set {} } // 0x0000000186B673C0-0x0000000186B67470 0x0000000186B685D0-0x0000000186B68680
		public QuestExec[] failExec { /* [XID] */ /* 0x00000001896EB840-0x00000001896EB860 */ get => default; /* [XID] */ /* 0x00000001896F2C70-0x00000001896F2C90 */ set {} } // 0x0000000186B67090-0x0000000186B67140 0x0000000186B68260-0x0000000186B68310
		public uint exclusiveNpcPriority { /* [XID] */ /* 0x00000001896FA570-0x00000001896FA590 */ get => default; /* [XID] */ /* 0x0000000189701C80-0x0000000189701CA0 */ set {} } // 0x0000000186B66EB0-0x0000000186B66F50 0x0000000186B68050-0x0000000186B68100
		public BanGroupType banType { /* [XID] */ /* 0x0000000189709540-0x0000000189709560 */ get => default; /* [XID] */ /* 0x0000000189710DD0-0x0000000189710DF0 */ set {} } // 0x0000000186B66B50-0x0000000186B66BF0 0x0000000186B67E40-0x0000000186B67EF0
	
		// Constructors
		public RandomQuestExcelConfig() {} // 0x0000000186B66910-0x0000000186B66970
	
		// Methods
		// [IDTag] // 0x00000001897180F0-0x0000000189718130
		// [XID] // 0x00000001897180F0-0x0000000189718130
		public virtual bool ParseFromLine(string line) => default; // 0x0000000186B641C0-0x0000000186B655D0
		// [IDTag] // 0x0000000189722780-0x00000001897227C0
		// [XID] // 0x0000000189722780-0x00000001897227C0
		public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000186B655D0-0x0000000186B66870
		// [XID] // 0x000000018972CDE0-0x000000018972CE00
		public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF2D1F */, bool useObjectPool = false /* Metadata: 0x00AF2D23 */) => default; // 0x0000000186B62E10-0x0000000186B64080
		[BlackList] // 0x0000000189734590-0x00000001897345D0
		// [XID] // 0x0000000189734590-0x00000001897345D0
		public virtual void AutoAllocTypeFields() {} // 0x0000000186B62C30-0x0000000186B62CD0
		[BlackList] // 0x000000018973F480-0x000000018973F4C0
		// [XID] // 0x000000018973F480-0x000000018973F4C0
		public virtual void AutoRecycleTypeFields() {} // 0x0000000186B62CD0-0x0000000186B62E10
		[BlackList] // 0x0000000189749A00-0x0000000189749A40
		// [XID] // 0x0000000189749A00-0x0000000189749A40
		public virtual void ReturnToObjectPool() {} // 0x0000000186B66870-0x0000000186B66910
		[BlackList] // 0x0000000189753E00-0x0000000189753E40
		// [XID] // 0x0000000189753E00-0x0000000189753E40
		public virtual void OnPoolAllocated() {} // 0x0000000186B64120-0x0000000186B641C0
		[BlackList] // 0x000000018975E4B0-0x000000018975E4F0
		// [XID] // 0x000000018975E4B0-0x000000018975E4F0
		public virtual void OnBeforePoolRecycled() {} // 0x0000000186B64080-0x0000000186B64120
	}
}
