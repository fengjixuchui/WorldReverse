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
	[LuaCallCSharp] // 0x0000000189A1D3A0-0x0000000189A1D3E0
	[RecycleType] // 0x0000000189A1D3A0-0x0000000189A1D3E0
	public class TalkExcelConfig : IAutoAllocRecycle // TypeDefIndex: 14898
	{
		// Fields
		private List<uint> _nextValidTalkList; // 0x10
		protected uint _id; // 0x18
		protected TalkBeginWay _beginWay; // 0x1C
		protected PlayMode _activeMode; // 0x20
		protected LogicType _beginCondComb; // 0x24
		// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
		protected TalkCond[] _beginCond; // 0x28
		protected uint _priority; // 0x30
		protected uint[] _nextTalks; // 0x38
		protected uint _initDialog; // 0x40
		protected uint[] _npcId; // 0x48
		protected uint[] _participantId; // 0x50
		protected string _performCfg; // 0x58
		protected TalkHeroType _heroTalk; // 0x60
		protected TalkLoadType _loadType; // 0x64
		protected uint _questId; // 0x68
		protected uint[] _extraLoadMarkId; // 0x70
		protected bool _dontBlockDaily; // 0x78
		protected string _prePerformCfg; // 0x80
		protected bool _stayFreeStyle; // 0x88
		protected bool _enableCameraDisplacement; // 0x89
		protected bool _lockGameTime; // 0x8A
		protected TalkMarkType _talkMarkType; // 0x8C
		protected bool _questIdleTalk; // 0x90
		protected bool _lowPriority; // 0x91
		// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
		protected TalkExec[] _finishExec; // 0x98
	
		// Properties
		public List<uint> nextValidTalkList { /* [XID] */ /* 0x0000000189BA5830-0x0000000189BA5850 */ get => default; } // 0x0000000186B76D00-0x0000000186B76DA0 
		public uint id { /* [XID] */ /* 0x0000000189BC62E0-0x0000000189BC6300 */ get => default; /* [XID] */ /* 0x0000000189BCDF20-0x0000000189BCDF40 */ set {} } // 0x0000000186B76920-0x0000000186B769C0 0x0000000186B779A0-0x0000000186B77A50
		public TalkBeginWay beginWay { /* [XID] */ /* 0x0000000189BD5390-0x0000000189BD53B0 */ get => default; /* [XID] */ /* 0x0000000189BDCFA0-0x0000000189BDCFC0 */ set {} } // 0x0000000186B76540-0x0000000186B765E0 0x0000000186B77580-0x0000000186B77630
		public PlayMode activeMode { /* [XID] */ /* 0x00000001895E9850-0x00000001895E9870 */ get => default; /* [XID] */ /* 0x00000001895F0F60-0x00000001895F0F80 */ set {} } // 0x0000000186B76360-0x0000000186B76400 0x0000000186B77370-0x0000000186B77420
		public LogicType beginCondComb { /* [XID] */ /* 0x00000001895F8A30-0x00000001895F8A50 */ get => default; /* [XID] */ /* 0x00000001895FFE30-0x00000001895FFE50 */ set {} } // 0x0000000186B76400-0x0000000186B764A0 0x0000000186B77420-0x0000000186B774D0
		public TalkCond[] beginCond { /* [XID] */ /* 0x0000000189607580-0x00000001896075A0 */ get => default; /* [XID] */ /* 0x000000018960F040-0x000000018960F060 */ set {} } // 0x0000000186B764A0-0x0000000186B76540 0x0000000186B774D0-0x0000000186B77580
		public uint priority { /* [XID] */ /* 0x00000001896166C0-0x00000001896166E0 */ get => default; /* [XID] */ /* 0x000000018961DF10-0x000000018961DF30 */ set {} } // 0x0000000186B77030-0x0000000186B770D0 0x0000000186B78080-0x0000000186B78130
		public uint[] nextTalks { /* [XID] */ /* 0x0000000189625370-0x0000000189625390 */ get => default; /* [XID] */ /* 0x000000018962CB10-0x000000018962CB30 */ set {} } // 0x0000000186B76C60-0x0000000186B76D00 0x0000000186B77D10-0x0000000186B77DC0
		public uint initDialog { /* [XID] */ /* 0x0000000189634830-0x0000000189634850 */ get => default; /* [XID] */ /* 0x000000018963BF40-0x000000018963BF60 */ set {} } // 0x0000000186B769C0-0x0000000186B76A60 0x0000000186B77A50-0x0000000186B77B00
		public uint[] npcId { /* [XID] */ /* 0x0000000189643680-0x00000001896436A0 */ get => default; /* [XID] */ /* 0x000000018964AC60-0x000000018964AC80 */ set {} } // 0x0000000186B76DA0-0x0000000186B76E40 0x0000000186B77DC0-0x0000000186B77E70
		public uint[] participantId { /* [XID] */ /* 0x0000000189652420-0x0000000189652440 */ get => default; /* [XID] */ /* 0x0000000189659B30-0x0000000189659B50 */ set {} } // 0x0000000186B76E40-0x0000000186B76EE0 0x0000000186B77E70-0x0000000186B77F20
		public string performCfg { /* [XID] */ /* 0x0000000189661330-0x0000000189661350 */ get => default; /* [XID] */ /* 0x0000000189668DC0-0x0000000189668DE0 */ set {} } // 0x0000000186B76EE0-0x0000000186B76F80 0x0000000186B77F20-0x0000000186B77FD0
		public TalkHeroType heroTalk { /* [XID] */ /* 0x00000001896708D0-0x00000001896708F0 */ get => default; /* [XID] */ /* 0x00000001896780B0-0x00000001896780D0 */ set {} } // 0x0000000186B76880-0x0000000186B76920 0x0000000186B778F0-0x0000000186B779A0
		public TalkLoadType loadType { /* [XID] */ /* 0x000000018967F900-0x000000018967F920 */ get => default; /* [XID] */ /* 0x0000000189687050-0x0000000189687070 */ set {} } // 0x0000000186B76A60-0x0000000186B76B00 0x0000000186B77B00-0x0000000186B77BB0
		public uint questId { /* [XID] */ /* 0x000000018968EE10-0x000000018968EE30 */ get => default; /* [XID] */ /* 0x0000000189696790-0x00000001896967B0 */ set {} } // 0x0000000186B770D0-0x0000000186B77170 0x0000000186B78130-0x0000000186B781E0
		public uint[] extraLoadMarkId { /* [XID] */ /* 0x000000018969DE30-0x000000018969DE50 */ get => default; /* [XID] */ /* 0x00000001896A4E20-0x00000001896A4E40 */ set {} } // 0x0000000186B76730-0x0000000186B767D0 0x0000000186B77790-0x0000000186B77840
		public bool dontBlockDaily { /* [XID] */ /* 0x00000001896AC6F0-0x00000001896AC710 */ get => default; /* [XID] */ /* 0x00000001896B39F0-0x00000001896B3A10 */ set {} } // 0x0000000186B765E0-0x0000000186B76680 0x0000000186B77630-0x0000000186B776E0
		public string prePerformCfg { /* [XID] */ /* 0x00000001896BB0F0-0x00000001896BB110 */ get => default; /* [XID] */ /* 0x00000001896C2260-0x00000001896C2280 */ set {} } // 0x0000000186B76F80-0x0000000186B77030 0x0000000186B77FD0-0x0000000186B78080
		public bool stayFreeStyle { /* [XID] */ /* 0x00000001896C9830-0x00000001896C9850 */ get => default; /* [XID] */ /* 0x00000001896D0F80-0x00000001896D0FA0 */ protected set {} } // 0x0000000186B77220-0x0000000186B772D0 0x0000000186B78290-0x0000000186B78340
		public bool enableCameraDisplacement { /* [XID] */ /* 0x00000001896D86D0-0x00000001896D86F0 */ get => default; /* [XID] */ /* 0x00000001896E0040-0x00000001896E0060 */ protected set {} } // 0x0000000186B76680-0x0000000186B76730 0x0000000186B776E0-0x0000000186B77790
		public bool lockGameTime { /* [XID] */ /* 0x00000001896E7320-0x00000001896E7340 */ get => default; /* [XID] */ /* 0x00000001896EE8D0-0x00000001896EE8F0 */ protected set {} } // 0x0000000186B76B00-0x0000000186B76BB0 0x0000000186B77BB0-0x0000000186B77C60
		public TalkMarkType talkMarkType { /* [XID] */ /* 0x00000001896F6160-0x00000001896F6180 */ get => default; /* [XID] */ /* 0x00000001896FD9D0-0x00000001896FD9F0 */ protected set {} } // 0x0000000186B772D0-0x0000000186B77370 0x0000000186B78340-0x0000000186B783F0
		public bool questIdleTalk { /* [XID] */ /* 0x0000000189704E70-0x0000000189704E90 */ get => default; /* [XID] */ /* 0x000000018970C4F0-0x000000018970C510 */ protected set {} } // 0x0000000186B77170-0x0000000186B77220 0x0000000186B781E0-0x0000000186B78290
		public bool lowPriority { /* [XID] */ /* 0x0000000189713E60-0x0000000189713E80 */ get => default; /* [XID] */ /* 0x000000018971B740-0x000000018971B760 */ protected set {} } // 0x0000000186B76BB0-0x0000000186B76C60 0x0000000186B77C60-0x0000000186B77D10
		public TalkExec[] finishExec { /* [XID] */ /* 0x0000000189722A20-0x0000000189722A40 */ get => default; /* [XID] */ /* 0x000000018972A180-0x000000018972A1A0 */ protected set {} } // 0x0000000186B767D0-0x0000000186B76880 0x0000000186B77840-0x0000000186B778F0
	
		// Constructors
		public TalkExcelConfig() {} // 0x0000000186B762F0-0x0000000186B76360
	
		// Methods
		// [IDTag] // 0x0000000189B9B280-0x0000000189B9B2C0
		// [XID] // 0x0000000189B9B280-0x0000000189B9B2C0
		public static void GenNextValidTalkList(uint[] nextTalks, ref List<uint> nextValidTalkList, uint mainQuestId, uint npcConfigId) {} // 0x0000000186B72C80-0x0000000186B72E80
		// [IDTag] // 0x0000000189BACA50-0x0000000189BACA90
		// [XID] // 0x0000000189BACA50-0x0000000189BACA90
		public List<uint> GenNextValidTalkList(uint mainQuestId, uint npcConfigId) => default; // 0x0000000186B72E80-0x0000000186B72F70
		// [XID] // 0x0000000189BB6FF0-0x0000000189BB7010
		public bool IsActive() => default; // 0x0000000186B72F70-0x0000000186B73130
		// [XID] // 0x0000000189BBE5D0-0x0000000189BBE5F0
		public bool IsValid(bool defaultValid, uint mainQuestId, uint npcConfigId) => default; // 0x0000000186B73130-0x0000000186B73380
		// [IDTag] // 0x00000001897317E0-0x0000000189731820
		// [XID] // 0x00000001897317E0-0x0000000189731820
		public virtual bool ParseFromLine(string line) => default; // 0x0000000186B74AF0-0x0000000186B76250
		// [IDTag] // 0x000000018973C280-0x000000018973C2C0
		// [XID] // 0x000000018973C280-0x000000018973C2C0
		public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000186B734C0-0x0000000186B74AF0
		// [XID] // 0x0000000189746A80-0x0000000189746AA0
		public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEF945 */, bool useObjectPool = false /* Metadata: 0x00AEF949 */) => default; // 0x0000000186B71AC0-0x0000000186B72C80
		[BlackList] // 0x000000018974E410-0x000000018974E450
		// [XID] // 0x000000018974E410-0x000000018974E450
		public virtual void AutoAllocTypeFields() {} // 0x0000000186B71900-0x0000000186B719A0
		[BlackList] // 0x00000001897584B0-0x00000001897584F0
		// [XID] // 0x00000001897584B0-0x00000001897584F0
		public virtual void AutoRecycleTypeFields() {} // 0x0000000186B719A0-0x0000000186B71AC0
		[BlackList] // 0x0000000189762F90-0x0000000189762FD0
		// [XID] // 0x0000000189762F90-0x0000000189762FD0
		public virtual void ReturnToObjectPool() {} // 0x0000000186B76250-0x0000000186B762F0
		[BlackList] // 0x000000018976D5A0-0x000000018976D5E0
		// [XID] // 0x000000018976D5A0-0x000000018976D5E0
		public virtual void OnPoolAllocated() {} // 0x0000000186B73420-0x0000000186B734C0
		[BlackList] // 0x0000000189777B10-0x0000000189777B50
		// [XID] // 0x0000000189777B10-0x0000000189777B50
		public virtual void OnBeforePoolRecycled() {} // 0x0000000186B73380-0x0000000186B73420
	}
}
