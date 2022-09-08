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
	public class MonoUseCount : MonoBehaviour // TypeDefIndex: 30975
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _useCountLabel; // 0x18
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _increaseButtonContainer; // 0x20
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _decreaseButtonContainer; // 0x28
	
		// Properties
		public Button increaseButton { /* [XID] */ /* 0x0000000189AEAA70-0x0000000189AEAA90 */ get => default; } // 0x000000018489C080-0x000000018489C130 
		public Button decreaseButton { /* [XID] */ /* 0x0000000189AF2360-0x0000000189AF2380 */ get => default; } // 0x000000018489BFD0-0x000000018489C080 
	
		// Constructors
		public MonoUseCount() {} // 0x000000018489BF60-0x000000018489BFD0
	
		// Methods
		// [XID] // 0x0000000189AF9CE0-0x0000000189AF9D00
		public void SetUseCount(int min, int max, int use) {} // 0x000000018489BE00-0x000000018489BF60
	}
}
