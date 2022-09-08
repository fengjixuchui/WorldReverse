/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	public class MonoInfoListPanel : MonoBehaviour // TypeDefIndex: 31221
	{
		// Fields
		[SerializeField] // 0x00000001899857A0-0x00000001899857D0
		[Space] // 0x00000001899857A0-0x00000001899857D0
		private MonoReusableList _reusableList; // 0x18
		[Space] // 0x00000001898E0F50-0x00000001898E0F60
		public float MaxHeight; // 0x20
		[SerializeField] // 0x0000000189699B50-0x0000000189699BA0
		// [Tooltip] // 0x0000000189699B50-0x0000000189699BA0
		private float _extraHeight; // 0x24
		[SerializeField] // 0x00000001896A5600-0x00000001896A5650
		// [Tooltip] // 0x00000001896A5600-0x00000001896A5650
		private uint _maxCount; // 0x28
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float _muteTime; // 0x2C
	
		// Properties
		public float muteTime { /* [XID] */ /* 0x00000001896D6090-0x00000001896D60B0 */ get => default; } // 0x0000000184710F40-0x0000000184710FF0 
		public uint maxCount { /* [XID] */ /* 0x00000001899CAD30-0x00000001899CAD50 */ get => default; } // 0x0000000184710EA0-0x0000000184710F40 
	
		// Constructors
		public MonoInfoListPanel() {} // 0x0000000184710E20-0x0000000184710EA0
	
		// Methods
		// [XID] // 0x0000000189A04E60-0x0000000189A04E80
		public void AddListItem(string content, bool showBackground, Color bgColor) {} // 0x0000000184710960-0x0000000184710AF0
		// [XID] // 0x00000001896BFC70-0x00000001896BFC90
		public void Clear() {} // 0x0000000184710AF0-0x0000000184710BA0
		// [XID] // 0x00000001896C7530-0x00000001896C7550
		public void ResetPanelRect() {} // 0x0000000184710C50-0x0000000184710E20
		// [XID] // 0x00000001896CEC90-0x00000001896CECB0
		public void DoRemoveItem() {} // 0x0000000184710BA0-0x0000000184710C50
	}
}
