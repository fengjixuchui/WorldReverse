/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole.Config;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	public class BaseInterAction : IComparable<MoleMole.BaseInterAction> // TypeDefIndex: 20625
	{
		// Fields
		protected InteractionType _type; // 0x10
		protected uint _mainQuestId; // 0x14
		protected ConfigBaseInterAction _cfg; // 0x18
		protected InterActionGrp _interGrp; // 0x20
		protected bool _isFromExternal; // 0x28
		protected LCBaseInter _inter; // 0x30
		protected LCBaseIntee _intee; // 0x38
		protected bool _isStarted; // 0x40
		protected bool _isFinished; // 0x41
	
		// Properties
		public InteractionType type { /* [XID] */ /* 0x00000001897424C0-0x00000001897424E0 */ get => default; } // 0x0000000181ACC4E0-0x0000000181ACC580 
		public uint mainQuestId { /* [XID] */ /* 0x00000001898ADAD0-0x00000001898ADAF0 */ get => default; } // 0x0000000181ACC440-0x0000000181ACC4E0 
		public ConfigBaseInterAction cfg { /* [XID] */ /* 0x00000001898BCA90-0x00000001898BCAB0 */ get => default; } // 0x0000000181ACC1C0-0x0000000181ACC260 
		public bool IsGrpFinished { /* [XID] */ /* 0x00000001898D6130-0x00000001898D6150 */ get => default; } // 0x0000000181ACC110-0x0000000181ACC1C0 
		public bool IsFromExternal { /* [XID] */ /* 0x00000001898DDD80-0x00000001898DDDA0 */ get => default; } // 0x0000000181ACC070-0x0000000181ACC110 
		public bool IsFinishImmdiately { /* [XID] */ /* 0x00000001898ECF00-0x00000001898ECF20 */ get => default; } // 0x0000000181ACBF20-0x0000000181ACBFD0 
		public LCBaseInter inter { /* [XID] */ /* 0x00000001898F4780-0x00000001898F47A0 */ get => default; } // 0x0000000181ACC300-0x0000000181ACC3A0 
		public LCBaseIntee intee { /* [XID] */ /* 0x00000001898FC050-0x00000001898FC070 */ get => default; } // 0x0000000181ACC260-0x0000000181ACC300 
		public bool isStarted { /* [XID] */ /* 0x000000018990E330-0x000000018990E350 */ get => default; } // 0x0000000181ACC3A0-0x0000000181ACC440 
		public bool IsFinished { /* [XID] */ /* 0x000000018990F140-0x000000018990F160 */ get => default; } // 0x0000000181ACBFD0-0x0000000181ACC070 
	
		// Constructors
		public BaseInterAction() {} // 0x0000000181ACBEA0-0x0000000181ACBF20
	
		// Methods
		// [XID] // 0x0000000189894770-0x0000000189894790
		public int CompareTo(BaseInterAction obj) => default; // 0x0000000181ACB850-0x0000000181ACB920
		// [IDTag] // 0x00000001898A3280-0x00000001898A32C0
		// [XID] // 0x00000001898A3280-0x00000001898A32C0
		public void Init(InteractionType type) {} // 0x0000000181ACBBE0-0x0000000181ACBC90
		// [XID] // 0x00000001898B4FE0-0x00000001898B5000
		public void InitMainQuestId(uint mainQuestId) {} // 0x0000000181ACBA70-0x0000000181ACBB20
		// [IDTag] // 0x00000001898C41D0-0x00000001898C4210
		// [XID] // 0x00000001898C41D0-0x00000001898C4210
		public void Init(ConfigBaseInterAction cfg) {} // 0x0000000181ACBC90-0x0000000181ACBD60
		// [XID] // 0x0000000189658920-0x0000000189658940
		public void InitGrp(InterActionGrp grp) {} // 0x0000000181ACB9C0-0x0000000181ACBA70
		// [XID] // 0x00000001898E5680-0x00000001898E56A0
		public void SetExternal() {} // 0x0000000181ACBE00-0x0000000181ACBEA0
		// [IDTag] // 0x0000000189903B10-0x0000000189903B50
		// [XID] // 0x0000000189903B10-0x0000000189903B50
		public void Init(LCBaseIntee intee) {} // 0x0000000181ACBB20-0x0000000181ACBBE0
		// [XID] // 0x0000000189655AE0-0x0000000189655B00
		public virtual void ReInit() {} // 0x0000000181ACBD60-0x0000000181ACBE00
		// [XID] // 0x00000001896469C0-0x00000001896469E0
		public virtual void Finish() {} // 0x0000000181ACB920-0x0000000181ACB9C0
	}
}
