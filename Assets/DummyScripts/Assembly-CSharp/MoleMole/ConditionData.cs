/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	public class ConditionData // TypeDefIndex: 21077
	{
		// Fields
		public const int DAILY_CONDITION_ALLDAY = 0; // Metadata: 0x00AFEDBF
		public const int DAILY_CONDITION_DAY = 1; // Metadata: 0x00AFEDC3
		public const int DAILY_CONDITION_NIGHT = 2; // Metadata: 0x00AFEDC7
		public const int TASKVAR_OPERATE_EQUAL = 0; // Metadata: 0x00AFEDCB
		public const int TASKVAR_OPERATE_GREATER = 1; // Metadata: 0x00AFEDCF
		public const int TASKVAR_OPERATE_LESS = 2; // Metadata: 0x00AFEDD3
		public int daily; // 0x10
		public uint mainQuestId; // 0x14
		public uint subQuestId; // 0x18
		public uint questState; // 0x1C
		public uint taskVarId; // 0x20
		public int taskVarIndex; // 0x24
		public int taskVarValue; // 0x28
		public int taskVarOperate; // 0x2C
		public uint questGlobalVarId; // 0x30
		public int questGlobalVarValue; // 0x34
		public int questGlobalVarOperate; // 0x38
		public int sceneId; // 0x3C
		public uint activityId; // 0x40
		public uint activityCondId; // 0x44
		public bool isActivityValid; // 0x48
	
		// Constructors
		public ConditionData() {} // 0x0000000187DEDC00-0x0000000187DEDC60
	
		// Methods
		// [XID] // 0x0000000189910F10-0x0000000189910F30
		public bool NeedTickCheck() => default; // 0x0000000187DEDB60-0x0000000187DEDC00
		// [XID] // 0x0000000189918A30-0x0000000189918A50
		public void GetListenNotifys(Dictionary<NotifyTypes, bool> listenedNofitys) {} // 0x0000000187DED710-0x0000000187DED7E0
		// [XID] // 0x00000001899201F0-0x0000000189920210
		public bool IsValid() => default; // 0x0000000187DED7E0-0x0000000187DEDB60
	}
}
