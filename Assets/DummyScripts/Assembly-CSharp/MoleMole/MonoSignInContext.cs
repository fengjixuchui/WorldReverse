/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;
using UnityEngine.UI;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	public class MonoSignInContext : MonoBehaviour // TypeDefIndex: 31265
	{
		// Fields
		private string SIGNIN_ITEM_PREFAB_PATH; // 0x18
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _leftItemRoot; // 0x20
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _rightItemRoot; // 0x28
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _timeDesc; // 0x30
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _titleDesc; // 0x38
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoElementSwitch _elementSwitch; // 0x40
		private List<GameObject> _itemList; // 0x48
	
		// Properties
		public MonoUIContainer btnExit { /* [XID] */ /* 0x00000001897B6730-0x00000001897B6750 */ get => default; } // 0x0000000184128590-0x0000000184128650 
		public MonoUIContainer btnBack { /* [XID] */ /* 0x00000001897BE570-0x00000001897BE590 */ get => default; } // 0x00000001841284D0-0x0000000184128590 
		public MonoUIContainer btnSelect { /* [XID] */ /* 0x00000001897C5C20-0x00000001897C5C40 */ get => default; } // 0x0000000184128710-0x00000001841287D0 
		public MonoUIContainer btnReward { /* [XID] */ /* 0x00000001897CD400-0x00000001897CD420 */ get => default; } // 0x0000000184128650-0x0000000184128710 
		public string timeDesc { /* [XID] */ /* 0x00000001897D4A60-0x00000001897D4A80 */ set {} } // 0x00000001841289B0-0x0000000184128A80
		public string titleDesc { /* [XID] */ /* 0x00000001897DC0E0-0x00000001897DC100 */ set {} } // 0x0000000184128A80-0x0000000184128B50
		public Transform leftItemRoot { /* [XID] */ /* 0x00000001897E39D0-0x00000001897E39F0 */ get => default; } // 0x0000000184128870-0x0000000184128910 
		public Transform rightItemRoot { /* [XID] */ /* 0x00000001897EB640-0x00000001897EB660 */ get => default; } // 0x0000000184128910-0x00000001841289B0 
		public List<GameObject> itemList { /* [XID] */ /* 0x00000001897F2F80-0x00000001897F2FA0 */ get => default; } // 0x00000001841287D0-0x0000000184128870 
	
		// Constructors
		public MonoSignInContext() {} // 0x0000000184128420-0x00000001841284D0
	
		// Methods
		// [XID] // 0x00000001897FA7D0-0x00000001897FA7F0
		public List<GameObject> GetItemList(int count) => default; // 0x0000000184128120-0x0000000184128380
		// [XID] // 0x0000000189801E40-0x0000000189801E60
		public void DestroyItemList() {} // 0x0000000184127F20-0x0000000184128120
		// [XID] // 0x0000000189809270-0x0000000189809290
		private void OnDestroy() {} // 0x0000000184128380-0x0000000184128420
	}
}
