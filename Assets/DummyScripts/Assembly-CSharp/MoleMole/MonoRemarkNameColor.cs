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
	public class MonoRemarkNameColor : MonoBehaviour // TypeDefIndex: 30882
	{
		// Fields
		public UnityEngine.UI.Text textComp; // 0x18
		[Space] // 0x00000001898E0F50-0x00000001898E0F60
		public Color playerNickNameColor; // 0x20
		public Color playerRemarkNameColor; // 0x30
	
		// Constructors
		public MonoRemarkNameColor() {} // 0x0000000184435FA0-0x0000000184436000
	
		// Methods
		// [XID] // 0x0000000189B8E570-0x0000000189B8E590
		public void SetNameText(string nickNameText, string remarkNameText, bool isRemarkName = true /* Metadata: 0x00B116A4 */) {} // 0x0000000184435E00-0x0000000184435FA0
		// [XID] // 0x0000000189B95A30-0x0000000189B95A50
		public void SetConcatNameText(string nickNameText, string remarkNameText) {} // 0x0000000184435BD0-0x0000000184435E00
		// [XID] // 0x0000000189B9CFD0-0x0000000189B9CFF0
		public string ColorToHexFormat(Color32 color) => default; // 0x0000000184435A70-0x0000000184435BD0
	}
}
