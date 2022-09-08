/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole.UAuto
{
	public class CharacterAIBehaviour : MonoBehaviour // TypeDefIndex: 27191
	{
		// Fields
		public string behaviourName; // 0x18
		public float findMonsterRange; // 0x20
		public float attackRange; // 0x24
		public bool needRecovery; // 0x28
		public int maxNoFoundCount; // 0x2C
		public int skillMask; // 0x30
		public int loopTime; // 0x34
		private CharacterAgent _characterAgent; // 0x38
		public bool isBehaviourEnd; // 0x40
		private static bool _isAIInit; // 0x00
	
		// Constructors
		public CharacterAIBehaviour() {} // 0x0000000181056290-0x0000000181056320
		static CharacterAIBehaviour() {} // 0x0000000181056230-0x0000000181056290
	
		// Methods
		private static void InitBehavic() {} // 0x0000000181055DF0-0x0000000181055EC0
		private void Update() {} // 0x0000000181056170-0x0000000181056230
		private void OnDestroy() {} // 0x0000000181055F70-0x0000000181056030
		public void ResumePlayerControl() {} // 0x0000000181056030-0x0000000181056110
		public bool ChangeBehaviaTree(string treeName) => default; // 0x0000000181055B70-0x0000000181055CE0
		public void Stop() {} // 0x0000000181056110-0x0000000181056170
		// [ContextMenu] // 0x0000000189730DA0-0x0000000189730DD0
		private void LogTest() {} // 0x0000000181055EC0-0x0000000181055F70
		// [ContextMenu] // 0x0000000189739D00-0x0000000189739D30
		private void DoRestart() {} // 0x0000000181055CE0-0x0000000181055D50
		// [ContextMenu] // 0x0000000189742D90-0x0000000189742DC0
		private void DoStop() {} // 0x0000000181055D50-0x0000000181055DF0
	}
}
