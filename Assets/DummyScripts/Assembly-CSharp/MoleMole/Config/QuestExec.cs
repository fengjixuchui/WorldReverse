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
	public class QuestExec : IAutoAllocRecycle // TypeDefIndex: 14897
	{
		// Fields
		protected QuestExecType _type; // 0x10
		protected string[] _param; // 0x18
	
		// Properties
		public QuestExecType type { /* [XID] */ /* 0x0000000189B21090-0x0000000189B210B0 */ get => default; /* [XID] */ /* 0x0000000189B28830-0x0000000189B28850 */ set {} } // 0x0000000188D55E10-0x0000000188D55EB0 0x0000000188D55F60-0x0000000188D56010
		public string[] param { /* [XID] */ /* 0x0000000189B2FB90-0x0000000189B2FBB0 */ get => default; /* [XID] */ /* 0x0000000189B37590-0x0000000189B375B0 */ set {} } // 0x0000000188D55D70-0x0000000188D55E10 0x0000000188D55EB0-0x0000000188D55F60
	
		// Constructors
		public QuestExec() {} // 0x0000000188D55D10-0x0000000188D55D70
	
		// Methods
		// [XID] // 0x0000000189B127A0-0x0000000189B127C0
		public QuestExecEx ToEx() => default; // 0x0000000188D55C20-0x0000000188D55D10
		// [XID] // 0x0000000189B19B10-0x0000000189B19B30
		public static QuestExecEx[] ToExList(QuestExec[] src) => default; // 0x0000000188D55AB0-0x0000000188D55C20
		// [XID] // 0x0000000189B3EE20-0x0000000189B3EE40
		public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000188D556E0-0x0000000188D55A10
		// [XID] // 0x0000000189B46880-0x0000000189B468A0
		public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEF940 */, bool useObjectPool = false /* Metadata: 0x00AEF944 */) => default; // 0x0000000188D55230-0x0000000188D555A0
		[BlackList] // 0x0000000189B4DE60-0x0000000189B4DEA0
		// [XID] // 0x0000000189B4DE60-0x0000000189B4DEA0
		public virtual void AutoAllocTypeFields() {} // 0x0000000188D550F0-0x0000000188D55190
		[BlackList] // 0x0000000189B58830-0x0000000189B58870
		// [XID] // 0x0000000189B58830-0x0000000189B58870
		public virtual void AutoRecycleTypeFields() {} // 0x0000000188D55190-0x0000000188D55230
		[BlackList] // 0x0000000189B62C20-0x0000000189B62C60
		// [XID] // 0x0000000189B62C20-0x0000000189B62C60
		public virtual void ReturnToObjectPool() {} // 0x0000000188D55A10-0x0000000188D55AB0
		[BlackList] // 0x0000000189B6D420-0x0000000189B6D460
		// [XID] // 0x0000000189B6D420-0x0000000189B6D460
		public virtual void OnPoolAllocated() {} // 0x0000000188D55640-0x0000000188D556E0
		[BlackList] // 0x0000000189B77950-0x0000000189B77990
		// [XID] // 0x0000000189B77950-0x0000000189B77990
		public virtual void OnBeforePoolRecycled() {} // 0x0000000188D555A0-0x0000000188D55640
	}
}
