/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;
using UnityEngine.UI;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	internal class MonoSuitList : MonoBehaviour // TypeDefIndex: 30431
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private SuitItem[] suitItems; // 0x18
	
		// Nested types
		[Serializable]
		public struct SuitItem // TypeDefIndex: 30432
		{
			// Fields
			public GameObject root; // 0x00
			public UnityEngine.UI.Text name; // 0x08
		}
	
		// Constructors
		public MonoSuitList() {} // 0x0000000185009760-0x00000001850097D0
	
		// Methods
		// [XID] // 0x0000000189740110-0x0000000189740130
		public void SetSuitList(SimpleSafeUInt32[] idList) {} // 0x00000001850094C0-0x0000000185009760
	}
}
