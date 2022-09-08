/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole.UAuto
{
	public sealed class TestCaseQuestBase : TestCaseBase // TypeDefIndex: 28305
	{
		// Fields
		private string output; // 0x198
		private string outputDiff; // 0x1A0
		private string[] title; // 0x1A8
		private string[] titleDiff; // 0x1B0
		private List<string> current; // 0x1B8
		private List<string> last; // 0x1C0
		private Dictionary<string, List<string>> sourceDict; // 0x1C8
	
		// Constructors
		public TestCaseQuestBase() {} // 0x0000000182192750-0x0000000182192D00
	
		// Methods
		~TestCaseQuestBase() {} // 0x00000001821917F0-0x0000000182191860
		public uint GetPlayerLevelExp(AccountDataItem accountData) => default; // 0x0000000182191B60-0x0000000182191D50
		public uint GetAvatarLevelExp(AvatarDataItem avatarItem) => default; // 0x0000000182191860-0x0000000182191A70
		public void PlayerInfo() {} // 0x0000000182192180-0x0000000182192370
		[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
		public IEnumerator AvatarInfo() => default; // 0x000000018218F7C0-0x000000018218F890
		public void BagInfo() {} // 0x000000018218F890-0x000000018218FE20
		[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
		public IEnumerator GetCurrentInfo(string taskId, bool check = true /* Metadata: 0x00B0D600 */) => default; // 0x0000000182191A70-0x0000000182191B60
		public Dictionary<string, List<string>> Str2Dic(string str) => default; // 0x0000000182192450-0x0000000182192750
		public void GetSourceData() {} // 0x0000000182191D50-0x0000000182192180
		public void CheckQuestNumber(string taskId) {} // 0x000000018218FE20-0x00000001821917F0
		[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
		public IEnumerator StartCheckQuestNumber(bool check = true /* Metadata: 0x00B0D601 */) => default; // 0x0000000182192370-0x0000000182192450
	}
}
