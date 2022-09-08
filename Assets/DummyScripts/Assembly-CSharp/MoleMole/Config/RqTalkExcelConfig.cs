/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
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
	public class RqTalkExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15970
	{
		// Fields
		protected uint _id; // 0x10
		protected TalkBeginWay _beginWay; // 0x14
		protected PlayMode _activeMode; // 0x18
		protected LogicType _beginCondComb; // 0x1C
		// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
		protected TalkCond[] _beginCond; // 0x20
		protected uint _priority; // 0x28
		protected uint[] _nextTalks; // 0x30
		protected uint _initDialog; // 0x38
		protected uint[] _npcId; // 0x40
		protected string _performCfg; // 0x48
		protected TalkHeroType _heroTalk; // 0x50
		protected uint _questId; // 0x54
		protected bool _dontBlockDaily; // 0x58
	
		// Properties
		public uint id { /* [XID] */ /* 0x0000000189BDB400-0x0000000189BDB420 */ get => default; /* [XID] */ /* 0x00000001895E7D50-0x00000001895E7D70 */ set {} } // 0x0000000186B6CC40-0x0000000186B6CCE0 0x0000000186B6D4C0-0x0000000186B6D570
		public TalkBeginWay beginWay { /* [XID] */ /* 0x00000001895EF640-0x00000001895EF660 */ get => default; /* [XID] */ /* 0x00000001895F7040-0x00000001895F7060 */ set {} } // 0x0000000186B6CA60-0x0000000186B6CB00 0x0000000186B6D2B0-0x0000000186B6D360
		public PlayMode activeMode { /* [XID] */ /* 0x00000001895FE3E0-0x00000001895FE400 */ get => default; /* [XID] */ /* 0x0000000189605DB0-0x0000000189605DD0 */ set {} } // 0x0000000186B6C880-0x0000000186B6C920 0x0000000186B6D0A0-0x0000000186B6D150
		public LogicType beginCondComb { /* [XID] */ /* 0x000000018960D5E0-0x000000018960D600 */ get => default; /* [XID] */ /* 0x0000000189614D40-0x0000000189614D60 */ set {} } // 0x0000000186B6C920-0x0000000186B6C9C0 0x0000000186B6D150-0x0000000186B6D200
		public TalkCond[] beginCond { /* [XID] */ /* 0x000000018961C5E0-0x000000018961C600 */ get => default; /* [XID] */ /* 0x0000000189623AA0-0x0000000189623AC0 */ set {} } // 0x0000000186B6C9C0-0x0000000186B6CA60 0x0000000186B6D200-0x0000000186B6D2B0
		public uint priority { /* [XID] */ /* 0x000000018962B280-0x000000018962B2A0 */ get => default; /* [XID] */ /* 0x0000000189632A60-0x0000000189632A80 */ set {} } // 0x0000000186B6CF60-0x0000000186B6D000 0x0000000186B6D830-0x0000000186B6D8E0
		public uint[] nextTalks { /* [XID] */ /* 0x000000018963A530-0x000000018963A550 */ get => default; /* [XID] */ /* 0x0000000189641BA0-0x0000000189641BC0 */ set {} } // 0x0000000186B6CD80-0x0000000186B6CE20 0x0000000186B6D620-0x0000000186B6D6D0
		public uint initDialog { /* [XID] */ /* 0x00000001896494A0-0x00000001896494C0 */ get => default; /* [XID] */ /* 0x0000000189650A50-0x0000000189650A70 */ set {} } // 0x0000000186B6CCE0-0x0000000186B6CD80 0x0000000186B6D570-0x0000000186B6D620
		public uint[] npcId { /* [XID] */ /* 0x0000000189658290-0x00000001896582B0 */ get => default; /* [XID] */ /* 0x000000018965F8A0-0x000000018965F8C0 */ set {} } // 0x0000000186B6CE20-0x0000000186B6CEC0 0x0000000186B6D6D0-0x0000000186B6D780
		public string performCfg { /* [XID] */ /* 0x00000001896672D0-0x00000001896672F0 */ get => default; /* [XID] */ /* 0x000000018966EB40-0x000000018966EB60 */ set {} } // 0x0000000186B6CEC0-0x0000000186B6CF60 0x0000000186B6D780-0x0000000186B6D830
		public TalkHeroType heroTalk { /* [XID] */ /* 0x0000000189676540-0x0000000189676560 */ get => default; /* [XID] */ /* 0x000000018967DD40-0x000000018967DD60 */ set {} } // 0x0000000186B6CBA0-0x0000000186B6CC40 0x0000000186B6D410-0x0000000186B6D4C0
		public uint questId { /* [XID] */ /* 0x0000000189685400-0x0000000189685420 */ get => default; /* [XID] */ /* 0x000000018968CF40-0x000000018968CF60 */ set {} } // 0x0000000186B6D000-0x0000000186B6D0A0 0x0000000186B6D8E0-0x0000000186B6D990
		public bool dontBlockDaily { /* [XID] */ /* 0x0000000189694A20-0x0000000189694A40 */ get => default; /* [XID] */ /* 0x000000018969C220-0x000000018969C240 */ set {} } // 0x0000000186B6CB00-0x0000000186B6CBA0 0x0000000186B6D360-0x0000000186B6D410
	
		// Constructors
		public RqTalkExcelConfig() {} // 0x0000000186B6C820-0x0000000186B6C880
	
		// Methods
		// [IDTag] // 0x00000001896A3720-0x00000001896A3760
		// [XID] // 0x00000001896A3720-0x00000001896A3760
		public virtual bool ParseFromLine(string line) => default; // 0x0000000186B6B6E0-0x0000000186B6C410
		// [IDTag] // 0x00000001896AD9F0-0x00000001896ADA30
		// [XID] // 0x00000001896AD9F0-0x00000001896ADA30
		public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000186B6AAA0-0x0000000186B6B6E0
		// [XID] // 0x00000001896B8050-0x00000001896B8070
		public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF2C93 */, bool useObjectPool = false /* Metadata: 0x00AF2C97 */) => default; // 0x0000000186B69EE0-0x0000000186B6A960
		[BlackList] // 0x00000001896BF0D0-0x00000001896BF110
		// [XID] // 0x00000001896BF0D0-0x00000001896BF110
		public virtual void AutoAllocTypeFields() {} // 0x0000000186B69D70-0x0000000186B69E10
		[BlackList] // 0x00000001896C95D0-0x00000001896C9610
		// [XID] // 0x00000001896C95D0-0x00000001896C9610
		public virtual void AutoRecycleTypeFields() {} // 0x0000000186B69E10-0x0000000186B69EE0
		[BlackList] // 0x00000001896D3A00-0x00000001896D3A40
		// [XID] // 0x00000001896D3A00-0x00000001896D3A40
		public virtual void ReturnToObjectPool() {} // 0x0000000186B6C410-0x0000000186B6C4B0
		[BlackList] // 0x00000001896DE360-0x00000001896DE3A0
		// [XID] // 0x00000001896DE360-0x00000001896DE3A0
		public virtual void OnPoolAllocated() {} // 0x0000000186B6AA00-0x0000000186B6AAA0
		[BlackList] // 0x00000001896E8760-0x00000001896E87A0
		// [XID] // 0x00000001896E8760-0x00000001896E87A0
		public virtual void OnBeforePoolRecycled() {} // 0x0000000186B6A960-0x0000000186B6AA00
		// [XID] // 0x00000001896F2C90-0x00000001896F2CB0
		public static List<ConfigTalkScheme> ToTalkSchemeList(List<RqTalkExcelConfig> origList) => default; // 0x0000000186B6C4B0-0x0000000186B6C610
		// [XID] // 0x00000001896FA590-0x00000001896FA5B0
		public ConfigTalkScheme ToTalkScheme() => default; // 0x0000000186B6C610-0x0000000186B6C820
	}
}
